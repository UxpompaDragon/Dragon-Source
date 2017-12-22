namespace Rotux.Forms
{
    partial class ChangeParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeParameter));
            this.changerankbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // changerankbtn
            // 
            this.changerankbtn.Location = new System.Drawing.Point(265, 131);
            this.changerankbtn.Name = "changerankbtn";
            this.changerankbtn.Size = new System.Drawing.Size(75, 23);
            this.changerankbtn.TabIndex = 0;
            this.changerankbtn.Text = "Change Rank";
            this.changerankbtn.UseVisualStyleBackColor = true;
            this.changerankbtn.Click += new System.EventHandler(this.changerankbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(11, 65);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(329, 20);
            this.email.TabIndex = 5;
            // 
            // key
            // 
            this.key.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.key.FormattingEnabled = true;
            this.key.Items.AddRange(new object[] {
            "id",
            "uuid",
            "password",
            "name",
            "rank",
            "namechosen",
            "verified",
            "guild",
            "guildRank",
            "guildFame",
            "lastip",
            "vaultCount",
            "maxCharSlot",
            "regTime",
            "guest",
            "banned",
            "publicMuledump",
            "muted",
            "prodAcc",
            "locked",
            "ignored",
            "gifts",
            "isAgeVerified",
            "petYardType",
            "ownedSkins",
            "authToken",
            "acceptedNewTos",
            "lastSeen",
            "accountInUse"});
            this.key.Location = new System.Drawing.Point(11, 25);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(329, 21);
            this.key.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(11, 104);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(327, 20);
            this.value.TabIndex = 8;
            // 
            // ChangeParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 168);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.key);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changerankbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Accounts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changerankbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.ComboBox key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox value;
    }
}