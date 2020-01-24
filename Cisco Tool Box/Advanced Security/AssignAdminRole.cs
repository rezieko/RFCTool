using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cisco_Tool_Box
{
    public partial class AssignAdminRole : Form
    {
        public AssignAdminRole()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }
        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += PrivilegeLevel();
            FinalText += PrivLevelPass();
            FinalText += User();
            
            return FinalText;
        }
        private string RoleBaseView()
        {
            string RoleBaseView = "";

            RoleBaseView += "aaa new-model \n";
            RoleBaseView += "enable view " + EnableViewNameText.Text + "\n";
            RoleBaseView += "parser view " + ParserViewNameText.Text + "\n";
            RoleBaseView += "secret " + ParserPassText.Text + "\n";
            RoleBaseView += "commands parser-mode " + ParserModeCombo.SelectedItem + " ";
            
            if (ParserAllChecked.Checked)
            {
                RoleBaseView += "all ";
            }
            if (ParserIntChecked.Checked)
            {
                RoleBaseView += "interface " + IntNameText.Text + " ";
            }
            if (ParserCommandChecked.Checked)
            {
                RoleBaseView += ParserCommandText.Text + " ";
            }
            RoleBaseView += "\n";

            return RoleBaseView;
        }
        private string PrivLevelPass()
        {
            return "enable secret level " + PassPrivLevel.Value + " " + PrivLevelPassText.Text + "\n";
        }
        private string User()
        {
            return "username " + UsernameText.Text + " privilege " + UserPrivLv.Value + " secret " + UserPassText.Text + "\n";
        }
        private string PrivilegeLevel()
        {
            string PrivilegeLevel = "";
            PrivilegeLevel += "privilege " + ModeCombo.SelectedItem;

            if (LevelChecked.Checked)
            {
                PrivilegeLevel += " level " + PrivLevelId.Value + " ";
            }

            if (ResetChecked.Checked)
            {
                PrivilegeLevel += " reset ";
            }
            PrivilegeLevel += CommandText.Text + "\n";

            return PrivilegeLevel;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnableViewNameChecked_CheckedChanged(object sender, EventArgs e)
        {
            EnableViewNameText.Enabled = EnableViewNameChecked.Checked;
        }

        private void EnableViewNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            IntNameText.Enabled = ParserIntChecked.Checked;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void IntNameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
