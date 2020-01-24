namespace Cisco_Tool_Box
{
    partial class ExtendedPermitDenyRemarkBox
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
            this.OptionsCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProtocolsCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SourcePortChecked = new System.Windows.Forms.CheckBox();
            this.SourceHostChecked = new System.Windows.Forms.CheckBox();
            this.SourcePortText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SourceWildcardText = new System.Windows.Forms.TextBox();
            this.SourceAddressText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DestinationPortChecked = new System.Windows.Forms.CheckBox();
            this.DestinationHostChecked = new System.Windows.Forms.CheckBox();
            this.DestinationPortText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DestinationWildcardText = new System.Windows.Forms.TextBox();
            this.DestinationAddressText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsCombo
            // 
            this.OptionsCombo.FormattingEnabled = true;
            this.OptionsCombo.Items.AddRange(new object[] {
            "Permit",
            "Deny",
            "Remark"});
            this.OptionsCombo.Location = new System.Drawing.Point(134, 21);
            this.OptionsCombo.Name = "OptionsCombo";
            this.OptionsCombo.Size = new System.Drawing.Size(96, 21);
            this.OptionsCombo.TabIndex = 0;
            this.OptionsCombo.Text = "Options";
            this.OptionsCombo.SelectedIndexChanged += new System.EventHandler(this.OptionsCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Permit | Deny | Remark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Protocols";
            // 
            // ProtocolsCombo
            // 
            this.ProtocolsCombo.FormattingEnabled = true;
            this.ProtocolsCombo.Items.AddRange(new object[] {
            "IP",
            "TCP",
            "IMCP",
            "UDP"});
            this.ProtocolsCombo.Location = new System.Drawing.Point(134, 48);
            this.ProtocolsCombo.Name = "ProtocolsCombo";
            this.ProtocolsCombo.Size = new System.Drawing.Size(96, 21);
            this.ProtocolsCombo.TabIndex = 3;
            this.ProtocolsCombo.Text = "Protocols";
            this.ProtocolsCombo.SelectedIndexChanged += new System.EventHandler(this.ProtocolsCombo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SourcePortChecked);
            this.groupBox1.Controls.Add(this.SourceHostChecked);
            this.groupBox1.Controls.Add(this.SourcePortText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SourceWildcardText);
            this.groupBox1.Controls.Add(this.SourceAddressText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(236, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // SourcePortChecked
            // 
            this.SourcePortChecked.AutoSize = true;
            this.SourcePortChecked.Location = new System.Drawing.Point(220, 23);
            this.SourcePortChecked.Name = "SourcePortChecked";
            this.SourcePortChecked.Size = new System.Drawing.Size(110, 17);
            this.SourcePortChecked.TabIndex = 5;
            this.SourcePortChecked.Text = "Operator and Port";
            this.SourcePortChecked.UseVisualStyleBackColor = true;
            this.SourcePortChecked.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SourceHostChecked
            // 
            this.SourceHostChecked.AutoSize = true;
            this.SourceHostChecked.Location = new System.Drawing.Point(220, 50);
            this.SourceHostChecked.Name = "SourceHostChecked";
            this.SourceHostChecked.Size = new System.Drawing.Size(48, 17);
            this.SourceHostChecked.TabIndex = 4;
            this.SourceHostChecked.Text = "Host";
            this.SourceHostChecked.UseVisualStyleBackColor = true;
            this.SourceHostChecked.CheckedChanged += new System.EventHandler(this.SourceHostChecked_CheckedChanged);
            // 
            // SourcePortText
            // 
            this.SourcePortText.Location = new System.Drawing.Point(433, 18);
            this.SourcePortText.Name = "SourcePortText";
            this.SourcePortText.Size = new System.Drawing.Size(100, 20);
            this.SourcePortText.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Operator and Port";
            // 
            // SourceWildcardText
            // 
            this.SourceWildcardText.Location = new System.Drawing.Point(114, 47);
            this.SourceWildcardText.Name = "SourceWildcardText";
            this.SourceWildcardText.Size = new System.Drawing.Size(100, 20);
            this.SourceWildcardText.TabIndex = 0;
            // 
            // SourceAddressText
            // 
            this.SourceAddressText.Location = new System.Drawing.Point(114, 21);
            this.SourceAddressText.Name = "SourceAddressText";
            this.SourceAddressText.Size = new System.Drawing.Size(100, 20);
            this.SourceAddressText.TabIndex = 0;
            this.SourceAddressText.TextChanged += new System.EventHandler(this.SourceAddressText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Source Wildcard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Source Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DestinationPortChecked);
            this.groupBox2.Controls.Add(this.DestinationHostChecked);
            this.groupBox2.Controls.Add(this.DestinationPortText);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.DestinationWildcardText);
            this.groupBox2.Controls.Add(this.DestinationAddressText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(236, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // DestinationPortChecked
            // 
            this.DestinationPortChecked.AutoSize = true;
            this.DestinationPortChecked.Location = new System.Drawing.Point(220, 21);
            this.DestinationPortChecked.Name = "DestinationPortChecked";
            this.DestinationPortChecked.Size = new System.Drawing.Size(110, 17);
            this.DestinationPortChecked.TabIndex = 5;
            this.DestinationPortChecked.Text = "Operator and Port";
            this.DestinationPortChecked.UseVisualStyleBackColor = true;
            // 
            // DestinationHostChecked
            // 
            this.DestinationHostChecked.AutoSize = true;
            this.DestinationHostChecked.Location = new System.Drawing.Point(220, 47);
            this.DestinationHostChecked.Name = "DestinationHostChecked";
            this.DestinationHostChecked.Size = new System.Drawing.Size(48, 17);
            this.DestinationHostChecked.TabIndex = 4;
            this.DestinationHostChecked.Text = "Host";
            this.DestinationHostChecked.UseVisualStyleBackColor = true;
            this.DestinationHostChecked.CheckedChanged += new System.EventHandler(this.DestinationHostChecked_CheckedChanged);
            // 
            // DestinationPortText
            // 
            this.DestinationPortText.Location = new System.Drawing.Point(433, 19);
            this.DestinationPortText.Name = "DestinationPortText";
            this.DestinationPortText.Size = new System.Drawing.Size(100, 20);
            this.DestinationPortText.TabIndex = 3;
            this.DestinationPortText.TextChanged += new System.EventHandler(this.DestinationOperatorPortText_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Operator and Port";
            // 
            // DestinationWildcardText
            // 
            this.DestinationWildcardText.Location = new System.Drawing.Point(114, 45);
            this.DestinationWildcardText.Name = "DestinationWildcardText";
            this.DestinationWildcardText.Size = new System.Drawing.Size(100, 20);
            this.DestinationWildcardText.TabIndex = 3;
            // 
            // DestinationAddressText
            // 
            this.DestinationAddressText.Location = new System.Drawing.Point(114, 19);
            this.DestinationAddressText.Name = "DestinationAddressText";
            this.DestinationAddressText.Size = new System.Drawing.Size(100, 20);
            this.DestinationAddressText.TabIndex = 2;
            this.DestinationAddressText.TextChanged += new System.EventHandler(this.DestinationAddressText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Destination Wildcard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Destination Address";
            // 
            // ExtendedPermitDenyRemarkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProtocolsCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OptionsCombo);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ExtendedPermitDenyRemarkBox";
            this.Size = new System.Drawing.Size(825, 176);
            this.Load += new System.EventHandler(this.ExtendedPermitDenyRemarkBox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OptionsCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProtocolsCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SourceWildcardText;
        private System.Windows.Forms.TextBox SourceAddressText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DestinationWildcardText;
        private System.Windows.Forms.TextBox DestinationAddressText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SourcePortText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DestinationPortText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox SourceHostChecked;
        private System.Windows.Forms.CheckBox DestinationHostChecked;
        private System.Windows.Forms.CheckBox SourcePortChecked;
        private System.Windows.Forms.CheckBox DestinationPortChecked;
    }
}
