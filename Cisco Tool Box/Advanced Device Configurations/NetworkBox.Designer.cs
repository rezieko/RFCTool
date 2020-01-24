namespace Cisco_Tool_Box
{
    partial class NetworkBox
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
            this.NetworkText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WildcardText = new System.Windows.Forms.TextBox();
            this.AreaIDText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Network";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NetworkText
            // 
            this.NetworkText.Location = new System.Drawing.Point(57, 4);
            this.NetworkText.Name = "NetworkText";
            this.NetworkText.Size = new System.Drawing.Size(100, 20);
            this.NetworkText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wildcard";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Area ID";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // WildcardText
            // 
            this.WildcardText.Location = new System.Drawing.Point(218, 4);
            this.WildcardText.Name = "WildcardText";
            this.WildcardText.Size = new System.Drawing.Size(100, 20);
            this.WildcardText.TabIndex = 1;
            // 
            // AreaIDText
            // 
            this.AreaIDText.Location = new System.Drawing.Point(373, 4);
            this.AreaIDText.Name = "AreaIDText";
            this.AreaIDText.Size = new System.Drawing.Size(28, 20);
            this.AreaIDText.TabIndex = 1;
            // 
            // NetworkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.AreaIDText);
            this.Controls.Add(this.WildcardText);
            this.Controls.Add(this.NetworkText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "NetworkBox";
            this.Size = new System.Drawing.Size(410, 30);
            this.Load += new System.EventHandler(this.NetworkBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NetworkText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WildcardText;
        private System.Windows.Forms.TextBox AreaIDText;
    }
}
