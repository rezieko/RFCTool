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
    public partial class Passwords : Form
    {
        public Passwords()
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
            FinalText += GetSecretPass();
            FinalText += GetConsolePass();
            FinalText += GetVtyPass();
            FinalText += GetAuxPass();
            FinalText += "service password-encryption \n";

            return FinalText;
        }
        private string GetConsolePass()
        {
            if (ConsoleChecked.Checked)
            {
                string GetConsole = "";
                GetConsole += "line console 0 \n";
                GetConsole += "password " + ConsolePassText.Text + "\n";
                GetConsole += "login \n";
                
                return GetConsole;
            }
            return "";
        }

        private string GetVtyPass()
        {
            if (VtyChecked.Checked)
            {
                string GetVty = "";
                GetVty += "line vty 0 15 \n";
                GetVty += "password " + VtyPassText.Text + "\n";
                GetVty += "login \n";

                return GetVty;
            }
            return "";
        }

        private string GetAuxPass()
        {
            if (AuxChecked.Checked)
            {
                string GetAux = "";
                GetAux += "line aux 0 \n";
                GetAux += "password " + AuxPassText.Text + "\n";
                GetAux += "login \n";

                return GetAux;
            }
            return "";
        }
        private string GetSecretPass()
        {
            if (SecretChecked.Checked)
            {
                return "enable secret " + SecretPassText.Text + "\n";
            }
            return "";
        }

        private void ConsoleChecked_CheckedChanged(object sender, EventArgs e)
        {
            ConsolePassText.Enabled = ConsoleChecked.Checked;
        }

        private void VtyChecked_CheckedChanged(object sender, EventArgs e)
        {
            VtyPassText.Enabled = VtyChecked.Checked;
        }

        private void AuxChecked_CheckedChanged(object sender, EventArgs e)
        {
            AuxPassText.Enabled = AuxChecked.Checked;
        }

        private void Passwords_Load(object sender, EventArgs e)
        {

        }

        private void SecretPassText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecretChecked_CheckedChanged(object sender, EventArgs e)
        {
            SecretPassText.Enabled = SecretChecked.Checked;
        }

        private void VtyPassText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
