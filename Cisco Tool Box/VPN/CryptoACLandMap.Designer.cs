namespace Cisco_Tool_Box
{
    partial class CryptoACLandMap
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
            this.KilobyteText = new System.Windows.Forms.TextBox();
            this.SecsText = new System.Windows.Forms.TextBox();
            this.KilobytesChecked = new System.Windows.Forms.CheckBox();
            this.SecondsChecked = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DynMapNameText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DynamicChecked = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IsakmpChecked = new System.Windows.Forms.CheckBox();
            this.ManualChecked = new System.Windows.Forms.CheckBox();
            this.TransformText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PfsGroupCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IpAddText = new System.Windows.Forms.TextBox();
            this.HostnameText = new System.Windows.Forms.TextBox();
            this.IpAddChecked = new System.Windows.Forms.CheckBox();
            this.HostnameChecked = new System.Windows.Forms.CheckBox();
            this.MatchAclText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SeqNumText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MapNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumAcls = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.BoxPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAcls)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KilobyteText);
            this.groupBox1.Controls.Add(this.SecsText);
            this.groupBox1.Controls.Add(this.KilobytesChecked);
            this.groupBox1.Controls.Add(this.SecondsChecked);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.TransformText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PfsGroupCombo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.MatchAclText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SeqNumText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MapNameText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crypto Maps";
            // 
            // KilobyteText
            // 
            this.KilobyteText.Location = new System.Drawing.Point(176, 220);
            this.KilobyteText.Name = "KilobyteText";
            this.KilobyteText.Size = new System.Drawing.Size(100, 20);
            this.KilobyteText.TabIndex = 16;
            // 
            // SecsText
            // 
            this.SecsText.Location = new System.Drawing.Point(176, 194);
            this.SecsText.Name = "SecsText";
            this.SecsText.Size = new System.Drawing.Size(100, 20);
            this.SecsText.TabIndex = 16;
            // 
            // KilobytesChecked
            // 
            this.KilobytesChecked.AutoSize = true;
            this.KilobytesChecked.Location = new System.Drawing.Point(102, 222);
            this.KilobytesChecked.Name = "KilobytesChecked";
            this.KilobytesChecked.Size = new System.Drawing.Size(68, 17);
            this.KilobytesChecked.TabIndex = 15;
            this.KilobytesChecked.Text = "Kilobytes";
            this.KilobytesChecked.UseVisualStyleBackColor = true;
            this.KilobytesChecked.CheckedChanged += new System.EventHandler(this.KilobytesChecked_CheckedChanged);
            // 
            // SecondsChecked
            // 
            this.SecondsChecked.AutoSize = true;
            this.SecondsChecked.Location = new System.Drawing.Point(102, 196);
            this.SecondsChecked.Name = "SecondsChecked";
            this.SecondsChecked.Size = new System.Drawing.Size(68, 17);
            this.SecondsChecked.TabIndex = 14;
            this.SecondsChecked.Text = "Seconds";
            this.SecondsChecked.UseVisualStyleBackColor = true;
            this.SecondsChecked.CheckedChanged += new System.EventHandler(this.SecondsChecked_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Set SA Lifetime";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DynMapNameText);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.DynamicChecked);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(10, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 85);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dynamic (Can Only Be Used when ISAKMP is chosen)";
            // 
            // DynMapNameText
            // 
            this.DynMapNameText.Location = new System.Drawing.Point(114, 56);
            this.DynMapNameText.Name = "DynMapNameText";
            this.DynMapNameText.Size = new System.Drawing.Size(80, 20);
            this.DynMapNameText.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Dynamic Map Name";
            // 
            // DynamicChecked
            // 
            this.DynamicChecked.AutoSize = true;
            this.DynamicChecked.Location = new System.Drawing.Point(7, 35);
            this.DynamicChecked.Name = "DynamicChecked";
            this.DynamicChecked.Size = new System.Drawing.Size(113, 17);
            this.DynamicChecked.TabIndex = 0;
            this.DynamicChecked.Text = "Use Dynamic Map";
            this.DynamicChecked.UseVisualStyleBackColor = true;
            this.DynamicChecked.CheckedChanged += new System.EventHandler(this.DynamicChecked_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.IsakmpChecked);
            this.groupBox3.Controls.Add(this.ManualChecked);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(10, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 67);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Establishment of IPSec SA";
            // 
            // IsakmpChecked
            // 
            this.IsakmpChecked.AutoSize = true;
            this.IsakmpChecked.Location = new System.Drawing.Point(7, 44);
            this.IsakmpChecked.Name = "IsakmpChecked";
            this.IsakmpChecked.Size = new System.Drawing.Size(66, 17);
            this.IsakmpChecked.TabIndex = 1;
            this.IsakmpChecked.Text = "ISAKMP";
            this.IsakmpChecked.UseVisualStyleBackColor = true;
            // 
            // ManualChecked
            // 
            this.ManualChecked.AutoSize = true;
            this.ManualChecked.Location = new System.Drawing.Point(7, 20);
            this.ManualChecked.Name = "ManualChecked";
            this.ManualChecked.Size = new System.Drawing.Size(61, 17);
            this.ManualChecked.TabIndex = 0;
            this.ManualChecked.Text = "Manual";
            this.ManualChecked.UseVisualStyleBackColor = true;
            this.ManualChecked.CheckedChanged += new System.EventHandler(this.ManualChecked_CheckedChanged);
            // 
            // TransformText
            // 
            this.TransformText.Location = new System.Drawing.Point(310, 170);
            this.TransformText.Name = "TransformText";
            this.TransformText.Size = new System.Drawing.Size(100, 20);
            this.TransformText.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Transform Set";
            // 
            // PfsGroupCombo
            // 
            this.PfsGroupCombo.FormattingEnabled = true;
            this.PfsGroupCombo.Items.AddRange(new object[] {
            "group1",
            "group2"});
            this.PfsGroupCombo.Location = new System.Drawing.Point(295, 142);
            this.PfsGroupCombo.Name = "PfsGroupCombo";
            this.PfsGroupCombo.Size = new System.Drawing.Size(77, 21);
            this.PfsGroupCombo.TabIndex = 8;
            this.PfsGroupCombo.Text = "Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PFS Group";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IpAddText);
            this.groupBox2.Controls.Add(this.HostnameText);
            this.groupBox2.Controls.Add(this.IpAddChecked);
            this.groupBox2.Controls.Add(this.HostnameChecked);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(233, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 74);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Peer";
            // 
            // IpAddText
            // 
            this.IpAddText.Location = new System.Drawing.Point(87, 44);
            this.IpAddText.Name = "IpAddText";
            this.IpAddText.Size = new System.Drawing.Size(100, 20);
            this.IpAddText.TabIndex = 3;
            // 
            // HostnameText
            // 
            this.HostnameText.Location = new System.Drawing.Point(87, 19);
            this.HostnameText.Name = "HostnameText";
            this.HostnameText.Size = new System.Drawing.Size(100, 20);
            this.HostnameText.TabIndex = 2;
            // 
            // IpAddChecked
            // 
            this.IpAddChecked.AutoSize = true;
            this.IpAddChecked.Location = new System.Drawing.Point(7, 46);
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
            this.HostnameChecked.Location = new System.Drawing.Point(7, 20);
            this.HostnameChecked.Name = "HostnameChecked";
            this.HostnameChecked.Size = new System.Drawing.Size(74, 17);
            this.HostnameChecked.TabIndex = 0;
            this.HostnameChecked.Text = "Hostname";
            this.HostnameChecked.UseVisualStyleBackColor = true;
            this.HostnameChecked.CheckedChanged += new System.EventHandler(this.HostnameChecked_CheckedChanged);
            // 
            // MatchAclText
            // 
            this.MatchAclText.Location = new System.Drawing.Point(367, 43);
            this.MatchAclText.Name = "MatchAclText";
            this.MatchAclText.Size = new System.Drawing.Size(76, 20);
            this.MatchAclText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Matched ACL ID/Number";
            // 
            // SeqNumText
            // 
            this.SeqNumText.Location = new System.Drawing.Point(332, 17);
            this.SeqNumText.Name = "SeqNumText";
            this.SeqNumText.Size = new System.Drawing.Size(63, 20);
            this.SeqNumText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sequence Number";
            // 
            // MapNameText
            // 
            this.MapNameText.Location = new System.Drawing.Point(72, 17);
            this.MapNameText.Name = "MapNameText";
            this.MapNameText.Size = new System.Drawing.Size(100, 20);
            this.MapNameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Map Name";
            // 
            // NumAcls
            // 
            this.NumAcls.Location = new System.Drawing.Point(74, 297);
            this.NumAcls.Name = "NumAcls";
            this.NumAcls.Size = new System.Drawing.Size(35, 20);
            this.NumAcls.TabIndex = 2;
            this.NumAcls.ValueChanged += new System.EventHandler(this.NumAcls_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "#of ACLs";
            // 
            // BoxPanel
            // 
            this.BoxPanel.AutoSize = true;
            this.BoxPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BoxPanel.Location = new System.Drawing.Point(13, 323);
            this.BoxPanel.Name = "BoxPanel";
            this.BoxPanel.Size = new System.Drawing.Size(0, 0);
            this.BoxPanel.TabIndex = 4;
            // 
            // CryptoACLandMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(473, 325);
            this.Controls.Add(this.BoxPanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumAcls);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "CryptoACLandMap";
            this.Text = "Crypto ACL and Map";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAcls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MapNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PfsGroupCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IpAddText;
        private System.Windows.Forms.TextBox HostnameText;
        private System.Windows.Forms.CheckBox IpAddChecked;
        private System.Windows.Forms.CheckBox HostnameChecked;
        private System.Windows.Forms.TextBox MatchAclText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SeqNumText;
        private System.Windows.Forms.TextBox TransformText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox DynMapNameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox DynamicChecked;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox IsakmpChecked;
        private System.Windows.Forms.CheckBox ManualChecked;
        private System.Windows.Forms.TextBox KilobyteText;
        private System.Windows.Forms.TextBox SecsText;
        private System.Windows.Forms.CheckBox KilobytesChecked;
        private System.Windows.Forms.CheckBox SecondsChecked;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NumAcls;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel BoxPanel;
    }
}