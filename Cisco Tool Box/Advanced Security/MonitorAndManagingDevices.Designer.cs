namespace Cisco_Tool_Box
{
    partial class MonitorAndManagingDevices
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
            this.SecureBootImageChecked = new System.Windows.Forms.CheckBox();
            this.SecureBootConfigChecked = new System.Windows.Forms.CheckBox();
            this.DisablePassRecoveryChecked = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HostnameChecked = new System.Windows.Forms.CheckBox();
            this.IPAddChecked = new System.Windows.Forms.CheckBox();
            this.HostnameText = new System.Windows.Forms.TextBox();
            this.IPAddText = new System.Windows.Forms.TextBox();
            this.LoggingTrapChecked = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrapLevelNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceIntIDText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrapLevelNum)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SecureBootConfigChecked);
            this.groupBox1.Controls.Add(this.SecureBootImageChecked);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enabling the IOS Image Resilience Feature";
            // 
            // SecureBootImageChecked
            // 
            this.SecureBootImageChecked.AutoSize = true;
            this.SecureBootImageChecked.Checked = true;
            this.SecureBootImageChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SecureBootImageChecked.Location = new System.Drawing.Point(7, 20);
            this.SecureBootImageChecked.Name = "SecureBootImageChecked";
            this.SecureBootImageChecked.Size = new System.Drawing.Size(117, 17);
            this.SecureBootImageChecked.TabIndex = 0;
            this.SecureBootImageChecked.Text = "Secure Boot Image";
            this.SecureBootImageChecked.UseVisualStyleBackColor = true;
            // 
            // SecureBootConfigChecked
            // 
            this.SecureBootConfigChecked.AutoSize = true;
            this.SecureBootConfigChecked.Checked = true;
            this.SecureBootConfigChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SecureBootConfigChecked.Location = new System.Drawing.Point(7, 44);
            this.SecureBootConfigChecked.Name = "SecureBootConfigChecked";
            this.SecureBootConfigChecked.Size = new System.Drawing.Size(118, 17);
            this.SecureBootConfigChecked.TabIndex = 1;
            this.SecureBootConfigChecked.Text = "Secure Boot Config";
            this.SecureBootConfigChecked.UseVisualStyleBackColor = true;
            // 
            // DisablePassRecoveryChecked
            // 
            this.DisablePassRecoveryChecked.AutoSize = true;
            this.DisablePassRecoveryChecked.Checked = true;
            this.DisablePassRecoveryChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisablePassRecoveryChecked.Location = new System.Drawing.Point(20, 120);
            this.DisablePassRecoveryChecked.Name = "DisablePassRecoveryChecked";
            this.DisablePassRecoveryChecked.Size = new System.Drawing.Size(159, 17);
            this.DisablePassRecoveryChecked.TabIndex = 2;
            this.DisablePassRecoveryChecked.Text = "Disable Password Recovery";
            this.DisablePassRecoveryChecked.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SourceIntIDText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TrapLevelNum);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LoggingTrapChecked);
            this.groupBox2.Controls.Add(this.IPAddText);
            this.groupBox2.Controls.Add(this.HostnameText);
            this.groupBox2.Controls.Add(this.IPAddChecked);
            this.groupBox2.Controls.Add(this.HostnameChecked);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(13, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 149);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Logging";
            // 
            // HostnameChecked
            // 
            this.HostnameChecked.AutoSize = true;
            this.HostnameChecked.Checked = true;
            this.HostnameChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HostnameChecked.Location = new System.Drawing.Point(7, 19);
            this.HostnameChecked.Name = "HostnameChecked";
            this.HostnameChecked.Size = new System.Drawing.Size(74, 17);
            this.HostnameChecked.TabIndex = 0;
            this.HostnameChecked.Text = "Hostname";
            this.HostnameChecked.UseVisualStyleBackColor = true;
            this.HostnameChecked.CheckedChanged += new System.EventHandler(this.HostnameChecked_CheckedChanged);
            // 
            // IPAddChecked
            // 
            this.IPAddChecked.AutoSize = true;
            this.IPAddChecked.Checked = true;
            this.IPAddChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IPAddChecked.Location = new System.Drawing.Point(7, 45);
            this.IPAddChecked.Name = "IPAddChecked";
            this.IPAddChecked.Size = new System.Drawing.Size(77, 17);
            this.IPAddChecked.TabIndex = 0;
            this.IPAddChecked.Text = "IP Address";
            this.IPAddChecked.UseVisualStyleBackColor = true;
            this.IPAddChecked.CheckedChanged += new System.EventHandler(this.IPAddChecked_CheckedChanged);
            // 
            // HostnameText
            // 
            this.HostnameText.Location = new System.Drawing.Point(87, 17);
            this.HostnameText.Name = "HostnameText";
            this.HostnameText.Size = new System.Drawing.Size(100, 20);
            this.HostnameText.TabIndex = 1;
            // 
            // IPAddText
            // 
            this.IPAddText.Location = new System.Drawing.Point(87, 43);
            this.IPAddText.Name = "IPAddText";
            this.IPAddText.Size = new System.Drawing.Size(100, 20);
            this.IPAddText.TabIndex = 1;
            // 
            // LoggingTrapChecked
            // 
            this.LoggingTrapChecked.AutoSize = true;
            this.LoggingTrapChecked.Checked = true;
            this.LoggingTrapChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LoggingTrapChecked.Location = new System.Drawing.Point(7, 66);
            this.LoggingTrapChecked.Name = "LoggingTrapChecked";
            this.LoggingTrapChecked.Size = new System.Drawing.Size(89, 17);
            this.LoggingTrapChecked.TabIndex = 2;
            this.LoggingTrapChecked.Text = "Logging Trap";
            this.LoggingTrapChecked.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trap Level";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TrapLevelNum
            // 
            this.TrapLevelNum.Location = new System.Drawing.Point(87, 87);
            this.TrapLevelNum.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.TrapLevelNum.Name = "TrapLevelNum";
            this.TrapLevelNum.Size = new System.Drawing.Size(37, 20);
            this.TrapLevelNum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Source Interface ID";
            // 
            // SourceIntIDText
            // 
            this.SourceIntIDText.Location = new System.Drawing.Point(112, 113);
            this.SourceIntIDText.Name = "SourceIntIDText";
            this.SourceIntIDText.Size = new System.Drawing.Size(108, 20);
            this.SourceIntIDText.TabIndex = 6;
            // 
            // MonitorAndManagingDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(254, 306);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DisablePassRecoveryChecked);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MonitorAndManagingDevices";
            this.Text = "Monitor And Managing Devices";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrapLevelNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SecureBootConfigChecked;
        private System.Windows.Forms.CheckBox SecureBootImageChecked;
        private System.Windows.Forms.CheckBox DisablePassRecoveryChecked;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox LoggingTrapChecked;
        private System.Windows.Forms.TextBox IPAddText;
        private System.Windows.Forms.TextBox HostnameText;
        private System.Windows.Forms.CheckBox IPAddChecked;
        private System.Windows.Forms.CheckBox HostnameChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TrapLevelNum;
        private System.Windows.Forms.TextBox SourceIntIDText;
    }
}