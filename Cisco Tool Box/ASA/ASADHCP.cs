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
    public partial class ASADHCP : Form
    {
        public ASADHCP()
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
            FinalText += "dhcpd enable inside \n";
            FinalText += "dhcpd address " + StartIpText.Text + " - " + EndIpText.Text + "\n";
            FinalText += "dhcpd domain " + DomainText.Text + "\n";
            FinalText += "dhcpd dns " + DNSText.Text + "\n";
            FinalText += "dhcpd wins " + WINSText.Text + "\n";
            FinalText += "dhcpd lease " + LeaseText.Text + "\n";
            FinalText += "dhcpd option " + OptionText.Text + "\n";

            return FinalText;
        }
    }
}
