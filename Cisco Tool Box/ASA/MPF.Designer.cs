namespace Cisco_Tool_Box
{
    partial class MPF
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
            this.ClassMapChecked = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassDescText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AnyChecked = new System.Windows.Forms.CheckBox();
            this.AclChecked = new System.Windows.Forms.CheckBox();
            this.AclText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PolicyMapChecked = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PolicyNameText = new System.Windows.Forms.TextBox();
            this.ConnectionChecked = new System.Windows.Forms.CheckBox();
            this.InspectChecked = new System.Windows.Forms.CheckBox();
            this.PoliceChecked = new System.Windows.Forms.CheckBox();
            this.ConnectionText = new System.Windows.Forms.TextBox();
            this.InspectText = new System.Windows.Forms.TextBox();
            this.PoliceText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ServiceChecked = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PolicyDescText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PolClassText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ServPolNameText = new System.Windows.Forms.TextBox();
            this.GlobalChecked = new System.Windows.Forms.CheckBox();
            this.IntChecked = new System.Windows.Forms.CheckBox();
            this.IntText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AclText);
            this.groupBox1.Controls.Add(this.AclChecked);
            this.groupBox1.Controls.Add(this.AnyChecked);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ClassDescText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ClassNameText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ClassMapChecked);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Map";
            // 
            // ClassMapChecked
            // 
            this.ClassMapChecked.AutoSize = true;
            this.ClassMapChecked.Checked = true;
            this.ClassMapChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ClassMapChecked.Location = new System.Drawing.Point(7, 20);
            this.ClassMapChecked.Name = "ClassMapChecked";
            this.ClassMapChecked.Size = new System.Drawing.Size(123, 17);
            this.ClassMapChecked.TabIndex = 0;
            this.ClassMapChecked.Text = "Configure Class Map";
            this.ClassMapChecked.UseVisualStyleBackColor = true;
            this.ClassMapChecked.CheckedChanged += new System.EventHandler(this.ClassMapChecked_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Map Name";
            // 
            // ClassNameText
            // 
            this.ClassNameText.Location = new System.Drawing.Point(99, 44);
            this.ClassNameText.Name = "ClassNameText";
            this.ClassNameText.Size = new System.Drawing.Size(100, 20);
            this.ClassNameText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // ClassDescText
            // 
            this.ClassDescText.Location = new System.Drawing.Point(99, 70);
            this.ClassDescText.Name = "ClassDescText";
            this.ClassDescText.Size = new System.Drawing.Size(100, 20);
            this.ClassDescText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Match Type";
            // 
            // AnyChecked
            // 
            this.AnyChecked.AutoSize = true;
            this.AnyChecked.Location = new System.Drawing.Point(99, 99);
            this.AnyChecked.Name = "AnyChecked";
            this.AnyChecked.Size = new System.Drawing.Size(44, 17);
            this.AnyChecked.TabIndex = 6;
            this.AnyChecked.Text = "Any";
            this.AnyChecked.UseVisualStyleBackColor = true;
            this.AnyChecked.CheckedChanged += new System.EventHandler(this.AnyChecked_CheckedChanged);
            // 
            // AclChecked
            // 
            this.AclChecked.AutoSize = true;
            this.AclChecked.Checked = true;
            this.AclChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AclChecked.Location = new System.Drawing.Point(99, 122);
            this.AclChecked.Name = "AclChecked";
            this.AclChecked.Size = new System.Drawing.Size(80, 17);
            this.AclChecked.TabIndex = 7;
            this.AclChecked.Text = "Access List";
            this.AclChecked.UseVisualStyleBackColor = true;
            this.AclChecked.CheckedChanged += new System.EventHandler(this.AclChecked_CheckedChanged);
            // 
            // AclText
            // 
            this.AclText.Location = new System.Drawing.Point(185, 120);
            this.AclText.Name = "AclText";
            this.AclText.Size = new System.Drawing.Size(100, 20);
            this.AclText.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PolClassText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PolicyDescText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PoliceText);
            this.groupBox2.Controls.Add(this.InspectText);
            this.groupBox2.Controls.Add(this.ConnectionText);
            this.groupBox2.Controls.Add(this.PoliceChecked);
            this.groupBox2.Controls.Add(this.InspectChecked);
            this.groupBox2.Controls.Add(this.ConnectionChecked);
            this.groupBox2.Controls.Add(this.PolicyNameText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PolicyMapChecked);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(13, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 203);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Policy Map";
            // 
            // PolicyMapChecked
            // 
            this.PolicyMapChecked.AutoSize = true;
            this.PolicyMapChecked.Checked = true;
            this.PolicyMapChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PolicyMapChecked.Location = new System.Drawing.Point(7, 19);
            this.PolicyMapChecked.Name = "PolicyMapChecked";
            this.PolicyMapChecked.Size = new System.Drawing.Size(126, 17);
            this.PolicyMapChecked.TabIndex = 0;
            this.PolicyMapChecked.Text = "Configure Policy Map";
            this.PolicyMapChecked.UseVisualStyleBackColor = true;
            this.PolicyMapChecked.CheckedChanged += new System.EventHandler(this.PolicyMapChecked_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Policy Map Name";
            // 
            // PolicyNameText
            // 
            this.PolicyNameText.Location = new System.Drawing.Point(102, 41);
            this.PolicyNameText.Name = "PolicyNameText";
            this.PolicyNameText.Size = new System.Drawing.Size(100, 20);
            this.PolicyNameText.TabIndex = 2;
            // 
            // ConnectionChecked
            // 
            this.ConnectionChecked.AutoSize = true;
            this.ConnectionChecked.Checked = true;
            this.ConnectionChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConnectionChecked.Location = new System.Drawing.Point(9, 121);
            this.ConnectionChecked.Name = "ConnectionChecked";
            this.ConnectionChecked.Size = new System.Drawing.Size(99, 17);
            this.ConnectionChecked.TabIndex = 3;
            this.ConnectionChecked.Text = "Set Connection";
            this.ConnectionChecked.UseVisualStyleBackColor = true;
            this.ConnectionChecked.CheckedChanged += new System.EventHandler(this.ConnectionChecked_CheckedChanged);
            // 
            // InspectChecked
            // 
            this.InspectChecked.AutoSize = true;
            this.InspectChecked.Checked = true;
            this.InspectChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InspectChecked.Location = new System.Drawing.Point(9, 148);
            this.InspectChecked.Name = "InspectChecked";
            this.InspectChecked.Size = new System.Drawing.Size(61, 17);
            this.InspectChecked.TabIndex = 4;
            this.InspectChecked.Text = "Inspect";
            this.InspectChecked.UseVisualStyleBackColor = true;
            this.InspectChecked.CheckedChanged += new System.EventHandler(this.InspectChecked_CheckedChanged);
            // 
            // PoliceChecked
            // 
            this.PoliceChecked.AutoSize = true;
            this.PoliceChecked.Checked = true;
            this.PoliceChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PoliceChecked.Location = new System.Drawing.Point(9, 176);
            this.PoliceChecked.Name = "PoliceChecked";
            this.PoliceChecked.Size = new System.Drawing.Size(55, 17);
            this.PoliceChecked.TabIndex = 5;
            this.PoliceChecked.Text = "Police";
            this.PoliceChecked.UseVisualStyleBackColor = true;
            this.PoliceChecked.CheckedChanged += new System.EventHandler(this.PoliceChecked_CheckedChanged);
            // 
            // ConnectionText
            // 
            this.ConnectionText.Location = new System.Drawing.Point(114, 119);
            this.ConnectionText.Name = "ConnectionText";
            this.ConnectionText.Size = new System.Drawing.Size(171, 20);
            this.ConnectionText.TabIndex = 6;
            // 
            // InspectText
            // 
            this.InspectText.Location = new System.Drawing.Point(114, 145);
            this.InspectText.Name = "InspectText";
            this.InspectText.Size = new System.Drawing.Size(171, 20);
            this.InspectText.TabIndex = 7;
            // 
            // PoliceText
            // 
            this.PoliceText.Location = new System.Drawing.Point(114, 171);
            this.PoliceText.Name = "PoliceText";
            this.PoliceText.Size = new System.Drawing.Size(171, 20);
            this.PoliceText.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.IntText);
            this.groupBox3.Controls.Add(this.IntChecked);
            this.groupBox3.Controls.Add(this.GlobalChecked);
            this.groupBox3.Controls.Add(this.ServPolNameText);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ServiceChecked);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(314, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 126);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Service Policy";
            // 
            // ServiceChecked
            // 
            this.ServiceChecked.AutoSize = true;
            this.ServiceChecked.Checked = true;
            this.ServiceChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ServiceChecked.Location = new System.Drawing.Point(7, 20);
            this.ServiceChecked.Name = "ServiceChecked";
            this.ServiceChecked.Size = new System.Drawing.Size(141, 17);
            this.ServiceChecked.TabIndex = 0;
            this.ServiceChecked.Text = "Configure Service Policy";
            this.ServiceChecked.UseVisualStyleBackColor = true;
            this.ServiceChecked.CheckedChanged += new System.EventHandler(this.ServiceChecked_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // PolicyDescText
            // 
            this.PolicyDescText.Location = new System.Drawing.Point(102, 67);
            this.PolicyDescText.Name = "PolicyDescText";
            this.PolicyDescText.Size = new System.Drawing.Size(100, 20);
            this.PolicyDescText.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Class Map Name";
            // 
            // PolClassText
            // 
            this.PolClassText.Location = new System.Drawing.Point(102, 93);
            this.PolClassText.Name = "PolClassText";
            this.PolClassText.Size = new System.Drawing.Size(100, 20);
            this.PolClassText.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Policy Map Name";
            // 
            // ServPolNameText
            // 
            this.ServPolNameText.Location = new System.Drawing.Point(103, 43);
            this.ServPolNameText.Name = "ServPolNameText";
            this.ServPolNameText.Size = new System.Drawing.Size(100, 20);
            this.ServPolNameText.TabIndex = 2;
            // 
            // GlobalChecked
            // 
            this.GlobalChecked.AutoSize = true;
            this.GlobalChecked.Location = new System.Drawing.Point(7, 69);
            this.GlobalChecked.Name = "GlobalChecked";
            this.GlobalChecked.Size = new System.Drawing.Size(59, 17);
            this.GlobalChecked.TabIndex = 3;
            this.GlobalChecked.Text = "Global ";
            this.GlobalChecked.UseVisualStyleBackColor = true;
            // 
            // IntChecked
            // 
            this.IntChecked.AutoSize = true;
            this.IntChecked.Checked = true;
            this.IntChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IntChecked.Location = new System.Drawing.Point(7, 92);
            this.IntChecked.Name = "IntChecked";
            this.IntChecked.Size = new System.Drawing.Size(68, 17);
            this.IntChecked.TabIndex = 4;
            this.IntChecked.Text = "Interface";
            this.IntChecked.UseVisualStyleBackColor = true;
            this.IntChecked.CheckedChanged += new System.EventHandler(this.IntChecked_CheckedChanged);
            // 
            // IntText
            // 
            this.IntText.Location = new System.Drawing.Point(81, 90);
            this.IntText.Name = "IntText";
            this.IntText.Size = new System.Drawing.Size(100, 20);
            this.IntText.TabIndex = 5;
            // 
            // MPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(543, 415);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MPF";
            this.Text = "MPF";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ClassNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ClassMapChecked;
        private System.Windows.Forms.TextBox ClassDescText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AclText;
        private System.Windows.Forms.CheckBox AclChecked;
        private System.Windows.Forms.CheckBox AnyChecked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox PolicyMapChecked;
        private System.Windows.Forms.TextBox PolicyNameText;
        private System.Windows.Forms.TextBox PoliceText;
        private System.Windows.Forms.TextBox InspectText;
        private System.Windows.Forms.TextBox ConnectionText;
        private System.Windows.Forms.CheckBox PoliceChecked;
        private System.Windows.Forms.CheckBox InspectChecked;
        private System.Windows.Forms.CheckBox ConnectionChecked;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ServiceChecked;
        private System.Windows.Forms.TextBox PolicyDescText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PolClassText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ServPolNameText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IntText;
        private System.Windows.Forms.CheckBox IntChecked;
        private System.Windows.Forms.CheckBox GlobalChecked;
    }
}