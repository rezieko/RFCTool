namespace Cisco_Tool_Box
{
    partial class ASAInterfaces
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
            this.IntText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IntNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SecLvText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IpAddText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShouldUseIP = new System.Windows.Forms.CheckBox();
            this.SubnetMaskAbbriev = new System.Windows.Forms.ComboBox();
            this.SubnetMaskText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AssignIntDescText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.VlanText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AssignIntText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IntDescText = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interface ID";
            // 
            // IntText
            // 
            this.IntText.Location = new System.Drawing.Point(82, 42);
            this.IntText.Name = "IntText";
            this.IntText.Size = new System.Drawing.Size(100, 20);
            this.IntText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interface Name";
            // 
            // IntNameText
            // 
            this.IntNameText.Location = new System.Drawing.Point(99, 95);
            this.IntNameText.Name = "IntNameText";
            this.IntNameText.Size = new System.Drawing.Size(100, 20);
            this.IntNameText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Security Level";
            // 
            // SecLvText
            // 
            this.SecLvText.Location = new System.Drawing.Point(99, 122);
            this.SecLvText.Name = "SecLvText";
            this.SecLvText.Size = new System.Drawing.Size(100, 20);
            this.SecLvText.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IpAddText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ShouldUseIP);
            this.groupBox1.Controls.Add(this.SubnetMaskAbbriev);
            this.groupBox1.Controls.Add(this.SubnetMaskText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(15, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 71);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IPv4 Address";
            // 
            // IpAddText
            // 
            this.IpAddText.Location = new System.Drawing.Point(70, 17);
            this.IpAddText.Name = "IpAddText";
            this.IpAddText.Size = new System.Drawing.Size(100, 20);
            this.IpAddText.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP Address";
            // 
            // ShouldUseIP
            // 
            this.ShouldUseIP.AutoSize = true;
            this.ShouldUseIP.Location = new System.Drawing.Point(142, 42);
            this.ShouldUseIP.Name = "ShouldUseIP";
            this.ShouldUseIP.Size = new System.Drawing.Size(99, 17);
            this.ShouldUseIP.TabIndex = 5;
            this.ShouldUseIP.Text = "Use IP Address";
            this.ShouldUseIP.UseVisualStyleBackColor = true;
            this.ShouldUseIP.CheckedChanged += new System.EventHandler(this.ShouldUseIP_CheckedChanged);
            // 
            // SubnetMaskAbbriev
            // 
            this.SubnetMaskAbbriev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubnetMaskAbbriev.FormattingEnabled = true;
            this.SubnetMaskAbbriev.Location = new System.Drawing.Point(91, 40);
            this.SubnetMaskAbbriev.Name = "SubnetMaskAbbriev";
            this.SubnetMaskAbbriev.Size = new System.Drawing.Size(45, 21);
            this.SubnetMaskAbbriev.TabIndex = 4;
            this.SubnetMaskAbbriev.SelectedIndexChanged += new System.EventHandler(this.SubnetMaskAbbriev_SelectedIndexChanged);
            // 
            // SubnetMaskText
            // 
            this.SubnetMaskText.Location = new System.Drawing.Point(246, 40);
            this.SubnetMaskText.Name = "SubnetMaskText";
            this.SubnetMaskText.Size = new System.Drawing.Size(100, 20);
            this.SubnetMaskText.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Subnet Mask";
            this.label5.Click += new System.EventHandler(this.Interface_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AssignIntDescText);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.VlanText);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.AssignIntText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(15, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 71);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assign Layer 2 Interfaces to VLAN";
            // 
            // AssignIntDescText
            // 
            this.AssignIntDescText.Location = new System.Drawing.Point(76, 43);
            this.AssignIntDescText.Name = "AssignIntDescText";
            this.AssignIntDescText.Size = new System.Drawing.Size(100, 20);
            this.AssignIntDescText.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Description";
            // 
            // VlanText
            // 
            this.VlanText.Location = new System.Drawing.Point(223, 17);
            this.VlanText.Name = "VlanText";
            this.VlanText.Size = new System.Drawing.Size(100, 20);
            this.VlanText.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "VLAN";
            // 
            // AssignIntText
            // 
            this.AssignIntText.Location = new System.Drawing.Point(76, 17);
            this.AssignIntText.Name = "AssignIntText";
            this.AssignIntText.Size = new System.Drawing.Size(100, 20);
            this.AssignIntText.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Interface ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Description";
            // 
            // IntDescText
            // 
            this.IntDescText.Location = new System.Drawing.Point(82, 69);
            this.IntDescText.Name = "IntDescText";
            this.IntDescText.Size = new System.Drawing.Size(100, 20);
            this.IntDescText.TabIndex = 10;
            // 
            // ASAInterfaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(378, 307);
            this.Controls.Add(this.IntDescText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SecLvText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IntNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IntText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ASAInterfaces";
            this.Text = "ASAInterfaces";
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
        private System.Windows.Forms.TextBox IntText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IntNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SecLvText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IpAddText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ShouldUseIP;
        private System.Windows.Forms.ComboBox SubnetMaskAbbriev;
        private System.Windows.Forms.TextBox SubnetMaskText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox VlanText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AssignIntText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AssignIntDescText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IntDescText;
    }
}