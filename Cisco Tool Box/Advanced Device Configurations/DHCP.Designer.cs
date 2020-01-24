namespace Cisco_Tool_Box
{
    partial class DHCP
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
            this.NumExcludedIP = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NetworkSubnetChecked = new System.Windows.Forms.CheckBox();
            this.ShouldUseIP = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubnetMaskAbbriev = new System.Windows.Forms.ComboBox();
            this.DefaultRouterAddressText = new System.Windows.Forms.TextBox();
            this.NetworkSubnetText = new System.Windows.Forms.TextBox();
            this.NetworkAddressText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PoolNameText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LeaseInfiniteChecked = new System.Windows.Forms.CheckBox();
            this.NetBIOSAddressText = new System.Windows.Forms.TextBox();
            this.LeaseHoursText = new System.Windows.Forms.TextBox();
            this.LeaseMinutesText = new System.Windows.Forms.TextBox();
            this.LeaseDaysText = new System.Windows.Forms.TextBox();
            this.DomainNameText = new System.Windows.Forms.TextBox();
            this.DNSServerAddressText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NetBIOSChecked = new System.Windows.Forms.CheckBox();
            this.LeaseChecked = new System.Windows.Forms.CheckBox();
            this.DomainNameChecked = new System.Windows.Forms.CheckBox();
            this.DNSServerChecked = new System.Windows.Forms.CheckBox();
            this.BoxPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.NumExcludedIP)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "# of excluded IP Addresses";
            // 
            // NumExcludedIP
            // 
            this.NumExcludedIP.Location = new System.Drawing.Point(153, 311);
            this.NumExcludedIP.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumExcludedIP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumExcludedIP.Name = "NumExcludedIP";
            this.NumExcludedIP.Size = new System.Drawing.Size(36, 20);
            this.NumExcludedIP.TabIndex = 2;
            this.NumExcludedIP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumExcludedIP.ValueChanged += new System.EventHandler(this.NumExcludedIP_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NetworkSubnetChecked);
            this.groupBox1.Controls.Add(this.ShouldUseIP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SubnetMaskAbbriev);
            this.groupBox1.Controls.Add(this.DefaultRouterAddressText);
            this.groupBox1.Controls.Add(this.NetworkSubnetText);
            this.groupBox1.Controls.Add(this.NetworkAddressText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(15, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 98);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Required Tasks";
            // 
            // NetworkSubnetChecked
            // 
            this.NetworkSubnetChecked.AutoSize = true;
            this.NetworkSubnetChecked.Location = new System.Drawing.Point(206, 19);
            this.NetworkSubnetChecked.Name = "NetworkSubnetChecked";
            this.NetworkSubnetChecked.Size = new System.Drawing.Size(131, 17);
            this.NetworkSubnetChecked.TabIndex = 6;
            this.NetworkSubnetChecked.Text = "Use Network Subnet?";
            this.NetworkSubnetChecked.UseVisualStyleBackColor = true;
            // 
            // ShouldUseIP
            // 
            this.ShouldUseIP.AutoSize = true;
            this.ShouldUseIP.Location = new System.Drawing.Point(182, 43);
            this.ShouldUseIP.Name = "ShouldUseIP";
            this.ShouldUseIP.Size = new System.Drawing.Size(124, 17);
            this.ShouldUseIP.TabIndex = 5;
            this.ShouldUseIP.Text = "SubnetMaskAddress";
            this.ShouldUseIP.UseVisualStyleBackColor = true;
            this.ShouldUseIP.CheckedChanged += new System.EventHandler(this.ShouldUseIP_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Network Subnet Mask";
            // 
            // SubnetMaskAbbriev
            // 
            this.SubnetMaskAbbriev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubnetMaskAbbriev.FormattingEnabled = true;
            this.SubnetMaskAbbriev.Location = new System.Drawing.Point(128, 40);
            this.SubnetMaskAbbriev.Name = "SubnetMaskAbbriev";
            this.SubnetMaskAbbriev.Size = new System.Drawing.Size(45, 21);
            this.SubnetMaskAbbriev.TabIndex = 4;
            this.SubnetMaskAbbriev.SelectedIndexChanged += new System.EventHandler(this.SubnetMaskAbbriev_SelectedIndexChanged);
            // 
            // DefaultRouterAddressText
            // 
            this.DefaultRouterAddressText.Location = new System.Drawing.Point(179, 66);
            this.DefaultRouterAddressText.Name = "DefaultRouterAddressText";
            this.DefaultRouterAddressText.Size = new System.Drawing.Size(100, 20);
            this.DefaultRouterAddressText.TabIndex = 1;
            // 
            // NetworkSubnetText
            // 
            this.NetworkSubnetText.Enabled = false;
            this.NetworkSubnetText.Location = new System.Drawing.Point(312, 43);
            this.NetworkSubnetText.Name = "NetworkSubnetText";
            this.NetworkSubnetText.Size = new System.Drawing.Size(100, 20);
            this.NetworkSubnetText.TabIndex = 1;
            this.NetworkSubnetText.TextChanged += new System.EventHandler(this.NetworkSubnetText_TextChanged);
            // 
            // NetworkAddressText
            // 
            this.NetworkAddressText.Location = new System.Drawing.Point(97, 15);
            this.NetworkAddressText.Name = "NetworkAddressText";
            this.NetworkAddressText.Size = new System.Drawing.Size(100, 20);
            this.NetworkAddressText.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Default Router | Gateway Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Network Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DHCP Pool Name";
            // 
            // PoolNameText
            // 
            this.PoolNameText.Location = new System.Drawing.Point(112, 43);
            this.PoolNameText.Name = "PoolNameText";
            this.PoolNameText.Size = new System.Drawing.Size(100, 20);
            this.PoolNameText.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.LeaseInfiniteChecked);
            this.groupBox2.Controls.Add(this.NetBIOSAddressText);
            this.groupBox2.Controls.Add(this.LeaseHoursText);
            this.groupBox2.Controls.Add(this.LeaseMinutesText);
            this.groupBox2.Controls.Add(this.LeaseDaysText);
            this.groupBox2.Controls.Add(this.DomainNameText);
            this.groupBox2.Controls.Add(this.DNSServerAddressText);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.NetBIOSChecked);
            this.groupBox2.Controls.Add(this.LeaseChecked);
            this.groupBox2.Controls.Add(this.DomainNameChecked);
            this.groupBox2.Controls.Add(this.DNSServerChecked);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(13, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 134);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Optional Tasks";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Hours";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Minutes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Days";
            // 
            // LeaseInfiniteChecked
            // 
            this.LeaseInfiniteChecked.AutoSize = true;
            this.LeaseInfiniteChecked.Location = new System.Drawing.Point(130, 72);
            this.LeaseInfiniteChecked.Name = "LeaseInfiniteChecked";
            this.LeaseInfiniteChecked.Size = new System.Drawing.Size(57, 17);
            this.LeaseInfiniteChecked.TabIndex = 4;
            this.LeaseInfiniteChecked.Text = "Infinite";
            this.LeaseInfiniteChecked.UseVisualStyleBackColor = true;
            // 
            // NetBIOSAddressText
            // 
            this.NetBIOSAddressText.Location = new System.Drawing.Point(242, 96);
            this.NetBIOSAddressText.Name = "NetBIOSAddressText";
            this.NetBIOSAddressText.Size = new System.Drawing.Size(100, 20);
            this.NetBIOSAddressText.TabIndex = 3;
            // 
            // LeaseHoursText
            // 
            this.LeaseHoursText.Location = new System.Drawing.Point(301, 69);
            this.LeaseHoursText.Name = "LeaseHoursText";
            this.LeaseHoursText.Size = new System.Drawing.Size(30, 20);
            this.LeaseHoursText.TabIndex = 3;
            // 
            // LeaseMinutesText
            // 
            this.LeaseMinutesText.Location = new System.Drawing.Point(384, 69);
            this.LeaseMinutesText.Name = "LeaseMinutesText";
            this.LeaseMinutesText.Size = new System.Drawing.Size(30, 20);
            this.LeaseMinutesText.TabIndex = 3;
            this.LeaseMinutesText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LeaseDaysText
            // 
            this.LeaseDaysText.Location = new System.Drawing.Point(225, 69);
            this.LeaseDaysText.Name = "LeaseDaysText";
            this.LeaseDaysText.Size = new System.Drawing.Size(30, 20);
            this.LeaseDaysText.TabIndex = 3;
            this.LeaseDaysText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // DomainNameText
            // 
            this.DomainNameText.Location = new System.Drawing.Point(242, 43);
            this.DomainNameText.Name = "DomainNameText";
            this.DomainNameText.Size = new System.Drawing.Size(100, 20);
            this.DomainNameText.TabIndex = 3;
            // 
            // DNSServerAddressText
            // 
            this.DNSServerAddressText.Location = new System.Drawing.Point(242, 17);
            this.DNSServerAddressText.Name = "DNSServerAddressText";
            this.DNSServerAddressText.Size = new System.Drawing.Size(100, 20);
            this.DNSServerAddressText.TabIndex = 3;
            this.DNSServerAddressText.TextChanged += new System.EventHandler(this.DNSServerAddressText_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "NetBIOS Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Domain Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "DNS Server Address";
            // 
            // NetBIOSChecked
            // 
            this.NetBIOSChecked.AutoSize = true;
            this.NetBIOSChecked.Location = new System.Drawing.Point(6, 98);
            this.NetBIOSChecked.Name = "NetBIOSChecked";
            this.NetBIOSChecked.Size = new System.Drawing.Size(134, 17);
            this.NetBIOSChecked.TabIndex = 0;
            this.NetBIOSChecked.Text = "NetBIOS WINS Server";
            this.NetBIOSChecked.UseVisualStyleBackColor = true;
            this.NetBIOSChecked.CheckedChanged += new System.EventHandler(this.NetBIOSChecked_CheckedChanged);
            // 
            // LeaseChecked
            // 
            this.LeaseChecked.AutoSize = true;
            this.LeaseChecked.Location = new System.Drawing.Point(6, 72);
            this.LeaseChecked.Name = "LeaseChecked";
            this.LeaseChecked.Size = new System.Drawing.Size(110, 17);
            this.LeaseChecked.TabIndex = 0;
            this.LeaseChecked.Text = "Duration of Lease";
            this.LeaseChecked.UseVisualStyleBackColor = true;
            this.LeaseChecked.CheckedChanged += new System.EventHandler(this.LeaseChecked_CheckedChanged);
            // 
            // DomainNameChecked
            // 
            this.DomainNameChecked.AutoSize = true;
            this.DomainNameChecked.Checked = true;
            this.DomainNameChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DomainNameChecked.Location = new System.Drawing.Point(6, 46);
            this.DomainNameChecked.Name = "DomainNameChecked";
            this.DomainNameChecked.Size = new System.Drawing.Size(93, 17);
            this.DomainNameChecked.TabIndex = 0;
            this.DomainNameChecked.Text = "Domain Name";
            this.DomainNameChecked.UseVisualStyleBackColor = true;
            this.DomainNameChecked.CheckedChanged += new System.EventHandler(this.DomainNameChecked_CheckedChanged);
            // 
            // DNSServerChecked
            // 
            this.DNSServerChecked.AutoSize = true;
            this.DNSServerChecked.Checked = true;
            this.DNSServerChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DNSServerChecked.Location = new System.Drawing.Point(6, 20);
            this.DNSServerChecked.Name = "DNSServerChecked";
            this.DNSServerChecked.Size = new System.Drawing.Size(83, 17);
            this.DNSServerChecked.TabIndex = 0;
            this.DNSServerChecked.Text = "DNS Server";
            this.DNSServerChecked.UseVisualStyleBackColor = true;
            this.DNSServerChecked.CheckedChanged += new System.EventHandler(this.DNSServerChecked_CheckedChanged);
            // 
            // BoxPanel
            // 
            this.BoxPanel.AutoSize = true;
            this.BoxPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BoxPanel.Location = new System.Drawing.Point(12, 337);
            this.BoxPanel.Name = "BoxPanel";
            this.BoxPanel.Size = new System.Drawing.Size(0, 0);
            this.BoxPanel.TabIndex = 7;
            // 
            // DHCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(525, 348);
            this.Controls.Add(this.BoxPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PoolNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NumExcludedIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "DHCP";
            this.Text = "DHCP";
            ((System.ComponentModel.ISupportInitialize)(this.NumExcludedIP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumExcludedIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NetworkAddressText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PoolNameText;
        private System.Windows.Forms.TextBox DefaultRouterAddressText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NetworkSubnetText;
        private System.Windows.Forms.ComboBox SubnetMaskAbbriev;
        private System.Windows.Forms.CheckBox ShouldUseIP;
        private System.Windows.Forms.CheckBox NetworkSubnetChecked;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox NetBIOSChecked;
        private System.Windows.Forms.CheckBox LeaseChecked;
        private System.Windows.Forms.CheckBox DomainNameChecked;
        private System.Windows.Forms.CheckBox DNSServerChecked;
        private System.Windows.Forms.TextBox NetBIOSAddressText;
        private System.Windows.Forms.TextBox LeaseMinutesText;
        private System.Windows.Forms.TextBox LeaseDaysText;
        private System.Windows.Forms.TextBox DomainNameText;
        private System.Windows.Forms.TextBox DNSServerAddressText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LeaseHoursText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox LeaseInfiniteChecked;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel BoxPanel;
    }
}