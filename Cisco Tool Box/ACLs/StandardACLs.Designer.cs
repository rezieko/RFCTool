namespace Cisco_Tool_Box
{
    partial class StandardACLs
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
            this.IDText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumControls = new System.Windows.Forms.NumericUpDown();
            this.BoxPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.InterfaceChecked = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InterfaceText = new System.Windows.Forms.TextBox();
            this.InterfaceInChecked = new System.Windows.Forms.CheckBox();
            this.InterfaceOutChecked = new System.Windows.Forms.CheckBox();
            this.VTYChecked = new System.Windows.Forms.CheckBox();
            this.VTYInChecked = new System.Windows.Forms.CheckBox();
            this.VTYOutChecked = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumControls)).BeginInit();
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
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name | Number";
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(98, 42);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(100, 20);
            this.IDText.TabIndex = 2;
            this.IDText.TextChanged += new System.EventHandler(this.IDText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "# of Controls";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NumControls
            // 
            this.NumControls.Location = new System.Drawing.Point(85, 145);
            this.NumControls.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NumControls.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumControls.Name = "NumControls";
            this.NumControls.Size = new System.Drawing.Size(37, 20);
            this.NumControls.TabIndex = 4;
            this.NumControls.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumControls.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // BoxPanel
            // 
            this.BoxPanel.AutoSize = true;
            this.BoxPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BoxPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.BoxPanel.Location = new System.Drawing.Point(15, 171);
            this.BoxPanel.Name = "BoxPanel";
            this.BoxPanel.Size = new System.Drawing.Size(0, 0);
            this.BoxPanel.TabIndex = 5;
            // 
            // InterfaceChecked
            // 
            this.InterfaceChecked.AutoSize = true;
            this.InterfaceChecked.Checked = true;
            this.InterfaceChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InterfaceChecked.Location = new System.Drawing.Point(13, 73);
            this.InterfaceChecked.Name = "InterfaceChecked";
            this.InterfaceChecked.Size = new System.Drawing.Size(109, 17);
            this.InterfaceChecked.TabIndex = 6;
            this.InterfaceChecked.Text = "Apply to Interface";
            this.InterfaceChecked.UseVisualStyleBackColor = true;
            this.InterfaceChecked.CheckedChanged += new System.EventHandler(this.InterfaceChecked_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Interface ID";
            // 
            // InterfaceText
            // 
            this.InterfaceText.Location = new System.Drawing.Point(81, 96);
            this.InterfaceText.Name = "InterfaceText";
            this.InterfaceText.Size = new System.Drawing.Size(65, 20);
            this.InterfaceText.TabIndex = 8;
            this.InterfaceText.TextChanged += new System.EventHandler(this.InterfaceText_TextChanged);
            // 
            // InterfaceInChecked
            // 
            this.InterfaceInChecked.AutoSize = true;
            this.InterfaceInChecked.Location = new System.Drawing.Point(152, 99);
            this.InterfaceInChecked.Name = "InterfaceInChecked";
            this.InterfaceInChecked.Size = new System.Drawing.Size(35, 17);
            this.InterfaceInChecked.TabIndex = 9;
            this.InterfaceInChecked.Text = "In";
            this.InterfaceInChecked.UseVisualStyleBackColor = true;
            this.InterfaceInChecked.CheckedChanged += new System.EventHandler(this.InterfaceInChecked_CheckedChanged);
            // 
            // InterfaceOutChecked
            // 
            this.InterfaceOutChecked.AutoSize = true;
            this.InterfaceOutChecked.Location = new System.Drawing.Point(193, 99);
            this.InterfaceOutChecked.Name = "InterfaceOutChecked";
            this.InterfaceOutChecked.Size = new System.Drawing.Size(43, 17);
            this.InterfaceOutChecked.TabIndex = 9;
            this.InterfaceOutChecked.Text = "Out";
            this.InterfaceOutChecked.UseVisualStyleBackColor = true;
            // 
            // VTYChecked
            // 
            this.VTYChecked.AutoSize = true;
            this.VTYChecked.Location = new System.Drawing.Point(11, 122);
            this.VTYChecked.Name = "VTYChecked";
            this.VTYChecked.Size = new System.Drawing.Size(110, 17);
            this.VTYChecked.TabIndex = 10;
            this.VTYChecked.Text = "Apply to VTY Port";
            this.VTYChecked.UseVisualStyleBackColor = true;
            // 
            // VTYInChecked
            // 
            this.VTYInChecked.AutoSize = true;
            this.VTYInChecked.Location = new System.Drawing.Point(129, 122);
            this.VTYInChecked.Name = "VTYInChecked";
            this.VTYInChecked.Size = new System.Drawing.Size(35, 17);
            this.VTYInChecked.TabIndex = 9;
            this.VTYInChecked.Text = "In";
            this.VTYInChecked.UseVisualStyleBackColor = true;
            // 
            // VTYOutChecked
            // 
            this.VTYOutChecked.AutoSize = true;
            this.VTYOutChecked.Location = new System.Drawing.Point(170, 122);
            this.VTYOutChecked.Name = "VTYOutChecked";
            this.VTYOutChecked.Size = new System.Drawing.Size(43, 17);
            this.VTYOutChecked.TabIndex = 9;
            this.VTYOutChecked.Text = "Out";
            this.VTYOutChecked.UseVisualStyleBackColor = true;
            // 
            // StandardACLs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(250, 177);
            this.Controls.Add(this.VTYChecked);
            this.Controls.Add(this.VTYOutChecked);
            this.Controls.Add(this.InterfaceOutChecked);
            this.Controls.Add(this.VTYInChecked);
            this.Controls.Add(this.InterfaceInChecked);
            this.Controls.Add(this.InterfaceText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InterfaceChecked);
            this.Controls.Add(this.BoxPanel);
            this.Controls.Add(this.NumControls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "StandardACLs";
            this.Text = "Standard ACLs";
            this.Load += new System.EventHandler(this.StandardACLs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumControls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumControls;
        private System.Windows.Forms.FlowLayoutPanel BoxPanel;
        private System.Windows.Forms.CheckBox InterfaceChecked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InterfaceText;
        private System.Windows.Forms.CheckBox InterfaceInChecked;
        private System.Windows.Forms.CheckBox InterfaceOutChecked;
        private System.Windows.Forms.CheckBox VTYChecked;
        private System.Windows.Forms.CheckBox VTYInChecked;
        private System.Windows.Forms.CheckBox VTYOutChecked;
    }
}