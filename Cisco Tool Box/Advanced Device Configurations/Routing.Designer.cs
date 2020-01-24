namespace Cisco_Tool_Box
{
    partial class Routing
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
            this.StaticRouteChecked = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InterfaceIDChecked = new System.Windows.Forms.CheckBox();
            this.NextHopIPChecked = new System.Windows.Forms.CheckBox();
            this.NetworkText = new System.Windows.Forms.TextBox();
            this.SubnetMaskText = new System.Windows.Forms.TextBox();
            this.InterfaceIDText = new System.Windows.Forms.TextBox();
            this.NextHopIPText = new System.Windows.Forms.TextBox();
            this.SubnetMaskAbbriev = new System.Windows.Forms.ComboBox();
            this.ShouldUseIPChecked = new System.Windows.Forms.CheckBox();
            this.DefaultChecked = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy To Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaticRouteChecked
            // 
            this.StaticRouteChecked.AutoSize = true;
            this.StaticRouteChecked.Checked = true;
            this.StaticRouteChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StaticRouteChecked.Location = new System.Drawing.Point(13, 43);
            this.StaticRouteChecked.Name = "StaticRouteChecked";
            this.StaticRouteChecked.Size = new System.Drawing.Size(53, 17);
            this.StaticRouteChecked.TabIndex = 1;
            this.StaticRouteChecked.Text = "Static";
            this.StaticRouteChecked.UseVisualStyleBackColor = true;
            this.StaticRouteChecked.CheckedChanged += new System.EventHandler(this.StaticRouteChecked_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Network Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subnet Mask";
            // 
            // InterfaceIDChecked
            // 
            this.InterfaceIDChecked.AutoSize = true;
            this.InterfaceIDChecked.Location = new System.Drawing.Point(75, 97);
            this.InterfaceIDChecked.Name = "InterfaceIDChecked";
            this.InterfaceIDChecked.Size = new System.Drawing.Size(82, 17);
            this.InterfaceIDChecked.TabIndex = 3;
            this.InterfaceIDChecked.Text = "Interface ID";
            this.InterfaceIDChecked.UseVisualStyleBackColor = true;
            // 
            // NextHopIPChecked
            // 
            this.NextHopIPChecked.AutoSize = true;
            this.NextHopIPChecked.Location = new System.Drawing.Point(75, 123);
            this.NextHopIPChecked.Name = "NextHopIPChecked";
            this.NextHopIPChecked.Size = new System.Drawing.Size(125, 17);
            this.NextHopIPChecked.TabIndex = 3;
            this.NextHopIPChecked.Text = "Next Hop IP Address";
            this.NextHopIPChecked.UseVisualStyleBackColor = true;
            // 
            // NetworkText
            // 
            this.NetworkText.Location = new System.Drawing.Point(167, 43);
            this.NetworkText.Name = "NetworkText";
            this.NetworkText.Size = new System.Drawing.Size(100, 20);
            this.NetworkText.TabIndex = 4;
            this.NetworkText.TextChanged += new System.EventHandler(this.NetworkText_TextChanged);
            // 
            // SubnetMaskText
            // 
            this.SubnetMaskText.Location = new System.Drawing.Point(319, 72);
            this.SubnetMaskText.Name = "SubnetMaskText";
            this.SubnetMaskText.Size = new System.Drawing.Size(100, 20);
            this.SubnetMaskText.TabIndex = 4;
            // 
            // InterfaceIDText
            // 
            this.InterfaceIDText.Location = new System.Drawing.Point(167, 95);
            this.InterfaceIDText.Name = "InterfaceIDText";
            this.InterfaceIDText.Size = new System.Drawing.Size(81, 20);
            this.InterfaceIDText.TabIndex = 4;
            // 
            // NextHopIPText
            // 
            this.NextHopIPText.Location = new System.Drawing.Point(206, 120);
            this.NextHopIPText.Name = "NextHopIPText";
            this.NextHopIPText.Size = new System.Drawing.Size(100, 20);
            this.NextHopIPText.TabIndex = 4;
            // 
            // SubnetMaskAbbriev
            // 
            this.SubnetMaskAbbriev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubnetMaskAbbriev.FormattingEnabled = true;
            this.SubnetMaskAbbriev.Location = new System.Drawing.Point(167, 69);
            this.SubnetMaskAbbriev.Name = "SubnetMaskAbbriev";
            this.SubnetMaskAbbriev.Size = new System.Drawing.Size(41, 21);
            this.SubnetMaskAbbriev.TabIndex = 4;
            this.SubnetMaskAbbriev.SelectedIndexChanged += new System.EventHandler(this.SubnetMaskAbbriev_SelectedIndexChanged);
            // 
            // ShouldUseIPChecked
            // 
            this.ShouldUseIPChecked.AutoSize = true;
            this.ShouldUseIPChecked.Location = new System.Drawing.Point(214, 74);
            this.ShouldUseIPChecked.Name = "ShouldUseIPChecked";
            this.ShouldUseIPChecked.Size = new System.Drawing.Size(99, 17);
            this.ShouldUseIPChecked.TabIndex = 5;
            this.ShouldUseIPChecked.Text = "Use IP Address";
            this.ShouldUseIPChecked.UseVisualStyleBackColor = true;
            this.ShouldUseIPChecked.CheckedChanged += new System.EventHandler(this.ShouldUseIPChecked_CheckedChanged);
            // 
            // DefaultChecked
            // 
            this.DefaultChecked.AutoSize = true;
            this.DefaultChecked.Location = new System.Drawing.Point(12, 71);
            this.DefaultChecked.Name = "DefaultChecked";
            this.DefaultChecked.Size = new System.Drawing.Size(60, 17);
            this.DefaultChecked.TabIndex = 6;
            this.DefaultChecked.Text = "Default";
            this.DefaultChecked.UseVisualStyleBackColor = true;
            this.DefaultChecked.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // Routing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(429, 156);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DefaultChecked);
            this.Controls.Add(this.ShouldUseIPChecked);
            this.Controls.Add(this.NextHopIPText);
            this.Controls.Add(this.SubnetMaskAbbriev);
            this.Controls.Add(this.InterfaceIDText);
            this.Controls.Add(this.SubnetMaskText);
            this.Controls.Add(this.NetworkText);
            this.Controls.Add(this.NextHopIPChecked);
            this.Controls.Add(this.InterfaceIDChecked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StaticRouteChecked);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Routing";
            this.Text = "Routing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox StaticRouteChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox InterfaceIDChecked;
        private System.Windows.Forms.CheckBox NextHopIPChecked;
        private System.Windows.Forms.TextBox NetworkText;
        private System.Windows.Forms.TextBox SubnetMaskText;
        private System.Windows.Forms.TextBox InterfaceIDText;
        private System.Windows.Forms.TextBox NextHopIPText;
        private System.Windows.Forms.ComboBox SubnetMaskAbbriev;
        private System.Windows.Forms.CheckBox ShouldUseIPChecked;
        private System.Windows.Forms.CheckBox DefaultChecked;
        private System.Windows.Forms.Label label3;
    }
}