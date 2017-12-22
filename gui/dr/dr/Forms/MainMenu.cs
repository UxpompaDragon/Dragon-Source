using Rotux.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using WinHaste;

namespace Rotux.Forms
{
    partial class MainMenu : Form
    {
        internal ProcManager portManager;
        internal ProcessHandler wServer, Server, MySQL;
        string wServerLoc, ServerLoc, MySQLStartLoc, MySQLStopLoc;
        internal Settings s;
        TextWriter console;

        public MainMenu(Settings s)
        {
            this.s = s;
            portManager = new ProcManager();
            InitializeComponent();
            LoadSettings();
            button1.Enabled = false;
            console = new ControlWriter(ConsoleOutput, this);
            Console.SetOut(console);
            if (!File.Exists(s.data["Flash Player"]))
            {
                playgamebtn.Text = "Download Projector and Start Client";
            }
        }

        private void LoadSettings()
        {
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
            Text = s.data["Title"];
            if (s.data["Background"] != "null")
                BackgroundImage = Image.FromFile(s.data["Background"]);

            if (s.data["Header"] != "null")
                Header.Image = Image.FromFile(s.data["Header"]);

            Directory.SetCurrentDirectory(s.data["Working Folder"]);

            wServerLoc = s.data["World Server"];
            ServerLoc = s.data["Request Server"];
            MySQLStartLoc = s.data["MySQL Start"];
            MySQLStopLoc = s.data["MySQL Stop"];

            wServer = new ProcessHandler(wServerOutput, wServerLoc, this);
            Server = new ProcessHandler(ServerOutput, ServerLoc, this);
            MySQL = new ProcessHandler(MySQLOutput, MySQLStartLoc, this);
        }
        private void serverstartbtn_Click(object sender, EventArgs e)
        {
            portManager.KillByPort(80);
            portManager.KillByPort(8080);
            Server.Start();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            startbtn.Enabled = false;
            stopbtn.Enabled = true;
            new Thread(StartThread).Start();
        }

        private void StartThread()
        {
            BeginInvoke(new Action(() => global.Value = 0));
            mysqlstartbtn_Click(this, null);
            BeginInvoke(new Action(() => global.Value = 35));
            Thread.Sleep(1000);
            BeginInvoke(new Action(() => global.Value = 45));
            Thread.Sleep(1000);
            BeginInvoke(new Action(() => global.Value = 55));
            Thread.Sleep(1000);
            BeginInvoke(new Action(() => global.Value = 65));
            Thread.Sleep(1000);
            wserverstartbtn_Click(this, null);
            BeginInvoke(new Action(() => global.Value = 75));
            serverstartbtn_Click(this, null);
            BeginInvoke(new Action(() => global.Value = 85));
            Thread.Sleep(1000);
            BeginInvoke(new Action(() => global.Value = 100));
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            global.Value = 0;
            startbtn.Enabled = true;
            stopbtn.Enabled = false;
            serverstopbtn_Click(sender, e);
            global.Value = 33;
            wserverstopbtn_Click(sender, e);
            global.Value = 66;
            mysqlstopbtn_Click(sender, e);
            global.Value = 100;
            KillProcess("wServer.exe");
            KillProcess("server.exe");
            KillProcess("mysqld.exe");
            KillProcess("cmd.exe");
        }

        public void DatabaseCreate()
        {
            MySQL.Start();
            Thread.Sleep(150);
            UpdateDatabase.LoadSQL(s);
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            s.Edit();
        }

        private void loadsettingsbtn_Click(object sender, EventArgs e)
        {
            s.Load();
            LoadSettings();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopbtn_Click(sender,e);
        }

        private void playgamebtn_Click(object sender, EventArgs e)
        {
            new Thread(clientplay).Start();
        }

