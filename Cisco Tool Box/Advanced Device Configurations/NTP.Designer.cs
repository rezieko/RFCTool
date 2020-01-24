namespace Cisco_Tool_Box
{
    partial class NTP
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
            this.IpAddChecked = new System.Windows.Forms.CheckBox();
            this.HostnameChecked = new System.Windows.Forms.CheckBox();
            this.IpAddText = new System.Windows.Forms.TextBox();
            this.HostnameText = new System.Windows.Forms.TextBox();
            this.VersionChecked = new System.Windows.Forms.CheckBox();
            this.VersionText = new System.Windows.Forms.TextBox();
            this.KeyChecked = new System.Windows.Forms.CheckBox();
            this.KeyText = new System.Windows.Forms.TextBox();
            this.SourceChecked = new System.Windows.Forms.CheckBox();
            this.SourceText = new System.Windows.Forms.TextBox();
            this.PreferChecked = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TrustedKeyNumText = new System.Windows.Forms.TextBox();
            this.AuthenKeyValueText = new System.Windows.Forms.TextBox();
            this.AuthenKeyNumberText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IpAddChecked
            // 
            this.IpAddChecked.AutoSize = true;
            this.IpAddChecked.Location = new System.Drawing.Point(6, 17);
            this.IpAddChecked.Name = "IpAddChecked";
            this.IpAddChecked.Size = new System.Drawing.Size(77, 17);
            this.IpAddChecked.TabIndex = 1;
            this.IpAddChecked.Text = "IP Address";
            this.IpAddChecked.UseVisualStyleBackColor = true;
            this.IpAddChecked.CheckedChanged += new System.EventHandler(this.IpAddChecked_CheckedChanged);
            // 
            // HostnameChecked
            // 
            this.HostnameChecked.AutoSize = true;
            this.HostnameChecked.Location = new System.Drawing.Point(6, 43);
            this.HostnameChecked.Name = "HostnameChecked";
            this.HostnameChecked.Size = new System.Drawing.Size(74, 17);
            this.HostnameChecked.TabIndex = 2;
            this.HostnameChecked.Text = "Hostname";
            this.HostnameChecked.UseVisualStyleBackColor = true;
            this.HostnameChecked.CheckedChanged += new System.EventHandler(this.HostnameChecked_CheckedChanged);
            // 
            // IpAddText
            // 
            this.IpAddText.Location = new System.Drawing.Point(89, 15);
            this.IpAddText.Name = "IpAddText";
            this.IpAddText.Size = new System.Drawing.Size(100, 20);
            this.IpAddText.TabIndex = 3;
            this.IpAddText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HostnameText
            // 
            this.HostnameText.Location = new System.Drawing.Point(89, 41);
            this.HostnameText.Name = "HostnameText";
            this.HostnameText.Size = new System.Drawing.Size(100, 20);
            this.HostnameText.TabIndex = 3;
            this.HostnameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // VersionChecked
            // 
            this.VersionChecked.AutoSize = true;
            this.VersionChecked.Location = new System.Drawing.Point(6, 69);
            this.VersionChecked.Name = "VersionChecked";
            this.VersionChecked.Size = new System.Drawing.Size(61, 17);
            this.VersionChecked.TabIndex = 4;
            this.VersionChecked.Text = "Version";
            this.VersionChecked.UseVisualStyleBackColor = true;
            this.VersionChecked.CheckedChanged += new System.EventHandler(this.VersionChecked_CheckedChanged);
            // 
            // VersionText
            // 
            this.VersionText.Location = new System.Drawing.Point(89, 67);
            this.VersionText.Name = "VersionText";
            this.VersionText.Size = new System.Drawing.Size(100, 20);
            this.VersionText.TabIndex = 3;
            this.VersionText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // KeyChecked
            // 
            this.KeyChecked.AutoSize = true;
            this.KeyChecked.Location = new System.Drawing.Point(6, 95);
            this.KeyChecked.Name = "KeyChecked";
            this.KeyChecked.Size = new System.Drawing.Size(58, 17);
            this.KeyChecked.TabIndex = 5;
            this.KeyChecked.Text = "Key ID";
            this.KeyChecked.UseVisualStyleBackColor = true;
            this.KeyChecked.CheckedChanged += new System.EventHandler(this.KeyChecked_CheckedChanged);
            // 
            // KeyText
            // 
            this.KeyText.Location = new System.Drawing.Point(89, 93);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(100, 20);
            this.KeyText.TabIndex = 3;
            this.KeyText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SourceChecked
            // 
            this.SourceChecked.AutoSize = true;
            this.SourceChecked.Location = new System.Drawing.Point(6, 121);
            this.SourceChecked.Name = "SourceChecked";
            this.SourceChecked.Size = new System.Drawing.Size(105, 17);
            this.SourceChecked.TabIndex = 6;
            this.SourceChecked.Text = "Source Interface";
            this.SourceChecked.UseVisualStyleBackColor = true;
            this.SourceChecked.CheckedChanged += new System.EventHandler(this.SourceChecked_CheckedChanged);
            // 
            // SourceText
            // 
            this.SourceText.Location = new System.Drawing.Point(117, 119);
            this.SourceText.Name = "SourceText";
            this.SourceText.Size = new System.Drawing.Size(100, 20);
            this.SourceText.TabIndex = 3;
            this.SourceText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PreferChecked
            // 
            this.PreferChecked.AutoSize = true;
            this.PreferChecked.Location = new System.Drawing.Point(6, 145);
            this.PreferChecked.Name = "PreferChecked";
            this.PreferChecked.Size = new System.Drawing.Size(60, 17);
            this.PreferChecked.TabIndex = 7;
            this.PreferChecked.Text = "Prefer?";
            this.PreferChecked.UseVisualStyleBackColor = true;
            this.PreferChecked.CheckedChanged += new System.EventHandler(this.PreferChecked_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HostnameChecked);
            this.groupBox1.Controls.Add(this.PreferChecked);
            this.groupBox1.Controls.Add(this.IpAddChecked);
            this.groupBox1.Controls.Add(this.SourceChecked);
            this.groupBox1.Controls.Add(this.IpAddText);
            this.groupBox1.Controls.Add(this.KeyChecked);
            this.groupBox1.Controls.Add(this.HostnameText);
            this.groupBox1.Controls.Add(this.VersionChecked);
            this.groupBox1.Controls.Add(this.VersionText);
            this.groupBox1.Controls.Add(this.SourceText);
            this.groupBox1.Controls.Add(this.KeyText);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 173);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TrustedKeyNumText);
            this.groupBox2.Controls.Add(this.AuthenKeyValueText);
            this.groupBox2.Controls.Add(this.AuthenKeyNumberText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(259, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 96);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authentication";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trusted-Key Number";
            // 
            // TrustedKeyNumText
            // 
            this.TrustedKeyNumText.Location = new System.Drawing.Point(143, 67);
            this.TrustedKeyNumText.Name = "TrustedKeyNumText";
            this.TrustedKeyNumText.Size = new System.Drawing.Size(100, 20);
            this.TrustedKeyNumText.TabIndex = 2;
            this.TrustedKeyNumText.TextChanged += new System.EventHandler(this.TrustedKeyNumText_TextChanged);
            // 
            // AuthenKeyValueText
            // 
            this.AuthenKeyValueText.Location = new System.Drawing.Point(143, 41);
            this.AuthenKeyValueText.Name = "AuthenKeyValueText";
            this.AuthenKeyValueText.Size = new System.Drawing.Size(100, 20);
            this.AuthenKeyValueText.TabIndex = 2;
            // 
            // AuthenKeyNumberText
            // 
            this.AuthenKeyNumberText.Location = new System.Drawing.Point(143, 15);
            this.AuthenKeyNumberText.Name = "AuthenKeyNumberText";
            this.AuthenKeyNumberText.Size = new System.Drawing.Size(100, 20);
            this.AuthenKeyNumberText.TabIndex = 2;
            this.AuthenKeyNumberText.TextChanged += new System.EventHandler(this.AuthenKeyNumberText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Authentication Key Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authentication Key Number";
            // 
            // NTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(525, 224);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NTP";
            this.Text = "NTP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox IpAddChecked;
        private System.Windows.Forms.CheckBox HostnameChecked;
        private System.Windows.Forms.TextBox IpAddText;
        private System.Windows.Forms.TextBox HostnameText;
        private System.Windows.Forms.CheckBox VersionChecked;
        private System.Windows.Forms.TextBox VersionText;
        private System.Windows.Forms.CheckBox KeyChecked;
        private System.Windows.Forms.TextBox KeyText;
        private System.Windows.Forms.CheckBox SourceChecked;
        private System.Windows.Forms.TextBox SourceText;
        private System.Windows.Forms.CheckBox PreferChecked;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TrustedKeyNumText;
        private System.Windows.Forms.TextBox AuthenKeyValueText;
        private System.Windows.Forms.TextBox AuthenKeyNumberText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}