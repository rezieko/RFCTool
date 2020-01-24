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
    public partial class StandardPermitDenyRemarkBox : UserControl
    {
        public StandardPermitDenyRemarkBox()
        {
            InitializeComponent();
        }

        private void PermitDenyRemarkBox_Load(object sender, EventArgs e)
        {

        }
        public string GetControlsText()
        {
            if (HostChecked.Checked)
            {
                return ControlsText.Text + " host " + SourceAddressText.Text + " " + GetLog() + "\n";
            }
            
            return ControlsText.Text + " " + SourceAddressText.Text + " " + SourceWildcardText.Text + " "  + GetLog() + "\n" ;
        }
        
        private string GetLog()
        {
            if (LogChecked.Checked)
            {
                return "log";
            }
            return "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HostChecked_CheckedChanged(object sender, EventArgs e)
        {   
                if (HostChecked.Checked)
                {
                    SourceWildcardText.Enabled = false;
                }
                else
                {
                    SourceWildcardText.Enabled = true;
                }
        }
    }
}
