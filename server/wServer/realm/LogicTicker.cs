using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace wServer.realm
{
    public class LogicTicker
    {
        /// <summary>
        /// Returns the task scheduler who will perform tasks on the logic thread
        /// Note: Use this task scheduler only for sync operations, not for blocking operations.
        /// </summary>
        public static TaskScheduler TaskScheduler { get; } = new LogicThreadTaskScheduler();

        private readonly RealmManager manager;
        private readonly ConcurrentQueue<Action<RealmTime>>[] pendings;

        public readonly int TPS;
        public readonly int MsPT;

        private readonly ManualResetEvent mre;
        private Task worldTask;
        private RealmTime worldTime;

        public LogicTicker(RealmManager manager)
        {
            this.manager = manager;
            MsPT = 1000 / manager.TPS;
            mre = new ManualResetEvent(false);
            worldTime = new RealmTime();

            pendings = new ConcurrentQueue<Action<RealmTime>>[5];
            for (int i = 0; i < 5; i++)
                pendings[i] = new ConcurrentQueue<Action<RealmTime>>();
        }

        public void TickLoop()
        {
            Console.WriteLine("Logic loop started.");

            var loopTime = 0;
            var t = new RealmTime();
            var watch = Stopwatch.StartNew();
            do
            {
                t.tickTimes = watch.ElapsedMilliseconds;
                t.thisTickCounts = loopTime / MsPT;
                t.tickCount += t.thisTickCounts;
                t.thisTickTimes = t.thisTickCounts * MsPT;

                if (t.thisTickCounts > 3)
                    Console.WriteLine("LAGGED! | ticks:" + t.thisTickCounts +
                                      " ms: " + loopTime +
                                      " tps: " + t.tickCount / (t.tickTimes / 1000.0));

                if (manager.Terminating)
                    break;

                DoLogic(t);

                var logicTime = (int)(watch.ElapsedMilliseconds - t.tickTimes);
                mre.WaitOne(Math.Max(0, MsPT - logicTime));
                loopTime += (int)(watch.ElapsedMilliseconds - t.tickTimes) - t.thisTickTimes;
            } while (true);
            Console.WriteLine("Logic loop stopped.");
        }

        private void DoLogic(RealmTime t)
        {
            var clients = manager.Clients.Values;

            foreach (var i in pendings)
            {
                Action<RealmTime> callback;
                while (i.TryDequeue(out callback))
                    try
                    {
                        callback(t);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
            }

            (TaskScheduler as LogicThreadTaskScheduler)?.RunPendingTasks();

            TickWorlds1(t);

            foreach (var client in clients.Where(client => client.Player?.Owner != null))
                client.Player.Flush();
        }

        void TickWorlds1(RealmTime t)    //Continous simulation
        {
            worldTime.thisTickCounts += t.thisTickCounts;

            // tick enemies
            try
            {
                foreach (var w in manager.Worlds.Values.Distinct())
                    w.TickLogic(t);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            // tick world every 200 ms
            if (worldTask != null && !worldTask.IsCompleted) return;
            t.thisTickCounts = worldTime.thisTickCounts;
            t.thisTickTimes = t.thisTickCounts * MsPT;

            if (t.thisTickTimes < 200)
                return;

            worldTime.thisTickCounts = 0;
            worldTask = Task.Factory.StartNew(() =>
            {
                foreach (var i in manager.Worlds.Values.Distinct())
                    i.Tick(t);
            }).ContinueWith(e =>
               Console.WriteLine(e.Exception.InnerException),
                TaskContinuationOptions.OnlyOnFaulted);
        }

        public void AddPendingAction(Action<RealmTime> callback,
            PendingPriority priority = PendingPriority.Normal)
        {
            pendings[(int)priority].Enqueue(callback);
        }

        private class LogicThreadTaskScheduler : TaskScheduler
        {
            [ThreadStatic]
            private static bool isExecuting;

            private readonly BlockingCollection<Task> taskQueue;

            public LogicThreadTaskScheduler()
            {
                taskQueue = new BlockingCollection<Task>();
            }

            private void internalRunOnCurrentThread()
            {
                isExecuting = true;

                try
                {
                    if (taskQueue.Count == 0) return;
                    foreach (var task in taskQueue.GetConsumingEnumerable())
                    {
                        TryExecuteTask(task);
                    }
                }
                catch (OperationCanceledException)
                { }
                finally
                {
                    isExecuting = false;
                }
            }

            public void Complete() { taskQueue.CompleteAdding(); }
            protected override IEnumerable<Task> GetScheduledTasks() { return null; }

            protected override void QueueTask(Task task)
            {
                try
                {
                    taskQueue.Add(task);
                }
                catch (OperationCanceledException) { }
            }

            protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
            {
                if (taskWasPreviouslyQueued) return false;
                return isExecuting && TryExecuteTask(task);
            }

            public void RunPendingTasks()
            {
                if (Thread.CurrentThread.Name != "Logic")
                    throw new InvalidOperationException("Method can only be called from the logic thread.");
                internalRunOnCurrentThread();
            }
        }
    }
}