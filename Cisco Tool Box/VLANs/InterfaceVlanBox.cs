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
    public partial class InterfaceVlanBox : UserControl
    {
        public InterfaceVlanBox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public string GetText()
        {
            string CommandText = "";
            CommandText += "interface " + InterfaceText.Text + "\n";
            CommandText += "switchport mode trunk \n";
            CommandText += "switchport nonegotiate \n";


            if (IsNative.Checked)
            {
                CommandText += "switchport trunk native vlan " + VlanIDText.Text + "\n";
            }
            else
            {
                CommandText += "switchport trunk allowed vlan " + VlanIDText.Text + "\n";
            }                                          
            return CommandText;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InterfaceVlanBox_Load(object sender, EventArgs e)
        {

        }
    }
}
