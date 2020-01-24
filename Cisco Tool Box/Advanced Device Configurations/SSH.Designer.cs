namespace Cisco_Tool_Box
{
    partial class SSH
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VerOneChecked = new System.Windows.Forms.CheckBox();
            this.VerTwoChecked = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DomainNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ModulusSizeText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeOutSecsText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AttemptsText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VerTwoChecked);
            this.groupBox1.Controls.Add(this.VerOneChecked);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 43);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Version";
            // 
            // VerOneChecked
            // 
            this.VerOneChecked.AutoSize = true;
            this.VerOneChecked.Location = new System.Drawing.Point(7, 20);
            this.VerOneChecked.Name = "VerOneChecked";
            this.VerOneChecked.Size = new System.Drawing.Size(70, 17);
            this.VerOneChecked.TabIndex = 0;
            this.VerOneChecked.Text = "Version 1";
            this.VerOneChecked.UseVisualStyleBackColor = true;
            this.VerOneChecked.CheckedChanged += new System.EventHandler(this.VerOneChecked_CheckedChanged);
            // 
            // VerTwoChecked
            // 
            this.VerTwoChecked.AutoSize = true;
            this.VerTwoChecked.Location = new System.Drawing.Point(83, 20);
            this.VerTwoChecked.Name = "VerTwoChecked";
            this.VerTwoChecked.Size = new System.Drawing.Size(70, 17);
            this.VerTwoChecked.TabIndex = 1;
            this.VerTwoChecked.Text = "Version 2";
            this.VerTwoChecked.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Domain-name";
            // 
            // DomainNameText
            // 
            this.DomainNameText.Location = new System.Drawing.Point(96, 90);
            this.DomainNameText.Name = "DomainNameText";
            this.DomainNameText.Size = new System.Drawing.Size(115, 20);
            this.DomainNameText.TabIndex = 3;
            this.DomainNameText.TextChanged += new System.EventHandler(this.DomainNameText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modulus Size";
            // 
            // ModulusSizeText
            // 
            this.ModulusSizeText.Location = new System.Drawing.Point(83, 19);
            this.ModulusSizeText.Name = "ModulusSizeText";
            this.ModulusSizeText.Size = new System.Drawing.Size(70, 20);
            this.ModulusSizeText.TabIndex = 3;
            this.ModulusSizeText.Text = "1024";
            this.ModulusSizeText.TextChanged += new System.EventHandler(this.ModulusSizeText_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ModulusSizeText);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(13, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 51);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RSA Crypto Key ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Out Seconds";
            // 
            // TimeOutSecsText
            // 
            this.TimeOutSecsText.Location = new System.Drawing.Point(119, 173);
            this.TimeOutSecsText.Name = "TimeOutSecsText";
            this.TimeOutSecsText.Size = new System.Drawing.Size(31, 20);
            this.TimeOutSecsText.TabIndex = 3;
            this.TimeOutSecsText.Text = "120";
            this.TimeOutSecsText.TextChanged += new System.EventHandler(this.DomainNameText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "# of Attempts before Disconnection";
            // 
            // AttemptsText
            // 
            this.AttemptsText.Location = new System.Drawing.Point(199, 197);
            this.AttemptsText.Name = "AttemptsText";
            this.AttemptsText.Size = new System.Drawing.Size(34, 20);
            this.AttemptsText.TabIndex = 3;
            this.AttemptsText.Text = "3";
            this.AttemptsText.TextChanged += new System.EventHandler(this.DomainNameText_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.PasswordText);
            this.groupBox3.Controls.Add(this.UsernameText);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(13, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 77);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username";
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(70, 17);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(100, 20);
            this.UsernameText.TabIndex = 1;
            this.UsernameText.TextChanged += new System.EventHandler(this.UsernameText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(70, 43);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(100, 20);
            this.PasswordText.TabIndex = 1;
            this.PasswordText.TextChanged += new System.EventHandler(this.PasswordText_TextChanged);
            // 
            // SSH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(254, 324);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AttemptsText);
            this.Controls.Add(this.TimeOutSecsText);
            this.Controls.Add(this.DomainNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SSH";
            this.Text = "SSH";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox VerTwoChecked;
        private System.Windows.Forms.CheckBox VerOneChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DomainNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ModulusSizeText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TimeOutSecsText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AttemptsText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PasswordText;
    }
}