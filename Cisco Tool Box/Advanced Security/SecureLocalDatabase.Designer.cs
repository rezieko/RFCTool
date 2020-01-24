namespace Cisco_Tool_Box
{
    partial class SecureLocalDatabase
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
            this.ConsoleChecked = new System.Windows.Forms.CheckBox();
            this.VtyChecked = new System.Windows.Forms.CheckBox();
            this.AuxChecked = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PassTypeCombo = new System.Windows.Forms.ComboBox();
            this.UserText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsoleChecked
            // 
            this.ConsoleChecked.AutoSize = true;
            this.ConsoleChecked.Checked = true;
            this.ConsoleChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConsoleChecked.Location = new System.Drawing.Point(13, 149);
            this.ConsoleChecked.Name = "ConsoleChecked";
            this.ConsoleChecked.Size = new System.Drawing.Size(90, 17);
            this.ConsoleChecked.TabIndex = 1;
            this.ConsoleChecked.Text = "Line Console ";
            this.ConsoleChecked.UseVisualStyleBackColor = true;
            // 
            // VtyChecked
            // 
            this.VtyChecked.AutoSize = true;
            this.VtyChecked.Checked = true;
            this.VtyChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VtyChecked.Location = new System.Drawing.Point(14, 195);
            this.VtyChecked.Name = "VtyChecked";
            this.VtyChecked.Size = new System.Drawing.Size(70, 17);
            this.VtyChecked.TabIndex = 1;
            this.VtyChecked.Text = "Line VTY";
            this.VtyChecked.UseVisualStyleBackColor = true;
            // 
            // AuxChecked
            // 
            this.AuxChecked.AutoSize = true;
            this.AuxChecked.Checked = true;
            this.AuxChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AuxChecked.Location = new System.Drawing.Point(13, 172);
            this.AuxChecked.Name = "AuxChecked";
            this.AuxChecked.Size = new System.Drawing.Size(71, 17);
            this.AuxChecked.TabIndex = 1;
            this.AuxChecked.Text = "Line AUX";
            this.AuxChecked.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PassTypeCombo);
            this.groupBox1.Controls.Add(this.PassText);
            this.groupBox1.Controls.Add(this.UserText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // PassTypeCombo
            // 
            this.PassTypeCombo.FormattingEnabled = true;
            this.PassTypeCombo.Items.AddRange(new object[] {
            "password",
            "secret"});
            this.PassTypeCombo.Location = new System.Drawing.Point(68, 39);
            this.PassTypeCombo.Name = "PassTypeCombo";
            this.PassTypeCombo.Size = new System.Drawing.Size(100, 21);
            this.PassTypeCombo.TabIndex = 2;
            this.PassTypeCombo.Text = "Password Type";
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(68, 13);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(100, 20);
            this.UserText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(68, 65);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(100, 20);
            this.PassText.TabIndex = 1;
            // 
            // SecureLocalDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(200, 223);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AuxChecked);
            this.Controls.Add(this.VtyChecked);
            this.Controls.Add(this.ConsoleChecked);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SecureLocalDatabase";
            this.Text = "Secure Local Database";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ConsoleChecked;
        private System.Windows.Forms.CheckBox VtyChecked;
        private System.Windows.Forms.CheckBox AuxChecked;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox PassTypeCombo;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassText;
    }
}