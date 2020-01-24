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
    public partial class ASABasics : Form
    {
        public ASABasics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }
        string GetFinalText()
        {
            string FinalText = "";
            FinalText += "hostname " + HostnameText.Text + "\n";
            FinalText += "domain-name " + DomainText.Text + "\n";
            FinalText += "enable password " + SecretText.Text + "\n";
            FinalText += "passwd " + LineConPassText.Text + "\n";
            FinalText += "key config-key password-encryption " + NewPassText.Text + " " + OldPassText.Text + "\n";
            FinalText += "password encryption aes \n";

            return FinalText;
        }
    }
}
