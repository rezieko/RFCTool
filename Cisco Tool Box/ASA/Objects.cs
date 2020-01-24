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
    public partial class Objects : Form
    {
        public Objects()
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
            if (NetworkChecked.Checked)
            {
                FinalText += GetNetworkObject();
            }
            if (ServiceChecked.Checked)
            {
                FinalText += GetServiceObject();
            }

            return FinalText;
        }
        private string GetNetworkObject()
        {
            string NetworkObject = "";
            NetworkObject += "object network " + NetworkNameText.Text + "\n";
            
            if (HostIpChecked.Checked)
            {
                NetworkObject += "host " + HostIpText.Text + "\n";
            }
            
            if (SubnetChecked.Checked)
            {
                NetworkObject += "subnet " + SubnetNetAddText.Text + " " + SubnetNetMaskText.Text + "\n";
            }

            if (RangeChecked.Checked)
            {
                NetworkObject += "range " + Add1Text.Text + " " + LastAddText.Text + "\n";
            }

            NetworkObject += "exit \n";

            return NetworkObject;
        }
        
        private string GetServiceObject()
        {
            string ServiceObject = "";
            ServiceObject += "object service " + ServiceNameText.Text + "\n";
            if (ProtocolChecked.Checked)
            {
                ServiceObject += "service " + ProtocolCombo.SelectedItem + " ";

                if (SourceChecked.Checked)
                {
                    ServiceObject += "source ";

                    if (SourceOpPortChecked.Checked)
                    {
                        ServiceObject += SourceOpCombo.SelectedItem + " " + SourcePortText.Text + " ";
                    }
                }

                if (DestChecked.Checked)
                {
                    ServiceObject += "destination ";
                    
                    if (DestOpPortChecked.Checked)
                    {
                        ServiceObject += DestOpCombo.SelectedItem + " " + DestPortText.Text + " ";
                    }
                }

                ServiceObject += "\n";
            }

            if (IcmpChecked.Checked)
            {
                ServiceObject += "service icmp " + IcmpText.Text + "\n";
            }
            
            if (Icmp6Checked.Checked)
            {
                ServiceObject += "service icmp6 " + Icmp6Text.Text + "\n";
            }
            ServiceObject += "exit \n";
                                                         
            return ServiceObject;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            IcmpText.Enabled = IcmpChecked.Checked;
        }

        private void Icmp6Checked_CheckedChanged(object sender, EventArgs e)
        {
            Icmp6Text.Enabled = Icmp6Checked.Checked;
        }

        private void SourceOpPortChecked_CheckedChanged(object sender, EventArgs e)
        {
            SourceOpCombo.Enabled = SourceOpPortChecked.Checked;
            SourcePortText.Enabled = SourceOpPortChecked.Checked;
        }

        private void DestOpPortChecked_CheckedChanged(object sender, EventArgs e)
        {
            DestOpCombo.Enabled = DestOpPortChecked.Checked;
            DestPortText.Enabled = DestOpPortChecked.Checked;
        }

        private void HostIpChecked_CheckedChanged(object sender, EventArgs e)
        {
            HostIpText.Enabled = HostIpChecked.Checked;
        }

        private void SubnetChecked_CheckedChanged(object sender, EventArgs e)
        {
            SubnetNetAddText.Enabled = SubnetChecked.Checked;
            SubnetNetMaskText.Enabled = SubnetChecked.Checked;
        }

        private void RangeChecked_CheckedChanged(object sender, EventArgs e)
        {
            LastAddText.Enabled = RangeChecked.Checked;
            Add1Text.Enabled = RangeChecked.Checked;
        }

        private void NetworkChecked_CheckedChanged(object sender, EventArgs e)
        {
            NetworkNameText.Enabled = NetworkChecked.Checked;
        }

        private void ServiceChecked_CheckedChanged(object sender, EventArgs e)
        {
            ServiceNameText.Enabled = ServiceChecked.Checked;
        }
    }
}
