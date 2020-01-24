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
    public partial class NTP : Form
    {
        public NTP()
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
            FinalText += GetServer();
            FinalText += GetAuthentication();
            return FinalText;
        }
        private string GetAuthentication()
        {
            string AuthenText = "";
            AuthenText += "ntp authenticate \n";
            AuthenText += "ntp authentication-key " + AuthenKeyValueText.Text + " md5 " + AuthenKeyValueText.Text + "\n";
            AuthenText += "ntp trusted-key " + TrustedKeyNumText.Text + "\n";

            return AuthenText;
        }
        private string GetServer()
        {
            string ServerText = "";
            ServerText += "ntp master 1 \n";
            ServerText += "ntp server ";
            if (IpAddChecked.Checked)
            {
                ServerText += "ip address " + IpAddText.Text + " ";
            }
            if (HostnameChecked.Checked)
            {
                ServerText += "hostname " + HostnameText.Text + " ";
            }
            if (VersionChecked.Checked)
            {
                ServerText += "version " + VersionText.Text + " ";
            }
            if (KeyChecked.Checked)
            {
                ServerText += "key " + KeyText.Text + " ";
            }
            if (SourceChecked.Checked)
            {
                ServerText += "source " + SourceText.Text + " ";
            }
            if (PreferChecked.Checked)
            {
                ServerText += "prefer";
            }
            ServerText += "\n";
            ServerText += "ntp broadcast client \n";

            return ServerText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VersionChecked_CheckedChanged(object sender, EventArgs e)
        {
            VersionText.Enabled = VersionChecked.Checked;
        }

        private void IpAddChecked_CheckedChanged(object sender, EventArgs e)
        {
            IpAddText.Enabled = IpAddChecked.Checked;

        }

        private void HostnameChecked_CheckedChanged(object sender, EventArgs e)
        {
            HostnameText.Enabled = HostnameChecked.Checked;
        }

        private void KeyChecked_CheckedChanged(object sender, EventArgs e)
        {
            KeyText.Enabled = KeyChecked.Checked;
        }

        private void SourceChecked_CheckedChanged(object sender, EventArgs e)
        {
            SourceText.Enabled = SourceChecked.Checked;
        }

        private void PreferChecked_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AuthenKeyNumberText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrustedKeyNumText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
