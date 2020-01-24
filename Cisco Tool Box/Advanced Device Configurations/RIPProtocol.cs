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
    public partial class RIPProtocol : Form
    {
        public RIPProtocol()
        {
            InitializeComponent();
        }

        private void RIPProtocol_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }

        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += "router rip \n";
            FinalText += GetVersionType() + "\n";
            FinalText += "network " + IPAddressText.Text + "\n";
            FinalText += "no auto-summary \n";
            FinalText += GetPassiveInt();
            FinalText += GetDefaultRoute();



            return FinalText;
        }
        private string GetVersionType()
        {
            if (VersionChecked.Checked)
            {
                return "version 2";
            }
            return "version 1";
            
        }
        private string GetPassiveInt()
        {
            if (PassiveIntCheck.Checked)
            {
                return "passive-interface " + InterfaceText.Text + "\n";
            }
            return "";
        }
        private string GetDefaultRoute()
        {
            if (DefaultCheck.Checked)
            {
                return "default-information originate \n";
            }
            return "";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            InterfaceText.Enabled = PassiveIntCheck.Checked;
        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            
        }

        private void InterfaceText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
