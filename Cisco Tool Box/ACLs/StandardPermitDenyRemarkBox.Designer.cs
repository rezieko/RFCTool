namespace Cisco_Tool_Box
{
    partial class StandardPermitDenyRemarkBox
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
            this.ControlsText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceAddressText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SourceWildcardText = new System.Windows.Forms.TextBox();
            this.LogChecked = new System.Windows.Forms.CheckBox();
            this.HostChecked = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permit | Deny | Remark";
            // 
            // ControlsText
            // 
            this.ControlsText.Location = new System.Drawing.Point(123, 3);
            this.ControlsText.Name = "ControlsText";
            this.ControlsText.Size = new System.Drawing.Size(100, 20);
            this.ControlsText.TabIndex = 1;
            this.ControlsText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Source Address | Any";
            // 
            // SourceAddressText
            // 
            this.SourceAddressText.Location = new System.Drawing.Point(343, 3);
            this.SourceAddressText.Name = "SourceAddressText";
            this.SourceAddressText.Size = new System.Drawing.Size(100, 20);
            this.SourceAddressText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Source Wildcard";
            // 
            // SourceWildcardText
            // 
            this.SourceWildcardText.Location = new System.Drawing.Point(343, 29);
            this.SourceWildcardText.Name = "SourceWildcardText";
            this.SourceWildcardText.Size = new System.Drawing.Size(100, 20);
            this.SourceWildcardText.TabIndex = 5;
            // 
            // LogChecked
            // 
            this.LogChecked.AutoSize = true;
            this.LogChecked.Location = new System.Drawing.Point(123, 28);
            this.LogChecked.Name = "LogChecked";
            this.LogChecked.Size = new System.Drawing.Size(44, 17);
            this.LogChecked.TabIndex = 6;
            this.LogChecked.Text = "Log";
            this.LogChecked.UseVisualStyleBackColor = true;
            // 
            // HostChecked
            // 
            this.HostChecked.AutoSize = true;
            this.HostChecked.Location = new System.Drawing.Point(6, 28);
            this.HostChecked.Name = "HostChecked";
            this.HostChecked.Size = new System.Drawing.Size(98, 17);
            this.HostChecked.TabIndex = 7;
            this.HostChecked.Text = "Apply to a Host";
            this.HostChecked.UseVisualStyleBackColor = true;
            this.HostChecked.CheckedChanged += new System.EventHandler(this.HostChecked_CheckedChanged);
            // 
            // PermitDenyRemarkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.HostChecked);
            this.Controls.Add(this.LogChecked);
            this.Controls.Add(this.SourceWildcardText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SourceAddressText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ControlsText);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "PermitDenyRemarkBox";
            this.Size = new System.Drawing.Size(451, 55);
            this.Load += new System.EventHandler(this.PermitDenyRemarkBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ControlsText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SourceAddressText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SourceWildcardText;
        private System.Windows.Forms.CheckBox LogChecked;
        private System.Windows.Forms.CheckBox HostChecked;
    }
}
