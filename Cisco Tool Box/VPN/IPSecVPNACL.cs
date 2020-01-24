using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cisco_Tool_Box
{
    public partial class IPSecVPNACL : UserControl
    {
        public IPSecVPNACL()
        {
            InitializeComponent();
        }
        public string GetIpSecVpnAclText()
        {
            string CommandText = "";
            CommandText += "access-list " + AclIdText.Text + " permit " + ProtocolCombo.SelectedItem + " ";
            
            if (SourceHostChecked.Checked)
            {
                CommandText += "host ";
            }

            CommandText += SourceIpText.Text + " ";

            if (!SourceHostChecked.Checked)
            {
                CommandText += SourceWildcardText.Text + " ";
            }

            if (DestHostChecked.Checked)
            {
                CommandText += "host ";
            }

            CommandText += DestIpText.Text + " ";

            if (!DestHostChecked.Checked)
            {
                CommandText += DestWildcardText.Text + " ";
            }

            CommandText += "\n";

            return CommandText;
        }

        private void AclIdText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SourceHostChecked_CheckedChanged(object sender, EventArgs e)
        {
            SourceWildcardText.Enabled = false;
        }

        private void DestHostChecked_CheckedChanged(object sender, EventArgs e)
        {
            DestWildcardText.Enabled = false;
        }

        private void SourceIpText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
