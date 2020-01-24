namespace Cisco_Tool_Box
{
    partial class NATInterfacesBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.InChecked = new System.Windows.Forms.CheckBox();
            this.OutChecked = new System.Windows.Forms.CheckBox();
            this.InterfaceIDText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interface ID";
            // 
            // InChecked
            // 
            this.InChecked.AutoSize = true;
            this.InChecked.Location = new System.Drawing.Point(178, 5);
            this.InChecked.Name = "InChecked";
            this.InChecked.Size = new System.Drawing.Size(35, 17);
            this.InChecked.TabIndex = 1;
            this.InChecked.Text = "In";
            this.InChecked.UseVisualStyleBackColor = true;
            // 
            // OutChecked
            // 
            this.OutChecked.AutoSize = true;
            this.OutChecked.Location = new System.Drawing.Point(219, 5);
            this.OutChecked.Name = "OutChecked";
            this.OutChecked.Size = new System.Drawing.Size(43, 17);
            this.OutChecked.TabIndex = 2;
            this.OutChecked.Text = "Out";
            this.OutChecked.UseVisualStyleBackColor = true;
            // 
            // InterfaceIDText
            // 
            this.InterfaceIDText.Location = new System.Drawing.Point(72, 3);
            this.InterfaceIDText.Name = "InterfaceIDText";
            this.InterfaceIDText.Size = new System.Drawing.Size(100, 20);
            this.InterfaceIDText.TabIndex = 3;
            this.InterfaceIDText.TextChanged += new System.EventHandler(this.InterfaceIDText_TextChanged);
            // 
            // StaticNATInterfacesBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.InterfaceIDText);
            this.Controls.Add(this.OutChecked);
            this.Controls.Add(this.InChecked);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "StaticNATInterfacesBox";
            this.Size = new System.Drawing.Size(267, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox InChecked;
        private System.Windows.Forms.CheckBox OutChecked;
        private System.Windows.Forms.TextBox InterfaceIDText;
    }
}
