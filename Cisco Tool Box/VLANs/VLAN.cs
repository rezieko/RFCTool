using System;
using System.Windows.Forms;

namespace Cisco_Tool_Box
{
    public partial class VLAN : Form
    {
        public VLAN()
        {
            InitializeComponent();
        }

        private void VLAN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());            
        }
        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += "vlan " + VLANIDText.Text + "\n";
            FinalText += GetVLANName();
            FinalText += "exit \n";
            FinalText += GetPortVLAN();


            return FinalText;
        }
        private string GetPortVLAN()
        {
            if (PortVLANChecked.Checked)
            {
                if (InterfaceIDChecked.Checked) 
                {
                    string FinalInterface = "";
                    FinalInterface += "interface " + IntIDText.Text + "\n";
                    FinalInterface += "switchport mode access \n";
                    FinalInterface += "switchport access vlan " + PortVLANIDText.Text + "\n";
                    FinalInterface += "description " + DescText.Text + "\n";

                    return FinalInterface;
                }
                if (InterfaceRangeChecked.Checked)
                {
                    string FinalInterfaceRange = "";
                    FinalInterfaceRange += "interface range " + FirstintIDText.Text + " - " + LastIntIDText.Text + "\n";
                    FinalInterfaceRange += "switchport mode access \n";
                    FinalInterfaceRange += "switchport access vlan " + PortVLANIDText.Text + "\n";
                    FinalInterfaceRange += "description " + DescText.Text + "\n";

                    return FinalInterfaceRange;
                }                
            }
            return "";
        }
        private string GetVLANName()
        {
            if (VLANNameChecked.Checked)
            {
                return "name " + VLANNameText.Text + "\n";
            }
            return "";
        }

        private void VLANNameChecked_CheckedChanged(object sender, EventArgs e)
        {
            VLANNameText.Enabled = VLANNameChecked.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PortVLANIDText.Enabled = PortVLANChecked.Checked;
        }

        private void InterfaceRangeChecked_CheckedChanged(object sender, EventArgs e)
        {
            FirstintIDText.Enabled = InterfaceRangeChecked.Checked;
            LastIntIDText.Enabled = InterfaceRangeChecked.Checked;            
        }

        private void InterfaceIDChecked_CheckedChanged(object sender, EventArgs e)
        {
            IntIDText.Enabled = InterfaceIDChecked.Checked;            
        }

        private void IntIDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void VLANNameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
