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
    public partial class MonitorAndManagingDevices : Form
    {
        public MonitorAndManagingDevices()
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
            if (SecureBootConfigChecked.Checked)
            {
                FinalText += "secure boot-config \n";
            }
            if (SecureBootImageChecked.Checked)
            {
                FinalText += "secure boot-image \n";
            }
            if (DisablePassRecoveryChecked.Checked)
            {
                FinalText += "no service password-recovery \n";
            }
            FinalText += SystemLogging();


            return FinalText;
        }
        private string SystemLogging()
        {
            string CommandText = "";
            CommandText += "logging host ";
            if (HostnameChecked.Checked)
            {
                CommandText += HostnameText.Text;
            }
            if (IPAddChecked.Checked)
            {
                CommandText += IPAddText.Text ;
            }
            CommandText += "\n";
            if (LoggingTrapChecked.Checked)
            {
                CommandText += "logging trap " + TrapLevelNum.Value + "\n";
            }
            CommandText += "logging source-interface " + SourceIntIDText.Text + "\n";
            CommandText += "logging on \n";

            return CommandText;
        }

        private void IPAddChecked_CheckedChanged(object sender, EventArgs e)
        {
            IPAddText.Enabled = IPAddChecked.Checked;
        }

        private void HostnameChecked_CheckedChanged(object sender, EventArgs e)
        {
            HostnameText.Enabled = HostnameChecked.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
