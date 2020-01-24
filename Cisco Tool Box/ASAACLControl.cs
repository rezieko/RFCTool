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
            CommandText += ProtoCombo.SelectedItem + " ";






            return CommandText;
        }
    }
}
