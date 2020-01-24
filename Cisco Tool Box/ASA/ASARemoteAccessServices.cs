using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cisco_Tool_Box
{
    public partial class ASARemoteAccessServices : Form
    {
        public ASARemoteAccessServices()
        {
            InitializeComponent();
            for (int i = 0; i <= 32; i++)
            {
                TelnetSubnetMaskAbbriev.Items.Add(i);
            }
            for (int i = 0; i <= 32; i++)
            {
                SshSubnetMaskAbbriev.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }
        private string GetFinalText()
        {
            string FinalText = "";
            if (TelnetChecked.Checked)
            {
                FinalText += GetTelnet();
            }
            if (SshChecked.Checked)
            {
                FinalText += GetSsh();
            }
            return FinalText;
        }
        private string GetTelnet()
        {
            string TelnetText = "";
            TelnetText += "passwd " + TelnetLineConPassText.Text + "\n";
            TelnetText += "telnet " + TelnetIpAddText.Text + " " + GetTelnetSubnet() + " " + TelnetIntNameText.Text + "\n";
            TelnetText += "telnet timeout " + TelnetTimeoutText.Text + "\n";

            return TelnetText;
        }
        private string GetSsh()
        {
            string FinalSSH = "";
            FinalSSH += "passwd " + SshLineConPassText.Text + "\n";
            FinalSSH += "username " + SshUserText.Text + " password " + SshPassText.Text + "\n";
            FinalSSH += "aaa authentication ssh console LOCAL \n";
            FinalSSH += "crypto key generate rsa modulus 1024 \n";
            FinalSSH += "ssh " + SshIpAddText.Text + " " + GetSshSubnet() + " " + SshIntNameText.Text + "\n";
            FinalSSH += "ssh timeout " + SshTimeoutText.Text + "\n";

            return FinalSSH;
        }
        private string GetTelnetSubnet()
        {
            if (TelnetShouldUseIP.Checked)
            {
                return TelnetSubnetMaskText.Text;
            }

            uint targ = Convert.ToUInt32(TelnetSubnetMaskAbbriev.SelectedItem.ToString());
            //(2 ^ 32 - 1) - (2 ^ (32 - mask) - 1)
            long mask = ((long)(Math.Pow(2, 32) - 1)) - ((long)(Math.Pow(2, (32 - targ)) - 1));
            return IPAddress.Parse(mask.ToString()).ToString();
        }
        private string GetSshSubnet()
        {
            if (SshShouldUseIP.Checked)
            {
                return SshSubnetMaskText.Text;
            }

            uint targ = Convert.ToUInt32(SshSubnetMaskAbbriev.SelectedItem.ToString());
            //(2 ^ 32 - 1) - (2 ^ (32 - mask) - 1)
            long mask = ((long)(Math.Pow(2, 32) - 1)) - ((long)(Math.Pow(2, (32 - targ)) - 1));
            return IPAddress.Parse(mask.ToString()).ToString();
        }
        private void Interface_Click(object sender, EventArgs e)
        {

        }

        private void SubnetMaskAbbriev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShouldUseIP_CheckedChanged(object sender, EventArgs e)
        {
            TelnetSubnetMaskText.Enabled = TelnetShouldUseIP.Checked;
        }

        private void TelnetChecked_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SshShouldUseIP_CheckedChanged(object sender, EventArgs e)
        {
            SshSubnetMaskText.Enabled = SshShouldUseIP.Checked;
        }
    }
}
