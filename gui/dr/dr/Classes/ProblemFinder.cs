using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Rotux.Classes
{
    public static class ReflectiveEnumerator
    {
        public static IEnumerable<T> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class
        {
            List<T> objects = new List<T>();
            foreach (Type type in
                Assembly.GetAssembly(typeof(T)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
            {
                objects.Add((T)Activator.CreateInstance(type, constructorArgs));
            }
            objects.Sort();
            return objects;
        }
    }

    enum ProblemResult
    {
        NoMoreProblems,
        OK,
        Fail
    }

    class ProblemFinder
    {
        List<Problem> Problems;
        Label Title, Description;
        ProgressBar Progress;
        internal ProblemFinder(Label title, Label desc, ProgressBar progress)
        {
            Problems = new List<Problem>();
            Title = title;
            Description = desc;
            Progress = progress;
        }

        internal void Init()
        {
            Title.Text = "Detecting problems";
            foreach (Problem p in ReflectiveEnumerator.GetEnumerableOfType<Problem>(Progress))
            {
                Description.Invoke(new Action(() => Description.Text = string.Format("Checking for problem with ID \"{0}\"...", p.GetType().Name)));
                if (p.Check())
                {
                    Problems.Add(p);
                }
            }
        }

        internal ProblemResult Solve()
        {
            Title.Invoke(new Action(() => Title.Text = "Fixing problems"));
            try
            {
                if (Problems.Count < 1)
                {
                    return ProblemResult.NoMoreProblems;
                }

                Problem ToSolve = Problems[0];
                Description.Invoke(new Action(() => Description.Text = string.Format("Fixing problem with ID \"{0}\"...", ToSolve.GetType().Name)));

                ToSolve.Solve();

                return ProblemResult.OK;
            } catch
            {
                Problems.RemoveAt(0);
                return ProblemResult.Fail;
            }
        }


    }
}
