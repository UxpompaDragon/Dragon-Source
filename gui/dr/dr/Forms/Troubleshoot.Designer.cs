namespace Rotux.Forms
{
    partial class Troubleshoot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Troubleshoot));
            this.detection = new System.Windows.Forms.TabPage();
            this.problem_label = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.detecting_label = new System.Windows.Forms.Label();
            this.done = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.desc = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            Pages = new Rotux.Controls.TablessControl();
            this.detection.SuspendLayout();
            this.done.SuspendLayout();
            Pages.SuspendLayout();
            this.SuspendLayout();
            // 
            // detection
            // 
            this.detection.Controls.Add(this.problem_label);
            this.detection.Controls.Add(this.progress);
            this.detection.Controls.Add(this.detecting_label);
            this.detection.Location = new System.Drawing.Point(4, 22);
            this.detection.Name = "detection";
            this.detection.Padding = new System.Windows.Forms.Padding(3);
            this.detection.Size = new System.Drawing.Size(513, 311);
            this.detection.TabIndex = 0;
            this.detection.Text = "Detecting";
            this.detection.UseVisualStyleBackColor = true;
            // 
            // problem_label
            // 
            this.problem_label.AutoSize = true;
            this.problem_label.Location = new System.Drawing.Point(18, 54);
            this.problem_label.Name = "problem_label";
            this.problem_label.Size = new System.Drawing.Size(140, 13);
            this.problem_label.TabIndex = 2;
            this.problem_label.Text = "Starting the troubleshooter...";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(6, 82);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(501, 23);
            this.progress.TabIndex = 1;
            // 
            // detecting_label
            // 
            this.detecting_label.AutoSize = true;
            this.detecting_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detecting_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.detecting_label.Location = new System.Drawing.Point(18, 22);
            this.detecting_label.Name = "detecting_label";
            this.detecting_label.Size = new System.Drawing.Size(154, 18);
            this.detecting_label.TabIndex = 0;
            this.detecting_label.Text = "Detecting problems";
            // 
            // done
            // 
            this.done.Controls.Add(this.button1);
            this.done.Controls.Add(this.desc);
            this.done.Controls.Add(this.title);
            this.done.Location = new System.Drawing.Point(4, 22);
            this.done.Name = "done";
            this.done.Padding = new System.Windows.Forms.Padding(3);
            this.done.Size = new System.Drawing.Size(513, 311);
            this.done.TabIndex = 1;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(18, 54);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(38, 13);
            this.desc.TabIndex = 4;
            this.desc.Text = "{desc}";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.title.Location = new System.Drawing.Point(18, 22);
            this.title.Name = "title";
            this.title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title.Size = new System.Drawing.Size(47, 18);
            this.title.TabIndex = 3;
            this.title.Text = "{title}";
            // 
            // Pages
            // 
            Pages.Controls.Add(this.detection);
            Pages.Controls.Add(this.done);
            Pages.Location = new System.Drawing.Point(12, 12);
            Pages.Name = "Pages";
            Pages.SelectedIndex = 0;
            Pages.Size = new System.Drawing.Size(521, 337);
            Pages.TabIndex = 0;
            // 
            // Troubleshoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 361);
            this.Controls.Add(Pages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Troubleshoot";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troubleshoot";
            this.Load += new System.EventHandler(this.Troubleshoot_Load);
            this.detection.ResumeLayout(false);
            this.detection.PerformLayout();
            this.done.ResumeLayout(false);
            this.done.PerformLayout();
            Pages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage detection;
        private System.Windows.Forms.TabPage done;
        private System.Windows.Forms.Label detecting_label;
        private System.Windows.Forms.Label problem_label;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button1;
        private Rotux.Controls.TablessControl Pages;

    }
}