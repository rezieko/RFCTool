namespace Cisco_Tool_Box
{
    partial class ASADHCP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StartIpText = new System.Windows.Forms.TextBox();
            this.EndIpText = new System.Windows.Forms.TextBox();
            this.DNSText = new System.Windows.Forms.TextBox();
            this.DomainText = new System.Windows.Forms.TextBox();
            this.WINSText = new System.Windows.Forms.TextBox();
            this.LeaseText = new System.Windows.Forms.TextBox();
            this.OptionText = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start of Pool IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "End of Pool IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Domain Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DNS IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "WINS IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lease Seconds";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "DHCP Option";
            // 
            // StartIpText
            // 
            this.StartIpText.Location = new System.Drawing.Point(93, 41);
            this.StartIpText.Name = "StartIpText";
            this.StartIpText.Size = new System.Drawing.Size(100, 20);
            this.StartIpText.TabIndex = 8;
            // 
            // EndIpText
            // 
            this.EndIpText.Location = new System.Drawing.Point(93, 67);
            this.EndIpText.Name = "EndIpText";
            this.EndIpText.Size = new System.Drawing.Size(100, 20);
            this.EndIpText.TabIndex = 9;
            // 
            // DNSText
            // 
            this.DNSText.Location = new System.Drawing.Point(93, 119);
            this.DNSText.Name = "DNSText";
            this.DNSText.Size = new System.Drawing.Size(100, 20);
            this.DNSText.TabIndex = 10;
            // 
            // DomainText
            // 
            this.DomainText.Location = new System.Drawing.Point(93, 93);
            this.DomainText.Name = "DomainText";
            this.DomainText.Size = new System.Drawing.Size(100, 20);
            this.DomainText.TabIndex = 11;
            // 
            // WINSText
            // 
            this.WINSText.Location = new System.Drawing.Point(93, 145);
            this.WINSText.Name = "WINSText";
            this.WINSText.Size = new System.Drawing.Size(100, 20);
            this.WINSText.TabIndex = 12;
            // 
            // LeaseText
            // 
            this.LeaseText.Location = new System.Drawing.Point(93, 171);
            this.LeaseText.Name = "LeaseText";
            this.LeaseText.Size = new System.Drawing.Size(100, 20);
            this.LeaseText.TabIndex = 13;
            // 
            // OptionText
            // 
            this.OptionText.Location = new System.Drawing.Point(93, 197);
            this.OptionText.Name = "OptionText";
            this.OptionText.Size = new System.Drawing.Size(100, 20);
            this.OptionText.TabIndex = 14;
            // 
            // ASADHCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(201, 226);
            this.Controls.Add(this.OptionText);
            this.Controls.Add(this.LeaseText);
            this.Controls.Add(this.WINSText);
            this.Controls.Add(this.DomainText);
            this.Controls.Add(this.DNSText);
            this.Controls.Add(this.EndIpText);
            this.Controls.Add(this.StartIpText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ASADHCP";
            this.Text = "ASADHCP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StartIpText;
        private System.Windows.Forms.TextBox EndIpText;
        private System.Windows.Forms.TextBox DNSText;
        private System.Windows.Forms.TextBox DomainText;
        private System.Windows.Forms.TextBox WINSText;
        private System.Windows.Forms.TextBox LeaseText;
        private System.Windows.Forms.TextBox OptionText;
    }
}