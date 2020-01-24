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
    public partial class ExtendedPermitDenyRemarkBox : UserControl
    {
        public ExtendedPermitDenyRemarkBox()
        {
            InitializeComponent();
        }

        private void ExtendedPermitDenyRemarkBox_Load(object sender, EventArgs e)
        {

        }
        public string GetExtendedControlsText()
        {
            string CommandText = "";
            CommandText += OptionsCombo.SelectedItem + " ";
            CommandText += ProtocolsCombo.SelectedItem + " ";
            
            if (SourceHostChecked.Checked)
            {
                CommandText += "host ";
            }

            CommandText += SourceAddressText.Text + " ";

            if (!SourceHostChecked.Checked)
            {
                CommandText += SourceWildcardText.Text + " ";
            }

            if (SourcePortChecked.Checked)
            {
                CommandText += SourcePortText.Text + " ";
            }

            if (DestinationHostChecked.Checked)
            {
                CommandText += "host ";
            }

            CommandText += DestinationAddressText.Text + " ";

            if (!DestinationHostChecked.Checked)
            {
                CommandText += DestinationWildcardText.Text + " ";
            }

            if (SourcePortChecked.Checked)
            {
                CommandText += DestinationPortText.Text + " ";
            }
            return CommandText + "\n";

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DestinationOperatorPortText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DestinationAddressText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProtocolsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OptionsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SourceAddressText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DestinationHostChecked_CheckedChanged(object sender, EventArgs e)
        {
            DestinationWildcardText.Enabled = false;
        }

        private void SourceHostChecked_CheckedChanged(object sender, EventArgs e)
        {
            SourceWildcardText.Enabled = false;
        }
    }
}
