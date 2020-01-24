namespace Cisco_Tool_Box
{
    partial class ISAKMPPara
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
            this.PriorityIdText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptionCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HashCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AuthenticationCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GroupIdNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.LifetimeText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PresharedChecked = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.KeyStringsText = new System.Windows.Forms.TextBox();
            this.HostnameChecked = new System.Windows.Forms.CheckBox();
            this.PeerChecked = new System.Windows.Forms.CheckBox();
            this.HostnameText = new System.Windows.Forms.TextBox();
            this.PeerText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupIdNum)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Priority #";
            // 
            // PriorityIdText
            // 
            this.PriorityIdText.Location = new System.Drawing.Point(68, 173);
            this.PriorityIdText.Name = "PriorityIdText";
            this.PriorityIdText.Size = new System.Drawing.Size(100, 20);
            this.PriorityIdText.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LifetimeText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.GroupIdNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AuthenticationCombo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.HashCombo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EncryptionCombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Encryption Type";
            // 
            // EncryptionCombo
            // 
            this.EncryptionCombo.FormattingEnabled = true;
            this.EncryptionCombo.Items.AddRange(new object[] {
            "des",
            "3des",
            "aes",
            "aes 192",
            "aes 256"});
            this.EncryptionCombo.Location = new System.Drawing.Point(97, 16);
            this.EncryptionCombo.Name = "EncryptionCombo";
            this.EncryptionCombo.Size = new System.Drawing.Size(84, 21);
            this.EncryptionCombo.TabIndex = 1;
            this.EncryptionCombo.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hash Type";
            // 
            // HashCombo
            // 
            this.HashCombo.FormattingEnabled = true;
            this.HashCombo.Items.AddRange(new object[] {
            "sha",
            "md5"});
            this.HashCombo.Location = new System.Drawing.Point(97, 46);
            this.HashCombo.Name = "HashCombo";
            this.HashCombo.Size = new System.Drawing.Size(84, 21);
            this.HashCombo.TabIndex = 3;
            this.HashCombo.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Authentication Type";
            // 
            // AuthenticationCombo
            // 
            this.AuthenticationCombo.FormattingEnabled = true;
            this.AuthenticationCombo.Items.AddRange(new object[] {
            "pre-shared",
            "rsa-encr",
            "rsa-slg"});
            this.AuthenticationCombo.Location = new System.Drawing.Point(114, 73);
            this.AuthenticationCombo.Name = "AuthenticationCombo";
            this.AuthenticationCombo.Size = new System.Drawing.Size(90, 21);
            this.AuthenticationCombo.TabIndex = 5;
            this.AuthenticationCombo.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Group ID";
            // 
            // GroupIdNum
            // 
            this.GroupIdNum.Location = new System.Drawing.Point(97, 100);
            this.GroupIdNum.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.GroupIdNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GroupIdNum.Name = "GroupIdNum";
            this.GroupIdNum.Size = new System.Drawing.Size(35, 20);
            this.GroupIdNum.TabIndex = 7;
            this.GroupIdNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lifetime ";
            // 
            // LifetimeText
            // 
            this.LifetimeText.Location = new System.Drawing.Point(97, 128);
            this.LifetimeText.Name = "LifetimeText";
            this.LifetimeText.Size = new System.Drawing.Size(84, 20);
            this.LifetimeText.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PeerText);
            this.groupBox2.Controls.Add(this.HostnameText);
            this.groupBox2.Controls.Add(this.PeerChecked);
            this.groupBox2.Controls.Add(this.HostnameChecked);
            this.groupBox2.Controls.Add(this.KeyStringsText);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.PresharedChecked);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 125);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pre-shared Keys";
            // 
            // PresharedChecked
            // 
            this.PresharedChecked.AutoSize = true;
            this.PresharedChecked.Location = new System.Drawing.Point(12, 20);
            this.PresharedChecked.Name = "PresharedChecked";
            this.PresharedChecked.Size = new System.Drawing.Size(229, 17);
            this.PresharedChecked.TabIndex = 0;
            this.PresharedChecked.Text = "Enable if Authentication Type is Pre-shared";
            this.PresharedChecked.UseVisualStyleBackColor = true;
            this.PresharedChecked.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Key-Strings";
            // 
            // KeyStringsText
            // 
            this.KeyStringsText.Location = new System.Drawing.Point(81, 41);
            this.KeyStringsText.Name = "KeyStringsText";
            this.KeyStringsText.Size = new System.Drawing.Size(100, 20);
            this.KeyStringsText.TabIndex = 2;
            // 
            // HostnameChecked
            // 
            this.HostnameChecked.AutoSize = true;
            this.HostnameChecked.Location = new System.Drawing.Point(12, 69);
            this.HostnameChecked.Name = "HostnameChecked";
            this.HostnameChecked.Size = new System.Drawing.Size(96, 17);
            this.HostnameChecked.TabIndex = 3;
            this.HostnameChecked.Text = "Use Hostname";
            this.HostnameChecked.UseVisualStyleBackColor = true;
            this.HostnameChecked.CheckedChanged += new System.EventHandler(this.HostnameChecked_CheckedChanged);
            // 
            // PeerChecked
            // 
            this.PeerChecked.AutoSize = true;
            this.PeerChecked.Location = new System.Drawing.Point(12, 95);
            this.PeerChecked.Name = "PeerChecked";
            this.PeerChecked.Size = new System.Drawing.Size(111, 17);
            this.PeerChecked.TabIndex = 4;
            this.PeerChecked.Text = "Use Peer Address";
            this.PeerChecked.UseVisualStyleBackColor = true;
            this.PeerChecked.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // HostnameText
            // 
            this.HostnameText.Location = new System.Drawing.Point(114, 67);
            this.HostnameText.Name = "HostnameText";
            this.HostnameText.Size = new System.Drawing.Size(100, 20);
            this.HostnameText.TabIndex = 5;
            // 
            // PeerText
            // 
            this.PeerText.Location = new System.Drawing.Point(129, 93);
            this.PeerText.Name = "PeerText";
            this.PeerText.Size = new System.Drawing.Size(100, 20);
            this.PeerText.TabIndex = 6;
            // 
            // ISAKMPPara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(267, 369);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PriorityIdText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ISAKMPPara";
            this.Text = "ISAKMP Parameters";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupIdNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PriorityIdText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LifetimeText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown GroupIdNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AuthenticationCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox HashCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EncryptionCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox PresharedChecked;
        private System.Windows.Forms.TextBox PeerText;
        private System.Windows.Forms.TextBox HostnameText;
        private System.Windows.Forms.CheckBox PeerChecked;
        private System.Windows.Forms.CheckBox HostnameChecked;
        private System.Windows.Forms.TextBox KeyStringsText;
        private System.Windows.Forms.Label label7;
    }
}