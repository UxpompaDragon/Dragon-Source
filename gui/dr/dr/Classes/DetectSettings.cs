using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Rotux.Classes
{
    internal class DetectSettings
    {
        Settings s; ProgressBar p; TextBox t; Label w;
        public DetectSettings(Settings s, ProgressBar p, TextBox t, Label w)
        {
            this.s = s;
            this.p = p;
            this.t = t;
            this.w = w;
        }
        internal void Detect()
        {
            Thread.Sleep(100);
            string back = Directory.GetCurrentDirectory(), tempstr = ""; const int proc = 2;
            SetProgress(0);
            WriteLine("Searching for XAMPP...");
            var search = Search("xampp-control.exe").ToArray();
            if (search.Length < 1)
            {
                WriteLine("XAMPP not found, moving on...");
            }
            else
            {
                tempstr = Path.GetDirectoryName(search[0]);
                WriteLine("XAMPP was found!");
                SetProgress(40 / proc);
                WriteLine("Checking for MySQL Paths...");
                if(File.Exists(tempstr + "\\mysql_start.bat"))
                {
                    WriteLine("MySQL Start Script found, setting it...");
                    s.data["MySQL Start"] = tempstr + "\\mysql_start.bat";
                }
                else
                {
                    WriteLine("MySQL Start Script was not found, moving on...");
                }
                SetProgress(60 / proc);
                if (File.Exists(tempstr + "\\mysql_stop.bat"))
                {
                    WriteLine("MySQL Stop Script found, setting it...");
                    s.data["MySQL Stop"] = tempstr + "\\mysql_stop.bat";
                }
                else
                {
                    WriteLine("MySQL Stop Script was not found, moving on...");
                }
                SetProgress(80 / proc);
                if (File.Exists(tempstr + "\\mysql\\bin\\mysql.exe"))
                {
                    WriteLine("MySQL binary found, setting it...");
                    s.data["MySQL"] = tempstr + "\\mysql\\bin\\mysql.exe";
                }
                else
                {
                    WriteLine("MySQL binary was not found, moving on...");
                }
                SetProgress(90 / proc);
            }
            SetProgress(100 / proc);
            tempstr = "";
            WriteLine("Searching for private server files...");
            string[] server = Search("wServer.exe").ToArray();
            SetProgress(133 / proc);
            if (server.Length > 0)
            {
                WriteLine("World Server was found, setting it...");
                s.data["World Server"] = server[0];
                if(File.Exists(Path.GetDirectoryName(server[0]) + "\\server.exe"))
                {
                    WriteLine("Request Server was found, setting it...");
                    s.data["Request Server"] = Path.GetDirectoryName(server[0]) + "\\server.exe";
                    tempstr = Path.GetDirectoryName(server[0]);
                } else
                {
                    WriteLine("Request Server was not found, moving on...");
                }
            } else
            {
                WriteLine("World Server was not found, moving on...");
            }
            SetProgress(166 / proc);
            if (tempstr != "")
            {
                WriteLine("Searching for Client...");
                string[] files = Directory.GetFiles(tempstr, "*.swf", SearchOption.AllDirectories);
                SetProgress(190 / proc);
                if (files.Length > 0)
                {
                    WriteLine("Client found, setting it...");
                    s.data["Client"] = files[0];
                } else
                {
                    WriteLine("Client was not found, moving on...");
                }
            } else
            {
                WriteLine("Not searching for cleint, moving on...");
            }
            if (tempstr != "")
            {
                WriteLine("Searching for database...");
                string[] files = Directory.GetFiles(tempstr, "*.sql", SearchOption.AllDirectories);
                SetProgress(175 / proc);
                if (files.Length > 0)
                {
                    WriteLine("Database was found, setting it...");
                    s.data["MySQL File"] = files[0];
                }
                else
                {
                    WriteLine("Database was not found, moving on...");
                }
            } else
            {
                WriteLine("Not searching for database, moving on...");
            }
            SetProgress(190 / proc);
            WriteLine("Setting working path to current directory...");
            s.data["Working Folder"] = back;
            s.data["Flash Player"] = back + "\\flashplayer.exe"; 
            Directory.SetCurrentDirectory(back);

            SetProgress(200 / proc);
            WriteLine("Auto-detect done!");
            WorkingOn("Done!");
            Thread.Sleep(1000);
        }
        public Settings Get()
        {
            return s;
        }
        public List<string> Search(string file)
        {
            try
            {
                var files = new List<string>();
                foreach (DriveInfo d in DriveInfo.GetDrives().Where(x => x.IsReady == true))
                    files.AddRange(Folder(d.RootDirectory.FullName, file));
                return files;
            }
            catch (Exception e)
            {
                return new List<string>(new string[] { e.Message.Split(';')[1] });
            }
        }

        public List<string> Folder(string folder, string file)
        {
            var files = new List<string>();
            WorkingOn("Searching for "+ file +" in: " + folder);
            try
            {
                if (folder.Contains("\\Windows"))
                    throw new Exception("NOPE!");

                if (File.Exists(folder + "\\" + file))
                {
                    if (file == "wServer.exe")
                    {
                        if(File.Exists(folder + "\\" + "server.exe"))
                        {
                            files.Add(folder + "\\" + file);
                            throw new Exception("Found it;" + folder + "\\" + file);
                        } else
                        {
                            throw new Exception("NOPE!");
                        }
                    }
                    files.Add(folder + "\\" + file);
                    throw new Exception("Found it;" + folder + "\\" + file);
                }


                foreach (string f in Directory.GetDirectories(folder).Reverse())
                    files.AddRange(Folder(f, file));

            } catch (Exception e)
            {
                if (e.Message.Split(';')[0] == "Found it")
                    throw e;
            }
            return files;
        }

        void SetProgress(int current)
        {
            Thread.Sleep(1);
            p.BeginInvoke(new Action(() => p.Value = current));
        }

        void WorkingOn(string text)
        {
            Thread.Sleep(1);
            w.BeginInvoke(new Action(() => w.Text = text));

        }

        void WriteLine(string text)
        {
            Thread.Sleep(1);
            t.BeginInvoke(new Action(() => t.AppendText(text + "\n")));
        }
    }
}
