namespace Cisco_Tool_Box
{
    partial class CompatibleIPSecVPNACLs
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
            this.NumAcls = new System.Windows.Forms.NumericUpDown();
            this.BoxPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.NumAcls)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "# of ACLs";
            // 
            // NumAcls
            // 
            this.NumAcls.Location = new System.Drawing.Point(73, 41);
            this.NumAcls.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumAcls.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumAcls.Name = "NumAcls";
            this.NumAcls.Size = new System.Drawing.Size(41, 20);
            this.NumAcls.TabIndex = 2;
            this.NumAcls.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumAcls.ValueChanged += new System.EventHandler(this.NumAcls_ValueChanged);
            // 
            // BoxPanel
            // 
            this.BoxPanel.AutoSize = true;
            this.BoxPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BoxPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.BoxPanel.Location = new System.Drawing.Point(13, 67);
            this.BoxPanel.Name = "BoxPanel";
            this.BoxPanel.Size = new System.Drawing.Size(0, 0);
            this.BoxPanel.TabIndex = 3;
            // 
            // CompatibleIPSecVPNACLs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(127, 67);
            this.Controls.Add(this.BoxPanel);
            this.Controls.Add(this.NumAcls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "CompatibleIPSecVPNACLs";
            this.Text = "CompatibleIPSecVPNACLs";
            ((System.ComponentModel.ISupportInitialize)(this.NumAcls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumAcls;
        private System.Windows.Forms.FlowLayoutPanel BoxPanel;
    }
}