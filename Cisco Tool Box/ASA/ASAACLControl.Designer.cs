namespace Cisco_Tool_Box
{
    partial class ASAACLControl
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
            this.ExtendedChecked = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AclIdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DenyPermitCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SrcPort2Checked = new System.Windows.Forms.CheckBox();
            this.SrcPort2Text = new System.Windows.Forms.TextBox();
            this.SrcOpPortText = new System.Windows.Forms.TextBox();
            this.label2131 = new System.Windows.Forms.Label();
            this.SrcIntChecked = new System.Windows.Forms.CheckBox();
            this.SrcHostChecked = new System.Windows.Forms.CheckBox();
            this.SrcOpPortChecked = new System.Windows.Forms.CheckBox();
            this.SrcMaskText = new System.Windows.Forms.TextBox();
            this.SrcAddText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProtoCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DestPort2Checked = new System.Windows.Forms.CheckBox();
            this.DestHostChecked = new System.Windows.Forms.CheckBox();
            this.DestPort2Text = new System.Windows.Forms.TextBox();
            this.DestOpPortChecked = new System.Windows.Forms.CheckBox();
            this.DestOpPortText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DestIntChecked = new System.Windows.Forms.CheckBox();
            this.DestMaskText = new System.Windows.Forms.TextBox();
            this.DestAddText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExtendedChecked
            // 
            this.ExtendedChecked.AutoSize = true;
            this.ExtendedChecked.Location = new System.Drawing.Point(15, 13);
            this.ExtendedChecked.Name = "ExtendedChecked";
            this.ExtendedChecked.Size = new System.Drawing.Size(71, 17);
            this.ExtendedChecked.TabIndex = 0;
            this.ExtendedChecked.Text = "Extended";
            this.ExtendedChecked.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACL ID";
            // 
            // AclIdText
            // 
            this.AclIdText.Location = new System.Drawing.Point(93, 34);
            this.AclIdText.Name = "AclIdText";
            this.AclIdText.Size = new System.Drawing.Size(83, 20);
            this.AclIdText.TabIndex = 2;
            this.AclIdText.TextChanged += new System.EventHandler(this.AclIdText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deny | Permit";
            // 
            // DenyPermitCombo
            // 
            this.DenyPermitCombo.FormattingEnabled = true;
            this.DenyPermitCombo.Items.AddRange(new object[] {
            "deny",
            "permit"});
            this.DenyPermitCombo.Location = new System.Drawing.Point(93, 60);
            this.DenyPermitCombo.Name = "DenyPermitCombo";
            this.DenyPermitCombo.Size = new System.Drawing.Size(83, 21);
            this.DenyPermitCombo.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SrcPort2Checked);
            this.groupBox1.Controls.Add(this.SrcPort2Text);
            this.groupBox1.Controls.Add(this.SrcOpPortText);
            this.groupBox1.Controls.Add(this.label2131);
            this.groupBox1.Controls.Add(this.SrcIntChecked);
            this.groupBox1.Controls.Add(this.SrcHostChecked);
            this.groupBox1.Controls.Add(this.SrcOpPortChecked);
            this.groupBox1.Controls.Add(this.SrcMaskText);
            this.groupBox1.Controls.Add(this.SrcAddText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(204, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // SrcPort2Checked
            // 
            this.SrcPort2Checked.AutoSize = true;
            this.SrcPort2Checked.Location = new System.Drawing.Point(454, 44);
            this.SrcPort2Checked.Name = "SrcPort2Checked";
            this.SrcPort2Checked.Size = new System.Drawing.Size(76, 17);
            this.SrcPort2Checked.TabIndex = 14;
            this.SrcPort2Checked.Text = "Use Port 2";
            this.SrcPort2Checked.UseVisualStyleBackColor = true;
            // 
            // SrcPort2Text
            // 
            this.SrcPort2Text.Location = new System.Drawing.Point(536, 42);
            this.SrcPort2Text.Name = "SrcPort2Text";
            this.SrcPort2Text.Size = new System.Drawing.Size(100, 20);
            this.SrcPort2Text.TabIndex = 13;
            // 
            // SrcOpPortText
            // 
            this.SrcOpPortText.Location = new System.Drawing.Point(536, 17);
            this.SrcOpPortText.Name = "SrcOpPortText";
            this.SrcOpPortText.Size = new System.Drawing.Size(100, 20);
            this.SrcOpPortText.TabIndex = 9;
            // 
            // label2131
            // 
            this.label2131.AutoSize = true;
            this.label2131.Location = new System.Drawing.Point(430, 20);
            this.label2131.Name = "label2131";
            this.label2131.Size = new System.Drawing.Size(100, 13);
            this.label2131.TabIndex = 8;
            this.label2131.Text = "Operator and Port 1";
            // 
            // SrcIntChecked
            // 
            this.SrcIntChecked.AutoSize = true;
            this.SrcIntChecked.Location = new System.Drawing.Point(328, 45);
            this.SrcIntChecked.Name = "SrcIntChecked";
            this.SrcIntChecked.Size = new System.Drawing.Size(90, 17);
            this.SrcIntChecked.TabIndex = 6;
            this.SrcIntChecked.Text = "Use Interface";
            this.SrcIntChecked.UseVisualStyleBackColor = true;
            // 
            // SrcHostChecked
            // 
            this.SrcHostChecked.AutoSize = true;
            this.SrcHostChecked.Location = new System.Drawing.Point(224, 46);
            this.SrcHostChecked.Name = "SrcHostChecked";
            this.SrcHostChecked.Size = new System.Drawing.Size(98, 17);
            this.SrcHostChecked.TabIndex = 5;
            this.SrcHostChecked.Text = "Apply to 1 Host";
            this.SrcHostChecked.UseVisualStyleBackColor = true;
            // 
            // SrcOpPortChecked
            // 
            this.SrcOpPortChecked.AutoSize = true;
            this.SrcOpPortChecked.Location = new System.Drawing.Point(314, 18);
            this.SrcOpPortChecked.Name = "SrcOpPortChecked";
            this.SrcOpPortChecked.Size = new System.Drawing.Size(110, 17);
            this.SrcOpPortChecked.TabIndex = 4;
            this.SrcOpPortChecked.Text = "Operator and Port";
            this.SrcOpPortChecked.UseVisualStyleBackColor = true;
            // 
            // SrcMaskText
            // 
            this.SrcMaskText.Location = new System.Drawing.Point(118, 44);
            this.SrcMaskText.Name = "SrcMaskText";
            this.SrcMaskText.Size = new System.Drawing.Size(100, 20);
            this.SrcMaskText.TabIndex = 3;
            // 
            // SrcAddText
            // 
            this.SrcAddText.Location = new System.Drawing.Point(194, 16);
            this.SrcAddText.Name = "SrcAddText";
            this.SrcAddText.Size = new System.Drawing.Size(100, 20);
            this.SrcAddText.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Source Mask";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Source Address | Host | Interface";
            // 
            // ProtoCombo
            // 
            this.ProtoCombo.FormattingEnabled = true;
            this.ProtoCombo.Location = new System.Drawing.Point(93, 88);
            this.ProtoCombo.Name = "ProtoCombo";
            this.ProtoCombo.Size = new System.Drawing.Size(83, 21);
            this.ProtoCombo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Protocol";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DestPort2Checked);
            this.groupBox2.Controls.Add(this.DestHostChecked);
            this.groupBox2.Controls.Add(this.DestPort2Text);
            this.groupBox2.Controls.Add(this.DestOpPortChecked);
            this.groupBox2.Controls.Add(this.DestOpPortText);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.DestIntChecked);
            this.groupBox2.Controls.Add(this.DestMaskText);
            this.groupBox2.Controls.Add(this.DestAddText);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(204, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 77);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // DestPort2Checked
            // 
            this.DestPort2Checked.AutoSize = true;
            this.DestPort2Checked.Location = new System.Drawing.Point(454, 44);
            this.DestPort2Checked.Name = "DestPort2Checked";
            this.DestPort2Checked.Size = new System.Drawing.Size(76, 17);
            this.DestPort2Checked.TabIndex = 16;
            this.DestPort2Checked.Text = "Use Port 2";
            this.DestPort2Checked.UseVisualStyleBackColor = true;
            // 
            // DestHostChecked
            // 
            this.DestHostChecked.AutoSize = true;
            this.DestHostChecked.Location = new System.Drawing.Point(224, 45);
            this.DestHostChecked.Name = "DestHostChecked";
            this.DestHostChecked.Size = new System.Drawing.Size(98, 17);
            this.DestHostChecked.TabIndex = 15;
            this.DestHostChecked.Text = "Apply to 1 Host";
            this.DestHostChecked.UseVisualStyleBackColor = true;
            // 
            // DestPort2Text
            // 
            this.DestPort2Text.Location = new System.Drawing.Point(536, 42);
            this.DestPort2Text.Name = "DestPort2Text";
            this.DestPort2Text.Size = new System.Drawing.Size(100, 20);
            this.DestPort2Text.TabIndex = 13;
            // 
            // DestOpPortChecked
            // 
            this.DestOpPortChecked.AutoSize = true;
            this.DestOpPortChecked.Location = new System.Drawing.Point(308, 18);
            this.DestOpPortChecked.Name = "DestOpPortChecked";
            this.DestOpPortChecked.Size = new System.Drawing.Size(110, 17);
            this.DestOpPortChecked.TabIndex = 14;
            this.DestOpPortChecked.Text = "Operator and Port";
            this.DestOpPortChecked.UseVisualStyleBackColor = true;
            // 
            // DestOpPortText
            // 
            this.DestOpPortText.Location = new System.Drawing.Point(536, 16);
            this.DestOpPortText.Name = "DestOpPortText";
            this.DestOpPortText.Size = new System.Drawing.Size(100, 20);
            this.DestOpPortText.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Operator and Port 1";
            // 
            // DestIntChecked
            // 
            this.DestIntChecked.AutoSize = true;
            this.DestIntChecked.Location = new System.Drawing.Point(328, 46);
            this.DestIntChecked.Name = "DestIntChecked";
            this.DestIntChecked.Size = new System.Drawing.Size(90, 17);
            this.DestIntChecked.TabIndex = 13;
            this.DestIntChecked.Text = "Use Interface";
            this.DestIntChecked.UseVisualStyleBackColor = true;
            // 
            // DestMaskText
            // 
            this.DestMaskText.Location = new System.Drawing.Point(118, 43);
            this.DestMaskText.Name = "DestMaskText";
            this.DestMaskText.Size = new System.Drawing.Size(100, 20);
            this.DestMaskText.TabIndex = 11;
            // 
            // DestAddText
            // 
            this.DestAddText.Location = new System.Drawing.Point(194, 16);
            this.DestAddText.Name = "DestAddText";
            this.DestAddText.Size = new System.Drawing.Size(100, 20);
            this.DestAddText.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Destination Address | Host | Interface";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Destination Mask";
            // 
            // ASAACLControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProtoCombo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DenyPermitCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AclIdText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExtendedChecked);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ASAACLControl";
            this.Size = new System.Drawing.Size(861, 174);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ExtendedChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AclIdText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DenyPermitCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ProtoCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SrcMaskText;
        private System.Windows.Forms.TextBox SrcAddText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox SrcHostChecked;
        private System.Windows.Forms.CheckBox SrcOpPortChecked;
        private System.Windows.Forms.CheckBox SrcIntChecked;
        private System.Windows.Forms.Label label2131;
        private System.Windows.Forms.CheckBox SrcPort2Checked;
        private System.Windows.Forms.TextBox SrcPort2Text;
        private System.Windows.Forms.TextBox SrcOpPortText;
        private System.Windows.Forms.CheckBox DestPort2Checked;
        private System.Windows.Forms.CheckBox DestHostChecked;
        private System.Windows.Forms.TextBox DestPort2Text;
        private System.Windows.Forms.CheckBox DestOpPortChecked;
        private System.Windows.Forms.TextBox DestOpPortText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox DestIntChecked;
        private System.Windows.Forms.TextBox DestMaskText;
        private System.Windows.Forms.TextBox DestAddText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
