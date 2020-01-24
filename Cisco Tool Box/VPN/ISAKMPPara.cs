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
    public partial class ISAKMPPara : Form
    {
        public ISAKMPPara()
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
            if (PresharedChecked.Checked)
            {
                FinalText += GetPresharedText();
            }
            FinalText += GetParameters();
            return FinalText;
        }
        private string GetParameters()
        {
            string ParaText = "";
            ParaText += "crypto isakmp policy " + PriorityIdText.Text + "\n";
            ParaText += "encryption " + EncryptionCombo.SelectedItem + "\n";
            ParaText += "hash " + HashCombo.SelectedItem + "\n";
            ParaText += "authentication " + AuthenticationCombo.SelectedItem + "\n";
            ParaText += "group " + GroupIdNum.Value + "\n";
            ParaText += "lifetime " + LifetimeText.Text + "\n";
            return ParaText;
        }
        private string GetPresharedText()
        {
            string PreSharedText = "";
            if (HostnameChecked.Checked)
            {
                PreSharedText += "crypto isakmp identity hostname \n";
            }
            PreSharedText += "crypto isakmp key " + KeyStringsText.Text + " ";
            if (HostnameChecked.Checked)
            {
                PreSharedText += "hostname " + HostnameText.Text;
            }
            if (PeerChecked.Checked)
            {
                PreSharedText += "address " + PeerText.Text;
            }
            PreSharedText += "\n";
            return PreSharedText;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            KeyStringsText.Enabled = PresharedChecked.Checked;
        }

        private void HostnameChecked_CheckedChanged(object sender, EventArgs e)
        {
            PeerText.Enabled = false;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            HostnameText.Enabled = false;
        }
    }
}
