namespace Cisco_Tool_Box
{
    partial class MACAddressSecurity
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
            this.InterfaceIDText = new System.Windows.Forms.TextBox();
            this.StaticMacChecked = new System.Windows.Forms.CheckBox();
            this.StaticMacText = new System.Windows.Forms.TextBox();
            this.MaxMACChecked = new System.Windows.Forms.CheckBox();
            this.MaxMACText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DynamicMACChecked = new System.Windows.Forms.CheckBox();
            this.MACAddressChecked = new System.Windows.Forms.CheckBox();
            this.DynamicMACText = new System.Windows.Forms.TextBox();
            this.ViolationModeChecked = new System.Windows.Forms.CheckBox();
            this.ViolationDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy To Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interface ID";
            // 
            // InterfaceIDText
            // 
            this.InterfaceIDText.Location = new System.Drawing.Point(81, 42);
            this.InterfaceIDText.Name = "InterfaceIDText";
            this.InterfaceIDText.Size = new System.Drawing.Size(81, 20);
            this.InterfaceIDText.TabIndex = 2;
            this.InterfaceIDText.TextChanged += new System.EventHandler(this.InterfaceIDText_TextChanged);
            // 
            // StaticMacChecked
            // 
            this.StaticMacChecked.AutoSize = true;
            this.StaticMacChecked.Checked = true;
            this.StaticMacChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StaticMacChecked.Location = new System.Drawing.Point(12, 97);
            this.StaticMacChecked.Name = "StaticMacChecked";
            this.StaticMacChecked.Size = new System.Drawing.Size(53, 17);
            this.StaticMacChecked.TabIndex = 3;
            this.StaticMacChecked.Text = "Static";
            this.StaticMacChecked.UseVisualStyleBackColor = true;
            this.StaticMacChecked.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // StaticMacText
            // 
            this.StaticMacText.Location = new System.Drawing.Point(142, 95);
            this.StaticMacText.Name = "StaticMacText";
            this.StaticMacText.Size = new System.Drawing.Size(100, 20);
            this.StaticMacText.TabIndex = 4;
            this.StaticMacText.TextChanged += new System.EventHandler(this.StaticMacText_TextChanged);
            // 
            // MaxMACChecked
            // 
            this.MaxMACChecked.AutoSize = true;
            this.MaxMACChecked.Checked = true;
            this.MaxMACChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MaxMACChecked.Location = new System.Drawing.Point(12, 71);
            this.MaxMACChecked.Name = "MaxMACChecked";
            this.MaxMACChecked.Size = new System.Drawing.Size(124, 17);
            this.MaxMACChecked.TabIndex = 5;
            this.MaxMACChecked.Text = "Max MAC Addresses";
            this.MaxMACChecked.UseVisualStyleBackColor = true;
            this.MaxMACChecked.CheckedChanged += new System.EventHandler(this.MaxMACChecked_CheckedChanged);
            // 
            // MaxMACText
            // 
            this.MaxMACText.Location = new System.Drawing.Point(249, 69);
            this.MaxMACText.Name = "MaxMACText";
            this.MaxMACText.Size = new System.Drawing.Size(44, 20);
            this.MaxMACText.TabIndex = 6;
            this.MaxMACText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MAC Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max # MAC Address";
            // 
            // DynamicMACChecked
            // 
            this.DynamicMACChecked.AutoSize = true;
            this.DynamicMACChecked.Checked = true;
            this.DynamicMACChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DynamicMACChecked.Location = new System.Drawing.Point(12, 121);
            this.DynamicMACChecked.Name = "DynamicMACChecked";
            this.DynamicMACChecked.Size = new System.Drawing.Size(67, 17);
            this.DynamicMACChecked.TabIndex = 9;
            this.DynamicMACChecked.Text = "Dynamic";
            this.DynamicMACChecked.UseVisualStyleBackColor = true;
            // 
            // MACAddressChecked
            // 
            this.MACAddressChecked.AutoSize = true;
            this.MACAddressChecked.Checked = true;
            this.MACAddressChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MACAddressChecked.Location = new System.Drawing.Point(85, 121);
            this.MACAddressChecked.Name = "MACAddressChecked";
            this.MACAddressChecked.Size = new System.Drawing.Size(96, 17);
            this.MACAddressChecked.TabIndex = 10;
            this.MACAddressChecked.Text = "MAC Address?";
            this.MACAddressChecked.UseVisualStyleBackColor = true;
            this.MACAddressChecked.CheckedChanged += new System.EventHandler(this.MACAddressChecked_CheckedChanged);
            // 
            // DynamicMACText
            // 
            this.DynamicMACText.Location = new System.Drawing.Point(188, 119);
            this.DynamicMACText.Name = "DynamicMACText";
            this.DynamicMACText.Size = new System.Drawing.Size(100, 20);
            this.DynamicMACText.TabIndex = 11;
            // 
            // ViolationModeChecked
            // 
            this.ViolationModeChecked.AutoSize = true;
            this.ViolationModeChecked.Checked = true;
            this.ViolationModeChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ViolationModeChecked.Location = new System.Drawing.Point(12, 147);
            this.ViolationModeChecked.Name = "ViolationModeChecked";
            this.ViolationModeChecked.Size = new System.Drawing.Size(96, 17);
            this.ViolationModeChecked.TabIndex = 12;
            this.ViolationModeChecked.Text = "Violation Mode";
            this.ViolationModeChecked.UseVisualStyleBackColor = true;
            this.ViolationModeChecked.CheckedChanged += new System.EventHandler(this.ViolationModeChecked_CheckedChanged);
            // 
            // ViolationDropDown
            // 
            this.ViolationDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViolationDropDown.FormattingEnabled = true;
            this.ViolationDropDown.Items.AddRange(new object[] {
            "Protect",
            "Restrict",
            "Shutdown "});
            this.ViolationDropDown.Location = new System.Drawing.Point(114, 145);
            this.ViolationDropDown.Name = "ViolationDropDown";
            this.ViolationDropDown.Size = new System.Drawing.Size(121, 21);
            this.ViolationDropDown.TabIndex = 13;
            this.ViolationDropDown.SelectedIndexChanged += new System.EventHandler(this.ViolationDropDown_SelectedIndexChanged);
            // 
            // MACAddressSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(301, 199);
            this.Controls.Add(this.ViolationDropDown);
            this.Controls.Add(this.ViolationModeChecked);
            this.Controls.Add(this.DynamicMACText);
            this.Controls.Add(this.MACAddressChecked);
            this.Controls.Add(this.DynamicMACChecked);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxMACText);
            this.Controls.Add(this.MaxMACChecked);
            this.Controls.Add(this.StaticMacText);
            this.Controls.Add(this.StaticMacChecked);
            this.Controls.Add(this.InterfaceIDText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MACAddressSecurity";
            this.Text = "MAC Address Security";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InterfaceIDText;
        private System.Windows.Forms.CheckBox StaticMacChecked;
        private System.Windows.Forms.TextBox StaticMacText;
        private System.Windows.Forms.CheckBox MaxMACChecked;
        private System.Windows.Forms.TextBox MaxMACText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox DynamicMACChecked;
        private System.Windows.Forms.CheckBox MACAddressChecked;
        private System.Windows.Forms.TextBox DynamicMACText;
        private System.Windows.Forms.CheckBox ViolationModeChecked;
        private System.Windows.Forms.ComboBox ViolationDropDown;
    }
}