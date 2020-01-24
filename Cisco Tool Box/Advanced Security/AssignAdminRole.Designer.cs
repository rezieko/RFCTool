namespace Cisco_Tool_Box
{
    partial class AssignAdminRole
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
            this.ResetChecked = new System.Windows.Forms.CheckBox();
            this.CommandText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ModeCombo = new System.Windows.Forms.ComboBox();
            this.PrivLevelId = new System.Windows.Forms.NumericUpDown();
            this.LevelChecked = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UserPassText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserPrivLv = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PrivLevelPassText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PassPrivLevel = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.IntNameText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ParserIntChecked = new System.Windows.Forms.CheckBox();
            this.ParserAllChecked = new System.Windows.Forms.CheckBox();
            this.ParserModeCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ParserPassText = new System.Windows.Forms.TextBox();
            this.ParserViewNameText = new System.Windows.Forms.TextBox();
            this.EnableViewNameText = new System.Windows.Forms.TextBox();
            this.EnableViewNameChecked = new System.Windows.Forms.CheckBox();
            this.ParserCommandChecked = new System.Windows.Forms.CheckBox();
            this.ParserCommandText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrivLevelId)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPrivLv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassPrivLevel)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResetChecked);
            this.groupBox1.Controls.Add(this.CommandText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ModeCombo);
            this.groupBox1.Controls.Add(this.PrivLevelId);
            this.groupBox1.Controls.Add(this.LevelChecked);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Privilege Levels";
            // 
            // ResetChecked
            // 
            this.ResetChecked.AutoSize = true;
            this.ResetChecked.Location = new System.Drawing.Point(10, 69);
            this.ResetChecked.Name = "ResetChecked";
            this.ResetChecked.Size = new System.Drawing.Size(54, 17);
            this.ResetChecked.TabIndex = 8;
            this.ResetChecked.Text = "Reset";
            this.ResetChecked.UseVisualStyleBackColor = true;
            // 
            // CommandText
            // 
            this.CommandText.Location = new System.Drawing.Point(67, 89);
            this.CommandText.Name = "CommandText";
            this.CommandText.Size = new System.Drawing.Size(85, 20);
            this.CommandText.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Command";
            // 
            // ModeCombo
            // 
            this.ModeCombo.FormattingEnabled = true;
            this.ModeCombo.Items.AddRange(new object[] {
            "configure",
            "exec",
            "interface",
            "line",
            "router"});
            this.ModeCombo.Location = new System.Drawing.Point(47, 17);
            this.ModeCombo.Name = "ModeCombo";
            this.ModeCombo.Size = new System.Drawing.Size(85, 21);
            this.ModeCombo.TabIndex = 5;
            this.ModeCombo.Text = "Mode";
            // 
            // PrivLevelId
            // 
            this.PrivLevelId.Location = new System.Drawing.Point(67, 44);
            this.PrivLevelId.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.PrivLevelId.Name = "PrivLevelId";
            this.PrivLevelId.Size = new System.Drawing.Size(36, 20);
            this.PrivLevelId.TabIndex = 4;
            this.PrivLevelId.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // LevelChecked
            // 
            this.LevelChecked.AutoSize = true;
            this.LevelChecked.Location = new System.Drawing.Point(10, 45);
            this.LevelChecked.Name = "LevelChecked";
            this.LevelChecked.Size = new System.Drawing.Size(52, 17);
            this.LevelChecked.TabIndex = 2;
            this.LevelChecked.Text = "Level";
            this.LevelChecked.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UserPassText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.UserPrivLv);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.UsernameText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User";
            // 
            // UserPassText
            // 
            this.UserPassText.Location = new System.Drawing.Point(63, 66);
            this.UserPassText.Name = "UserPassText";
            this.UserPassText.Size = new System.Drawing.Size(94, 20);
            this.UserPassText.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // UserPrivLv
            // 
            this.UserPrivLv.Location = new System.Drawing.Point(89, 40);
            this.UserPrivLv.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.UserPrivLv.Name = "UserPrivLv";
            this.UserPrivLv.Size = new System.Drawing.Size(41, 20);
            this.UserPrivLv.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Privilege Level";
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(67, 14);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(90, 20);
            this.UsernameText.TabIndex = 1;
            this.UsernameText.TextChanged += new System.EventHandler(this.UsernameText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.PrivLevelPassText);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.PassPrivLevel);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 76);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Password for Privilege Levels";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Password";
            // 
            // PrivLevelPassText
            // 
            this.PrivLevelPassText.Location = new System.Drawing.Point(67, 44);
            this.PrivLevelPassText.Name = "PrivLevelPassText";
            this.PrivLevelPassText.Size = new System.Drawing.Size(85, 20);
            this.PrivLevelPassText.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Level";
            // 
            // PassPrivLevel
            // 
            this.PassPrivLevel.Location = new System.Drawing.Point(50, 18);
            this.PassPrivLevel.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.PassPrivLevel.Name = "PassPrivLevel";
            this.PassPrivLevel.Size = new System.Drawing.Size(36, 20);
            this.PassPrivLevel.TabIndex = 4;
            this.PassPrivLevel.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.ParserPassText);
            this.groupBox4.Controls.Add(this.ParserViewNameText);
            this.groupBox4.Controls.Add(this.EnableViewNameText);
            this.groupBox4.Controls.Add(this.EnableViewNameChecked);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(197, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 242);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Role-Based View ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ParserCommandChecked);
            this.groupBox5.Controls.Add(this.ParserCommandText);
            this.groupBox5.Controls.Add(this.IntNameText);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.ParserIntChecked);
            this.groupBox5.Controls.Add(this.ParserAllChecked);
            this.groupBox5.Controls.Add(this.ParserModeCombo);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(9, 92);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 141);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parser Mode\'s Commands";
            // 
            // IntNameText
            // 
            this.IntNameText.Location = new System.Drawing.Point(93, 86);
            this.IntNameText.Name = "IntNameText";
            this.IntNameText.Size = new System.Drawing.Size(100, 20);
            this.IntNameText.TabIndex = 5;
            this.IntNameText.TextChanged += new System.EventHandler(this.IntNameText_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Interface Name";
            // 
            // ParserIntChecked
            // 
            this.ParserIntChecked.AutoSize = true;
            this.ParserIntChecked.Location = new System.Drawing.Point(10, 69);
            this.ParserIntChecked.Name = "ParserIntChecked";
            this.ParserIntChecked.Size = new System.Drawing.Size(68, 17);
            this.ParserIntChecked.TabIndex = 3;
            this.ParserIntChecked.Text = "Interface";
            this.ParserIntChecked.UseVisualStyleBackColor = true;
            this.ParserIntChecked.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ParserAllChecked
            // 
            this.ParserAllChecked.AutoSize = true;
            this.ParserAllChecked.Location = new System.Drawing.Point(10, 46);
            this.ParserAllChecked.Name = "ParserAllChecked";
            this.ParserAllChecked.Size = new System.Drawing.Size(37, 17);
            this.ParserAllChecked.TabIndex = 2;
            this.ParserAllChecked.Text = "All";
            this.ParserAllChecked.UseVisualStyleBackColor = true;
            this.ParserAllChecked.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // ParserModeCombo
            // 
            this.ParserModeCombo.FormattingEnabled = true;
            this.ParserModeCombo.Items.AddRange(new object[] {
            "include",
            "include-exclusive",
            "exclude"});
            this.ParserModeCombo.Location = new System.Drawing.Point(47, 19);
            this.ParserModeCombo.Name = "ParserModeCombo";
            this.ParserModeCombo.Size = new System.Drawing.Size(135, 21);
            this.ParserModeCombo.TabIndex = 1;
            this.ParserModeCombo.Text = "Mode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Parser View\'s Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Parser View, View Name";
            // 
            // ParserPassText
            // 
            this.ParserPassText.Location = new System.Drawing.Point(159, 69);
            this.ParserPassText.Name = "ParserPassText";
            this.ParserPassText.Size = new System.Drawing.Size(100, 20);
            this.ParserPassText.TabIndex = 1;
            this.ParserPassText.TextChanged += new System.EventHandler(this.EnableViewNameText_TextChanged);
            // 
            // ParserViewNameText
            // 
            this.ParserViewNameText.Location = new System.Drawing.Point(159, 43);
            this.ParserViewNameText.Name = "ParserViewNameText";
            this.ParserViewNameText.Size = new System.Drawing.Size(100, 20);
            this.ParserViewNameText.TabIndex = 1;
            this.ParserViewNameText.TextChanged += new System.EventHandler(this.EnableViewNameText_TextChanged);
            // 
            // EnableViewNameText
            // 
            this.EnableViewNameText.Location = new System.Drawing.Point(159, 17);
            this.EnableViewNameText.Name = "EnableViewNameText";
            this.EnableViewNameText.Size = new System.Drawing.Size(100, 20);
            this.EnableViewNameText.TabIndex = 1;
            this.EnableViewNameText.TextChanged += new System.EventHandler(this.EnableViewNameText_TextChanged);
            // 
            // EnableViewNameChecked
            // 
            this.EnableViewNameChecked.AutoSize = true;
            this.EnableViewNameChecked.Checked = true;
            this.EnableViewNameChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableViewNameChecked.Location = new System.Drawing.Point(8, 19);
            this.EnableViewNameChecked.Name = "EnableViewNameChecked";
            this.EnableViewNameChecked.Size = new System.Drawing.Size(145, 17);
            this.EnableViewNameChecked.TabIndex = 0;
            this.EnableViewNameChecked.Text = "Enable View, View Name";
            this.EnableViewNameChecked.UseVisualStyleBackColor = true;
            this.EnableViewNameChecked.CheckedChanged += new System.EventHandler(this.EnableViewNameChecked_CheckedChanged);
            // 
            // ParserCommandChecked
            // 
            this.ParserCommandChecked.AutoSize = true;
            this.ParserCommandChecked.Location = new System.Drawing.Point(10, 114);
            this.ParserCommandChecked.Name = "ParserCommandChecked";
            this.ParserCommandChecked.Size = new System.Drawing.Size(73, 17);
            this.ParserCommandChecked.TabIndex = 6;
            this.ParserCommandChecked.Text = "Command";
            this.ParserCommandChecked.UseVisualStyleBackColor = true;
            // 
            // ParserCommandText
            // 
            this.ParserCommandText.Location = new System.Drawing.Point(93, 112);
            this.ParserCommandText.Name = "ParserCommandText";
            this.ParserCommandText.Size = new System.Drawing.Size(100, 20);
            this.ParserCommandText.TabIndex = 5;
            this.ParserCommandText.TextChanged += new System.EventHandler(this.IntNameText_TextChanged);
            // 
            // AssignAdminRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(478, 355);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AssignAdminRole";
            this.Text = "Assigning Administrative Role";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrivLevelId)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPrivLv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassPrivLevel)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox LevelChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PrivLevelId;
        private System.Windows.Forms.TextBox CommandText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ModeCombo;
        private System.Windows.Forms.CheckBox ResetChecked;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox UserPassText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown UserPrivLv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PrivLevelPassText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown PassPrivLevel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox EnableViewNameText;
        private System.Windows.Forms.CheckBox EnableViewNameChecked;
        private System.Windows.Forms.TextBox ParserViewNameText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ParserPassText;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox IntNameText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ParserIntChecked;
        private System.Windows.Forms.CheckBox ParserAllChecked;
        private System.Windows.Forms.ComboBox ParserModeCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ParserCommandChecked;
        private System.Windows.Forms.TextBox ParserCommandText;
    }
}