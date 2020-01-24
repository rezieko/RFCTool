namespace Cisco_Tool_Box
{
    partial class EncapsulationDot1Q
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
            this.SwitchChecked = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InterfaceIDText = new System.Windows.Forms.TextBox();
            this.RouterChecked = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubInterfaceIDText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VLANIDText = new System.Windows.Forms.TextBox();
            this.NativeChecked = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy To Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SwitchChecked
            // 
            this.SwitchChecked.AutoSize = true;
            this.SwitchChecked.Checked = true;
            this.SwitchChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SwitchChecked.Location = new System.Drawing.Point(12, 47);
            this.SwitchChecked.Name = "SwitchChecked";
            this.SwitchChecked.Size = new System.Drawing.Size(58, 17);
            this.SwitchChecked.TabIndex = 1;
            this.SwitchChecked.Text = "Switch";
            this.SwitchChecked.UseVisualStyleBackColor = true;
            this.SwitchChecked.CheckedChanged += new System.EventHandler(this.SwitchChecked_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interface ID";
            // 
            // InterfaceIDText
            // 
            this.InterfaceIDText.Location = new System.Drawing.Point(146, 45);
            this.InterfaceIDText.Name = "InterfaceIDText";
            this.InterfaceIDText.Size = new System.Drawing.Size(99, 20);
            this.InterfaceIDText.TabIndex = 3;
            this.InterfaceIDText.TextChanged += new System.EventHandler(this.InterfaceIDText_TextChanged);
            // 
            // RouterChecked
            // 
            this.RouterChecked.AutoSize = true;
            this.RouterChecked.Checked = true;
            this.RouterChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RouterChecked.Location = new System.Drawing.Point(12, 71);
            this.RouterChecked.Name = "RouterChecked";
            this.RouterChecked.Size = new System.Drawing.Size(58, 17);
            this.RouterChecked.TabIndex = 4;
            this.RouterChecked.Text = "Router";
            this.RouterChecked.UseVisualStyleBackColor = true;
            this.RouterChecked.CheckedChanged += new System.EventHandler(this.RouterChecked_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sub-Interface ID";
            // 
            // SubInterfaceIDText
            // 
            this.SubInterfaceIDText.Location = new System.Drawing.Point(168, 68);
            this.SubInterfaceIDText.Name = "SubInterfaceIDText";
            this.SubInterfaceIDText.Size = new System.Drawing.Size(77, 20);
            this.SubInterfaceIDText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "VLAN ID";
            // 
            // VLANIDText
            // 
            this.VLANIDText.Location = new System.Drawing.Point(132, 94);
            this.VLANIDText.Name = "VLANIDText";
            this.VLANIDText.Size = new System.Drawing.Size(39, 20);
            this.VLANIDText.TabIndex = 3;
            // 
            // NativeChecked
            // 
            this.NativeChecked.AutoSize = true;
            this.NativeChecked.Location = new System.Drawing.Point(188, 96);
            this.NativeChecked.Name = "NativeChecked";
            this.NativeChecked.Size = new System.Drawing.Size(63, 17);
            this.NativeChecked.TabIndex = 7;
            this.NativeChecked.Text = "Native?";
            this.NativeChecked.UseVisualStyleBackColor = true;
            // 
            // EncapsulationDot1Q
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(257, 134);
            this.Controls.Add(this.NativeChecked);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RouterChecked);
            this.Controls.Add(this.VLANIDText);
            this.Controls.Add(this.SubInterfaceIDText);
            this.Controls.Add(this.InterfaceIDText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SwitchChecked);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EncapsulationDot1Q";
            this.Text = "EncapsulationDot1Q";
            this.Load += new System.EventHandler(this.EncapsulationDot1Q_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox SwitchChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InterfaceIDText;
        private System.Windows.Forms.CheckBox RouterChecked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SubInterfaceIDText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VLANIDText;
        private System.Windows.Forms.CheckBox NativeChecked;
    }
}