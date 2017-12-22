using Rotux.Classes;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Rotux.Forms
{
    internal partial class RotuxSetup : Form
    {
        Settings s;
        public RotuxSetup(Settings s)
        {
            this.s = s;
            InitializeComponent();
            StartOnExit.Checked = true;
            FinishBtn.Enabled = false;
            databasecreate.Checked = true;
            BackBtn.Enabled = false;
            WorkingPath.Text = s.data["Working Folder"];
            WindowTitle.Text = s.data["Title"];
            host.Text = s.data["MySQL Host"];
            port.Value = int.Parse(s.data["MySQL Port"]);
            database.Text = s.data["MySQL File"];
            password.Text = s.data["MySQL Password"];
            username.Text = s.data["MySQL Username"];
            mysql.Text = s.data["MySQL"];
            mysqlstart.Text = s.data["MySQL Start"];
            mysqlstop.Text = s.data["MySQL Stop"];
            FlashDownload.Text = s.data["Flash Download"];
            FlashPlayer.Text = s.data["Flash Player"];
            Client.Text = s.data["Client"];
            wServer.Text = s.data["World Server"];
            Server.Text = s.data["Request Server"];
            if (s.data["Header"] != "null")
            {
                try
                {
                    head.Image = Image.FromFile(s.data["Header"]);
                } catch (Exception)
                {
                    s.data["Header"] = "null";
                }
            }
            if (s.data["Background"] != "null")
            {
                try
                {
                    back.Image = Image.FromFile(s.data["Background"]);
                } catch (Exception)
                {
                    s.data["Background"] = "null";
                }
            }
        }

        private void SelectWorkingPath_Click(object sender, EventArgs e)
        {
            openfolderdialog.ShowNewFolderButton = true;
            openfolderdialog.SelectedPath = Path.GetFullPath(s.data["Working Folder"]);
            openfolderdialog.Description = "Please select the folder where you will work from.";
            DialogResult x = openfolderdialog.ShowDialog();
            if (x == DialogResult.OK)
            {
                WorkingPath.Text = openfolderdialog.SelectedPath;
                WorkingPath_TextChanged(sender,e);
            }
        }

        private void WorkingPath_TextChanged(object sender, EventArgs e)
        {
            s.data["Working Folder"] = WorkingPath.Text; 
        }

        private void WindowTitle_TextChanged(object sender, EventArgs e)
        {
            s.data["Title"] = WindowTitle.Text;
        }

        private void changebkg_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.DefaultExt = "png";
            openFileDialog.DereferenceLinks = true;
            openFileDialog.FileName = s.data["Background"];
            openFileDialog.Multiselect = false;
            DialogResult x = openFileDialog.ShowDialog();
            if (x == DialogResult.OK)
            {
                try
                {
                    back.Image = Image.FromFile(openFileDialog.FileName);
                    s.data["Background"] = Path.GetFullPath(openFileDialog.FileName);
                } catch (Exception)
                {
                    s.data["Background"] = "null";
                }
            }
        }

        private void changeheader_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.DefaultExt = "png";
            openFileDialog.DereferenceLinks = true;
            openFileDialog.FileName = s.data["Background"];
            openFileDialog.Multiselect = false;
            DialogResult x = openFileDialog.ShowDialog();
            if (x == DialogResult.OK)
            {
                try
                {
                    head.Image = Image.FromFile(openFileDialog.FileName);
                    s.data["Header"] = Path.GetFullPath(openFileDialog.FileName);
                } catch(Exception)
                {
                    s.data["Header"] = "null";
                }
            }
        }

        private void host_TextChanged(object sender, EventArgs e)
        {
            s.data["MySQL Host"] = host.Text;
        }

        private void database_TextChanged(object sender, EventArgs e)
        {
            s.data["MySQL File"] = database.Text;
        }

        private void port_ValueChanged(object sender, EventArgs e)
        {
            s.data["MySQL Port"] = ((int)port.Value).ToString();
        }

        private void dbbutton_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.DefaultExt = "sql";
            openFileDialog.DereferenceLinks = true;
            openFileDialog.FileName = s.data["MySQL File"];
            openFileDialog.Multiselect = false;
            DialogResult x = openFileDialog.ShowDialog();
            if (x == DialogResult.OK)
            {
                database.Text = Path.GetFullPath(openFileDialog.FileName);
                database_TextChanged(sender,e);
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            s.data["MySQL Username"] = username.Text;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            s.data["MySQL Password"] = password.Text;
        }

        private void mysqlstart_TextChanged(object sender, EventArgs e)
        {
            s.data["MySQL Start"] = mysqlstart.Text;
        }

        private void mysqlstop_TextChanged(object sender, EventArgs e)
        {
            s.data["MySQL Stop"] = mysqlstop.Text;
        }

        private void mysql_TextChanged(object sender, EventArgs e)
        {
            s.data["MySQL"] = mysql.Text;
        }

        private void mysqlstartbtn_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.DefaultExt = "bat";
            openFileDialog.DereferenceLinks = true;
            openFileDialog.FileName = s.data["MySQL Start"];
            openFileDialog.Multiselect = false;
            DialogResult x = openFileDialog.ShowDialog();
            if (x == DialogResult.OK)
            {
                mysqlstart.Text = Path.GetFullPath(openFileDialog.FileName);
                mysqlstart_TextChanged(sender, e);
            }
        }

        private void mysqlstopbtn_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.DefaultExt = "bat";
            openFileDialog.DereferenceLinks = true;
            openFileDialog.FileName = s.data["MySQL Stop"];
            openFileDialog.Multiselect = false;
            DialogResult x = openFileDialog.ShowDialog();
            if (x == DialogResult.OK)
            {
                mysqlstop.Text = Path.GetFullPath(openFileDialog.FileName);
                mysqlstop_TextChanged(sender, e);
            }
        }

        private void mysqlbtn_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.DefaultExt = "exe";
            openFileDialog.DereferenceLinks = true;
            openFileDialog.FileName = s.data["MySQL"];
            openFileDialog.Multiselect = false;
            DialogResult x = openFileDialog.ShowDialog();
            if (x == DialogResult.OK)
            {
                mysql.Text = Path.GetFullPath(openFileDialog.FileName);
                mysql_TextChanged(sender, e);
            }
        }

        private void FlashDownload_TextChanged(object sender, EventArgs e)
        {
            s.data["Flash Download"] = FlashDownload.Text;
        }

        private void FlashPlayer_TextChanged(object sender, EventArgs e)
        {
            s.data["Flash Player"] = FlashPlayer.Text;
        }

        private void Client_TextChanged(object sender, EventArgs e)
        {
            s.data["Client"] = Client.Text;
        }

        private void wServer_TextChanged(object sender, EventArgs e)
        {
            s.data["World Server"] = wServer.Text;
        }

        private void Server_TextChanged(object sender, EventArgs e)
        {
            s.data["Request Server"] = Server.Text;
        }

        private void FlashPlayerBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.CheckFileExists = false;
            openFileDialog.CheckPathExists = true;
            openFileDialog.DefaultExt = "exe";
            openFileDialog.DereferenceLinks = true;
            openFileDialog.FileName = s.data["Flash Player"];
            openFileDialog.Multiselect = false;
            DialogResult x = openFileDialog.ShowDialog();
            if (x == DialogResult.OK)
            {
                FlashPlayer.Text = Path.GetFullPath(openFileDialog.FileName);
                FlashPlayer_TextChanged(sender, e);
            }
        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.DefaultExt = "swf";
            openFileDialog.DereferenceLinks = true;
            openFileDialog.FileName = s.data["Client"];
            openFileDialog.Multiselect = false;
            DialogResult x = openFileDialog.ShowDialog();
            if (x == DialogResult.OK)
            {
                Client.Text = Path.GetFullPath(openFileDialog.FileName);
                Client_TextChanged(sender, e);
            }
        }

        private void wServerBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.DefaultExt = "exe";
            openFileDialog.DereferenceLinks = true;
            openFileDialog.FileName = s.data["World Server"];
            openFileDialog.Multiselect = false;
            DialogResult x = openFileDialog.ShowDialog();
            if (x == DialogResult.OK)
            {
                wServer.Text = Path.GetFullPath(openFileDialog.FileName);
                wServer_TextChanged(sender, e);
            }
        }

        private void ServerBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.DefaultExt = "exe";
            openFileDialog.DereferenceLinks = true;
            openFileDialog.FileName = s.data["Request Server"];
            openFileDialog.Multiselect = false;
            DialogResult x = openFileDialog.ShowDialog();
            if (x == DialogResult.OK)
            {
                Server.Text = Path.GetFullPath(openFileDialog.FileName);
                Server_TextChanged(sender, e);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                BackBtn.Enabled = true;
            } else
            {
                BackBtn.Enabled = false;
            }
            if (tabControl1.SelectedIndex + 1 == tabControl1.TabCount - 1)
            {
                FinishBtn.Enabled = true;
                NextBtn.Enabled = false;
            }
            else
            {
                FinishBtn.Enabled = false;
                NextBtn.Enabled = true;
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex += 1;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 1;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists("doSetup")) File.Delete("doSetup");
            s.Save();
            if (GitHub.Checked)
                Process.Start("https://github.com/MihailProg/Rotux");
            if (databasecreate.Checked)
                Process.Start(Assembly.GetExecutingAssembly().Location, "database");
            if (StartOnExit.Checked)
                Process.Start(Assembly.GetExecutingAssembly().Location);
            Close();
        }

        private void RotuxSetup_Load(object sender, EventArgs e)
        {

        }

        private void autodetect_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.TabCount - 1;
            NextBtn.Enabled = false;
            BackBtn.Enabled = false;
            FinishBtn.Enabled = false;
            new Thread(Detect).Start();
        }
        void Detect()
        {
            DetectSettings x = new DetectSettings(s, AutoDetectProgress, AutoDetectConsole, WorkingOn);
            x.Detect();
            s = x.Get();
            string text = "";
            BeginInvoke(new Action(() => text = AutoDetectConsole.Text));
            if (!text.Contains("moving"))
            {
                BeginInvoke(new Action(() => tabControl1.SelectedIndex -= 1));
            } else
            {
                BeginInvoke(new Action(() => AutoDetectConsole.AppendText("\n\n**** WARNING **** \n\n There were some issues with the setup, please resolve them and run setup again.")));
            }
        }

        private void RotuxSetup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
