using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cisco_Tool_Box
{
    public partial class IPv4ConfigForm : Form
    {
        public IPv4ConfigForm()
        {            
            InitializeComponent();

            for(int i = 0; i <= 32; i++)
            {
                SubnetMaskAbbriev.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CopyInterface(InterfaceText.Text, IPAddressText.Text);           
        }

        private void CopyInterface(string interfacetext, string ipaddresstext) 
        {
            // MessageBox.Show("int " + interfacetext);

            string CommandText = ("");
            CommandText += "interface " + interfacetext + "\n";
            
            CommandText += "ip address " + ipaddresstext;            
            
            CommandText += " " + GetSubnet() + "\n";

            CommandText += "no shutdown \n";

            CommandText += "description " + DescText.Text + "\n";
            
            System.Windows.Forms.Clipboard.SetText(CommandText);


        }
        
        private string GetSubnet()
        {
            if (ShouldUseIP.Checked)
            {
                return SubnetMaskText.Text;
            }
            
            uint targ = Convert.ToUInt32(SubnetMaskAbbriev.SelectedItem.ToString());
            //(2 ^ 32 - 1) - (2 ^ (32 - mask) - 1)
            long mask = ((long)(Math.Pow(2, 32) - 1)) - ((long)(Math.Pow(2, (32 - targ)) - 1));
            return IPAddress.Parse(mask.ToString()).ToString();
        }

        private void Interface_Click(object sender, EventArgs e)
        {

        }

        private void InterfaceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShouldUseIP_CheckedChanged(object sender, EventArgs e)
        {
            SubnetMaskAbbriev.Enabled = !ShouldUseIP.Checked;
            SubnetMaskText.Enabled = ShouldUseIP.Checked;
        }

        private void IPv4ConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void IPAddressText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubnetMaskAbbriev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DescText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
