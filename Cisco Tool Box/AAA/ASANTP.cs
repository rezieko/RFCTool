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
    public partial class ASANTP : Form
    {
        public ASANTP()
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
            FinalText += "ntp server " + ServerIpText.Text + "\n";
            FinalText += "ntp authentication-key " + AuthenKeyText.Text + " md5 " + NtpKeyText.Text + "\n";
            FinalText += "ntp trusted-key " + TrustedKeyText.Text + "\n";
            FinalText += "ntp authenticate \n";
            
            return FinalText;
        }

    }
}
