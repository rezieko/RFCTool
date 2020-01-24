namespace Cisco_Tool_Box
{
    partial class ExcludedAddressBox
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
            this.label2 = new System.Windows.Forms.Label();
            this.LowerAddressText = new System.Windows.Forms.TextBox();
            this.HigherAddressText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lower Excluded Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Higher Excluded Address";
            // 
            // LowerAddressText
            // 
            this.LowerAddressText.Location = new System.Drawing.Point(135, 7);
            this.LowerAddressText.Name = "LowerAddressText";
            this.LowerAddressText.Size = new System.Drawing.Size(100, 20);
            this.LowerAddressText.TabIndex = 2;
            this.LowerAddressText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HigherAddressText
            // 
            this.HigherAddressText.Location = new System.Drawing.Point(382, 7);
            this.HigherAddressText.Name = "HigherAddressText";
            this.HigherAddressText.Size = new System.Drawing.Size(100, 20);
            this.HigherAddressText.TabIndex = 2;
            // 
            // ExcludedAddressBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.HigherAddressText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LowerAddressText);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ExcludedAddressBox";
            this.Size = new System.Drawing.Size(497, 36);
            this.Load += new System.EventHandler(this.ExcludedAddressBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LowerAddressText;
        private System.Windows.Forms.TextBox HigherAddressText;
    }
}
