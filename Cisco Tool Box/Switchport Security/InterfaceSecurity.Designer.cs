namespace Cisco_Tool_Box
{
    partial class InterfaceSecurity
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
            this.SecureIntChecked = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InterfaceIDText = new System.Windows.Forms.TextBox();
            this.SecureUnusedChecked = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstIntIDText = new System.Windows.Forms.TextBox();
            this.LastIntIDText = new System.Windows.Forms.TextBox();
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
            // SecureIntChecked
            // 
            this.SecureIntChecked.AutoSize = true;
            this.SecureIntChecked.Checked = true;
            this.SecureIntChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SecureIntChecked.Location = new System.Drawing.Point(13, 42);
            this.SecureIntChecked.Name = "SecureIntChecked";
            this.SecureIntChecked.Size = new System.Drawing.Size(105, 17);
            this.SecureIntChecked.TabIndex = 1;
            this.SecureIntChecked.Text = "Secure Interface";
            this.SecureIntChecked.UseVisualStyleBackColor = true;
            this.SecureIntChecked.CheckedChanged += new System.EventHandler(this.SecureIntChecked_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interface ID";
            // 
            // InterfaceIDText
            // 
            this.InterfaceIDText.Location = new System.Drawing.Point(193, 40);
            this.InterfaceIDText.Name = "InterfaceIDText";
            this.InterfaceIDText.Size = new System.Drawing.Size(100, 20);
            this.InterfaceIDText.TabIndex = 3;
            // 
            // SecureUnusedChecked
            // 
            this.SecureUnusedChecked.AutoSize = true;
            this.SecureUnusedChecked.Checked = true;
            this.SecureUnusedChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SecureUnusedChecked.Location = new System.Drawing.Point(13, 68);
            this.SecureUnusedChecked.Name = "SecureUnusedChecked";
            this.SecureUnusedChecked.Size = new System.Drawing.Size(127, 17);
            this.SecureUnusedChecked.TabIndex = 4;
            this.SecureUnusedChecked.Text = "Secure Unused Ports";
            this.SecureUnusedChecked.UseVisualStyleBackColor = true;
            this.SecureUnusedChecked.CheckedChanged += new System.EventHandler(this.SecureUnusedChecked_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "1st Interface ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Interface ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FirstIntIDText
            // 
            this.FirstIntIDText.Location = new System.Drawing.Point(232, 66);
            this.FirstIntIDText.Name = "FirstIntIDText";
            this.FirstIntIDText.Size = new System.Drawing.Size(61, 20);
            this.FirstIntIDText.TabIndex = 6;
            // 
            // LastIntIDText
            // 
            this.LastIntIDText.Location = new System.Drawing.Point(232, 92);
            this.LastIntIDText.Name = "LastIntIDText";
            this.LastIntIDText.Size = new System.Drawing.Size(61, 20);
            this.LastIntIDText.TabIndex = 6;
            // 
            // InterfaceSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(301, 130);
            this.Controls.Add(this.LastIntIDText);
            this.Controls.Add(this.FirstIntIDText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SecureUnusedChecked);
            this.Controls.Add(this.InterfaceIDText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecureIntChecked);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InterfaceSecurity";
            this.Text = "Interface Security";
            this.Load += new System.EventHandler(this.SwitchportSecurity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox SecureIntChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InterfaceIDText;
        private System.Windows.Forms.CheckBox SecureUnusedChecked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstIntIDText;
        private System.Windows.Forms.TextBox LastIntIDText;
    }
}