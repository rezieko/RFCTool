﻿using System;
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
    public partial class GREVPN : Form
    {
        public GREVPN()
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
            FinalText += "interface tunnel 0\n";
            FinalText += "tunnel mode gre ip\n";
            FinalText += "ip address " + IPAddText.Text + " " + GetSubnet() + "\n";
            FinalText += "tunnel source " + SourceIpText.Text + "\n";
            FinalText += "tunnel destination " + DestIpText.Text + "\n";
            FinalText += "exit \n";

            return FinalText;
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

        private void SubnetMaskAbbriev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShouldUseIP_CheckedChanged(object sender, EventArgs e)
        {
            SubnetMaskAbbriev.Enabled = !ShouldUseIP.Checked;
            SubnetMaskText.Enabled = ShouldUseIP.Checked;
        }
    }
}
