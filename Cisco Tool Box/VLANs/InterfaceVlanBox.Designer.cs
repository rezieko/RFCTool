namespace Cisco_Tool_Box
{
    partial class InterfaceVlanBox
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
            this.InterfaceText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VlanIDText = new System.Windows.Forms.TextBox();
            this.IsNative = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // InterfaceText
            // 
            this.InterfaceText.Location = new System.Drawing.Point(63, 5);
            this.InterfaceText.Name = "InterfaceText";
            this.InterfaceText.Size = new System.Drawing.Size(100, 20);
            this.InterfaceText.TabIndex = 0;
            this.InterfaceText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interface";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "VLAN ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // VlanIDText
            // 
            this.VlanIDText.Location = new System.Drawing.Point(224, 5);
            this.VlanIDText.Name = "VlanIDText";
            this.VlanIDText.Size = new System.Drawing.Size(44, 20);
            this.VlanIDText.TabIndex = 0;
            this.VlanIDText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IsNative
            // 
            this.IsNative.AutoSize = true;
            this.IsNative.Location = new System.Drawing.Point(284, 7);
            this.IsNative.Name = "IsNative";
            this.IsNative.Size = new System.Drawing.Size(57, 17);
            this.IsNative.TabIndex = 2;
            this.IsNative.Text = "Native";
            this.IsNative.UseVisualStyleBackColor = true;
            this.IsNative.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // InterfaceVlanBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.IsNative);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VlanIDText);
            this.Controls.Add(this.InterfaceText);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "InterfaceVlanBox";
            this.Size = new System.Drawing.Size(340, 34);
            this.Load += new System.EventHandler(this.InterfaceVlanBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InterfaceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VlanIDText;
        private System.Windows.Forms.CheckBox IsNative;
    }
}
