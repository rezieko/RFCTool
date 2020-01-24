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
    public partial class InterfaceSecurity : Form
    {
        public InterfaceSecurity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            {
                Clipboard.SetText(GetFinalText());
                Close();
            }           
        }
        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += GetSwitchportSecurity();
            FinalText += "interface range " + FirstIntIDText.Text + " - " + LastIntIDText.Text + "\n shutdown \n";


            return FinalText;
        }
        private string GetSwitchportSecurity()
        {     
            if (SecureIntChecked.Checked)
            {
                string SwitchportSecurity = "";
                SwitchportSecurity += "interface " + InterfaceIDText.Text + "\n";
                SwitchportSecurity += "switchport mode access \n";
                SwitchportSecurity += "switchport port-security \n";

                return SwitchportSecurity;
            }
            return "";
        }
        


        private void SecureUnusedChecked_CheckedChanged(object sender, EventArgs e)
        {
            FirstIntIDText.Enabled = SecureUnusedChecked.Checked;
            LastIntIDText.Enabled = SecureUnusedChecked.Checked;
        }

        private void SecureIntChecked_CheckedChanged(object sender, EventArgs e)
        {
            InterfaceIDText.Enabled = SecureIntChecked.Checked;
        }

        private void SwitchportSecurity_Load(object sender, EventArgs e)
        {            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
