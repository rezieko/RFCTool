namespace Cisco_Tool_Box
{
    partial class I802form
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
            this.DevicesLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfInterfaces = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfInterfaces)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy To Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DevicesLayout
            // 
            this.DevicesLayout.AutoSize = true;
            this.DevicesLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DevicesLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DevicesLayout.Location = new System.Drawing.Point(13, 42);
            this.DevicesLayout.Name = "DevicesLayout";
            this.DevicesLayout.Size = new System.Drawing.Size(0, 0);
            this.DevicesLayout.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Interfaces";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumberOfInterfaces
            // 
            this.NumberOfInterfaces.Location = new System.Drawing.Point(238, 16);
            this.NumberOfInterfaces.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.NumberOfInterfaces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfInterfaces.Name = "NumberOfInterfaces";
            this.NumberOfInterfaces.Size = new System.Drawing.Size(40, 20);
            this.NumberOfInterfaces.TabIndex = 3;
            this.NumberOfInterfaces.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfInterfaces.ValueChanged += new System.EventHandler(this.NumberOfInterfaces_ValueChanged);
            // 
            // I802form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(344, 49);
            this.Controls.Add(this.NumberOfInterfaces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DevicesLayout);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "I802form";
            this.Text = "IEEE 802.1Q";
            this.Load += new System.EventHandler(this.I802form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfInterfaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel DevicesLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumberOfInterfaces;
    }
}