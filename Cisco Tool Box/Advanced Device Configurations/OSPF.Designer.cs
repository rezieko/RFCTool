namespace Cisco_Tool_Box
{
    partial class OSPF
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
            this.ProcessIDText = new System.Windows.Forms.TextBox();
            this.RouterIDChecked = new System.Windows.Forms.CheckBox();
            this.RouterIDText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassiveIntCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InterfaceText = new System.Windows.Forms.TextBox();
            this.BoxPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NumNetworks = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumNetworks)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProcessIDText
            // 
            this.ProcessIDText.Location = new System.Drawing.Point(77, 40);
            this.ProcessIDText.Name = "ProcessIDText";
            this.ProcessIDText.Size = new System.Drawing.Size(100, 20);
            this.ProcessIDText.TabIndex = 3;
            this.ProcessIDText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RouterIDChecked
            // 
            this.RouterIDChecked.AutoSize = true;
            this.RouterIDChecked.Checked = true;
            this.RouterIDChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RouterIDChecked.Location = new System.Drawing.Point(12, 66);
            this.RouterIDChecked.Name = "RouterIDChecked";
            this.RouterIDChecked.Size = new System.Drawing.Size(72, 17);
            this.RouterIDChecked.TabIndex = 8;
            this.RouterIDChecked.Text = "Router ID";
            this.RouterIDChecked.UseVisualStyleBackColor = true;
            this.RouterIDChecked.CheckedChanged += new System.EventHandler(this.RouterIDChecked_CheckedChanged);
            // 
            // RouterIDText
            // 
            this.RouterIDText.Location = new System.Drawing.Point(155, 64);
            this.RouterIDText.Name = "RouterIDText";
            this.RouterIDText.Size = new System.Drawing.Size(100, 20);
            this.RouterIDText.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Router ID";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // PassiveIntCheck
            // 
            this.PassiveIntCheck.AutoSize = true;
            this.PassiveIntCheck.Checked = true;
            this.PassiveIntCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PassiveIntCheck.Location = new System.Drawing.Point(12, 89);
            this.PassiveIntCheck.Name = "PassiveIntCheck";
            this.PassiveIntCheck.Size = new System.Drawing.Size(108, 17);
            this.PassiveIntCheck.TabIndex = 4;
            this.PassiveIntCheck.Text = "Passive Interface";
            this.PassiveIntCheck.UseVisualStyleBackColor = true;
            this.PassiveIntCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interface";
            // 
            // InterfaceText
            // 
            this.InterfaceText.Location = new System.Drawing.Point(183, 87);
            this.InterfaceText.Name = "InterfaceText";
            this.InterfaceText.Size = new System.Drawing.Size(100, 20);
            this.InterfaceText.TabIndex = 5;
            // 
            // BoxPanel
            // 
            this.BoxPanel.AutoSize = true;
            this.BoxPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BoxPanel.Location = new System.Drawing.Point(15, 129);
            this.BoxPanel.Name = "BoxPanel";
            this.BoxPanel.Size = new System.Drawing.Size(0, 0);
            this.BoxPanel.TabIndex = 10;
            // 
            // NumNetworks
            // 
            this.NumNetworks.Location = new System.Drawing.Point(93, 112);
            this.NumNetworks.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NumNetworks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumNetworks.Name = "NumNetworks";
            this.NumNetworks.Size = new System.Drawing.Size(41, 20);
            this.NumNetworks.TabIndex = 11;
            this.NumNetworks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumNetworks.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "# of Networks";
            // 
            // OSPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(296, 146);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumNetworks);
            this.Controls.Add(this.BoxPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InterfaceText);
            this.Controls.Add(this.RouterIDText);
            this.Controls.Add(this.RouterIDChecked);
            this.Controls.Add(this.PassiveIntCheck);
            this.Controls.Add(this.ProcessIDText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OSPF";
            this.Text = "OSPF";
            this.Load += new System.EventHandler(this.OSPF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumNetworks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProcessIDText;
        private System.Windows.Forms.CheckBox RouterIDChecked;
        private System.Windows.Forms.TextBox RouterIDText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox PassiveIntCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InterfaceText;
        private System.Windows.Forms.FlowLayoutPanel BoxPanel;
        private System.Windows.Forms.NumericUpDown NumNetworks;
        private System.Windows.Forms.Label label4;
    }
}