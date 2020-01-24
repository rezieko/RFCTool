namespace Cisco_Tool_Box
{
    partial class TransformSet
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
            this.NameText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Transform1Text = new System.Windows.Forms.TextBox();
            this.Transform2Text = new System.Windows.Forms.TextBox();
            this.Transform3Text = new System.Windows.Forms.TextBox();
            this.Transform4Text = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transform Set Name";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(123, 42);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Transform1Text);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Transform2Text);
            this.groupBox1.Controls.Add(this.Transform3Text);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Transform4Text);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(16, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transform";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Transform 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trasnform 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Transform 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Transform 4";
            // 
            // Transform1Text
            // 
            this.Transform1Text.Location = new System.Drawing.Point(75, 13);
            this.Transform1Text.Name = "Transform1Text";
            this.Transform1Text.Size = new System.Drawing.Size(100, 20);
            this.Transform1Text.TabIndex = 4;
            // 
            // Transform2Text
            // 
            this.Transform2Text.Location = new System.Drawing.Point(75, 37);
            this.Transform2Text.Name = "Transform2Text";
            this.Transform2Text.Size = new System.Drawing.Size(100, 20);
            this.Transform2Text.TabIndex = 5;
            // 
            // Transform3Text
            // 
            this.Transform3Text.Location = new System.Drawing.Point(75, 63);
            this.Transform3Text.Name = "Transform3Text";
            this.Transform3Text.Size = new System.Drawing.Size(100, 20);
            this.Transform3Text.TabIndex = 6;
            // 
            // Transform4Text
            // 
            this.Transform4Text.Location = new System.Drawing.Point(75, 89);
            this.Transform4Text.Name = "Transform4Text";
            this.Transform4Text.Size = new System.Drawing.Size(100, 20);
            this.Transform4Text.TabIndex = 7;
            // 
            // TransformSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(230, 195);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransformSet";
            this.Text = "TransformSet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Transform1Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Transform2Text;
        private System.Windows.Forms.TextBox Transform3Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Transform4Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}