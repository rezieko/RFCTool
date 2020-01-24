namespace Cisco_Tool_Box
{
    partial class BasicConfig
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
            this.HostnameText = new System.Windows.Forms.TextBox();
            this.EnableSecretChecked = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnableSecretText = new System.Windows.Forms.TextBox();
            this.LineConsoleChecked = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LineConsoleText = new System.Windows.Forms.TextBox();
            this.LineVTYChecked = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LineVTYPassText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy To Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hostname";
            // 
            // HostnameText
            // 
            this.HostnameText.Location = new System.Drawing.Point(73, 39);
            this.HostnameText.Name = "HostnameText";
            this.HostnameText.Size = new System.Drawing.Size(100, 20);
            this.HostnameText.TabIndex = 2;
            this.HostnameText.TextChanged += new System.EventHandler(this.HostnameText_TextChanged);
            // 
            // EnableSecretChecked
            // 
            this.EnableSecretChecked.AutoSize = true;
            this.EnableSecretChecked.Checked = true;
            this.EnableSecretChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableSecretChecked.Location = new System.Drawing.Point(12, 70);
            this.EnableSecretChecked.Name = "EnableSecretChecked";
            this.EnableSecretChecked.Size = new System.Drawing.Size(93, 17);
            this.EnableSecretChecked.TabIndex = 3;
            this.EnableSecretChecked.Text = "Enable Secret";
            this.EnableSecretChecked.UseVisualStyleBackColor = true;
            this.EnableSecretChecked.CheckedChanged += new System.EventHandler(this.EnableSecretChecked_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // EnableSecretText
            // 
            this.EnableSecretText.Location = new System.Drawing.Point(170, 68);
            this.EnableSecretText.Name = "EnableSecretText";
            this.EnableSecretText.Size = new System.Drawing.Size(100, 20);
            this.EnableSecretText.TabIndex = 2;
            this.EnableSecretText.TextChanged += new System.EventHandler(this.HostnameText_TextChanged);
            // 
            // LineConsoleChecked
            // 
            this.LineConsoleChecked.AutoSize = true;
            this.LineConsoleChecked.Checked = true;
            this.LineConsoleChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LineConsoleChecked.Location = new System.Drawing.Point(12, 97);
            this.LineConsoleChecked.Name = "LineConsoleChecked";
            this.LineConsoleChecked.Size = new System.Drawing.Size(136, 17);
            this.LineConsoleChecked.TabIndex = 5;
            this.LineConsoleChecked.Text = "Line Console Password";
            this.LineConsoleChecked.UseVisualStyleBackColor = true;
            this.LineConsoleChecked.CheckedChanged += new System.EventHandler(this.LineConsoleChecked_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LineConsoleText
            // 
            this.LineConsoleText.Location = new System.Drawing.Point(213, 95);
            this.LineConsoleText.Name = "LineConsoleText";
            this.LineConsoleText.Size = new System.Drawing.Size(100, 20);
            this.LineConsoleText.TabIndex = 7;
            // 
            // LineVTYChecked
            // 
            this.LineVTYChecked.AutoSize = true;
            this.LineVTYChecked.Checked = true;
            this.LineVTYChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LineVTYChecked.Location = new System.Drawing.Point(12, 125);
            this.LineVTYChecked.Name = "LineVTYChecked";
            this.LineVTYChecked.Size = new System.Drawing.Size(119, 17);
            this.LineVTYChecked.TabIndex = 8;
            this.LineVTYChecked.Text = "Line VTY Password";
            this.LineVTYChecked.UseVisualStyleBackColor = true;
            this.LineVTYChecked.CheckedChanged += new System.EventHandler(this.LineVTYChecked_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // LineVTYPassText
            // 
            this.LineVTYPassText.Location = new System.Drawing.Point(196, 123);
            this.LineVTYPassText.Name = "LineVTYPassText";
            this.LineVTYPassText.Size = new System.Drawing.Size(100, 20);
            this.LineVTYPassText.TabIndex = 9;
            // 
            // BasicConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(334, 163);
            this.Controls.Add(this.LineVTYPassText);
            this.Controls.Add(this.LineVTYChecked);
            this.Controls.Add(this.LineConsoleText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LineConsoleChecked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnableSecretChecked);
            this.Controls.Add(this.EnableSecretText);
            this.Controls.Add(this.HostnameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BasicConfig";
            this.Text = "Basic Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HostnameText;
        private System.Windows.Forms.CheckBox EnableSecretChecked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnableSecretText;
        private System.Windows.Forms.CheckBox LineConsoleChecked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LineConsoleText;
        private System.Windows.Forms.CheckBox LineVTYChecked;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LineVTYPassText;
    }
}