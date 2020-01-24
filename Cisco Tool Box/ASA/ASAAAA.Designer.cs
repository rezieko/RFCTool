namespace Cisco_Tool_Box
{
    partial class ASAAAA
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
            this.PrivLevelText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PassText = new System.Windows.Forms.TextBox();
            this.UserText = new System.Windows.Forms.TextBox();
            this.PrivLevelChecked = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LocalUserChecked = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IntNameText = new System.Windows.Forms.TextBox();
            this.IntChecked = new System.Windows.Forms.CheckBox();
            this.ProtocolCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TagText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ServerChecked = new System.Windows.Forms.CheckBox();
            this.ServerIpChecked = new System.Windows.Forms.CheckBox();
            this.ServerNameChecked = new System.Windows.Forms.CheckBox();
            this.ServerIpText = new System.Windows.Forms.TextBox();
            this.ServerNameText = new System.Windows.Forms.TextBox();
            this.KeyText = new System.Windows.Forms.TextBox();
            this.KeyChecked = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AuthenChecked = new System.Windows.Forms.CheckBox();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LocalChecked = new System.Windows.Forms.CheckBox();
            this.ServerGroupChecked = new System.Windows.Forms.CheckBox();
            this.LocalServerGroupChecked = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ServerGroupText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrivLevelText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PassText);
            this.groupBox1.Controls.Add(this.UserText);
            this.groupBox1.Controls.Add(this.PrivLevelChecked);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LocalUserChecked);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local User Account";
            // 
            // PrivLevelText
            // 
            this.PrivLevelText.Location = new System.Drawing.Point(89, 115);
            this.PrivLevelText.Name = "PrivLevelText";
            this.PrivLevelText.Size = new System.Drawing.Size(100, 20);
            this.PrivLevelText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Privilege Level";
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(70, 68);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(100, 20);
            this.PassText.TabIndex = 5;
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(68, 41);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(100, 20);
            this.UserText.TabIndex = 4;
            // 
            // PrivLevelChecked
            // 
            this.PrivLevelChecked.AutoSize = true;
            this.PrivLevelChecked.Checked = true;
            this.PrivLevelChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PrivLevelChecked.Location = new System.Drawing.Point(7, 94);
            this.PrivLevelChecked.Name = "PrivLevelChecked";
            this.PrivLevelChecked.Size = new System.Drawing.Size(183, 17);
            this.PrivLevelChecked.TabIndex = 3;
            this.PrivLevelChecked.Text = "Configure Privilege Level for User";
            this.PrivLevelChecked.UseVisualStyleBackColor = true;
            this.PrivLevelChecked.CheckedChanged += new System.EventHandler(this.PrivLevelChecked_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // LocalUserChecked
            // 
            this.LocalUserChecked.AutoSize = true;
            this.LocalUserChecked.Checked = true;
            this.LocalUserChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LocalUserChecked.Location = new System.Drawing.Point(7, 20);
            this.LocalUserChecked.Name = "LocalUserChecked";
            this.LocalUserChecked.Size = new System.Drawing.Size(128, 17);
            this.LocalUserChecked.TabIndex = 0;
            this.LocalUserChecked.Text = "Configure Local User ";
            this.LocalUserChecked.UseVisualStyleBackColor = true;
            this.LocalUserChecked.CheckedChanged += new System.EventHandler(this.LocalUserChecked_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KeyChecked);
            this.groupBox2.Controls.Add(this.KeyText);
            this.groupBox2.Controls.Add(this.ServerNameText);
            this.groupBox2.Controls.Add(this.ServerIpText);
            this.groupBox2.Controls.Add(this.ServerNameChecked);
            this.groupBox2.Controls.Add(this.ServerIpChecked);
            this.groupBox2.Controls.Add(this.IntNameText);
            this.groupBox2.Controls.Add(this.IntChecked);
            this.groupBox2.Controls.Add(this.ProtocolCombo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TagText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ServerChecked);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TACACS+  / RADIUS Server ";
            // 
            // IntNameText
            // 
            this.IntNameText.Location = new System.Drawing.Point(112, 97);
            this.IntNameText.Name = "IntNameText";
            this.IntNameText.Size = new System.Drawing.Size(76, 20);
            this.IntNameText.TabIndex = 6;
            // 
            // IntChecked
            // 
            this.IntChecked.AutoSize = true;
            this.IntChecked.Checked = true;
            this.IntChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IntChecked.Location = new System.Drawing.Point(7, 99);
            this.IntChecked.Name = "IntChecked";
            this.IntChecked.Size = new System.Drawing.Size(99, 17);
            this.IntChecked.TabIndex = 5;
            this.IntChecked.Text = "Interface Name";
            this.IntChecked.UseVisualStyleBackColor = true;
            this.IntChecked.CheckedChanged += new System.EventHandler(this.IntChecked_CheckedChanged);
            // 
            // ProtocolCombo
            // 
            this.ProtocolCombo.FormattingEnabled = true;
            this.ProtocolCombo.Items.AddRange(new object[] {
            "tacacs+ ",
            "radius"});
            this.ProtocolCombo.Location = new System.Drawing.Point(73, 69);
            this.ProtocolCombo.Name = "ProtocolCombo";
            this.ProtocolCombo.Size = new System.Drawing.Size(100, 21);
            this.ProtocolCombo.TabIndex = 4;
            this.ProtocolCombo.Text = "Protocol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Protocol";
            // 
            // TagText
            // 
            this.TagText.Location = new System.Drawing.Point(73, 41);
            this.TagText.Name = "TagText";
            this.TagText.Size = new System.Drawing.Size(100, 20);
            this.TagText.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Server-Tag";
            // 
            // ServerChecked
            // 
            this.ServerChecked.AutoSize = true;
            this.ServerChecked.Checked = true;
            this.ServerChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ServerChecked.Location = new System.Drawing.Point(7, 20);
            this.ServerChecked.Name = "ServerChecked";
            this.ServerChecked.Size = new System.Drawing.Size(105, 17);
            this.ServerChecked.TabIndex = 0;
            this.ServerChecked.Text = "Configure Server";
            this.ServerChecked.UseVisualStyleBackColor = true;
            this.ServerChecked.CheckedChanged += new System.EventHandler(this.ServerChecked_CheckedChanged);
            // 
            // ServerIpChecked
            // 
            this.ServerIpChecked.AutoSize = true;
            this.ServerIpChecked.Checked = true;
            this.ServerIpChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ServerIpChecked.Location = new System.Drawing.Point(7, 125);
            this.ServerIpChecked.Name = "ServerIpChecked";
            this.ServerIpChecked.Size = new System.Drawing.Size(70, 17);
            this.ServerIpChecked.TabIndex = 7;
            this.ServerIpChecked.Text = "Server IP";
            this.ServerIpChecked.UseVisualStyleBackColor = true;
            this.ServerIpChecked.CheckedChanged += new System.EventHandler(this.ServerIpChecked_CheckedChanged);
            // 
            // ServerNameChecked
            // 
            this.ServerNameChecked.AutoSize = true;
            this.ServerNameChecked.Checked = true;
            this.ServerNameChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ServerNameChecked.Location = new System.Drawing.Point(7, 151);
            this.ServerNameChecked.Name = "ServerNameChecked";
            this.ServerNameChecked.Size = new System.Drawing.Size(88, 17);
            this.ServerNameChecked.TabIndex = 8;
            this.ServerNameChecked.Text = "Server Name";
            this.ServerNameChecked.UseVisualStyleBackColor = true;
            this.ServerNameChecked.CheckedChanged += new System.EventHandler(this.ServerNameChecked_CheckedChanged);
            // 
            // ServerIpText
            // 
            this.ServerIpText.Location = new System.Drawing.Point(88, 123);
            this.ServerIpText.Name = "ServerIpText";
            this.ServerIpText.Size = new System.Drawing.Size(100, 20);
            this.ServerIpText.TabIndex = 9;
            // 
            // ServerNameText
            // 
            this.ServerNameText.Location = new System.Drawing.Point(101, 149);
            this.ServerNameText.Name = "ServerNameText";
            this.ServerNameText.Size = new System.Drawing.Size(88, 20);
            this.ServerNameText.TabIndex = 10;
            // 
            // KeyText
            // 
            this.KeyText.Location = new System.Drawing.Point(102, 175);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(87, 20);
            this.KeyText.TabIndex = 11;
            // 
            // KeyChecked
            // 
            this.KeyChecked.AutoSize = true;
            this.KeyChecked.Checked = true;
            this.KeyChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KeyChecked.Location = new System.Drawing.Point(7, 176);
            this.KeyChecked.Name = "KeyChecked";
            this.KeyChecked.Size = new System.Drawing.Size(44, 17);
            this.KeyChecked.TabIndex = 12;
            this.KeyChecked.Text = "Key";
            this.KeyChecked.UseVisualStyleBackColor = true;
            this.KeyChecked.CheckedChanged += new System.EventHandler(this.KeyChecked_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.LocalChecked);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TypeCombo);
            this.groupBox3.Controls.Add(this.AuthenChecked);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(221, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 199);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Authentication";
            // 
            // AuthenChecked
            // 
            this.AuthenChecked.AutoSize = true;
            this.AuthenChecked.Checked = true;
            this.AuthenChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AuthenChecked.Location = new System.Drawing.Point(7, 20);
            this.AuthenChecked.Name = "AuthenChecked";
            this.AuthenChecked.Size = new System.Drawing.Size(142, 17);
            this.AuthenChecked.TabIndex = 0;
            this.AuthenChecked.Text = "Configure Authentication";
            this.AuthenChecked.UseVisualStyleBackColor = true;
            // 
            // TypeCombo
            // 
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Items.AddRange(new object[] {
            "serial",
            "enable",
            "telnet",
            "ssh",
            "http"});
            this.TypeCombo.Location = new System.Drawing.Point(114, 40);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(78, 21);
            this.TypeCombo.TabIndex = 1;
            this.TypeCombo.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Authentication Type";
            // 
            // LocalChecked
            // 
            this.LocalChecked.AutoSize = true;
            this.LocalChecked.Checked = true;
            this.LocalChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LocalChecked.Location = new System.Drawing.Point(9, 70);
            this.LocalChecked.Name = "LocalChecked";
            this.LocalChecked.Size = new System.Drawing.Size(74, 17);
            this.LocalChecked.TabIndex = 5;
            this.LocalChecked.Text = "Use Local";
            this.LocalChecked.UseVisualStyleBackColor = true;
            // 
            // ServerGroupChecked
            // 
            this.ServerGroupChecked.AutoSize = true;
            this.ServerGroupChecked.Checked = true;
            this.ServerGroupChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ServerGroupChecked.Location = new System.Drawing.Point(6, 25);
            this.ServerGroupChecked.Name = "ServerGroupChecked";
            this.ServerGroupChecked.Size = new System.Drawing.Size(111, 17);
            this.ServerGroupChecked.TabIndex = 6;
            this.ServerGroupChecked.Text = "Use Server Group";
            this.ServerGroupChecked.UseVisualStyleBackColor = true;
            this.ServerGroupChecked.CheckedChanged += new System.EventHandler(this.ServerGroupChecked_CheckedChanged);
            // 
            // LocalServerGroupChecked
            // 
            this.LocalServerGroupChecked.AutoSize = true;
            this.LocalServerGroupChecked.Checked = true;
            this.LocalServerGroupChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LocalServerGroupChecked.Location = new System.Drawing.Point(6, 72);
            this.LocalServerGroupChecked.Name = "LocalServerGroupChecked";
            this.LocalServerGroupChecked.Size = new System.Drawing.Size(155, 17);
            this.LocalServerGroupChecked.TabIndex = 7;
            this.LocalServerGroupChecked.Text = "Use Local on Server Group";
            this.LocalServerGroupChecked.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.ServerGroupText);
            this.groupBox4.Controls.Add(this.LocalServerGroupChecked);
            this.groupBox4.Controls.Add(this.ServerGroupChecked);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(7, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 96);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Server Group";
            // 
            // ServerGroupText
            // 
            this.ServerGroupText.Location = new System.Drawing.Point(82, 46);
            this.ServerGroupText.Name = "ServerGroupText";
            this.ServerGroupText.Size = new System.Drawing.Size(100, 20);
            this.ServerGroupText.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Server Group";
            // 
            // ASAAAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(451, 410);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ASAAAA";
            this.Text = "ASA AAA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PrivLevelText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.CheckBox PrivLevelChecked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox LocalUserChecked;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TagText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ServerChecked;
        private System.Windows.Forms.TextBox IntNameText;
        private System.Windows.Forms.CheckBox IntChecked;
        private System.Windows.Forms.ComboBox ProtocolCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ServerNameText;
        private System.Windows.Forms.TextBox ServerIpText;
        private System.Windows.Forms.CheckBox ServerNameChecked;
        private System.Windows.Forms.CheckBox ServerIpChecked;
        private System.Windows.Forms.CheckBox KeyChecked;
        private System.Windows.Forms.TextBox KeyText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.CheckBox AuthenChecked;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ServerGroupText;
        private System.Windows.Forms.CheckBox LocalServerGroupChecked;
        private System.Windows.Forms.CheckBox ServerGroupChecked;
        private System.Windows.Forms.CheckBox LocalChecked;
    }
}