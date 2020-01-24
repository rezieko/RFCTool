namespace Cisco_Tool_Box
{
    partial class IPv4ConfigForm
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
            this.InterfaceText = new System.Windows.Forms.TextBox();
            this.Interface = new System.Windows.Forms.Label();
            this.IPAddressText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubnetMaskAbbriev = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ShouldUseIP = new System.Windows.Forms.CheckBox();
            this.SubnetMaskText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Copy To Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InterfaceText
            // 
            this.InterfaceText.Location = new System.Drawing.Point(97, 56);
            this.InterfaceText.Name = "InterfaceText";
            this.InterfaceText.Size = new System.Drawing.Size(100, 20);
            this.InterfaceText.TabIndex = 2;
            this.InterfaceText.TextChanged += new System.EventHandler(this.InterfaceText_TextChanged);
            // 
            // Interface
            // 
            this.Interface.AutoSize = true;
            this.Interface.Location = new System.Drawing.Point(12, 55);
            this.Interface.Name = "Interface";
            this.Interface.Size = new System.Drawing.Size(49, 13);
            this.Interface.TabIndex = 3;
            this.Interface.Text = "Interface";
            this.Interface.Click += new System.EventHandler(this.Interface_Click);
            // 
            // IPAddressText
            // 
            this.IPAddressText.Location = new System.Drawing.Point(97, 82);
            this.IPAddressText.Name = "IPAddressText";
            this.IPAddressText.Size = new System.Drawing.Size(100, 20);
            this.IPAddressText.TabIndex = 2;
            this.IPAddressText.TextChanged += new System.EventHandler(this.IPAddressText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address";
            this.label1.Click += new System.EventHandler(this.Interface_Click);
            // 
            // SubnetMaskAbbriev
            // 
            this.SubnetMaskAbbriev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubnetMaskAbbriev.FormattingEnabled = true;
            this.SubnetMaskAbbriev.Location = new System.Drawing.Point(97, 108);
            this.SubnetMaskAbbriev.Name = "SubnetMaskAbbriev";
            this.SubnetMaskAbbriev.Size = new System.Drawing.Size(45, 21);
            this.SubnetMaskAbbriev.TabIndex = 4;
            this.SubnetMaskAbbriev.SelectedIndexChanged += new System.EventHandler(this.SubnetMaskAbbriev_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subnet Mask";
            this.label2.Click += new System.EventHandler(this.Interface_Click);
            // 
            // ShouldUseIP
            // 
            this.ShouldUseIP.AutoSize = true;
            this.ShouldUseIP.Location = new System.Drawing.Point(148, 110);
            this.ShouldUseIP.Name = "ShouldUseIP";
            this.ShouldUseIP.Size = new System.Drawing.Size(99, 17);
            this.ShouldUseIP.TabIndex = 5;
            this.ShouldUseIP.Text = "Use IP Address";
            this.ShouldUseIP.UseVisualStyleBackColor = true;
            this.ShouldUseIP.CheckedChanged += new System.EventHandler(this.ShouldUseIP_CheckedChanged);
            // 
            // SubnetMaskText
            // 
            this.SubnetMaskText.Enabled = false;
            this.SubnetMaskText.Location = new System.Drawing.Point(244, 108);
            this.SubnetMaskText.Name = "SubnetMaskText";
            this.SubnetMaskText.Size = new System.Drawing.Size(100, 20);
            this.SubnetMaskText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // DescText
            // 
            this.DescText.Location = new System.Drawing.Point(97, 134);
            this.DescText.Name = "DescText";
            this.DescText.Size = new System.Drawing.Size(100, 20);
            this.DescText.TabIndex = 7;
            this.DescText.TextChanged += new System.EventHandler(this.DescText_TextChanged);
            // 
            // IPv4ConfigForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(351, 164);
            this.Controls.Add(this.DescText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShouldUseIP);
            this.Controls.Add(this.SubnetMaskAbbriev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Interface);
            this.Controls.Add(this.SubnetMaskText);
            this.Controls.Add(this.IPAddressText);
            this.Controls.Add(this.InterfaceText);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IPv4ConfigForm";
            this.Text = "IPv4 Address Config ";
            this.Load += new System.EventHandler(this.IPv4ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InterfaceText;
        private System.Windows.Forms.Label Interface;
        private System.Windows.Forms.TextBox IPAddressText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SubnetMaskAbbriev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ShouldUseIP;
        private System.Windows.Forms.TextBox SubnetMaskText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescText;
    }
}

