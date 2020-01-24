namespace Cisco_Tool_Box
{
    partial class StaticNAT
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
            this.label2 = new System.Windows.Forms.Label();
            this.NumInterfaces = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.LocalAddrText = new System.Windows.Forms.TextBox();
            this.InterfacesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.GlobalAddrText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumInterfaces)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inside Local Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Outside Global Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NumInterfaces
            // 
            this.NumInterfaces.Location = new System.Drawing.Point(93, 97);
            this.NumInterfaces.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumInterfaces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumInterfaces.Name = "NumInterfaces";
            this.NumInterfaces.Size = new System.Drawing.Size(34, 20);
            this.NumInterfaces.TabIndex = 2;
            this.NumInterfaces.TabStop = false;
            this.NumInterfaces.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumInterfaces.ValueChanged += new System.EventHandler(this.NumInterfaces_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "# of Interfaces";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // LocalAddrText
            // 
            this.LocalAddrText.Location = new System.Drawing.Point(120, 42);
            this.LocalAddrText.Name = "LocalAddrText";
            this.LocalAddrText.Size = new System.Drawing.Size(100, 20);
            this.LocalAddrText.TabIndex = 3;
            this.LocalAddrText.TextChanged += new System.EventHandler(this.LocalAddrText_TextChanged);
            // 
            // InterfacesPanel
            // 
            this.InterfacesPanel.AutoSize = true;
            this.InterfacesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InterfacesPanel.Location = new System.Drawing.Point(15, 123);
            this.InterfacesPanel.Name = "InterfacesPanel";
            this.InterfacesPanel.Size = new System.Drawing.Size(0, 0);
            this.InterfacesPanel.TabIndex = 4;
            // 
            // GlobalAddrText
            // 
            this.GlobalAddrText.Location = new System.Drawing.Point(133, 71);
            this.GlobalAddrText.Name = "GlobalAddrText";
            this.GlobalAddrText.Size = new System.Drawing.Size(100, 20);
            this.GlobalAddrText.TabIndex = 3;
            // 
            // StaticNAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(245, 143);
            this.Controls.Add(this.InterfacesPanel);
            this.Controls.Add(this.GlobalAddrText);
            this.Controls.Add(this.LocalAddrText);
            this.Controls.Add(this.NumInterfaces);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "StaticNAT";
            this.Text = "Static NAT";
            ((System.ComponentModel.ISupportInitialize)(this.NumInterfaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumInterfaces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LocalAddrText;
        private System.Windows.Forms.FlowLayoutPanel InterfacesPanel;
        private System.Windows.Forms.TextBox GlobalAddrText;
    }
}