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
    public partial class SSH : Form
    {
        public SSH()
        {
            InitializeComponent();
        }

        private void VerOneChecked_CheckedChanged(object sender, EventArgs e)
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
            if (VerOneChecked.Checked)
            {
                FinalText += "ip ssh version 1 \n";
            }

            if (VerTwoChecked.Checked)
            {
                FinalText += "ip ssh version 2 \n";
            }
            FinalText += "ip domain-name " + DomainNameText.Text + "\n";
            FinalText += "crypto key generate rsa general-keys modulus " + ModulusSizeText.Text + "\n";
            FinalText += "ip ssh time-out " + TimeOutSecsText.Text + "\n";
            FinalText += "ip ssh authentication retries " + AttemptsText.Text + "\n";
            FinalText += "username " + UsernameText.Text + " secret " + PasswordText.Text + "\n";
            FinalText += "line vty 0 4 \n";
            FinalText += "login local \n";
            FinalText += "transport input ssh \n";
            FinalText += "exit \n";

            return FinalText;
        }

        private void ModulusSizeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DomainNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
