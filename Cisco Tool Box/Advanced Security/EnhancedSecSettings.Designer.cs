namespace Cisco_Tool_Box
{
    partial class EnhancedSecSettings
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
            this.MinPassLengthText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TimeoutSecsText = new System.Windows.Forms.TextBox();
            this.TimeoutMinsText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WithinSecsText = new System.Windows.Forms.TextBox();
            this.AttemptsText = new System.Windows.Forms.TextBox();
            this.BlockSecsText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ACLText = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DelaySecsText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ThresholdRateText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ThresholdChecked = new System.Windows.Forms.CheckBox();
            this.FailureLogChecked = new System.Windows.Forms.CheckBox();
            this.SuccessLogChecked = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MinPassLengthText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Minimum Password Length";
            // 
            // MinPassLengthText
            // 
            this.MinPassLengthText.Location = new System.Drawing.Point(54, 20);
            this.MinPassLengthText.Name = "MinPassLengthText";
            this.MinPassLengthText.Size = new System.Drawing.Size(109, 20);
            this.MinPassLengthText.TabIndex = 1;
            this.MinPassLengthText.TextChanged += new System.EventHandler(this.MinPassLengthText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TimeoutSecsText);
            this.groupBox2.Controls.Add(this.TimeoutMinsText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(13, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exec Timeout";
            // 
            // TimeoutSecsText
            // 
            this.TimeoutSecsText.Location = new System.Drawing.Point(63, 43);
            this.TimeoutSecsText.Name = "TimeoutSecsText";
            this.TimeoutSecsText.Size = new System.Drawing.Size(100, 20);
            this.TimeoutSecsText.TabIndex = 2;
            // 
            // TimeoutMinsText
            // 
            this.TimeoutMinsText.Location = new System.Drawing.Point(63, 17);
            this.TimeoutMinsText.Name = "TimeoutMinsText";
            this.TimeoutMinsText.Size = new System.Drawing.Size(100, 20);
            this.TimeoutMinsText.TabIndex = 2;
            this.TimeoutMinsText.TextChanged += new System.EventHandler(this.TimeoutMinsText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Minutes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.WithinSecsText);
            this.groupBox3.Controls.Add(this.AttemptsText);
            this.groupBox3.Controls.Add(this.BlockSecsText);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(13, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 103);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login Blocking";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Within Seconds";
            // 
            // WithinSecsText
            // 
            this.WithinSecsText.Location = new System.Drawing.Point(96, 69);
            this.WithinSecsText.Name = "WithinSecsText";
            this.WithinSecsText.Size = new System.Drawing.Size(67, 20);
            this.WithinSecsText.TabIndex = 1;
            // 
            // AttemptsText
            // 
            this.AttemptsText.Location = new System.Drawing.Point(73, 43);
            this.AttemptsText.Name = "AttemptsText";
            this.AttemptsText.Size = new System.Drawing.Size(90, 20);
            this.AttemptsText.TabIndex = 1;
            // 
            // BlockSecsText
            // 
            this.BlockSecsText.Location = new System.Drawing.Point(106, 17);
            this.BlockSecsText.Name = "BlockSecsText";
            this.BlockSecsText.Size = new System.Drawing.Size(57, 20);
            this.BlockSecsText.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "# Attempts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Blocking Seconds";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.ACLText);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(203, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 47);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Login Quiet Mode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ACL";
            // 
            // ACLText
            // 
            this.ACLText.Location = new System.Drawing.Point(44, 17);
            this.ACLText.Name = "ACLText";
            this.ACLText.Size = new System.Drawing.Size(119, 20);
            this.ACLText.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DelaySecsText);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(203, 234);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(173, 45);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Login Delay";
            // 
            // DelaySecsText
            // 
            this.DelaySecsText.Location = new System.Drawing.Point(62, 17);
            this.DelaySecsText.Name = "DelaySecsText";
            this.DelaySecsText.Size = new System.Drawing.Size(100, 20);
            this.DelaySecsText.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Seconds";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ThresholdRateText);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.ThresholdChecked);
            this.groupBox6.Controls.Add(this.FailureLogChecked);
            this.groupBox6.Controls.Add(this.SuccessLogChecked);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Location = new System.Drawing.Point(203, 43);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(279, 127);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Login Logs";
            // 
            // ThresholdRateText
            // 
            this.ThresholdRateText.Location = new System.Drawing.Point(96, 86);
            this.ThresholdRateText.Name = "ThresholdRateText";
            this.ThresholdRateText.Size = new System.Drawing.Size(100, 20);
            this.ThresholdRateText.TabIndex = 4;
            this.ThresholdRateText.TextChanged += new System.EventHandler(this.ThresholdRateText_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Threshold Rate";
            // 
            // ThresholdChecked
            // 
            this.ThresholdChecked.AutoSize = true;
            this.ThresholdChecked.Checked = true;
            this.ThresholdChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ThresholdChecked.Location = new System.Drawing.Point(10, 66);
            this.ThresholdChecked.Name = "ThresholdChecked";
            this.ThresholdChecked.Size = new System.Drawing.Size(266, 17);
            this.ThresholdChecked.TabIndex = 2;
            this.ThresholdChecked.Text = "All Messages when Failed Logins exceed threshold";
            this.ThresholdChecked.UseVisualStyleBackColor = true;
            this.ThresholdChecked.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FailureLogChecked
            // 
            this.FailureLogChecked.AutoSize = true;
            this.FailureLogChecked.Checked = true;
            this.FailureLogChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FailureLogChecked.Location = new System.Drawing.Point(10, 43);
            this.FailureLogChecked.Name = "FailureLogChecked";
            this.FailureLogChecked.Size = new System.Drawing.Size(57, 17);
            this.FailureLogChecked.TabIndex = 1;
            this.FailureLogChecked.Text = "Failure";
            this.FailureLogChecked.UseVisualStyleBackColor = true;
            // 
            // SuccessLogChecked
            // 
            this.SuccessLogChecked.AutoSize = true;
            this.SuccessLogChecked.Checked = true;
            this.SuccessLogChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SuccessLogChecked.Location = new System.Drawing.Point(10, 20);
            this.SuccessLogChecked.Name = "SuccessLogChecked";
            this.SuccessLogChecked.Size = new System.Drawing.Size(67, 17);
            this.SuccessLogChecked.TabIndex = 0;
            this.SuccessLogChecked.Text = "Success";
            this.SuccessLogChecked.UseVisualStyleBackColor = true;
            // 
            // EnhancedSecSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(499, 311);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EnhancedSecSettings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MinPassLengthText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TimeoutSecsText;
        private System.Windows.Forms.TextBox TimeoutMinsText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox AttemptsText;
        private System.Windows.Forms.TextBox BlockSecsText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox WithinSecsText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ACLText;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox DelaySecsText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox FailureLogChecked;
        private System.Windows.Forms.CheckBox SuccessLogChecked;
        private System.Windows.Forms.TextBox ThresholdRateText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ThresholdChecked;
    }
}