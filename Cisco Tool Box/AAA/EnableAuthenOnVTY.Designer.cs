namespace Cisco_Tool_Box
{
    partial class EnableAuthenOnVTY
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
            this.DefaultChecked = new System.Windows.Forms.CheckBox();
            this.ListnameChecked = new System.Windows.Forms.CheckBox();
            this.ListnameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DefaultChecked
            // 
            this.DefaultChecked.AutoSize = true;
            this.DefaultChecked.Location = new System.Drawing.Point(13, 43);
            this.DefaultChecked.Name = "DefaultChecked";
            this.DefaultChecked.Size = new System.Drawing.Size(60, 17);
            this.DefaultChecked.TabIndex = 1;
            this.DefaultChecked.Text = "Default";
            this.DefaultChecked.UseVisualStyleBackColor = true;
            // 
            // ListnameChecked
            // 
            this.ListnameChecked.AutoSize = true;
            this.ListnameChecked.Location = new System.Drawing.Point(13, 67);
            this.ListnameChecked.Name = "ListnameChecked";
            this.ListnameChecked.Size = new System.Drawing.Size(68, 17);
            this.ListnameChecked.TabIndex = 2;
            this.ListnameChecked.Text = "Listname";
            this.ListnameChecked.UseVisualStyleBackColor = true;
            // 
            // ListnameText
            // 
            this.ListnameText.Location = new System.Drawing.Point(87, 65);
            this.ListnameText.Name = "ListnameText";
            this.ListnameText.Size = new System.Drawing.Size(100, 20);
            this.ListnameText.TabIndex = 3;
            this.ListnameText.TextChanged += new System.EventHandler(this.ListnameText_TextChanged);
            // 
            // EnableAuthenOnVTY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(199, 99);
            this.Controls.Add(this.ListnameText);
            this.Controls.Add(this.ListnameChecked);
            this.Controls.Add(this.DefaultChecked);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EnableAuthenOnVTY";
            this.Text = "Enable Authentiocation On VTY lines";
            this.Load += new System.EventHandler(this.EnableAuthenOnVTY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox DefaultChecked;
        private System.Windows.Forms.CheckBox ListnameChecked;
        private System.Windows.Forms.TextBox ListnameText;
    }
}