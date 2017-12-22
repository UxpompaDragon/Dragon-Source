using Rotux.Classes;
using Rotux.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Rotux
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Mutex mutex = new Mutex(false, "ROTUX_GUI");
            try
            {
                if (mutex.WaitOne(0, false))
                {
                    Run(args);
                }
                else
                {
                    MessageBox.Show("An instance of Rotux is already running.", "Rotux", MessageBoxButtons.OK);
                }
            }
            finally
            {
                if (mutex != null)
                {
                    mutex.Close();
                    mutex = null;
                }
            }
        }

        static void Run(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!(args.Length == 1 && args[0] == "debug"))
                AppDomain.CurrentDomain.UnhandledException += ExceptionHandler;
            string setting = "config.cfg";
            bool excmode = false;
            bool setupmode = false;
            bool dbmode = false;
            bool trbmode = false;
            if (args.Length > 0)
            {
                if (args[0] == "exception")
                    excmode = true;
                if (args[0] == "setup")
                    setupmode = true;
                if (args[0] == "database")
                    dbmode = true;
                if (args[0] == "troubleshoot")
                    trbmode = true;
            }
            if (!File.Exists(setting))
            {
                File.WriteAllText("doSetup", "true");
                setupmode = true;
                File.WriteAllText(setting, @"# General Settings
Title=Rotux Private Server
Working Folder=..\..\..\..\..

# Images
Background=null
Header=null

# MySQL Paths
MySQL=\xampp\mysql\bin\mysql.exe
MySQL Start=\xampp\mysql_start.bat
MySQL Stop=\xampp\mysql_stop.bat

# MySQL Settings
MySQL File=server\bin\Debug\database.sql
MySQL Host=127.0.0.1
MySQL Port=3306
MySQL Username=root
MySQL Password=

# Private Server Paths
World Server=server\bin\Debug\wServer.exe
Request Server=server\bin\Debug\server.exe

# Client Paths
Flash Player=client\flashplayer.exe
Flash Download=https://fpdownload.macromedia.com/pub/flashplayer/updaters/24/flashplayer_24_sa.exe
Client=client\client.swf");
            }

            if (File.Exists("doSetup"))
                setupmode = true;

            if (excmode)
            {
                Application.Run(new ExceptionWindow(Base64Decode(args[1])));
            }
            else
            {
                foreach (string s in args)
                {
                    if (File.Exists(s))
                        setting = s;
                }
                if (setupmode)
                {
                    Application.Run(new RotuxSetup(new Settings(setting)));
                }
                else if (dbmode)
                {
                    var s = new Settings(setting);
                    var x = Process.Start(new ProcessStartInfo()
                    {
                        FileName = s.data["MySQL Start"],
                        CreateNoWindow = true,
                        UseShellExecute = false
                    }); Thread.Sleep(1);
                    UpdateDatabase.LoadSQL(s);
                    Thread.Sleep(1);
                    x.Kill();
                    x = Process.Start(new ProcessStartInfo()
                    {
                        FileName = s.data["MySQL Stop"],
                        CreateNoWindow = true,
                        UseShellExecute = false
                    });
                } else if (trbmode)
                {
                    Application.Run(new Troubleshoot());
                }
                else
                {
                    Application.Run(new Forms.MainMenu(new Settings(setting)));
                }

            }
        }

        static void ExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            string msg = ((Exception)args.ExceptionObject).ToString();
            Process.Start(Assembly.GetExecutingAssembly().Location, "exception " + Base64Encode(msg));
            Environment.Exit(0);
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }
}
