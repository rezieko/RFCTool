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
    public partial class CryptoACL : UserControl
    {
        public CryptoACL()
        {
            InitializeComponent();
        }
        public string GetCryptoACL()
        {
            string CryptoACLText = "";
            CryptoACLText += "access-list " + IdText.Text + " ";
            CryptoACLText += PermitDenyCombo.SelectedItem + " ";
            CryptoACLText += ProtocolCombo.SelectedItem + " ";
            CryptoACLText += SourceAddText.Text + " ";
            CryptoACLText += SourceWildcardText.Text + " ";
            CryptoACLText += DestAddText.Text + " ";
            CryptoACLText += DestWildcardText.Text + " ";
            CryptoACLText += "\n";

            return CryptoACLText;

        }

        private void IdText_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SourceHostChecked_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SourceAddressText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
