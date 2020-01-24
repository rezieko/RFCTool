namespace Cisco_Tool_Box
{
    partial class ASARemoteAccessServices
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
            this.TelnetTimeoutText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TelnetIntNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TelnetIpAddText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TelnetShouldUseIP = new System.Windows.Forms.CheckBox();
            this.TelnetLineConPassText = new System.Windows.Forms.TextBox();
            this.TelnetSubnetMaskAbbriev = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TelnetSubnetMaskText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TelnetChecked = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SshPassText = new System.Windows.Forms.TextBox();
            this.SshUserText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SshChecked = new System.Windows.Forms.CheckBox();
            this.SshLineConPassText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SshSubnetMaskText = new System.Windows.Forms.TextBox();
            this.SshSubnetMaskAbbriev = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SshIpAddText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SshIntNameText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SshTimeoutText = new System.Windows.Forms.TextBox();
            this.SshShouldUseIP = new System.Windows.Forms.CheckBox();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TelnetTimeoutText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TelnetIntNameText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TelnetIpAddText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TelnetShouldUseIP);
            this.groupBox1.Controls.Add(this.TelnetLineConPassText);
            this.groupBox1.Controls.Add(this.TelnetSubnetMaskAbbriev);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TelnetSubnetMaskText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TelnetChecked);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telnet";
            // 
            // TelnetTimeoutText
            // 
            this.TelnetTimeoutText.Location = new System.Drawing.Point(96, 148);
            this.TelnetTimeoutText.Name = "TelnetTimeoutText";
            this.TelnetTimeoutText.Size = new System.Drawing.Size(100, 20);
            this.TelnetTimeoutText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Timeout Minutes";
            // 
            // TelnetIntNameText
            // 
            this.TelnetIntNameText.Location = new System.Drawing.Point(96, 121);
            this.TelnetIntNameText.Name = "TelnetIntNameText";
            this.TelnetIntNameText.Size = new System.Drawing.Size(100, 20);
            this.TelnetIntNameText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interface Name";
            // 
            // TelnetIpAddText
            // 
            this.TelnetIpAddText.Location = new System.Drawing.Point(74, 67);
            this.TelnetIpAddText.Name = "TelnetIpAddText";
            this.TelnetIpAddText.Size = new System.Drawing.Size(100, 20);
            this.TelnetIpAddText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Address";
            // 
            // TelnetShouldUseIP
            // 
            this.TelnetShouldUseIP.AutoSize = true;
            this.TelnetShouldUseIP.Checked = true;
            this.TelnetShouldUseIP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TelnetShouldUseIP.Location = new System.Drawing.Point(146, 96);
            this.TelnetShouldUseIP.Name = "TelnetShouldUseIP";
            this.TelnetShouldUseIP.Size = new System.Drawing.Size(99, 17);
            this.TelnetShouldUseIP.TabIndex = 5;
            this.TelnetShouldUseIP.Text = "Use IP Address";
            this.TelnetShouldUseIP.UseVisualStyleBackColor = true;
            this.TelnetShouldUseIP.CheckedChanged += new System.EventHandler(this.ShouldUseIP_CheckedChanged);
            // 
            // TelnetLineConPassText
            // 
            this.TelnetLineConPassText.Location = new System.Drawing.Point(130, 41);
            this.TelnetLineConPassText.Name = "TelnetLineConPassText";
            this.TelnetLineConPassText.Size = new System.Drawing.Size(100, 20);
            this.TelnetLineConPassText.TabIndex = 2;
            // 
            // TelnetSubnetMaskAbbriev
            // 
            this.TelnetSubnetMaskAbbriev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TelnetSubnetMaskAbbriev.FormattingEnabled = true;
            this.TelnetSubnetMaskAbbriev.Location = new System.Drawing.Point(95, 94);
            this.TelnetSubnetMaskAbbriev.Name = "TelnetSubnetMaskAbbriev";
            this.TelnetSubnetMaskAbbriev.Size = new System.Drawing.Size(45, 21);
            this.TelnetSubnetMaskAbbriev.TabIndex = 4;
            this.TelnetSubnetMaskAbbriev.SelectedIndexChanged += new System.EventHandler(this.SubnetMaskAbbriev_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Console Lines Password";
            // 
            // TelnetSubnetMaskText
            // 
            this.TelnetSubnetMaskText.Location = new System.Drawing.Point(251, 94);
            this.TelnetSubnetMaskText.Name = "TelnetSubnetMaskText";
            this.TelnetSubnetMaskText.Size = new System.Drawing.Size(100, 20);
            this.TelnetSubnetMaskText.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Subnet Mask";
            this.label5.Click += new System.EventHandler(this.Interface_Click);
            // 
            // TelnetChecked
            // 
            this.TelnetChecked.AutoSize = true;
            this.TelnetChecked.Location = new System.Drawing.Point(7, 20);
            this.TelnetChecked.Name = "TelnetChecked";
            this.TelnetChecked.Size = new System.Drawing.Size(116, 17);
            this.TelnetChecked.TabIndex = 0;
            this.TelnetChecked.Text = "Configure TELNET";
            this.TelnetChecked.UseVisualStyleBackColor = true;
            this.TelnetChecked.CheckedChanged += new System.EventHandler(this.TelnetChecked_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SshShouldUseIP);
            this.groupBox2.Controls.Add(this.SshTimeoutText);
            this.groupBox2.Controls.Add(this.SshPassText);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.SshUserText);
            this.groupBox2.Controls.Add(this.SshIntNameText);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SshIpAddText);
            this.groupBox2.Controls.Add(this.SshChecked);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.SshLineConPassText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.SshSubnetMaskText);
            this.groupBox2.Controls.Add(this.SshSubnetMaskAbbriev);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(13, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SSH";
            // 
            // SshPassText
            // 
            this.SshPassText.Location = new System.Drawing.Point(239, 66);
            this.SshPassText.Name = "SshPassText";
            this.SshPassText.Size = new System.Drawing.Size(100, 20);
            this.SshPassText.TabIndex = 6;
            // 
            // SshUserText
            // 
            this.SshUserText.Location = new System.Drawing.Point(74, 66);
            this.SshUserText.Name = "SshUserText";
            this.SshUserText.Size = new System.Drawing.Size(100, 20);
            this.SshUserText.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Username";
            // 
            // SshChecked
            // 
            this.SshChecked.AutoSize = true;
            this.SshChecked.Location = new System.Drawing.Point(7, 19);
            this.SshChecked.Name = "SshChecked";
            this.SshChecked.Size = new System.Drawing.Size(96, 17);
            this.SshChecked.TabIndex = 0;
            this.SshChecked.Text = "Configure SSH";
            this.SshChecked.UseVisualStyleBackColor = true;
            // 
            // SshLineConPassText
            // 
            this.SshLineConPassText.Location = new System.Drawing.Point(130, 40);
            this.SshLineConPassText.Name = "SshLineConPassText";
            this.SshLineConPassText.Size = new System.Drawing.Size(100, 20);
            this.SshLineConPassText.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Console Lines Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Subnet Mask";
            this.label9.Click += new System.EventHandler(this.Interface_Click);
            // 
            // SshSubnetMaskText
            // 
            this.SshSubnetMaskText.Location = new System.Drawing.Point(251, 119);
            this.SshSubnetMaskText.Name = "SshSubnetMaskText";
            this.SshSubnetMaskText.Size = new System.Drawing.Size(100, 20);
            this.SshSubnetMaskText.TabIndex = 2;
            // 
            // SshSubnetMaskAbbriev
            // 
            this.SshSubnetMaskAbbriev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SshSubnetMaskAbbriev.FormattingEnabled = true;
            this.SshSubnetMaskAbbriev.Location = new System.Drawing.Point(95, 119);
            this.SshSubnetMaskAbbriev.Name = "SshSubnetMaskAbbriev";
            this.SshSubnetMaskAbbriev.Size = new System.Drawing.Size(45, 21);
            this.SshSubnetMaskAbbriev.TabIndex = 4;
            this.SshSubnetMaskAbbriev.SelectedIndexChanged += new System.EventHandler(this.SubnetMaskAbbriev_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "IP Address";
            // 
            // SshIpAddText
            // 
            this.SshIpAddText.Location = new System.Drawing.Point(74, 92);
            this.SshIpAddText.Name = "SshIpAddText";
            this.SshIpAddText.Size = new System.Drawing.Size(100, 20);
            this.SshIpAddText.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Interface Name";
            // 
            // SshIntNameText
            // 
            this.SshIntNameText.Location = new System.Drawing.Point(96, 144);
            this.SshIntNameText.Name = "SshIntNameText";
            this.SshIntNameText.Size = new System.Drawing.Size(100, 20);
            this.SshIntNameText.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Timeout Minutes";
            // 
            // SshTimeoutText
            // 
            this.SshTimeoutText.Location = new System.Drawing.Point(96, 171);
            this.SshTimeoutText.Name = "SshTimeoutText";
            this.SshTimeoutText.Size = new System.Drawing.Size(100, 20);
            this.SshTimeoutText.TabIndex = 9;
            // 
            // SshShouldUseIP
            // 
            this.SshShouldUseIP.AutoSize = true;
            this.SshShouldUseIP.Checked = true;
            this.SshShouldUseIP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SshShouldUseIP.Location = new System.Drawing.Point(146, 121);
            this.SshShouldUseIP.Name = "SshShouldUseIP";
            this.SshShouldUseIP.Size = new System.Drawing.Size(99, 17);
            this.SshShouldUseIP.TabIndex = 10;
            this.SshShouldUseIP.Text = "Use IP Address";
            this.SshShouldUseIP.UseVisualStyleBackColor = true;
            this.SshShouldUseIP.CheckedChanged += new System.EventHandler(this.SshShouldUseIP_CheckedChanged);
            // 
            // ASARemoteAccessServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(394, 446);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ASARemoteAccessServices";
            this.Text = "ASARemoteAccessServices";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TelnetIpAddText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TelnetLineConPassText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox TelnetChecked;
        private System.Windows.Forms.CheckBox TelnetShouldUseIP;
        private System.Windows.Forms.ComboBox TelnetSubnetMaskAbbriev;
        private System.Windows.Forms.TextBox TelnetSubnetMaskText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TelnetIntNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TelnetTimeoutText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SshPassText;
        private System.Windows.Forms.TextBox SshUserText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox SshChecked;
        private System.Windows.Forms.TextBox SshLineConPassText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SshTimeoutText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SshIntNameText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SshIpAddText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SshSubnetMaskText;
        private System.Windows.Forms.ComboBox SshSubnetMaskAbbriev;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox SshShouldUseIP;
    }
}