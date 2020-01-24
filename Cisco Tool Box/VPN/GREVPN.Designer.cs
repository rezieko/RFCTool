namespace Cisco_Tool_Box
{
    partial class GREVPN
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
            this.SubnetMaskText = new System.Windows.Forms.TextBox();
            this.ShouldUseIP = new System.Windows.Forms.CheckBox();
            this.IPAddText = new System.Windows.Forms.TextBox();
            this.SubnetMaskAbbriev = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SourceIpText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DestIpText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.SubnetMaskText);
            this.groupBox1.Controls.Add(this.ShouldUseIP);
            this.groupBox1.Controls.Add(this.IPAddText);
            this.groupBox1.Controls.Add(this.SubnetMaskAbbriev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Address";
            // 
            // SubnetMaskText
            // 
            this.SubnetMaskText.Location = new System.Drawing.Point(229, 38);
            this.SubnetMaskText.Name = "SubnetMaskText";
            this.SubnetMaskText.Size = new System.Drawing.Size(100, 20);
            this.SubnetMaskText.TabIndex = 5;
            // 
            // ShouldUseIP
            // 
            this.ShouldUseIP.AutoSize = true;
            this.ShouldUseIP.Location = new System.Drawing.Point(124, 40);
            this.ShouldUseIP.Name = "ShouldUseIP";
            this.ShouldUseIP.Size = new System.Drawing.Size(99, 17);
            this.ShouldUseIP.TabIndex = 4;
            this.ShouldUseIP.Text = "Use IP Address";
            this.ShouldUseIP.UseVisualStyleBackColor = true;
            this.ShouldUseIP.CheckedChanged += new System.EventHandler(this.ShouldUseIP_CheckedChanged);
            // 
            // IPAddText
            // 
            this.IPAddText.Location = new System.Drawing.Point(71, 13);
            this.IPAddText.Name = "IPAddText";
            this.IPAddText.Size = new System.Drawing.Size(100, 20);
            this.IPAddText.TabIndex = 2;
            // 
            // SubnetMaskAbbriev
            // 
            this.SubnetMaskAbbriev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubnetMaskAbbriev.FormattingEnabled = true;
            this.SubnetMaskAbbriev.Location = new System.Drawing.Point(83, 38);
            this.SubnetMaskAbbriev.Name = "SubnetMaskAbbriev";
            this.SubnetMaskAbbriev.Size = new System.Drawing.Size(35, 21);
            this.SubnetMaskAbbriev.TabIndex = 4;
            this.SubnetMaskAbbriev.SelectedIndexChanged += new System.EventHandler(this.SubnetMaskAbbriev_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subnet Mask";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tunnel Source IP ";
            // 
            // SourceIpText
            // 
            this.SourceIpText.Location = new System.Drawing.Point(122, 113);
            this.SourceIpText.Name = "SourceIpText";
            this.SourceIpText.Size = new System.Drawing.Size(100, 20);
            this.SourceIpText.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tunnel Destination IP";
            // 
            // DestIpText
            // 
            this.DestIpText.Location = new System.Drawing.Point(136, 139);
            this.DestIpText.Name = "DestIpText";
            this.DestIpText.Size = new System.Drawing.Size(100, 20);
            this.DestIpText.TabIndex = 5;
            // 
            // GREVPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(360, 166);
            this.Controls.Add(this.DestIpText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SourceIpText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GREVPN";
            this.Text = "GRE VPN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPAddText;
        private System.Windows.Forms.CheckBox ShouldUseIP;
        private System.Windows.Forms.TextBox SubnetMaskText;
        private System.Windows.Forms.ComboBox SubnetMaskAbbriev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SourceIpText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DestIpText;
    }
}