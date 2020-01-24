namespace Cisco_Tool_Box
{
    partial class Objects
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
            this.NetworkChecked = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NetworkNameText = new System.Windows.Forms.TextBox();
            this.HostIpChecked = new System.Windows.Forms.CheckBox();
            this.HostIpText = new System.Windows.Forms.TextBox();
            this.SubnetChecked = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubnetNetAddText = new System.Windows.Forms.TextBox();
            this.SubnetNetMaskText = new System.Windows.Forms.TextBox();
            this.RangeChecked = new System.Windows.Forms.CheckBox();
            this.Add1Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LastAddText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServiceChecked = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ServiceNameText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProtocolCombo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SourceChecked = new System.Windows.Forms.CheckBox();
            this.SourceOpPortChecked = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SourcePortText = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DestChecked = new System.Windows.Forms.CheckBox();
            this.DestOpPortChecked = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DestPortText = new System.Windows.Forms.TextBox();
            this.IcmpChecked = new System.Windows.Forms.CheckBox();
            this.Icmp6Checked = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.IcmpText = new System.Windows.Forms.TextBox();
            this.Icmp6Text = new System.Windows.Forms.TextBox();
            this.DestOpCombo = new System.Windows.Forms.ComboBox();
            this.SourceOpCombo = new System.Windows.Forms.ComboBox();
            this.ProtocolChecked = new System.Windows.Forms.CheckBox();
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
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LastAddText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Add1Text);
            this.groupBox1.Controls.Add(this.RangeChecked);
            this.groupBox1.Controls.Add(this.SubnetNetMaskText);
            this.groupBox1.Controls.Add(this.SubnetNetAddText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SubnetChecked);
            this.groupBox1.Controls.Add(this.HostIpText);
            this.groupBox1.Controls.Add(this.HostIpChecked);
            this.groupBox1.Controls.Add(this.NetworkNameText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NetworkChecked);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network";
            // 
            // NetworkChecked
            // 
            this.NetworkChecked.AutoSize = true;
            this.NetworkChecked.Checked = true;
            this.NetworkChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NetworkChecked.Location = new System.Drawing.Point(7, 20);
            this.NetworkChecked.Name = "NetworkChecked";
            this.NetworkChecked.Size = new System.Drawing.Size(153, 17);
            this.NetworkChecked.TabIndex = 0;
            this.NetworkChecked.Text = "Configure Network Objects";
            this.NetworkChecked.UseVisualStyleBackColor = true;
            this.NetworkChecked.CheckedChanged += new System.EventHandler(this.NetworkChecked_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // NetworkNameText
            // 
            this.NetworkNameText.Location = new System.Drawing.Point(88, 43);
            this.NetworkNameText.Name = "NetworkNameText";
            this.NetworkNameText.Size = new System.Drawing.Size(100, 20);
            this.NetworkNameText.TabIndex = 2;
            // 
            // HostIpChecked
            // 
            this.HostIpChecked.AutoSize = true;
            this.HostIpChecked.Checked = true;
            this.HostIpChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HostIpChecked.Location = new System.Drawing.Point(7, 71);
            this.HostIpChecked.Name = "HostIpChecked";
            this.HostIpChecked.Size = new System.Drawing.Size(61, 17);
            this.HostIpChecked.TabIndex = 3;
            this.HostIpChecked.Text = "Host IP";
            this.HostIpChecked.UseVisualStyleBackColor = true;
            this.HostIpChecked.CheckedChanged += new System.EventHandler(this.HostIpChecked_CheckedChanged);
            // 
            // HostIpText
            // 
            this.HostIpText.Location = new System.Drawing.Point(88, 69);
            this.HostIpText.Name = "HostIpText";
            this.HostIpText.Size = new System.Drawing.Size(100, 20);
            this.HostIpText.TabIndex = 4;
            // 
            // SubnetChecked
            // 
            this.SubnetChecked.AutoSize = true;
            this.SubnetChecked.Checked = true;
            this.SubnetChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SubnetChecked.Location = new System.Drawing.Point(7, 94);
            this.SubnetChecked.Name = "SubnetChecked";
            this.SubnetChecked.Size = new System.Drawing.Size(60, 17);
            this.SubnetChecked.TabIndex = 5;
            this.SubnetChecked.Text = "Subnet";
            this.SubnetChecked.UseVisualStyleBackColor = true;
            this.SubnetChecked.CheckedChanged += new System.EventHandler(this.SubnetChecked_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Network Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Network  Mask";
            // 
            // SubnetNetAddText
            // 
            this.SubnetNetAddText.Location = new System.Drawing.Point(98, 114);
            this.SubnetNetAddText.Name = "SubnetNetAddText";
            this.SubnetNetAddText.Size = new System.Drawing.Size(100, 20);
            this.SubnetNetAddText.TabIndex = 8;
            // 
            // SubnetNetMaskText
            // 
            this.SubnetNetMaskText.Location = new System.Drawing.Point(98, 141);
            this.SubnetNetMaskText.Name = "SubnetNetMaskText";
            this.SubnetNetMaskText.Size = new System.Drawing.Size(100, 20);
            this.SubnetNetMaskText.TabIndex = 9;
            // 
            // RangeChecked
            // 
            this.RangeChecked.AutoSize = true;
            this.RangeChecked.Checked = true;
            this.RangeChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RangeChecked.Location = new System.Drawing.Point(6, 171);
            this.RangeChecked.Name = "RangeChecked";
            this.RangeChecked.Size = new System.Drawing.Size(58, 17);
            this.RangeChecked.TabIndex = 10;
            this.RangeChecked.Text = "Range";
            this.RangeChecked.UseVisualStyleBackColor = true;
            this.RangeChecked.CheckedChanged += new System.EventHandler(this.RangeChecked_CheckedChanged);
            // 
            // Add1Text
            // 
            this.Add1Text.Location = new System.Drawing.Point(88, 191);
            this.Add1Text.Name = "Add1Text";
            this.Add1Text.Size = new System.Drawing.Size(100, 20);
            this.Add1Text.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "1st Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Last Address";
            // 
            // LastAddText
            // 
            this.LastAddText.Location = new System.Drawing.Point(88, 217);
            this.LastAddText.Name = "LastAddText";
            this.LastAddText.Size = new System.Drawing.Size(100, 20);
            this.LastAddText.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProtocolChecked);
            this.groupBox2.Controls.Add(this.Icmp6Text);
            this.groupBox2.Controls.Add(this.IcmpText);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Icmp6Checked);
            this.groupBox2.Controls.Add(this.IcmpChecked);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.ProtocolCombo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ServiceNameText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ServiceChecked);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(229, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 277);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Service";
            // 
            // ServiceChecked
            // 
            this.ServiceChecked.AutoSize = true;
            this.ServiceChecked.Checked = true;
            this.ServiceChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ServiceChecked.Location = new System.Drawing.Point(7, 20);
            this.ServiceChecked.Name = "ServiceChecked";
            this.ServiceChecked.Size = new System.Drawing.Size(149, 17);
            this.ServiceChecked.TabIndex = 0;
            this.ServiceChecked.Text = "Configure Service Objects";
            this.ServiceChecked.UseVisualStyleBackColor = true;
            this.ServiceChecked.CheckedChanged += new System.EventHandler(this.ServiceChecked_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Name";
            // 
            // ServiceNameText
            // 
            this.ServiceNameText.Location = new System.Drawing.Point(56, 43);
            this.ServiceNameText.Name = "ServiceNameText";
            this.ServiceNameText.Size = new System.Drawing.Size(100, 20);
            this.ServiceNameText.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Protocol";
            // 
            // ProtocolCombo
            // 
            this.ProtocolCombo.FormattingEnabled = true;
            this.ProtocolCombo.Items.AddRange(new object[] {
            "tcp",
            "udp"});
            this.ProtocolCombo.Location = new System.Drawing.Point(148, 69);
            this.ProtocolCombo.Name = "ProtocolCombo";
            this.ProtocolCombo.Size = new System.Drawing.Size(100, 21);
            this.ProtocolCombo.TabIndex = 4;
            this.ProtocolCombo.Text = "Protocol";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SourceOpCombo);
            this.groupBox3.Controls.Add(this.SourcePortText);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.SourceOpPortChecked);
            this.groupBox3.Controls.Add(this.SourceChecked);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(7, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 117);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Source";
            // 
            // SourceChecked
            // 
            this.SourceChecked.AutoSize = true;
            this.SourceChecked.Checked = true;
            this.SourceChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SourceChecked.Location = new System.Drawing.Point(7, 18);
            this.SourceChecked.Name = "SourceChecked";
            this.SourceChecked.Size = new System.Drawing.Size(82, 17);
            this.SourceChecked.TabIndex = 0;
            this.SourceChecked.Text = "Use Source";
            this.SourceChecked.UseVisualStyleBackColor = true;
            // 
            // SourceOpPortChecked
            // 
            this.SourceOpPortChecked.AutoSize = true;
            this.SourceOpPortChecked.Checked = true;
            this.SourceOpPortChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SourceOpPortChecked.Location = new System.Drawing.Point(6, 41);
            this.SourceOpPortChecked.Name = "SourceOpPortChecked";
            this.SourceOpPortChecked.Size = new System.Drawing.Size(132, 17);
            this.SourceOpPortChecked.TabIndex = 1;
            this.SourceOpPortChecked.Text = "Use Operator and Port";
            this.SourceOpPortChecked.UseVisualStyleBackColor = true;
            this.SourceOpPortChecked.CheckedChanged += new System.EventHandler(this.SourceOpPortChecked_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Operator";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Port";
            // 
            // SourcePortText
            // 
            this.SourcePortText.Location = new System.Drawing.Point(75, 87);
            this.SourcePortText.Name = "SourcePortText";
            this.SourcePortText.Size = new System.Drawing.Size(100, 20);
            this.SourcePortText.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DestOpCombo);
            this.groupBox4.Controls.Add(this.DestPortText);
            this.groupBox4.Controls.Add(this.DestOpPortChecked);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.DestChecked);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(199, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 117);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Destination";
            // 
            // DestChecked
            // 
            this.DestChecked.AutoSize = true;
            this.DestChecked.Checked = true;
            this.DestChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DestChecked.Location = new System.Drawing.Point(7, 18);
            this.DestChecked.Name = "DestChecked";
            this.DestChecked.Size = new System.Drawing.Size(101, 17);
            this.DestChecked.TabIndex = 0;
            this.DestChecked.Text = "Use Destination";
            this.DestChecked.UseVisualStyleBackColor = true;
            // 
            // DestOpPortChecked
            // 
            this.DestOpPortChecked.AutoSize = true;
            this.DestOpPortChecked.Checked = true;
            this.DestOpPortChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DestOpPortChecked.Location = new System.Drawing.Point(7, 41);
            this.DestOpPortChecked.Name = "DestOpPortChecked";
            this.DestOpPortChecked.Size = new System.Drawing.Size(132, 17);
            this.DestOpPortChecked.TabIndex = 1;
            this.DestOpPortChecked.Text = "Use Operator and Port";
            this.DestOpPortChecked.UseVisualStyleBackColor = true;
            this.DestOpPortChecked.CheckedChanged += new System.EventHandler(this.DestOpPortChecked_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Operator";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Port";
            // 
            // DestPortText
            // 
            this.DestPortText.Location = new System.Drawing.Point(76, 87);
            this.DestPortText.Name = "DestPortText";
            this.DestPortText.Size = new System.Drawing.Size(100, 20);
            this.DestPortText.TabIndex = 5;
            // 
            // IcmpChecked
            // 
            this.IcmpChecked.AutoSize = true;
            this.IcmpChecked.Checked = true;
            this.IcmpChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IcmpChecked.Location = new System.Drawing.Point(6, 219);
            this.IcmpChecked.Name = "IcmpChecked";
            this.IcmpChecked.Size = new System.Drawing.Size(55, 17);
            this.IcmpChecked.TabIndex = 7;
            this.IcmpChecked.Text = "ICMP ";
            this.IcmpChecked.UseVisualStyleBackColor = true;
            this.IcmpChecked.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // Icmp6Checked
            // 
            this.Icmp6Checked.AutoSize = true;
            this.Icmp6Checked.Checked = true;
            this.Icmp6Checked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Icmp6Checked.Location = new System.Drawing.Point(6, 245);
            this.Icmp6Checked.Name = "Icmp6Checked";
            this.Icmp6Checked.Size = new System.Drawing.Size(58, 17);
            this.Icmp6Checked.TabIndex = 8;
            this.Icmp6Checked.Text = "ICMP6";
            this.Icmp6Checked.UseVisualStyleBackColor = true;
            this.Icmp6Checked.CheckedChanged += new System.EventHandler(this.Icmp6Checked_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "ICMP Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(67, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "ICMP6 Type";
            // 
            // IcmpText
            // 
            this.IcmpText.Location = new System.Drawing.Point(148, 217);
            this.IcmpText.Name = "IcmpText";
            this.IcmpText.Size = new System.Drawing.Size(100, 20);
            this.IcmpText.TabIndex = 11;
            // 
            // Icmp6Text
            // 
            this.Icmp6Text.Location = new System.Drawing.Point(148, 243);
            this.Icmp6Text.Name = "Icmp6Text";
            this.Icmp6Text.Size = new System.Drawing.Size(100, 20);
            this.Icmp6Text.TabIndex = 12;
            // 
            // DestOpCombo
            // 
            this.DestOpCombo.FormattingEnabled = true;
            this.DestOpCombo.Items.AddRange(new object[] {
            "eq",
            "neq",
            "lt",
            "gt",
            "range"});
            this.DestOpCombo.Location = new System.Drawing.Point(76, 61);
            this.DestOpCombo.Name = "DestOpCombo";
            this.DestOpCombo.Size = new System.Drawing.Size(100, 21);
            this.DestOpCombo.TabIndex = 6;
            // 
            // SourceOpCombo
            // 
            this.SourceOpCombo.FormattingEnabled = true;
            this.SourceOpCombo.Items.AddRange(new object[] {
            "eq",
            "neq",
            "lt",
            "gt",
            "range"});
            this.SourceOpCombo.Location = new System.Drawing.Point(75, 61);
            this.SourceOpCombo.Name = "SourceOpCombo";
            this.SourceOpCombo.Size = new System.Drawing.Size(100, 21);
            this.SourceOpCombo.TabIndex = 6;
            // 
            // ProtocolChecked
            // 
            this.ProtocolChecked.AutoSize = true;
            this.ProtocolChecked.Checked = true;
            this.ProtocolChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProtocolChecked.Location = new System.Drawing.Point(7, 71);
            this.ProtocolChecked.Name = "ProtocolChecked";
            this.ProtocolChecked.Size = new System.Drawing.Size(87, 17);
            this.ProtocolChecked.TabIndex = 13;
            this.ProtocolChecked.Text = "Use Protocol";
            this.ProtocolChecked.UseVisualStyleBackColor = true;
            // 
            // Objects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(650, 327);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Objects";
            this.Text = "Objects";
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
        private System.Windows.Forms.CheckBox NetworkChecked;
        private System.Windows.Forms.TextBox NetworkNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubnetNetMaskText;
        private System.Windows.Forms.TextBox SubnetNetAddText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox SubnetChecked;
        private System.Windows.Forms.TextBox HostIpText;
        private System.Windows.Forms.CheckBox HostIpChecked;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Add1Text;
        private System.Windows.Forms.CheckBox RangeChecked;
        private System.Windows.Forms.TextBox LastAddText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ServiceChecked;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox DestPortText;
        private System.Windows.Forms.CheckBox DestOpPortChecked;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox DestChecked;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox SourcePortText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox SourceOpPortChecked;
        private System.Windows.Forms.CheckBox SourceChecked;
        private System.Windows.Forms.ComboBox ProtocolCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ServiceNameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox IcmpChecked;
        private System.Windows.Forms.TextBox Icmp6Text;
        private System.Windows.Forms.TextBox IcmpText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox Icmp6Checked;
        private System.Windows.Forms.ComboBox DestOpCombo;
        private System.Windows.Forms.ComboBox SourceOpCombo;
        private System.Windows.Forms.CheckBox ProtocolChecked;
    }
}