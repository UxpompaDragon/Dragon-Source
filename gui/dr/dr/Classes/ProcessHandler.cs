using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Rotux.Classes
{
    internal class ProcessHandler : IDisposable
    {
        TextBox textbox;
        Process process;
        Form parent;
        public ProcessHandler(TextBox t, string file, Form p)
        {
            if (!File.Exists(file))
            {
                throw new FileNotFoundException("The file " + file + " was not found!");
            }
            parent = p;
            textbox = t;
            process = new Process();
            process.StartInfo.FileName = file;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.StartInfo.WorkingDirectory = Path.GetDirectoryName(file);
        }

        public void Dispose()
        {
            process.Dispose();
        }

        public bool IsRunning()
        {
            bool isRunning;
            try
            {
                isRunning = !process.HasExited && process.Threads.Count > 0;
            }
            catch (SystemException)
            {
                isRunning = false;
            }

            return isRunning;
        }
        public void Stop()
        {
            if (IsRunning())
                process.Kill();
        }
        public void Start()
        {
           process.Start();
           process.BeginOutputReadLine();
        }

        public void Wait()
        {
            process.WaitForExit();
        }

        private void OutputHandler(object sender, DataReceivedEventArgs e)
        {
            parent.BeginInvoke(new Action(() => textbox.AppendText((e.Data ?? string.Empty) + "\n")));
        }
    }
}
