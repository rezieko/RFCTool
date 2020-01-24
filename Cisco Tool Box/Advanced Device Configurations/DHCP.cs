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
    public partial class DHCP : Form
    {
        private List<ExcludedAddressBox> Boxes = new List<ExcludedAddressBox>();
        public DHCP()
        {
            InitializeComponent();
            BoxPanel.FlowDirection = FlowDirection.TopDown;
            BoxPanel.Location = new Point(12, 337);
            NumExcludedIP_ValueChanged(null, null);

            for (int i = 0; i <= 32; i++)
            {
                SubnetMaskAbbriev.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
        }
        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += GetExcluded();
            FinalText += "ip dhcp pool " + PoolNameText.Text + "\n";
            FinalText += GetNetwork();
            FinalText += "default-router " + DefaultRouterAddressText.Text + "\n";
            FinalText += GetDNSServer();
            FinalText += GetDomainName();
            FinalText += GetLeaseDuration();
            FinalText += GetNetBIOSServer();
            
            return FinalText;

        }
        private string GetNetBIOSServer()
        {
            if (NetBIOSChecked.Checked)
            {
                return "netbios-name-server " + NetBIOSAddressText.Text + "\n";
            }
            return "";
        }

        private string GetLeaseDuration()
        {
            if (LeaseChecked.Checked)
            {
                if (LeaseInfiniteChecked.Checked)
                {
                    return "lease infinite \n";
                }
                return "lease " + LeaseDaysText.Text + " " + LeaseHoursText.Text + " " + LeaseMinutesText.Text + "\n";
            }
            return "";
        }
        private string GetDomainName()
        {
            if (DomainNameChecked.Checked)
            {
                return "domain-name " + DomainNameText.Text + "\n";
            }
            return "";
        }

        private string GetDNSServer()
        {
            if (DNSServerChecked.Checked)
            {
                return "dns-server " + DNSServerAddressText.Text + "\n";
            }
            return "";
        }
        
        private string GetNetwork()
        {
            if (NetworkSubnetChecked.Checked)
            {
                return "network " + NetworkAddressText.Text + " " + GetNetworkSubnet() + "\n";
            }
            return "network " + NetworkAddressText.Text + "\n";
        }
        
        private string GetNetworkSubnet()
        {
            if (ShouldUseIP.Checked)
            {
                return NetworkSubnetText.Text;
            }

            uint targ = Convert.ToUInt32(SubnetMaskAbbriev.SelectedItem.ToString());
            //(2 ^ 32 - 1) - (2 ^ (32 - mask) - 1)
            long mask = ((long)(Math.Pow(2, 32) - 1)) - ((long)(Math.Pow(2, (32 - targ)) - 1));
            return System.Net.IPAddress.Parse(mask.ToString()).ToString();
        }
        
        private string GetExcluded()
        {
            string FinalExcludedAddress = "";
            foreach (var box in Boxes)
            {
                FinalExcludedAddress += box.GetExcludedAddress();
            }
            return FinalExcludedAddress;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SubnetMaskAbbriev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NetworkSubnetText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShouldUseIP_CheckedChanged(object sender, EventArgs e)
        {
            NetworkSubnetText.Enabled = ShouldUseIP.Checked;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumExcludedIP_ValueChanged(object sender, EventArgs e)
        {
            while (BoxPanel.Controls.Count != NumExcludedIP.Value)
            {
                if (BoxPanel.Controls.Count < NumExcludedIP.Value)
                {
                    ExcludedAddressBox V = new ExcludedAddressBox();
                    Boxes.Add(V);
                    BoxPanel.Controls.Add(V);
                }
                else
                {
                    ExcludedAddressBox V = Boxes[Boxes.Count - 1];
                    Boxes.Remove(V);
                    BoxPanel.Controls.Remove(V);
                }
            }
        }

        private void DNSServerChecked_CheckedChanged(object sender, EventArgs e)
        {
            DNSServerAddressText.Enabled = DNSServerChecked.Checked;
        }

        private void DomainNameChecked_CheckedChanged(object sender, EventArgs e)
        {
            DomainNameText.Enabled = DomainNameChecked.Checked;
        }

        private void DNSServerAddressText_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeaseChecked_CheckedChanged(object sender, EventArgs e)
        {
            LeaseHoursText.Enabled = LeaseChecked.Checked;
            LeaseDaysText.Enabled = LeaseChecked.Checked;
            LeaseMinutesText.Enabled = LeaseChecked.Checked;
        }

        private void NetBIOSChecked_CheckedChanged(object sender, EventArgs e)
        {
            NetBIOSAddressText.Enabled = NetBIOSChecked.Checked;
        }
    }
}
