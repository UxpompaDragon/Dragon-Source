using System;
using System.Diagnostics;
using System.IO;

namespace Rotux.Classes
{
    internal class UpdateDatabase
    {
        internal static void LoadSQL(Settings s)
        {
            RunMySql(s.data["MySQL"],s.data["MySQL Host"],int.Parse(s.data["MySQL Port"]),s.data["MySQL Username"],s.data["MySQL Password"],s.data["MySQL File"]);
        }
        internal static void RunQuery(Settings s, string[] query)
        {
            RunQuery(s.data["MySQL"], s.data["MySQL Host"], int.Parse(s.data["MySQL Port"]), s.data["MySQL Username"], s.data["MySQL Password"], query);
        }
        internal static void RunQuery(string exec, string server, int port, string user, string password, string[] query)
        {
            File.WriteAllLines("temp.sql",query);
            RunMySql(exec,server,port,user,password,"temp.sql");
            File.Delete("temp.sql");
        }
        internal static void RunMySql(string exec, string server, int port, string user, string password, string filename)
        {
            var process = Process.Start(
                new ProcessStartInfo
                {
                    FileName = exec,
                    Arguments =
                        string.Format(
                            "-C -B --host={0} -P {1} --user={2} --password={3} -e \"\\. {4}\"",
                            server, port, user, password, filename),
                    ErrorDialog = false,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    WorkingDirectory = Environment.CurrentDirectory,
                }
                );

            process.OutputDataReceived += (o, e) => Console.WriteLine(e.Data);
            process.ErrorDataReceived += (o, e) => Console.WriteLine(e.Data);
            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            process.StandardInput.Close();
            process.WaitForExit();
        }

    }
}
