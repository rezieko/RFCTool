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
    public partial class ObjectGroup : Form
    {
        public ObjectGroup()
        {
            InitializeComponent();
            for (int i = 0; i <= 32; i++)
            {
                SubnetMaskAbbriev.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }
        private string GetFinalText()
        {
            string FinalText = "";
            if (NetworkChecked.Checked)
            {
                FinalText += GetNetwork();
            }
            if (ProtocolChecked.Checked)
            {
                FinalText += GetProtocol();
            }
            if (IcmpTypeChecked.Checked)
            {
                FinalText += GetICMPType();
            }
            if (ServiceChecked.Checked)
            {
                FinalText +=  GetService();
            }

            return FinalText;
        }
        private string GetService()
        {
            string ServiceText = "";
            ServiceText += "object-group service " + ServiceNameText.Text + " " + TcpCombo.SelectedItem + "\n";
            ServiceText += "description " + ServiceDescText.Text + "\n";
            
            if (EqChecked.Checked)
            {
                ServiceText += "port-object eq " + PortText.Text + "\n";
            }

            if (RangeChecked.Checked)
            {
                ServiceText += "port-object range " + FirstAddText.Text + " " + LastAddText.Text + "\n";
            }
            ServiceText += "exit \n";

            return ServiceText;
        }
        private string GetICMPType()
        {
            string IcmpType = "";
            IcmpType += "object-group icmp-type " + IcmpNameText.Text + "\n";
            IcmpType += "description " + IcmpDescText.Text + "\n";
            IcmpType += "icmp-object " + IcmpTypesCombo.SelectedItem + "\n";
            IcmpType += "exit \n";
            return IcmpType;
        }
        private string GetProtocol()
        {
            string ProtocolText = "";
            ProtocolText += "object-group protocol " + ProtocolNameText.Text + "\n";
            ProtocolText += "description " + ProtocolDescText.Text + "\n";
            ProtocolText += "protocol-object " + ProtocolCombo.SelectedItem + "\n";
            ProtocolText += "exit \n";
            return ProtocolText;
        }
        private string GetNetwork()
        {
            string NetworkText = "";
            NetworkText += "object-group network " + NetworkNameText.Text + "\n";
            NetworkText += "description " + NetworkDescText.Text + "\n";
           
            if (IpChecked.Checked)
            {
                NetworkText += "network-object ";
                NetworkText += IpAddText.Text + " " + GetSubnet() + "\n";
            }

            if (HostChecked.Checked)
            {
                NetworkText += "network-object ";
                NetworkText += "host " + HostIpText.Text + "\n";
            }
            NetworkText += "exit \n";

            return NetworkText;
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

        private void SubnetMaskAbbriev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShouldUseIP_CheckedChanged(object sender, EventArgs e)
        {
            SubnetMaskAbbriev.Enabled = !ShouldUseIP.Checked;
            SubnetMaskText.Enabled = ShouldUseIP.Checked;
        }

        private void RangeChecked_CheckedChanged(object sender, EventArgs e)
        {
            FirstAddText.Enabled = RangeChecked.Checked;
            LastAddText.Enabled = RangeChecked.Checked;
        }

        private void EqChecked_CheckedChanged(object sender, EventArgs e)
        {
            PortText.Enabled = EqChecked.Checked;
        }

        private void ServiceChecked_CheckedChanged(object sender, EventArgs e)
        {
            ServiceNameText.Enabled = ServiceChecked.Checked;
            ServiceDescText.Enabled = ServiceChecked.Checked;
            TcpCombo.Enabled = ServiceChecked.Checked;
        }

        private void HostChecked_CheckedChanged(object sender, EventArgs e)
        {
            label12321.Enabled = HostChecked.Checked;
        }

        private void NetworkChecked_CheckedChanged(object sender, EventArgs e)
        {
            NetworkNameText.Enabled = NetworkChecked.Checked;
        }

        private void ProtocolChecked_CheckedChanged(object sender, EventArgs e)
        {
            ProtocolNameText.Enabled = ProtocolChecked.Checked;
            ProtocolDescText.Enabled = ProtocolChecked.Checked;
            ProtocolCombo.Enabled = ProtocolChecked.Checked;
        }

        private void IcmpTypeChecked_CheckedChanged(object sender, EventArgs e)
        {
            IcmpDescText.Enabled = IcmpTypeChecked.Checked;
            IcmpNameText.Enabled = IcmpTypeChecked.Checked;
            IcmpTypesCombo.Enabled = IcmpTypeChecked.Checked;
        }
    }
}
