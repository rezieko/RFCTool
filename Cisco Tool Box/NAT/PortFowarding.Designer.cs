namespace Cisco_Tool_Box
{
    partial class PortFowarding
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
            this.ProtocolCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LocalAdrText = new System.Windows.Forms.TextBox();
            this.LocalPortText = new System.Windows.Forms.TextBox();
            this.GlobalAdrText = new System.Windows.Forms.TextBox();
            this.GlobalPortText = new System.Windows.Forms.TextBox();
            this.ExtendableChecked = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumInterfaces = new System.Windows.Forms.NumericUpDown();
            this.InterfacesPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.NumInterfaces)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TCP | UDP";
            // 
            // ProtocolCombo
            // 
            this.ProtocolCombo.FormattingEnabled = true;
            this.ProtocolCombo.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.ProtocolCombo.Location = new System.Drawing.Point(78, 42);
            this.ProtocolCombo.Name = "ProtocolCombo";
            this.ProtocolCombo.Size = new System.Drawing.Size(48, 21);
            this.ProtocolCombo.TabIndex = 2;
            this.ProtocolCombo.SelectedIndexChanged += new System.EventHandler(this.ProtocolCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Global IP Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Global Port";
            // 
            // LocalAdrText
            // 
            this.LocalAdrText.Location = new System.Drawing.Point(119, 69);
            this.LocalAdrText.Name = "LocalAdrText";
            this.LocalAdrText.Size = new System.Drawing.Size(100, 20);
            this.LocalAdrText.TabIndex = 7;
            // 
            // LocalPortText
            // 
            this.LocalPortText.Location = new System.Drawing.Point(119, 95);
            this.LocalPortText.Name = "LocalPortText";
            this.LocalPortText.Size = new System.Drawing.Size(100, 20);
            this.LocalPortText.TabIndex = 8;
            // 
            // GlobalAdrText
            // 
            this.GlobalAdrText.Location = new System.Drawing.Point(119, 121);
            this.GlobalAdrText.Name = "GlobalAdrText";
            this.GlobalAdrText.Size = new System.Drawing.Size(100, 20);
            this.GlobalAdrText.TabIndex = 9;
            // 
            // GlobalPortText
            // 
            this.GlobalPortText.Location = new System.Drawing.Point(119, 147);
            this.GlobalPortText.Name = "GlobalPortText";
            this.GlobalPortText.Size = new System.Drawing.Size(100, 20);
            this.GlobalPortText.TabIndex = 10;
            // 
            // ExtendableChecked
            // 
            this.ExtendableChecked.AutoSize = true;
            this.ExtendableChecked.Location = new System.Drawing.Point(266, 44);
            this.ExtendableChecked.Name = "ExtendableChecked";
            this.ExtendableChecked.Size = new System.Drawing.Size(79, 17);
            this.ExtendableChecked.TabIndex = 11;
            this.ExtendableChecked.Text = "Extendable";
            this.ExtendableChecked.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "# of Interfaces";
            // 
            // NumInterfaces
            // 
            this.NumInterfaces.Location = new System.Drawing.Point(99, 172);
            this.NumInterfaces.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumInterfaces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumInterfaces.Name = "NumInterfaces";
            this.NumInterfaces.Size = new System.Drawing.Size(40, 20);
            this.NumInterfaces.TabIndex = 13;
            this.NumInterfaces.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumInterfaces.ValueChanged += new System.EventHandler(this.NumInterfaces_ValueChanged);
            // 
            // InterfacesPanel
            // 
            this.InterfacesPanel.AutoSize = true;
            this.InterfacesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InterfacesPanel.Location = new System.Drawing.Point(15, 198);
            this.InterfacesPanel.Name = "InterfacesPanel";
            this.InterfacesPanel.Size = new System.Drawing.Size(0, 0);
            this.InterfacesPanel.TabIndex = 14;
            // 
            // PortFowarding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(361, 209);
            this.Controls.Add(this.InterfacesPanel);
            this.Controls.Add(this.NumInterfaces);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ExtendableChecked);
            this.Controls.Add(this.GlobalPortText);
            this.Controls.Add(this.GlobalAdrText);
            this.Controls.Add(this.LocalPortText);
            this.Controls.Add(this.LocalAdrText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProtocolCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "PortFowarding";
            this.Text = "Port Fowarding";
            ((System.ComponentModel.ISupportInitialize)(this.NumInterfaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProtocolCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LocalAdrText;
        private System.Windows.Forms.TextBox LocalPortText;
        private System.Windows.Forms.TextBox GlobalAdrText;
        private System.Windows.Forms.TextBox GlobalPortText;
        private System.Windows.Forms.CheckBox ExtendableChecked;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumInterfaces;
        private System.Windows.Forms.FlowLayoutPanel InterfacesPanel;
    }
}