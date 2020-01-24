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
    public partial class EncapsulationDot1Q : Form
    {
        public EncapsulationDot1Q()
        {
            InitializeComponent();
        }

        private void EncapsulationDot1Q_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());     
        }
        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += GetSwitch();
            FinalText += GetRouter();

            return FinalText;
        }
        private string GetSwitch()
        {
            if (SwitchChecked.Checked)
            {
                string FinalSwitch = "";
                FinalSwitch += "interface " + InterfaceIDText.Text + "\n";
                FinalSwitch += "switchport mode trunk \n";
                FinalSwitch += "switchport trunk encapsulation dot1Q \n";

                return FinalSwitch;
            }
            return "";
        }
        private string GetRouter()
        {
            if (RouterChecked.Checked)
            {
                if (NativeChecked.Checked)
                {
                    string FinalRouterNative = "";
                    FinalRouterNative += "interface " + SubInterfaceIDText.Text + "\n";
                    FinalRouterNative += "encapsulation dot1Q " + VLANIDText.Text + " native \n";

                    return FinalRouterNative;
                }
                string FinalRouter = "";
                FinalRouter += "interface " + SubInterfaceIDText.Text + "\n";
                FinalRouter += "encapsulation dot1Q " + VLANIDText.Text + "\n";

                return FinalRouter;
            }
            return "";
        }

        private void SwitchChecked_CheckedChanged(object sender, EventArgs e)
        {
            InterfaceIDText.Enabled = SwitchChecked.Checked;
        }

        private void RouterChecked_CheckedChanged(object sender, EventArgs e)
        {
            SubInterfaceIDText.Enabled = RouterChecked.Checked;
            VLANIDText.Enabled = RouterChecked.Checked;
        }

        private void InterfaceIDText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
