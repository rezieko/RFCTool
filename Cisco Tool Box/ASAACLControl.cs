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
    public partial class ASAACLControl : UserControl
    {
        public ASAACLControl()
        {
            InitializeComponent();
        }
        public string GetASAACL()
        {
            string CommandText = "";
            CommandText += "access-list " + AclIdText.Text + " ";
            if (ExtendedChecked.Checked)
            {
                CommandText += "extended ";
            }
            CommandText += DenyPermitCombo.SelectedItem + " ";
            CommandText += ProtoCombo.SelectedItem;
            if (SrcHostChecked.Checked)
            {
                CommandText += "host ";
            }
            if (SrcIntChecked.Checked)
            {
                CommandText += "interface ";
            }
            CommandText += SrcAddText.Text + " ";

            if (!SrcHostChecked.Checked && !SrcIntChecked.Checked)
            {
                CommandText += SrcMaskText.Text + " ";
            }

            if (SrcOpPortChecked.Checked)
            {
                CommandText += SrcOpPortText.Text + " ";

                if (SrcPort2Checked.Checked)
                {
                    CommandText += SrcPort2Text.Text + " ";
                }
            }
            if (DestHostChecked.Checked)
            {
                CommandText += "host ";
            }
            if (DestIntChecked.Checked)
            {
                CommandText += "interface ";
            }
            CommandText += DestAddText.Text + " ";
            if (!DestHostChecked.Checked && !DestIntChecked.Checked)
            {
                CommandText += DestMaskText.Text + " ";
            }
            if (DestOpPortChecked.Checked)
            {
                CommandText += DestOpPortText.Text + " ";
                if (DestPort2Checked.Checked)
                {
                    CommandText += DestPort2Text.Text + " ";
                }
            }
            CommandText += "\n";
            return CommandText;
        }

        private void AclIdText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
