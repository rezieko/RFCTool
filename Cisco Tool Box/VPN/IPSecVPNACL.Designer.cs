namespace Cisco_Tool_Box
{
    partial class IPSecVPNACL
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AclIdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProtocolCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SourceHostChecked = new System.Windows.Forms.CheckBox();
            this.SourceWildcardText = new System.Windows.Forms.TextBox();
            this.SourceIpText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DestHostChecked = new System.Windows.Forms.CheckBox();
            this.DestWildcardText = new System.Windows.Forms.TextBox();
            this.DestIpText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACL ID";
            // 
            // AclIdText
            // 
            this.AclIdText.Location = new System.Drawing.Point(59, 12);
            this.AclIdText.Name = "AclIdText";
            this.AclIdText.Size = new System.Drawing.Size(76, 20);
            this.AclIdText.TabIndex = 1;
            this.AclIdText.TextChanged += new System.EventHandler(this.AclIdText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Protocol";
            // 
            // ProtocolCombo
            // 
            this.ProtocolCombo.FormattingEnabled = true;
            this.ProtocolCombo.Items.AddRange(new object[] {
            "ahp",
            "esp",
            "udp"});
            this.ProtocolCombo.Location = new System.Drawing.Point(67, 38);
            this.ProtocolCombo.Name = "ProtocolCombo";
            this.ProtocolCombo.Size = new System.Drawing.Size(68, 21);
            this.ProtocolCombo.TabIndex = 3;
            this.ProtocolCombo.Text = "Protocols";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SourceHostChecked);
            this.groupBox1.Controls.Add(this.SourceWildcardText);
            this.groupBox1.Controls.Add(this.SourceIpText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(152, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 39);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // SourceHostChecked
            // 
            this.SourceHostChecked.AutoSize = true;
            this.SourceHostChecked.Location = new System.Drawing.Point(409, 14);
            this.SourceHostChecked.Name = "SourceHostChecked";
            this.SourceHostChecked.Size = new System.Drawing.Size(48, 17);
            this.SourceHostChecked.TabIndex = 4;
            this.SourceHostChecked.Text = "Host";
            this.SourceHostChecked.UseVisualStyleBackColor = true;
            this.SourceHostChecked.CheckedChanged += new System.EventHandler(this.SourceHostChecked_CheckedChanged);
            // 
            // SourceWildcardText
            // 
            this.SourceWildcardText.Location = new System.Drawing.Point(303, 12);
            this.SourceWildcardText.Name = "SourceWildcardText";
            this.SourceWildcardText.Size = new System.Drawing.Size(100, 20);
            this.SourceWildcardText.TabIndex = 3;
            // 
            // SourceIpText
            // 
            this.SourceIpText.Location = new System.Drawing.Point(86, 12);
            this.SourceIpText.Name = "SourceIpText";
            this.SourceIpText.Size = new System.Drawing.Size(100, 20);
            this.SourceIpText.TabIndex = 2;
            this.SourceIpText.TextChanged += new System.EventHandler(this.SourceIpText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Source Wildcard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Source IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DestHostChecked);
            this.groupBox2.Controls.Add(this.DestWildcardText);
            this.groupBox2.Controls.Add(this.DestIpText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(152, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 44);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // DestHostChecked
            // 
            this.DestHostChecked.AutoSize = true;
            this.DestHostChecked.Location = new System.Drawing.Point(409, 15);
            this.DestHostChecked.Name = "DestHostChecked";
            this.DestHostChecked.Size = new System.Drawing.Size(48, 17);
            this.DestHostChecked.TabIndex = 4;
            this.DestHostChecked.Text = "Host";
            this.DestHostChecked.UseVisualStyleBackColor = true;
            this.DestHostChecked.CheckedChanged += new System.EventHandler(this.DestHostChecked_CheckedChanged);
            // 
            // DestWildcardText
            // 
            this.DestWildcardText.Location = new System.Drawing.Point(303, 13);
            this.DestWildcardText.Name = "DestWildcardText";
            this.DestWildcardText.Size = new System.Drawing.Size(100, 20);
            this.DestWildcardText.TabIndex = 3;
            // 
            // DestIpText
            // 
            this.DestIpText.Location = new System.Drawing.Point(86, 13);
            this.DestIpText.Name = "DestIpText";
            this.DestIpText.Size = new System.Drawing.Size(100, 20);
            this.DestIpText.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Destination Wildcard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Destination IP";
            // 
            // IPSecVPNACL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProtocolCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AclIdText);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "IPSecVPNACL";
            this.Size = new System.Drawing.Size(623, 102);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AclIdText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProtocolCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SourceHostChecked;
        private System.Windows.Forms.TextBox SourceWildcardText;
        private System.Windows.Forms.TextBox SourceIpText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox DestHostChecked;
        private System.Windows.Forms.TextBox DestWildcardText;
        private System.Windows.Forms.TextBox DestIpText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
