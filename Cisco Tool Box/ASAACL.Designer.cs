namespace Cisco_Tool_Box
{
    partial class ASAACL
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
            this.label1 = new System.Windows.Forms.Label();
            this.ApplyIntChecked = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PerUser1Checked = new System.Windows.Forms.CheckBox();
            this.ControlPlane1Checked = new System.Windows.Forms.CheckBox();
            this.Acl1Text = new System.Windows.Forms.TextBox();
            this.Int1Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PerUser2Checked = new System.Windows.Forms.CheckBox();
            this.ControlPlane2Checked = new System.Windows.Forms.CheckBox();
            this.Acl2Text = new System.Windows.Forms.TextBox();
            this.Int2Text = new System.Windows.Forms.TextBox();
            this.NumControls = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumControls)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Int2Text);
            this.groupBox1.Controls.Add(this.Int1Text);
            this.groupBox1.Controls.Add(this.Acl2Text);
            this.groupBox1.Controls.Add(this.Acl1Text);
            this.groupBox1.Controls.Add(this.ControlPlane2Checked);
            this.groupBox1.Controls.Add(this.PerUser2Checked);
            this.groupBox1.Controls.Add(this.ControlPlane1Checked);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PerUser1Checked);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ApplyIntChecked);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apply to Interface";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACL ID";
            // 
            // ApplyIntChecked
            // 
            this.ApplyIntChecked.AutoSize = true;
            this.ApplyIntChecked.Location = new System.Drawing.Point(7, 20);
            this.ApplyIntChecked.Name = "ApplyIntChecked";
            this.ApplyIntChecked.Size = new System.Drawing.Size(109, 17);
            this.ApplyIntChecked.TabIndex = 1;
            this.ApplyIntChecked.Text = "Apply to Interface";
            this.ApplyIntChecked.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interface ID";
            // 
            // PerUser1Checked
            // 
            this.PerUser1Checked.AutoSize = true;
            this.PerUser1Checked.Location = new System.Drawing.Point(187, 43);
            this.PerUser1Checked.Name = "PerUser1Checked";
            this.PerUser1Checked.Size = new System.Drawing.Size(146, 17);
            this.PerUser1Checked.TabIndex = 3;
            this.PerUser1Checked.Text = "Enable Per User Override";
            this.PerUser1Checked.UseVisualStyleBackColor = true;
            this.PerUser1Checked.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ControlPlane1Checked
            // 
            this.ControlPlane1Checked.AutoSize = true;
            this.ControlPlane1Checked.Location = new System.Drawing.Point(187, 70);
            this.ControlPlane1Checked.Name = "ControlPlane1Checked";
            this.ControlPlane1Checked.Size = new System.Drawing.Size(111, 17);
            this.ControlPlane1Checked.TabIndex = 4;
            this.ControlPlane1Checked.Text = "Use Control Plane";
            this.ControlPlane1Checked.UseVisualStyleBackColor = true;
            // 
            // Acl1Text
            // 
            this.Acl1Text.Location = new System.Drawing.Point(81, 40);
            this.Acl1Text.Name = "Acl1Text";
            this.Acl1Text.Size = new System.Drawing.Size(100, 20);
            this.Acl1Text.TabIndex = 5;
            // 
            // Int1Text
            // 
            this.Int1Text.Location = new System.Drawing.Point(81, 67);
            this.Int1Text.Name = "Int1Text";
            this.Int1Text.Size = new System.Drawing.Size(100, 20);
            this.Int1Text.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ACL ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Interface ID";
            // 
            // PerUser2Checked
            // 
            this.PerUser2Checked.AutoSize = true;
            this.PerUser2Checked.Location = new System.Drawing.Point(187, 96);
            this.PerUser2Checked.Name = "PerUser2Checked";
            this.PerUser2Checked.Size = new System.Drawing.Size(146, 17);
            this.PerUser2Checked.TabIndex = 3;
            this.PerUser2Checked.Text = "Enable Per User Override";
            this.PerUser2Checked.UseVisualStyleBackColor = true;
            this.PerUser2Checked.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ControlPlane2Checked
            // 
            this.ControlPlane2Checked.AutoSize = true;
            this.ControlPlane2Checked.Location = new System.Drawing.Point(187, 123);
            this.ControlPlane2Checked.Name = "ControlPlane2Checked";
            this.ControlPlane2Checked.Size = new System.Drawing.Size(111, 17);
            this.ControlPlane2Checked.TabIndex = 4;
            this.ControlPlane2Checked.Text = "Use Control Plane";
            this.ControlPlane2Checked.UseVisualStyleBackColor = true;
            // 
            // Acl2Text
            // 
            this.Acl2Text.Location = new System.Drawing.Point(81, 93);
            this.Acl2Text.Name = "Acl2Text";
            this.Acl2Text.Size = new System.Drawing.Size(100, 20);
            this.Acl2Text.TabIndex = 5;
            // 
            // Int2Text
            // 
            this.Int2Text.Location = new System.Drawing.Point(81, 120);
            this.Int2Text.Name = "Int2Text";
            this.Int2Text.Size = new System.Drawing.Size(100, 20);
            this.Int2Text.TabIndex = 6;
            // 
            // NumControls
            // 
            this.NumControls.Location = new System.Drawing.Point(94, 198);
            this.NumControls.Name = "NumControls";
            this.NumControls.Size = new System.Drawing.Size(35, 20);
            this.NumControls.TabIndex = 2;
            this.NumControls.ValueChanged += new System.EventHandler(this.NumControls_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "# of ACLs";
            // 
            // BoxPanel
            // 
            this.BoxPanel.Location = new System.Drawing.Point(13, 224);
            this.BoxPanel.Name = "BoxPanel";
            this.BoxPanel.Size = new System.Drawing.Size(200, 100);
            this.BoxPanel.TabIndex = 4;
            // 
            // ASAACL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.BoxPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumControls);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ASAACL";
            this.Text = "ASA ACL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumControls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Acl1Text;
        private System.Windows.Forms.CheckBox ControlPlane1Checked;
        private System.Windows.Forms.CheckBox PerUser1Checked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ApplyIntChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Int2Text;
        private System.Windows.Forms.TextBox Int1Text;
        private System.Windows.Forms.TextBox Acl2Text;
        private System.Windows.Forms.CheckBox ControlPlane2Checked;
        private System.Windows.Forms.CheckBox PerUser2Checked;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumControls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel BoxPanel;
    }
}