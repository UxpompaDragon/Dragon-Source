using System;
using System.Windows.Forms;

namespace Rotux.Forms
{
    partial class ExceptionWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionWindow));
            this.errortext = new System.Windows.Forms.TextBox();
            this.setupbtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // errortext
            // 
            this.errortext.Location = new System.Drawing.Point(12, 12);
            this.errortext.Multiline = true;
            this.errortext.Name = "errortext";
            this.errortext.ReadOnly = true;
            this.errortext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.errortext.Size = new System.Drawing.Size(374, 305);
            this.errortext.TabIndex = 0;
            // 
            // setupbtn
            // 
            this.setupbtn.Location = new System.Drawing.Point(12, 323);
            this.setupbtn.Name = "setupbtn";
            this.setupbtn.Size = new System.Drawing.Size(172, 23);
            this.setupbtn.TabIndex = 1;
            this.setupbtn.Text = "Run Setup";
            this.setupbtn.UseVisualStyleBackColor = true;
            this.setupbtn.Click += new System.EventHandler(this.setupbtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(214, 323);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(172, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Exit";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ExceptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 358);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.setupbtn);
            this.Controls.Add(this.errortext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExceptionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatal Error";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox errortext;
        private Button setupbtn;
        private Button CloseBtn;
    }
}