        void clientplay()
        {
            if (!File.Exists(s.data["Flash Player"]))
            {
                using (var client = new WebClient())
                {
                    client.DownloadProgressChanged += (s, e) =>
                    {
                        BeginInvoke(new Action(() => global.Value = e.ProgressPercentage));
                    };
                    client.DownloadFileCompleted += (s, e) =>
                    {
                        BeginInvoke(new Action(() => global.Value = 100));
                        BeginInvoke(new Action(() => playgamebtn.Text = "Start Client"));
                        BeginInvoke(new Action(() => playgamebtn_Click(this, null)));
                    };
                    client.DownloadFileAsync(new Uri(s.data["Flash Download"]), s.data["Flash Player"]);
                }
            } else
            {
                Process.Start(s.data["Flash Player"], s.data["Client"]);
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            KillProcess("cmd.exe");
            Console.WriteLine("Welcome to Rotux!");
        }

        void KillProcess(string process)
        {
            global.Value = 0; int i = 0;
            var y = Process.GetProcessesByName(process);
            foreach (Process x in y)
            {
                global.Value = i / y.Length;
            }
            global.Value = 100;
        }

        private void dbcreatebtn_Click(object sender, EventArgs e)
        {
            new Thread(UpdateDb).Start();
        }

        void UpdateDb()
        {
            UpdateDatabase.LoadSQL(s);
        }

        private void RunSetup_Click(object sender, EventArgs e)
        {
            Process.Start(Assembly.GetExecutingAssembly().Location, "setup");
            Close();
        }

        private void ChangeRankBtn_Click(object sender, EventArgs e)
        {
            new ChangeParameter(s).Show();
        }

        private void report_button_Click(object sender, EventArgs e)
        {
            Report();
        }

        public void Report()
        {
            string log = Environment.GetEnvironmentVariable("tmp") + "\\report.log";
            File.WriteAllText(log, GetMessage());
            Haste.Run("https://hastebin.com", log);
            if (File.Exists(log))
            {
                File.Delete(log);
            }

            if (Haste.HasteURL != "Error")
            {
                Console.WriteLine("Report: {0}", Haste.HasteURL);
                Clipboard.SetText(Haste.HasteURL);
                MessageBox.Show("Report URL (copied): " + Haste.HasteURL,
                    "Report", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Unable to send the report! ", "Report", MessageBoxButtons.OK);
                Console.WriteLine("Unable to report the error!");
            }
        }

        private string GetMessage()
        {
            List<string> Message = new List<string>();
            Message.Add("\n\n");
            Message.Add("--- COMPUTER INFO ---");
            GenerateComputerInfo(Message);
            Message.Add("--- END COMPUTER INFO ---");
            Message.Add("\n\n");
            Message.Add("--- ROTUX CONFIG ---");
            GetRotuxInfo(Message);
            Message.Add("--- END ROTUX CONFIG ---");
            Message.Add("\n\n");
            Message.Add("--- ROTUX LOGS ---");
            GetRotuxLogs(Message);
            Message.Add("--- END ROTUX LOGS ---");
            Message.Add("\n\n");
            return string.Join("\n", Message.ToArray());

        }

        private void GetRotuxLogs(List<string> Message)
        {
            Message.Add("\n\n");
            Message.Add("--- SERVER ---");
            Message.AddRange(ServerOutput.Lines);
            Message.Add("--- END SERVER ---");
            Message.Add("\n\n");
            Message.Add("--- WSERVER ---");
            Message.AddRange(wServerOutput.Lines);
            Message.Add("--- END WSERVER ---");
            Message.Add("\n\n");
            Message.Add("--- MYSQL ---");
            Message.AddRange(MySQLOutput.Lines);
            Message.Add("--- END MYSQL ---");
            Message.Add("\n\n");
            Message.Add("--- CONSOLE ---");
            Message.AddRange(ConsoleOutput.Lines);
            Message.Add("--- END CONSOLE ---");
            Message.Add("\n\n");
        }

        private void GetRotuxInfo(List<string> Message)
        {
            foreach(var x in s.data)
            {
                Message.Add(x.Key + "=" + x.Value);
            }
        }

        private void GenerateComputerInfo(List<string> Message)
        {
            ComputerInfo pc = new ComputerInfo();
            Message.Add("\n\n");
            Message.Add("--- PROCESSES ---");
            Message.Add("\n\n");
            foreach (Process p in Process.GetProcesses())
            {
                Message.Add(p.ProcessName + "=mem:" + p.WorkingSet64 +
                    ";vmem:" + p.VirtualMemorySize64 +
                    ";icmd:" + p.StartInfo.FileName + " " + p.StartInfo.Arguments);
            }
            Message.Add("--- END PROCESSES ---");
            Message.Add("\n\n");
            Message.Add("--- SYSTEM ---");
            Message.Add("PhysicalMemory=" + pc.AvailablePhysicalMemory + "/" + pc.TotalPhysicalMemory);
            Message.Add("VirtualMemory=" + pc.AvailableVirtualMemory + "/" + pc.TotalVirtualMemory);
            Message.Add("OperatingSystem=" + pc.OSFullName + "_" + pc.OSPlatform + "_" + pc.OSVersion);
            Message.Add("InstalledUICulture="+pc.InstalledUICulture.DisplayName);
            Message.Add("--- END SYSTEM ---");
            Message.Add("\n\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serverstopbtn_Click(sender, e);
            Process.Start(Assembly.GetExecutingAssembly().Location, "troubleshoot");
            Environment.Exit(0);
        }

        private void wserverstartbtn_Click(object sender, EventArgs e)
        {
            portManager.KillByPort(2050);
            portManager.KillByPort(843);
            wServer.Start();
        }

        private void mysqlstartbtn_Click(object sender, EventArgs e)
        {
            portManager.KillByPort(3306);
            MySQL.Start();
        }

        private void wserverstopbtn_Click(object sender, EventArgs e)
        {
            wServer.Stop();
            wServer.Dispose();
            wServer = new ProcessHandler(wServerOutput, wServerLoc, this);
            wServerOutput.Clear();
        }

        private void serverstopbtn_Click(object sender, EventArgs e)
        {
            Server.Stop();
            Server.Dispose();
            Server = new ProcessHandler(ServerOutput, ServerLoc, this);
            ServerOutput.Clear();
        }

        private void mysqlstopbtn_Click(object sender, EventArgs e)
        {
            MySQL.Stop();
            MySQL.Dispose();
            MySQL = new ProcessHandler(MySQLOutput, MySQLStopLoc, this);
            MySQL.Start();
            MySQL.Wait();
            MySQL.Dispose();
            MySQL = new ProcessHandler(MySQLOutput, MySQLStartLoc, this);
            MySQLOutput.Clear();
        }
    }
}
