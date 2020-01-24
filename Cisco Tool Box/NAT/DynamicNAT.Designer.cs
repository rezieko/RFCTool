namespace Cisco_Tool_Box
{
    partial class DynamicNAT
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
            this.label3 = new System.Windows.Forms.Label();
            this.NumInterfaces = new System.Windows.Forms.NumericUpDown();
            this.InterfacesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.PoolNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartAddrText = new System.Windows.Forms.TextBox();
            this.EndAddrText = new System.Windows.Forms.TextBox();
            this.NetmaskChecked = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NetmaskText = new System.Windows.Forms.TextBox();
            this.PrefixChecked = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PrefixText = new System.Windows.Forms.TextBox();
            this.OverloadChecked = new System.Windows.Forms.CheckBox();
            this.SingleGlobalChecked = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SingleIntText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WildcardText = new System.Windows.Forms.TextBox();
            this.SourceText = new System.Windows.Forms.TextBox();
            this.ACLNumberText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumInterfaces)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "# of Interfaces";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // NumInterfaces
            // 
            this.NumInterfaces.Location = new System.Drawing.Point(94, 282);
            this.NumInterfaces.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumInterfaces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumInterfaces.Name = "NumInterfaces";
            this.NumInterfaces.Size = new System.Drawing.Size(34, 20);
            this.NumInterfaces.TabIndex = 2;
            this.NumInterfaces.TabStop = false;
            this.NumInterfaces.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumInterfaces.ValueChanged += new System.EventHandler(this.NumInterfaces_ValueChanged);
            // 
            // InterfacesPanel
            // 
            this.InterfacesPanel.AutoSize = true;
            this.InterfacesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InterfacesPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.InterfacesPanel.Location = new System.Drawing.Point(12, 308);
            this.InterfacesPanel.Name = "InterfacesPanel";
            this.InterfacesPanel.Size = new System.Drawing.Size(0, 0);
            this.InterfacesPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pool Name";
            // 
            // PoolNameText
            // 
            this.PoolNameText.Location = new System.Drawing.Point(77, 41);
            this.PoolNameText.Name = "PoolNameText";
            this.PoolNameText.Size = new System.Drawing.Size(100, 20);
            this.PoolNameText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start IP Address";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "End IP Address";
            this.label4.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // StartAddrText
            // 
            this.StartAddrText.Location = new System.Drawing.Point(94, 67);
            this.StartAddrText.Name = "StartAddrText";
            this.StartAddrText.Size = new System.Drawing.Size(100, 20);
            this.StartAddrText.TabIndex = 7;
            // 
            // EndAddrText
            // 
            this.EndAddrText.Location = new System.Drawing.Point(94, 93);
            this.EndAddrText.Name = "EndAddrText";
            this.EndAddrText.Size = new System.Drawing.Size(100, 20);
            this.EndAddrText.TabIndex = 7;
            // 
            // NetmaskChecked
            // 
            this.NetmaskChecked.AutoSize = true;
            this.NetmaskChecked.Location = new System.Drawing.Point(12, 122);
            this.NetmaskChecked.Name = "NetmaskChecked";
            this.NetmaskChecked.Size = new System.Drawing.Size(68, 17);
            this.NetmaskChecked.TabIndex = 8;
            this.NetmaskChecked.Text = "Netmask";
            this.NetmaskChecked.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Netmask ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // NetmaskText
            // 
            this.NetmaskText.Location = new System.Drawing.Point(144, 119);
            this.NetmaskText.Name = "NetmaskText";
            this.NetmaskText.Size = new System.Drawing.Size(100, 20);
            this.NetmaskText.TabIndex = 10;
            // 
            // PrefixChecked
            // 
            this.PrefixChecked.AutoSize = true;
            this.PrefixChecked.Location = new System.Drawing.Point(12, 147);
            this.PrefixChecked.Name = "PrefixChecked";
            this.PrefixChecked.Size = new System.Drawing.Size(88, 17);
            this.PrefixChecked.TabIndex = 11;
            this.PrefixChecked.Text = "Prefix Length";
            this.PrefixChecked.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Prefix Length";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // PrefixText
            // 
            this.PrefixText.Location = new System.Drawing.Point(178, 145);
            this.PrefixText.Name = "PrefixText";
            this.PrefixText.Size = new System.Drawing.Size(100, 20);
            this.PrefixText.TabIndex = 10;
            // 
            // OverloadChecked
            // 
            this.OverloadChecked.AutoSize = true;
            this.OverloadChecked.Location = new System.Drawing.Point(357, 43);
            this.OverloadChecked.Name = "OverloadChecked";
            this.OverloadChecked.Size = new System.Drawing.Size(69, 17);
            this.OverloadChecked.TabIndex = 12;
            this.OverloadChecked.Text = "Overload";
            this.OverloadChecked.UseVisualStyleBackColor = true;
            this.OverloadChecked.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SingleGlobalChecked
            // 
            this.SingleGlobalChecked.AutoSize = true;
            this.SingleGlobalChecked.Checked = true;
            this.SingleGlobalChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SingleGlobalChecked.Location = new System.Drawing.Point(357, 66);
            this.SingleGlobalChecked.Name = "SingleGlobalChecked";
            this.SingleGlobalChecked.Size = new System.Drawing.Size(129, 17);
            this.SingleGlobalChecked.TabIndex = 12;
            this.SingleGlobalChecked.Text = "Single Global Address";
            this.SingleGlobalChecked.UseVisualStyleBackColor = true;
            this.SingleGlobalChecked.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Single Interface ID";
            // 
            // SingleIntText
            // 
            this.SingleIntText.Location = new System.Drawing.Point(357, 103);
            this.SingleIntText.Name = "SingleIntText";
            this.SingleIntText.Size = new System.Drawing.Size(100, 20);
            this.SingleIntText.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "ACL Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Source";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Source Wildcard";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WildcardText);
            this.groupBox1.Controls.Add(this.SourceText);
            this.groupBox1.Controls.Add(this.ACLNumberText);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(15, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 105);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACL";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // WildcardText
            // 
            this.WildcardText.Location = new System.Drawing.Point(101, 71);
            this.WildcardText.Name = "WildcardText";
            this.WildcardText.Size = new System.Drawing.Size(100, 20);
            this.WildcardText.TabIndex = 18;
            // 
            // SourceText
            // 
            this.SourceText.Location = new System.Drawing.Point(80, 45);
            this.SourceText.Name = "SourceText";
            this.SourceText.Size = new System.Drawing.Size(100, 20);
            this.SourceText.TabIndex = 17;
            // 
            // ACLNumberText
            // 
            this.ACLNumberText.Location = new System.Drawing.Point(80, 19);
            this.ACLNumberText.Name = "ACLNumberText";
            this.ACLNumberText.Size = new System.Drawing.Size(100, 20);
            this.ACLNumberText.TabIndex = 16;
            // 
            // DynamicNAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(498, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SingleIntText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SingleGlobalChecked);
            this.Controls.Add(this.OverloadChecked);
            this.Controls.Add(this.PrefixChecked);
            this.Controls.Add(this.PrefixText);
            this.Controls.Add(this.NetmaskText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NetmaskChecked);
            this.Controls.Add(this.EndAddrText);
            this.Controls.Add(this.StartAddrText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PoolNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InterfacesPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumInterfaces);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "DynamicNAT";
            this.Text = "Dynamic NAT";
            this.Load += new System.EventHandler(this.DynamicNAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumInterfaces)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumInterfaces;
        private System.Windows.Forms.FlowLayoutPanel InterfacesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PoolNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StartAddrText;
        private System.Windows.Forms.TextBox EndAddrText;
        private System.Windows.Forms.CheckBox NetmaskChecked;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NetmaskText;
        private System.Windows.Forms.CheckBox PrefixChecked;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PrefixText;
        private System.Windows.Forms.CheckBox OverloadChecked;
        private System.Windows.Forms.CheckBox SingleGlobalChecked;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SingleIntText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox WildcardText;
        private System.Windows.Forms.TextBox SourceText;
        private System.Windows.Forms.TextBox ACLNumberText;
    }
}