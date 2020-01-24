namespace Cisco_Tool_Box
{
    partial class RIPProtocol
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
            this.VersionChecked = new System.Windows.Forms.CheckBox();
            this.IPAddressText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassiveIntCheck = new System.Windows.Forms.CheckBox();
            this.InterfaceText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DefaultCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy To Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VersionChecked
            // 
            this.VersionChecked.AutoSize = true;
            this.VersionChecked.Checked = true;
            this.VersionChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VersionChecked.Location = new System.Drawing.Point(13, 43);
            this.VersionChecked.Name = "VersionChecked";
            this.VersionChecked.Size = new System.Drawing.Size(70, 17);
            this.VersionChecked.TabIndex = 1;
            this.VersionChecked.Text = "Version 2";
            this.VersionChecked.UseVisualStyleBackColor = true;
            this.VersionChecked.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // IPAddressText
            // 
            this.IPAddressText.Location = new System.Drawing.Point(76, 63);
            this.IPAddressText.Name = "IPAddressText";
            this.IPAddressText.Size = new System.Drawing.Size(100, 20);
            this.IPAddressText.TabIndex = 2;
            this.IPAddressText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PassiveIntCheck
            // 
            this.PassiveIntCheck.AutoSize = true;
            this.PassiveIntCheck.Checked = true;
            this.PassiveIntCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PassiveIntCheck.Location = new System.Drawing.Point(13, 91);
            this.PassiveIntCheck.Name = "PassiveIntCheck";
            this.PassiveIntCheck.Size = new System.Drawing.Size(108, 17);
            this.PassiveIntCheck.TabIndex = 4;
            this.PassiveIntCheck.Text = "Passive Interface";
            this.PassiveIntCheck.UseVisualStyleBackColor = true;
            this.PassiveIntCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // InterfaceText
            // 
            this.InterfaceText.Location = new System.Drawing.Point(201, 88);
            this.InterfaceText.Name = "InterfaceText";
            this.InterfaceText.Size = new System.Drawing.Size(100, 20);
            this.InterfaceText.TabIndex = 5;
            this.InterfaceText.TextChanged += new System.EventHandler(this.InterfaceText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Interface";
            // 
            // DefaultCheck
            // 
            this.DefaultCheck.AutoSize = true;
            this.DefaultCheck.Checked = true;
            this.DefaultCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultCheck.Location = new System.Drawing.Point(12, 114);
            this.DefaultCheck.Name = "DefaultCheck";
            this.DefaultCheck.Size = new System.Drawing.Size(160, 17);
            this.DefaultCheck.TabIndex = 7;
            this.DefaultCheck.Text = "Default Information Originate";
            this.DefaultCheck.UseVisualStyleBackColor = true;
            this.DefaultCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_2);
            // 
            // RIPProtocol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(316, 144);
            this.Controls.Add(this.DefaultCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InterfaceText);
            this.Controls.Add(this.PassiveIntCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPAddressText);
            this.Controls.Add(this.VersionChecked);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RIPProtocol";
            this.Text = "RIP Protocol";
            this.Load += new System.EventHandler(this.RIPProtocol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox VersionChecked;
        private System.Windows.Forms.TextBox IPAddressText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox PassiveIntCheck;
        private System.Windows.Forms.TextBox InterfaceText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox DefaultCheck;
    }
}