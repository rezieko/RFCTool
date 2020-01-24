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
    public partial class BasicConfig : Form
    {
        public BasicConfig()
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
            FinalText += "hostname " + HostnameText.Text + "\n";
            FinalText += GetSecretPassword();
            FinalText += GetLineConsolePass();
            FinalText += GetLineVTYPass();
            FinalText += "service password-encryption \n";

            return FinalText;
        }
        private string GetSecretPassword()
        {
            if (EnableSecretChecked.Checked)
            {
                return "enable secret " + EnableSecretText.Text + "\n";
            }
            return "";
        }
        private string GetLineConsolePass()
        {
            if (LineConsoleChecked.Checked)
            {
                return LineConsole();
            }
            return "";
        }
        private string LineConsole()
        {
            string LineConsole = "";
            LineConsole += "line console 0 \n";
            LineConsole += "password " + LineConsoleText.Text + "\n";
            LineConsole += "login \n";

            return LineConsole;
        }
        private string GetLineVTYPass()
        {
            if (LineVTYChecked.Checked)
            {
                return LineVTY();
            }
            return "";
        }
        private string LineVTY()
        {
            string LineVTY = "";
            LineVTY += "line vty 0 15 \n";
            LineVTY += "password " + LineVTYPassText.Text + "\n";
            LineVTY += "login \n";

            return LineVTY;
        }

        private void HostnameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnableSecretChecked_CheckedChanged(object sender, EventArgs e)
        {
            EnableSecretText.Enabled = EnableSecretChecked.Checked;
        }

        private void LineConsoleChecked_CheckedChanged(object sender, EventArgs e)
        {
            LineConsoleText.Enabled = LineConsoleChecked.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LineVTYChecked_CheckedChanged(object sender, EventArgs e)
        {
            LineVTYPassText.Enabled = LineVTYChecked.Checked; 
        }
    }
}
