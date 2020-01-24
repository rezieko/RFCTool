namespace Cisco_Tool_Box
{
    partial class Passwords
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConsoleChecked = new System.Windows.Forms.CheckBox();
            this.ConsolePassText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VtyChecked = new System.Windows.Forms.CheckBox();
            this.VtyPassText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AuxChecked = new System.Windows.Forms.CheckBox();
            this.AuxPassText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SecretPassText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SecretChecked = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConsoleChecked);
            this.groupBox1.Controls.Add(this.ConsolePassText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Line Console";
            // 
            // ConsoleChecked
            // 
            this.ConsoleChecked.AutoSize = true;
            this.ConsoleChecked.Checked = true;
            this.ConsoleChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConsoleChecked.Location = new System.Drawing.Point(6, 19);
            this.ConsoleChecked.Name = "ConsoleChecked";
            this.ConsoleChecked.Size = new System.Drawing.Size(136, 17);
            this.ConsoleChecked.TabIndex = 2;
            this.ConsoleChecked.Text = "Line Console Password";
            this.ConsoleChecked.UseVisualStyleBackColor = true;
            this.ConsoleChecked.CheckedChanged += new System.EventHandler(this.ConsoleChecked_CheckedChanged);
            // 
            // ConsolePassText
            // 
            this.ConsolePassText.Location = new System.Drawing.Point(69, 42);
            this.ConsolePassText.Name = "ConsolePassText";
            this.ConsolePassText.Size = new System.Drawing.Size(100, 20);
            this.ConsolePassText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VtyChecked);
            this.groupBox2.Controls.Add(this.VtyPassText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Line VTY";
            // 
            // VtyChecked
            // 
            this.VtyChecked.AutoSize = true;
            this.VtyChecked.Checked = true;
            this.VtyChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VtyChecked.Location = new System.Drawing.Point(6, 19);
            this.VtyChecked.Name = "VtyChecked";
            this.VtyChecked.Size = new System.Drawing.Size(119, 17);
            this.VtyChecked.TabIndex = 2;
            this.VtyChecked.Text = "Line VTY Password";
            this.VtyChecked.UseVisualStyleBackColor = true;
            this.VtyChecked.CheckedChanged += new System.EventHandler(this.VtyChecked_CheckedChanged);
            // 
            // VtyPassText
            // 
            this.VtyPassText.Location = new System.Drawing.Point(69, 42);
            this.VtyPassText.Name = "VtyPassText";
            this.VtyPassText.Size = new System.Drawing.Size(100, 20);
            this.VtyPassText.TabIndex = 1;
            this.VtyPassText.TextChanged += new System.EventHandler(this.VtyPassText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AuxChecked);
            this.groupBox3.Controls.Add(this.AuxPassText);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 74);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Line AUX";
            // 
            // AuxChecked
            // 
            this.AuxChecked.AutoSize = true;
            this.AuxChecked.Checked = true;
            this.AuxChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AuxChecked.Location = new System.Drawing.Point(6, 19);
            this.AuxChecked.Name = "AuxChecked";
            this.AuxChecked.Size = new System.Drawing.Size(120, 17);
            this.AuxChecked.TabIndex = 2;
            this.AuxChecked.Text = "Line AUX Password";
            this.AuxChecked.UseVisualStyleBackColor = true;
            this.AuxChecked.CheckedChanged += new System.EventHandler(this.AuxChecked_CheckedChanged);
            // 
            // AuxPassText
            // 
            this.AuxPassText.Location = new System.Drawing.Point(69, 42);
            this.AuxPassText.Name = "AuxPassText";
            this.AuxPassText.Size = new System.Drawing.Size(100, 20);
            this.AuxPassText.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SecretPassText);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.SecretChecked);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(12, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 69);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Secret Password";
            // 
            // SecretPassText
            // 
            this.SecretPassText.Location = new System.Drawing.Point(69, 39);
            this.SecretPassText.Name = "SecretPassText";
            this.SecretPassText.Size = new System.Drawing.Size(100, 20);
            this.SecretPassText.TabIndex = 2;
            this.SecretPassText.TextChanged += new System.EventHandler(this.SecretPassText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // SecretChecked
            // 
            this.SecretChecked.AutoSize = true;
            this.SecretChecked.Checked = true;
            this.SecretChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SecretChecked.Location = new System.Drawing.Point(6, 19);
            this.SecretChecked.Name = "SecretChecked";
            this.SecretChecked.Size = new System.Drawing.Size(106, 17);
            this.SecretChecked.TabIndex = 0;
            this.SecretChecked.Text = "Secret Password";
            this.SecretChecked.UseVisualStyleBackColor = true;
            this.SecretChecked.CheckedChanged += new System.EventHandler(this.SecretChecked_CheckedChanged);
            // 
            // Passwords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(202, 358);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Passwords";
            this.Text = "Passwords";
            this.Load += new System.EventHandler(this.Passwords_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ConsoleChecked;
        private System.Windows.Forms.TextBox ConsolePassText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox VtyChecked;
        private System.Windows.Forms.TextBox VtyPassText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox AuxChecked;
        private System.Windows.Forms.TextBox AuxPassText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox SecretPassText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox SecretChecked;
    }
}