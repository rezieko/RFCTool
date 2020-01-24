namespace Cisco_Tool_Box
{
    partial class ASABasics
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HostnameText = new System.Windows.Forms.TextBox();
            this.DomainText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SecretText = new System.Windows.Forms.TextBox();
            this.LineConPassText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NewPassText = new System.Windows.Forms.TextBox();
            this.OldPassText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hostname";
            // 
            // HostnameText
            // 
            this.HostnameText.Location = new System.Drawing.Point(74, 42);
            this.HostnameText.Name = "HostnameText";
            this.HostnameText.Size = new System.Drawing.Size(100, 20);
            this.HostnameText.TabIndex = 2;
            // 
            // DomainText
            // 
            this.DomainText.Location = new System.Drawing.Point(93, 68);
            this.DomainText.Name = "DomainText";
            this.DomainText.Size = new System.Drawing.Size(100, 20);
            this.DomainText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Domain Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secret Password";
            // 
            // SecretText
            // 
            this.SecretText.Location = new System.Drawing.Point(106, 94);
            this.SecretText.Name = "SecretText";
            this.SecretText.Size = new System.Drawing.Size(100, 20);
            this.SecretText.TabIndex = 6;
            // 
            // LineConPassText
            // 
            this.LineConPassText.Location = new System.Drawing.Point(141, 120);
            this.LineConPassText.Name = "LineConPassText";
            this.LineConPassText.Size = new System.Drawing.Size(100, 20);
            this.LineConPassText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Console Lines Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OldPassText);
            this.groupBox1.Controls.Add(this.NewPassText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 71);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Encryption Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "New Passphrase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Old Passphrase";
            // 
            // NewPassText
            // 
            this.NewPassText.Location = new System.Drawing.Point(103, 17);
            this.NewPassText.Name = "NewPassText";
            this.NewPassText.Size = new System.Drawing.Size(100, 20);
            this.NewPassText.TabIndex = 2;
            // 
            // OldPassText
            // 
            this.OldPassText.Location = new System.Drawing.Point(103, 43);
            this.OldPassText.Name = "OldPassText";
            this.OldPassText.Size = new System.Drawing.Size(100, 20);
            this.OldPassText.TabIndex = 3;
            // 
            // ASABasics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(251, 224);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LineConPassText);
            this.Controls.Add(this.SecretText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DomainText);
            this.Controls.Add(this.HostnameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ASABasics";
            this.Text = "ASA Basic Configurations";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HostnameText;
        private System.Windows.Forms.TextBox DomainText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SecretText;
        private System.Windows.Forms.TextBox LineConPassText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox OldPassText;
        private System.Windows.Forms.TextBox NewPassText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}