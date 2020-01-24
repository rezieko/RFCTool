namespace Cisco_Tool_Box
{
    partial class CryptoACL
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
            this.IdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PermitDenyCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProtocolCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SourceWildcardText = new System.Windows.Forms.TextBox();
            this.SourceAddText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DestWildcardText = new System.Windows.Forms.TextBox();
            this.DestAddText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACL ID";
            // 
            // IdText
            // 
            this.IdText.Location = new System.Drawing.Point(63, 16);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(67, 20);
            this.IdText.TabIndex = 1;
            this.IdText.TextChanged += new System.EventHandler(this.IdText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Permit | Deny";
            // 
            // PermitDenyCombo
            // 
            this.PermitDenyCombo.FormattingEnabled = true;
            this.PermitDenyCombo.Items.AddRange(new object[] {
            "permit",
            "deny"});
            this.PermitDenyCombo.Location = new System.Drawing.Point(94, 42);
            this.PermitDenyCombo.Name = "PermitDenyCombo";
            this.PermitDenyCombo.Size = new System.Drawing.Size(69, 21);
            this.PermitDenyCombo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Protocol";
            // 
            // ProtocolCombo
            // 
            this.ProtocolCombo.FormattingEnabled = true;
            this.ProtocolCombo.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "ICMP",
            "IP"});
            this.ProtocolCombo.Location = new System.Drawing.Point(94, 69);
            this.ProtocolCombo.Name = "ProtocolCombo";
            this.ProtocolCombo.Size = new System.Drawing.Size(69, 21);
            this.ProtocolCombo.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SourceWildcardText);
            this.groupBox1.Controls.Add(this.SourceAddText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(169, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 44);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // SourceWildcardText
            // 
            this.SourceWildcardText.Location = new System.Drawing.Point(331, 19);
            this.SourceWildcardText.Name = "SourceWildcardText";
            this.SourceWildcardText.Size = new System.Drawing.Size(100, 20);
            this.SourceWildcardText.TabIndex = 0;
            // 
            // SourceAddText
            // 
            this.SourceAddText.Location = new System.Drawing.Point(110, 18);
            this.SourceAddText.Name = "SourceAddText";
            this.SourceAddText.Size = new System.Drawing.Size(100, 20);
            this.SourceAddText.TabIndex = 0;
            this.SourceAddText.TextChanged += new System.EventHandler(this.SourceAddressText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Source Wildcard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Source Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DestWildcardText);
            this.groupBox2.Controls.Add(this.DestAddText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(169, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 44);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // DestWildcardText
            // 
            this.DestWildcardText.Location = new System.Drawing.Point(331, 19);
            this.DestWildcardText.Name = "DestWildcardText";
            this.DestWildcardText.Size = new System.Drawing.Size(100, 20);
            this.DestWildcardText.TabIndex = 0;
            // 
            // DestAddText
            // 
            this.DestAddText.Location = new System.Drawing.Point(110, 18);
            this.DestAddText.Name = "DestAddText";
            this.DestAddText.Size = new System.Drawing.Size(100, 20);
            this.DestAddText.TabIndex = 0;
            this.DestAddText.TextChanged += new System.EventHandler(this.SourceAddressText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Destination Wildcard";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Destination Address";
            // 
            // CryptoACL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.ProtocolCombo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PermitDenyCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "CryptoACL";
            this.Size = new System.Drawing.Size(617, 110);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PermitDenyCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProtocolCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SourceWildcardText;
        private System.Windows.Forms.TextBox SourceAddText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DestWildcardText;
        private System.Windows.Forms.TextBox DestAddText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
