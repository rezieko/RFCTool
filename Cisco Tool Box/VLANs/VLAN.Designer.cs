namespace Cisco_Tool_Box
{
    partial class VLAN
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
            this.VLANIDText = new System.Windows.Forms.TextBox();
            this.VLANNameChecked = new System.Windows.Forms.CheckBox();
            this.VLANNameText = new System.Windows.Forms.TextBox();
            this.PortVLANChecked = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IntIDText = new System.Windows.Forms.TextBox();
            this.PortVLANIDText = new System.Windows.Forms.TextBox();
            this.InterfaceRangeChecked = new System.Windows.Forms.CheckBox();
            this.FirstintIDText = new System.Windows.Forms.TextBox();
            this.LastIntIDText = new System.Windows.Forms.TextBox();
            this.InterfaceIDChecked = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DescText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy To Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "VLAN ID";
            // 
            // VLANIDText
            // 
            this.VLANIDText.Location = new System.Drawing.Point(67, 42);
            this.VLANIDText.Name = "VLANIDText";
            this.VLANIDText.Size = new System.Drawing.Size(40, 20);
            this.VLANIDText.TabIndex = 2;
            // 
            // VLANNameChecked
            // 
            this.VLANNameChecked.AutoSize = true;
            this.VLANNameChecked.Checked = true;
            this.VLANNameChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VLANNameChecked.Location = new System.Drawing.Point(15, 70);
            this.VLANNameChecked.Name = "VLANNameChecked";
            this.VLANNameChecked.Size = new System.Drawing.Size(85, 17);
            this.VLANNameChecked.TabIndex = 3;
            this.VLANNameChecked.Text = "VLAN Name";
            this.VLANNameChecked.UseVisualStyleBackColor = true;
            this.VLANNameChecked.CheckedChanged += new System.EventHandler(this.VLANNameChecked_CheckedChanged);
            // 
            // VLANNameText
            // 
            this.VLANNameText.Location = new System.Drawing.Point(106, 68);
            this.VLANNameText.Name = "VLANNameText";
            this.VLANNameText.Size = new System.Drawing.Size(99, 20);
            this.VLANNameText.TabIndex = 4;
            this.VLANNameText.TextChanged += new System.EventHandler(this.VLANNameText_TextChanged);
            // 
            // PortVLANChecked
            // 
            this.PortVLANChecked.AutoSize = true;
            this.PortVLANChecked.Checked = true;
            this.PortVLANChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PortVLANChecked.Location = new System.Drawing.Point(15, 120);
            this.PortVLANChecked.Name = "PortVLANChecked";
            this.PortVLANChecked.Size = new System.Drawing.Size(210, 17);
            this.PortVLANChecked.TabIndex = 5;
            this.PortVLANChecked.Text = "Assigning VLAN to Port (Access Mode)";
            this.PortVLANChecked.UseVisualStyleBackColor = true;
            this.PortVLANChecked.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "VLAN ID";
            // 
            // IntIDText
            // 
            this.IntIDText.Location = new System.Drawing.Point(110, 141);
            this.IntIDText.Name = "IntIDText";
            this.IntIDText.Size = new System.Drawing.Size(75, 20);
            this.IntIDText.TabIndex = 4;
            this.IntIDText.TextChanged += new System.EventHandler(this.IntIDText_TextChanged);
            // 
            // PortVLANIDText
            // 
            this.PortVLANIDText.Location = new System.Drawing.Point(88, 216);
            this.PortVLANIDText.Name = "PortVLANIDText";
            this.PortVLANIDText.Size = new System.Drawing.Size(54, 20);
            this.PortVLANIDText.TabIndex = 4;
            // 
            // InterfaceRangeChecked
            // 
            this.InterfaceRangeChecked.AutoSize = true;
            this.InterfaceRangeChecked.Checked = true;
            this.InterfaceRangeChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InterfaceRangeChecked.Location = new System.Drawing.Point(36, 167);
            this.InterfaceRangeChecked.Name = "InterfaceRangeChecked";
            this.InterfaceRangeChecked.Size = new System.Drawing.Size(103, 17);
            this.InterfaceRangeChecked.TabIndex = 8;
            this.InterfaceRangeChecked.Text = "Interface Range";
            this.InterfaceRangeChecked.UseVisualStyleBackColor = true;
            this.InterfaceRangeChecked.CheckedChanged += new System.EventHandler(this.InterfaceRangeChecked_CheckedChanged);
            // 
            // FirstintIDText
            // 
            this.FirstintIDText.Location = new System.Drawing.Point(236, 165);
            this.FirstintIDText.Name = "FirstintIDText";
            this.FirstintIDText.Size = new System.Drawing.Size(75, 20);
            this.FirstintIDText.TabIndex = 9;
            // 
            // LastIntIDText
            // 
            this.LastIntIDText.Location = new System.Drawing.Point(236, 190);
            this.LastIntIDText.Name = "LastIntIDText";
            this.LastIntIDText.Size = new System.Drawing.Size(75, 20);
            this.LastIntIDText.TabIndex = 9;
            // 
            // InterfaceIDChecked
            // 
            this.InterfaceIDChecked.AutoSize = true;
            this.InterfaceIDChecked.Checked = true;
            this.InterfaceIDChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InterfaceIDChecked.Location = new System.Drawing.Point(36, 145);
            this.InterfaceIDChecked.Name = "InterfaceIDChecked";
            this.InterfaceIDChecked.Size = new System.Drawing.Size(68, 17);
            this.InterfaceIDChecked.TabIndex = 10;
            this.InterfaceIDChecked.Text = "Interface";
            this.InterfaceIDChecked.UseVisualStyleBackColor = true;
            this.InterfaceIDChecked.CheckedChanged += new System.EventHandler(this.InterfaceIDChecked_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "First Interface ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Interface ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description";
            // 
            // DescText
            // 
            this.DescText.Location = new System.Drawing.Point(85, 94);
            this.DescText.Name = "DescText";
            this.DescText.Size = new System.Drawing.Size(100, 20);
            this.DescText.TabIndex = 13;
            // 
            // VLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(324, 249);
            this.Controls.Add(this.DescText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InterfaceIDChecked);
            this.Controls.Add(this.LastIntIDText);
            this.Controls.Add(this.FirstintIDText);
            this.Controls.Add(this.InterfaceRangeChecked);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PortVLANChecked);
            this.Controls.Add(this.PortVLANIDText);
            this.Controls.Add(this.IntIDText);
            this.Controls.Add(this.VLANNameText);
            this.Controls.Add(this.VLANNameChecked);
            this.Controls.Add(this.VLANIDText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VLAN";
            this.Text = "VLAN";
            this.Load += new System.EventHandler(this.VLAN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VLANIDText;
        private System.Windows.Forms.CheckBox VLANNameChecked;
        private System.Windows.Forms.TextBox VLANNameText;
        private System.Windows.Forms.CheckBox PortVLANChecked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IntIDText;
        private System.Windows.Forms.TextBox PortVLANIDText;
        private System.Windows.Forms.CheckBox InterfaceRangeChecked;
        private System.Windows.Forms.TextBox FirstintIDText;
        private System.Windows.Forms.TextBox LastIntIDText;
        private System.Windows.Forms.CheckBox InterfaceIDChecked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescText;
    }
}