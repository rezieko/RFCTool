using System;
using System.Windows.Forms;

namespace Cisco_Tool_Box
{
    public partial class MACAddressSecurity : Form
    {
        public MACAddressSecurity()
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
            FinalText += "interface " + InterfaceIDText.Text + "\n";
            FinalText += "switchport mode access \n";
            FinalText += "switchport port-security \n";
            FinalText += GetMaxMAC();
            FinalText += GetStaticMAC();
            FinalText += GetDynamicMAC();
            FinalText += GetViolationMode();


            return FinalText;
        }
        private string GetViolationMode()
        {
            if (ViolationModeChecked.Checked)
            {
                return "switchport port-security violation " + ViolationDropDown.SelectedItem + "\n";
            }
            return "";
        }
        private string GetDynamicMAC()
        {
            if (DynamicMACChecked.Checked)
            {
                if (MACAddressChecked.Checked)
                {
                    return "switchport port-security mac-address sticky " + DynamicMACText.Text + "\n";
                }
                return "switchport port-security mac-address sticky \n";
            }
            return "";
        }
        private string GetMaxMAC()
        {
            if (MaxMACChecked.Checked)
            {
                return "switchport port-security maximum " + MaxMACText.Text + "\n";
            }
            return "";
        }
        private string GetStaticMAC()
        {
            if (StaticMacChecked.Checked)
            {
                return "switchport port-security mac-address " + StaticMacText.Text + "\n";
            }
            return "";
        }

        private void InterfaceIDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            StaticMacText.Enabled = StaticMacChecked.Checked;
        }

        private void StaticMacText_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxMACChecked_CheckedChanged(object sender, EventArgs e)
        {
            MaxMACText.Enabled = MaxMACChecked.Checked;
        }

        private void MACAddressChecked_CheckedChanged(object sender, EventArgs e)
        {
            DynamicMACText.Enabled = MACAddressChecked.Checked;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViolationDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViolationModeChecked_CheckedChanged(object sender, EventArgs e)
        {
            ViolationDropDown.Enabled = ViolationModeChecked.Checked;
        }
    }
}
