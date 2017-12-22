using Rotux.Controls;

namespace Rotux.Forms
{
    partial class RotuxSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RotuxSetup));
            this.openfolderdialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new Rotux.Controls.TablessControl();
            this.welcome = new System.Windows.Forms.TabPage();
            this.autodetect = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.page1 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.changebkg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.changeheader = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WindowTitle = new System.Windows.Forms.TextBox();
            this.labelWindowTitle = new System.Windows.Forms.Label();
            this.SelectWorkingPath = new System.Windows.Forms.Button();
            this.wplabel = new System.Windows.Forms.Label();
            this.WorkingPath = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.head = new System.Windows.Forms.PictureBox();
            this.page2 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.mysqlbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mysql = new System.Windows.Forms.TextBox();
            this.mysqlstopbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mysqlstop = new System.Windows.Forms.TextBox();
            this.mysqlstartbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mysqlstart = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.NumericUpDown();
            this.dbbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.database = new System.Windows.Forms.TextBox();
            this.host = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.page3 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ServerBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Server = new System.Windows.Forms.TextBox();
            this.wServerBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.wServer = new System.Windows.Forms.TextBox();
            this.ClientBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Client = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.FlashDownload = new System.Windows.Forms.TextBox();
            this.FlashPlayerBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.FlashPlayer = new System.Windows.Forms.TextBox();
            this.finish = new System.Windows.Forms.TabPage();
            this.databasecreate = new System.Windows.Forms.CheckBox();
            this.GitHub = new System.Windows.Forms.CheckBox();
            this.StartOnExit = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.auto = new System.Windows.Forms.TabPage();
            this.WorkingOn = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.AutoDetectProgress = new System.Windows.Forms.ProgressBar();
            this.AutoDetectConsole = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.welcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).BeginInit();
            this.page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.page3.SuspendLayout();
            this.finish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.auto.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(16, 351);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(394, 351);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "Next >";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // FinishBtn
            // 
            this.FinishBtn.Location = new System.Drawing.Point(475, 351);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(75, 23);
            this.FinishBtn.TabIndex = 4;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(320, 351);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "< Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.welcome);
            this.tabControl1.Controls.Add(this.page1);
            this.tabControl1.Controls.Add(this.page2);
            this.tabControl1.Controls.Add(this.page3);
            this.tabControl1.Controls.Add(this.finish);
            this.tabControl1.Controls.Add(this.auto);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 331);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // welcome
            // 
            this.welcome.Controls.Add(this.autodetect);
            this.welcome.Controls.Add(this.label25);
            this.welcome.Controls.Add(this.pictureBox1);
            this.welcome.Controls.Add(this.label15);
            this.welcome.Location = new System.Drawing.Point(4, 22);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(534, 305);
            this.welcome.TabIndex = 3;
            this.welcome.Text = "Welcome";
            this.welcome.UseVisualStyleBackColor = true;
            // 
            // autodetect
            // 
            this.autodetect.Location = new System.Drawing.Point(62, 159);
            this.autodetect.Name = "autodetect";
            this.autodetect.Size = new System.Drawing.Size(162, 23);
            this.autodetect.TabIndex = 4;
            this.autodetect.Text = "Auto-Detect Settings";
            this.autodetect.UseVisualStyleBackColor = true;
            this.autodetect.Click += new System.EventHandler(this.autodetect_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 49);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(275, 91);
            this.label25.TabIndex = 3;
            this.label25.Text = resources.GetString("label25.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Rotux.Properties.Resources.oryx;
            this.pictureBox1.Location = new System.Drawing.Point(297, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 227);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(13, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(448, 37);
            this.label15.TabIndex = 0;
            this.label15.Text = "Welcome to the Rotux Setup";
            // 
            // page1
            // 
            this.page1.Controls.Add(this.label20);
            this.page1.Controls.Add(this.label17);
            this.page1.Controls.Add(this.changebkg);
            this.page1.Controls.Add(this.label2);
            this.page1.Controls.Add(this.changeheader);
            this.page1.Controls.Add(this.label1);
            this.page1.Controls.Add(this.WindowTitle);
            this.page1.Controls.Add(this.labelWindowTitle);
            this.page1.Controls.Add(this.SelectWorkingPath);
            this.page1.Controls.Add(this.wplabel);
            this.page1.Controls.Add(this.WorkingPath);
            this.page1.Controls.Add(this.back);
            this.page1.Controls.Add(this.head);
            this.page1.Location = new System.Drawing.Point(4, 22);
            this.page1.Name = "page1";
            this.page1.Padding = new System.Windows.Forms.Padding(3);
            this.page1.Size = new System.Drawing.Size(534, 305);
            this.page1.TabIndex = 0;
            this.page1.Text = "General Settings";
            this.page1.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(219, 65);
            this.label20.TabIndex = 14;
            this.label20.Text = resources.GetString("label20.Text");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(13, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(270, 37);
            this.label17.TabIndex = 13;
            this.label17.Text = "General Settings";
            // 
            // changebkg
            // 
            this.changebkg.Location = new System.Drawing.Point(425, 72);
            this.changebkg.Name = "changebkg";
            this.changebkg.Size = new System.Drawing.Size(57, 20);
            this.changebkg.TabIndex = 9;
            this.changebkg.Text = "Browse";
            this.changebkg.UseVisualStyleBackColor = true;
            this.changebkg.Click += new System.EventHandler(this.changebkg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Background Image";
            // 
            // changeheader
            // 
            this.changeheader.Location = new System.Drawing.Point(425, 199);
            this.changeheader.Name = "changeheader";
            this.changeheader.Size = new System.Drawing.Size(57, 20);
            this.changeheader.TabIndex = 10;
            this.changeheader.Text = "Browse";
            this.changeheader.UseVisualStyleBackColor = true;
            this.changeheader.Click += new System.EventHandler(this.changeheader_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Header Image";
            // 
            // WindowTitle
            // 
            this.WindowTitle.Location = new System.Drawing.Point(25, 200);
            this.WindowTitle.Name = "WindowTitle";
            this.WindowTitle.Size = new System.Drawing.Size(209, 20);
            this.WindowTitle.TabIndex = 6;
            this.WindowTitle.TextChanged += new System.EventHandler(this.WindowTitle_TextChanged);
            // 
            // labelWindowTitle
            // 
            this.labelWindowTitle.AutoSize = true;
            this.labelWindowTitle.Location = new System.Drawing.Point(22, 184);
            this.labelWindowTitle.Name = "labelWindowTitle";
            this.labelWindowTitle.Size = new System.Drawing.Size(69, 13);
            this.labelWindowTitle.TabIndex = 3;
            this.labelWindowTitle.Text = "Window Title";
            // 
            // SelectWorkingPath
            // 
            this.SelectWorkingPath.Location = new System.Drawing.Point(177, 237);
            this.SelectWorkingPath.Name = "SelectWorkingPath";
            this.SelectWorkingPath.Size = new System.Drawing.Size(57, 20);
            this.SelectWorkingPath.TabIndex = 8;
            this.SelectWorkingPath.Text = "Browse";
            this.SelectWorkingPath.UseVisualStyleBackColor = true;
            this.SelectWorkingPath.Click += new System.EventHandler(this.SelectWorkingPath_Click);
            // 
            // wplabel
            // 
            this.wplabel.AutoSize = true;
            this.wplabel.Location = new System.Drawing.Point(22, 222);
            this.wplabel.Name = "wplabel";
            this.wplabel.Size = new System.Drawing.Size(72, 13);
            this.wplabel.TabIndex = 2;
            this.wplabel.Text = "Working Path";
            // 
            // WorkingPath
            // 
            this.WorkingPath.Location = new System.Drawing.Point(25, 238);
            this.WorkingPath.Name = "WorkingPath";
            this.WorkingPath.Size = new System.Drawing.Size(146, 20);
            this.WorkingPath.TabIndex = 7;
            this.WorkingPath.TextChanged += new System.EventHandler(this.WorkingPath_TextChanged);
            // 
            // back
            // 
            this.back.Image = global::Rotux.Properties.Resources.sand;
            this.back.Location = new System.Drawing.Point(273, 72);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(146, 105);
            this.back.TabIndex = 11;
            this.back.TabStop = false;
            // 
            // head
            // 
            this.head.ErrorImage = null;
            this.head.Image = global::Rotux.Properties.Resources.sand;
            this.head.InitialImage = null;
            this.head.Location = new System.Drawing.Point(273, 199);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(146, 105);
            this.head.TabIndex = 8;
            this.head.TabStop = false;
            // 
            // page2
            // 
            this.page2.Controls.Add(this.label21);
            this.page2.Controls.Add(this.label18);
            this.page2.Controls.Add(this.mysqlbtn);
            this.page2.Controls.Add(this.label9);
            this.page2.Controls.Add(this.mysql);
            this.page2.Controls.Add(this.mysqlstopbtn);
            this.page2.Controls.Add(this.label8);
            this.page2.Controls.Add(this.mysqlstop);
            this.page2.Controls.Add(this.mysqlstartbtn);
            this.page2.Controls.Add(this.label7);
            this.page2.Controls.Add(this.mysqlstart);
            this.page2.Controls.Add(this.password);
            this.page2.Controls.Add(this.label6);
            this.page2.Controls.Add(this.username);
            this.page2.Controls.Add(this.label5);
            this.page2.Controls.Add(this.port);
            this.page2.Controls.Add(this.dbbutton);
            this.page2.Controls.Add(this.label4);
            this.page2.Controls.Add(this.database);
            this.page2.Controls.Add(this.host);
            this.page2.Controls.Add(this.label3);
            this.page2.Location = new System.Drawing.Point(4, 22);
            this.page2.Name = "page2";
            this.page2.Padding = new System.Windows.Forms.Padding(3);
            this.page2.Size = new System.Drawing.Size(534, 305);
            this.page2.TabIndex = 1;
            this.page2.Text = "MySQL Settings";
            this.page2.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(229, 78);
            this.label21.TabIndex = 34;
            this.label21.Text = resources.GetString("label21.Text");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(13, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(260, 37);
            this.label18.TabIndex = 33;
            this.label18.Text = "MySQL Settings";
            // 
            // mysqlbtn
            // 
            this.mysqlbtn.Location = new System.Drawing.Point(428, 238);
            this.mysqlbtn.Name = "mysqlbtn";
            this.mysqlbtn.Size = new System.Drawing.Size(57, 20);
            this.mysqlbtn.TabIndex = 22;
            this.mysqlbtn.Text = "Browse";
            this.mysqlbtn.UseVisualStyleBackColor = true;
            this.mysqlbtn.Click += new System.EventHandler(this.mysqlbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "MySQL Binary File";
            // 
            // mysql
            // 
            this.mysql.Location = new System.Drawing.Point(276, 239);
            this.mysql.Name = "mysql";
            this.mysql.Size = new System.Drawing.Size(146, 20);
            this.mysql.TabIndex = 21;
            this.mysql.TextChanged += new System.EventHandler(this.mysql_TextChanged);
            // 
            // mysqlstopbtn
            // 
            this.mysqlstopbtn.Location = new System.Drawing.Point(428, 199);
            this.mysqlstopbtn.Name = "mysqlstopbtn";
            this.mysqlstopbtn.Size = new System.Drawing.Size(57, 20);
            this.mysqlstopbtn.TabIndex = 20;
            this.mysqlstopbtn.Text = "Browse";
            this.mysqlstopbtn.UseVisualStyleBackColor = true;
            this.mysqlstopbtn.Click += new System.EventHandler(this.mysqlstopbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "MySQL Stop Script";
            // 
            // mysqlstop
            // 
            this.mysqlstop.Location = new System.Drawing.Point(276, 200);
            this.mysqlstop.Name = "mysqlstop";
            this.mysqlstop.Size = new System.Drawing.Size(146, 20);
            this.mysqlstop.TabIndex = 19;
            this.mysqlstop.TextChanged += new System.EventHandler(this.mysqlstop_TextChanged);
            // 
            // mysqlstartbtn
            // 
            this.mysqlstartbtn.Location = new System.Drawing.Point(428, 160);
            this.mysqlstartbtn.Name = "mysqlstartbtn";
            this.mysqlstartbtn.Size = new System.Drawing.Size(57, 20);
            this.mysqlstartbtn.TabIndex = 18;
            this.mysqlstartbtn.Text = "Browse";
            this.mysqlstartbtn.UseVisualStyleBackColor = true;
            this.mysqlstartbtn.Click += new System.EventHandler(this.mysqlstartbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "MySQL Start Script";
            // 
            // mysqlstart
            // 
            this.mysqlstart.Location = new System.Drawing.Point(276, 161);
            this.mysqlstart.Name = "mysqlstart";
            this.mysqlstart.Size = new System.Drawing.Size(146, 20);
            this.mysqlstart.TabIndex = 17;
            this.mysqlstart.TextChanged += new System.EventHandler(this.mysqlstart_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(276, 116);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(209, 20);
            this.password.TabIndex = 16;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "MySQL Password";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(276, 77);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(209, 20);
            this.username.TabIndex = 15;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "MySQL Username";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(177, 201);
            this.port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(56, 20);
            this.port.TabIndex = 12;
            this.port.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.port.ValueChanged += new System.EventHandler(this.port_ValueChanged);
            // 
            // dbbutton
            // 
            this.dbbutton.Location = new System.Drawing.Point(177, 238);
            this.dbbutton.Name = "dbbutton";
            this.dbbutton.Size = new System.Drawing.Size(57, 20);
            this.dbbutton.TabIndex = 14;
            this.dbbutton.Text = "Browse";
            this.dbbutton.UseVisualStyleBackColor = true;
            this.dbbutton.Click += new System.EventHandler(this.dbbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "MySQL Database";
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(25, 239);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(146, 20);
            this.database.TabIndex = 13;
            this.database.TextChanged += new System.EventHandler(this.database_TextChanged);
            // 
            // host
            // 
            this.host.Location = new System.Drawing.Point(25, 200);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(146, 20);
            this.host.TabIndex = 11;
            this.host.TextChanged += new System.EventHandler(this.host_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "MySQL Host";
            // 
            // page3
            // 
            this.page3.Controls.Add(this.label22);
            this.page3.Controls.Add(this.label19);
            this.page3.Controls.Add(this.ServerBtn);
            this.page3.Controls.Add(this.label14);
            this.page3.Controls.Add(this.Server);
            this.page3.Controls.Add(this.wServerBtn);
            this.page3.Controls.Add(this.label13);
            this.page3.Controls.Add(this.wServer);
            this.page3.Controls.Add(this.ClientBtn);
            this.page3.Controls.Add(this.label12);
            this.page3.Controls.Add(this.Client);
            this.page3.Controls.Add(this.label11);
            this.page3.Controls.Add(this.FlashDownload);
            this.page3.Controls.Add(this.FlashPlayerBtn);
            this.page3.Controls.Add(this.label10);
            this.page3.Controls.Add(this.FlashPlayer);
            this.page3.Location = new System.Drawing.Point(4, 22);
            this.page3.Name = "page3";
            this.page3.Size = new System.Drawing.Size(534, 305);
            this.page3.TabIndex = 2;
            this.page3.Text = "RotMG Settings";
            this.page3.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(207, 91);
            this.label22.TabIndex = 35;
            this.label22.Text = resources.GetString("label22.Text");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(13, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(246, 37);
            this.label19.TabIndex = 48;
            this.label19.Text = "Realm Settings";
            // 
            // ServerBtn
            // 
            this.ServerBtn.Location = new System.Drawing.Point(428, 239);
            this.ServerBtn.Name = "ServerBtn";
            this.ServerBtn.Size = new System.Drawing.Size(57, 20);
            this.ServerBtn.TabIndex = 31;
            this.ServerBtn.Text = "Browse";
            this.ServerBtn.UseVisualStyleBackColor = true;
            this.ServerBtn.Click += new System.EventHandler(this.ServerBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(273, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Request Server Binary Path";
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(276, 239);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(146, 20);
            this.Server.TabIndex = 30;
            this.Server.TextChanged += new System.EventHandler(this.Server_TextChanged);
            // 
            // wServerBtn
            // 
            this.wServerBtn.Location = new System.Drawing.Point(428, 200);
            this.wServerBtn.Name = "wServerBtn";
            this.wServerBtn.Size = new System.Drawing.Size(57, 20);
            this.wServerBtn.TabIndex = 29;
            this.wServerBtn.Text = "Browse";
            this.wServerBtn.UseVisualStyleBackColor = true;
            this.wServerBtn.Click += new System.EventHandler(this.wServerBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(273, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "World Server Binary Path";
            // 
            // wServer
            // 
            this.wServer.Location = new System.Drawing.Point(276, 200);
            this.wServer.Name = "wServer";
            this.wServer.Size = new System.Drawing.Size(146, 20);
            this.wServer.TabIndex = 28;
            this.wServer.TextChanged += new System.EventHandler(this.wServer_TextChanged);
            // 
            // ClientBtn
            // 
            this.ClientBtn.Location = new System.Drawing.Point(428, 161);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(57, 20);
            this.ClientBtn.TabIndex = 27;
            this.ClientBtn.Text = "Browse";
            this.ClientBtn.UseVisualStyleBackColor = true;
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Private Server Client Path";
            // 
            // Client
            // 
            this.Client.Location = new System.Drawing.Point(276, 161);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(146, 20);
            this.Client.TabIndex = 26;
            this.Client.TextChanged += new System.EventHandler(this.Client_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Flash Projector Download URL";
            // 
            // FlashDownload
            // 
            this.FlashDownload.Location = new System.Drawing.Point(25, 239);
            this.FlashDownload.Name = "FlashDownload";
            this.FlashDownload.Size = new System.Drawing.Size(209, 20);
            this.FlashDownload.TabIndex = 25;
            this.FlashDownload.TextChanged += new System.EventHandler(this.FlashDownload_TextChanged);
            // 
            // FlashPlayerBtn
            // 
            this.FlashPlayerBtn.Location = new System.Drawing.Point(177, 200);
            this.FlashPlayerBtn.Name = "FlashPlayerBtn";
            this.FlashPlayerBtn.Size = new System.Drawing.Size(57, 20);
            this.FlashPlayerBtn.TabIndex = 24;
            this.FlashPlayerBtn.Text = "Browse";
            this.FlashPlayerBtn.UseVisualStyleBackColor = true;
            this.FlashPlayerBtn.Click += new System.EventHandler(this.FlashPlayerBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Flash Projector Path";
            // 
            // FlashPlayer
            // 
            this.FlashPlayer.Location = new System.Drawing.Point(25, 200);
            this.FlashPlayer.Name = "FlashPlayer";
            this.FlashPlayer.Size = new System.Drawing.Size(146, 20);
            this.FlashPlayer.TabIndex = 23;
            this.FlashPlayer.TextChanged += new System.EventHandler(this.FlashPlayer_TextChanged);
            // 
            // finish
            // 
            this.finish.Controls.Add(this.databasecreate);
            this.finish.Controls.Add(this.GitHub);
            this.finish.Controls.Add(this.StartOnExit);
            this.finish.Controls.Add(this.pictureBox2);
            this.finish.Controls.Add(this.label24);
            this.finish.Controls.Add(this.label23);
            this.finish.Location = new System.Drawing.Point(4, 22);
            this.finish.Name = "finish";
            this.finish.Padding = new System.Windows.Forms.Padding(3);
            this.finish.Size = new System.Drawing.Size(534, 305);
            this.finish.TabIndex = 4;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            // 
            // databasecreate
            // 
            this.databasecreate.AutoSize = true;
            this.databasecreate.Location = new System.Drawing.Point(20, 189);
            this.databasecreate.Name = "databasecreate";
            this.databasecreate.Size = new System.Drawing.Size(187, 17);
            this.databasecreate.TabIndex = 54;
            this.databasecreate.Text = "Create the database on the server";
            this.databasecreate.UseVisualStyleBackColor = true;
            // 
            // GitHub
            // 
            this.GitHub.AutoSize = true;
            this.GitHub.Location = new System.Drawing.Point(20, 212);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(125, 17);
            this.GitHub.TabIndex = 53;
            this.GitHub.Text = "View the Github repo";
            this.GitHub.UseVisualStyleBackColor = true;
            // 
            // StartOnExit
            // 
            this.StartOnExit.AutoSize = true;
            this.StartOnExit.Location = new System.Drawing.Point(20, 166);
            this.StartOnExit.Name = "StartOnExit";
            this.StartOnExit.Size = new System.Drawing.Size(116, 17);
            this.StartOnExit.TabIndex = 52;
            this.StartOnExit.Text = "Launch Rotux now";
            this.StartOnExit.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Rotux.Properties.Resources.sword;
            this.pictureBox2.Location = new System.Drawing.Point(297, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 227);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 60);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(303, 78);
            this.label24.TabIndex = 50;
            this.label24.Text = resources.GetString("label24.Text");
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(13, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(259, 37);
            this.label23.TabIndex = 49;
            this.label23.Text = "Setup Complete";
            // 
            // auto
            // 
            this.auto.Controls.Add(this.WorkingOn);
            this.auto.Controls.Add(this.label26);
            this.auto.Controls.Add(this.label16);
            this.auto.Controls.Add(this.AutoDetectProgress);
            this.auto.Controls.Add(this.AutoDetectConsole);
            this.auto.Location = new System.Drawing.Point(4, 22);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(534, 305);
            this.auto.TabIndex = 5;
            this.auto.Text = "Detect";
            this.auto.UseVisualStyleBackColor = true;
            // 
            // WorkingOn
            // 
            this.WorkingOn.AutoSize = true;
            this.WorkingOn.Location = new System.Drawing.Point(4, 289);
            this.WorkingOn.Name = "WorkingOn";
            this.WorkingOn.Size = new System.Drawing.Size(38, 13);
            this.WorkingOn.TabIndex = 52;
            this.WorkingOn.Text = "Ready";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(17, 60);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(252, 26);
            this.label26.TabIndex = 51;
            this.label26.Text = "We are currently searching for the files needed\r\nfor your private server to run, " +
    "this may take a while...";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(13, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(329, 37);
            this.label16.TabIndex = 50;
            this.label16.Text = "Auto-Detect Settings";
            // 
            // AutoDetectProgress
            // 
            this.AutoDetectProgress.Location = new System.Drawing.Point(3, 115);
            this.AutoDetectProgress.Name = "AutoDetectProgress";
            this.AutoDetectProgress.Size = new System.Drawing.Size(528, 23);
            this.AutoDetectProgress.TabIndex = 1;
            // 
            // AutoDetectConsole
            // 
            this.AutoDetectConsole.Location = new System.Drawing.Point(3, 144);
            this.AutoDetectConsole.Multiline = true;
            this.AutoDetectConsole.Name = "AutoDetectConsole";
            this.AutoDetectConsole.ReadOnly = true;
            this.AutoDetectConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AutoDetectConsole.Size = new System.Drawing.Size(528, 139);
            this.AutoDetectConsole.TabIndex = 0;
            // 
            // RotuxSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 386);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RotuxSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rotux Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RotuxSetup_FormClosing);
            this.Load += new System.EventHandler(this.RotuxSetup_Load);
            this.tabControl1.ResumeLayout(false);
            this.welcome.ResumeLayout(false);
            this.welcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).EndInit();
            this.page2.ResumeLayout(false);
            this.page2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.page3.ResumeLayout(false);
            this.page3.PerformLayout();
            this.finish.ResumeLayout(false);
            this.finish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.auto.ResumeLayout(false);
            this.auto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox WorkingPath;
        private System.Windows.Forms.Button SelectWorkingPath;
        private System.Windows.Forms.FolderBrowserDialog openfolderdialog;
        private System.Windows.Forms.Label wplabel;
        private System.Windows.Forms.TabPage page1;
        private System.Windows.Forms.TabPage page2;
        private System.Windows.Forms.TextBox WindowTitle;
        private System.Windows.Forms.Label labelWindowTitle;
        private System.Windows.Forms.Button changeheader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox head;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Button changebkg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dbbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.NumericUpDown port;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button mysqlstopbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mysqlstop;
        private System.Windows.Forms.Button mysqlstartbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mysqlstart;
        private System.Windows.Forms.Button mysqlbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mysql;
        private System.Windows.Forms.TabPage page3;
        private System.Windows.Forms.Button FlashPlayerBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FlashPlayer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox FlashDownload;
        private System.Windows.Forms.Button ClientBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Client;
        private System.Windows.Forms.Button ServerBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.Button wServerBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox wServer;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button FinishBtn;
        private TablessControl tabControl1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TabPage welcome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage finish;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox GitHub;
        private System.Windows.Forms.CheckBox StartOnExit;
        private System.Windows.Forms.CheckBox databasecreate;
        private System.Windows.Forms.Button autodetect;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage auto;
        private System.Windows.Forms.TextBox AutoDetectConsole;
        private System.Windows.Forms.ProgressBar AutoDetectProgress;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label WorkingOn;
    }
}