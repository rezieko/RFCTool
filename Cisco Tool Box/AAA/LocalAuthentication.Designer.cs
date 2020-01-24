namespace Cisco_Tool_Box
{
    partial class LocalAAA
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
            this.DefaultChecked = new System.Windows.Forms.CheckBox();
            this.ListnameChecked = new System.Windows.Forms.CheckBox();
            this.ListnameText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MethodOneText = new System.Windows.Forms.TextBox();
            this.MethodTwoText = new System.Windows.Forms.TextBox();
            this.MethodThreeText = new System.Windows.Forms.TextBox();
            this.MethodFourText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxFailText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListnameText);
            this.groupBox1.Controls.Add(this.ListnameChecked);
            this.groupBox1.Controls.Add(this.DefaultChecked);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Type";
            // 
            // DefaultChecked
            // 
            this.DefaultChecked.AutoSize = true;
            this.DefaultChecked.Location = new System.Drawing.Point(7, 20);
            this.DefaultChecked.Name = "DefaultChecked";
            this.DefaultChecked.Size = new System.Drawing.Size(60, 17);
            this.DefaultChecked.TabIndex = 0;
            this.DefaultChecked.Text = "Default";
            this.DefaultChecked.UseVisualStyleBackColor = true;
            // 
            // ListnameChecked
            // 
            this.ListnameChecked.AutoSize = true;
            this.ListnameChecked.Location = new System.Drawing.Point(7, 44);
            this.ListnameChecked.Name = "ListnameChecked";
            this.ListnameChecked.Size = new System.Drawing.Size(71, 17);
            this.ListnameChecked.TabIndex = 1;
            this.ListnameChecked.Text = "List name";
            this.ListnameChecked.UseVisualStyleBackColor = true;
            this.ListnameChecked.CheckedChanged += new System.EventHandler(this.ListnameChecked_CheckedChanged);
            // 
            // ListnameText
            // 
            this.ListnameText.Location = new System.Drawing.Point(84, 42);
            this.ListnameText.Name = "ListnameText";
            this.ListnameText.Size = new System.Drawing.Size(100, 20);
            this.ListnameText.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MethodFourText);
            this.groupBox2.Controls.Add(this.MethodThreeText);
            this.groupBox2.Controls.Add(this.MethodTwoText);
            this.groupBox2.Controls.Add(this.MethodOneText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(13, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login Method";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Method 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Method 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Method 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Method 4";
            // 
            // MethodOneText
            // 
            this.MethodOneText.Location = new System.Drawing.Point(66, 17);
            this.MethodOneText.Name = "MethodOneText";
            this.MethodOneText.Size = new System.Drawing.Size(128, 20);
            this.MethodOneText.TabIndex = 4;
            // 
            // MethodTwoText
            // 
            this.MethodTwoText.Location = new System.Drawing.Point(66, 43);
            this.MethodTwoText.Name = "MethodTwoText";
            this.MethodTwoText.Size = new System.Drawing.Size(128, 20);
            this.MethodTwoText.TabIndex = 5;
            // 
            // MethodThreeText
            // 
            this.MethodThreeText.Location = new System.Drawing.Point(66, 69);
            this.MethodThreeText.Name = "MethodThreeText";
            this.MethodThreeText.Size = new System.Drawing.Size(128, 20);
            this.MethodThreeText.TabIndex = 6;
            // 
            // MethodFourText
            // 
            this.MethodFourText.Location = new System.Drawing.Point(66, 95);
            this.MethodFourText.Name = "MethodFourText";
            this.MethodFourText.Size = new System.Drawing.Size(128, 20);
            this.MethodFourText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Number of Max Failed Attempts";
            // 
            // MaxFailText
            // 
            this.MaxFailText.Location = new System.Drawing.Point(177, 258);
            this.MaxFailText.Name = "MaxFailText";
            this.MaxFailText.Size = new System.Drawing.Size(30, 20);
            this.MaxFailText.TabIndex = 4;
            // 
            // LocalAAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(222, 294);
            this.Controls.Add(this.MaxFailText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LocalAAA";
            this.Text = "LocalAAA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ListnameText;
        private System.Windows.Forms.CheckBox ListnameChecked;
        private System.Windows.Forms.CheckBox DefaultChecked;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox MethodFourText;
        private System.Windows.Forms.TextBox MethodThreeText;
        private System.Windows.Forms.TextBox MethodTwoText;
        private System.Windows.Forms.TextBox MethodOneText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MaxFailText;
    }
}