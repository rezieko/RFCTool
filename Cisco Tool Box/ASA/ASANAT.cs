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
    public partial class ASANAT : Form
    {
        public ASANAT()
        {
            InitializeComponent();
            for (int i = 0; i <= 32; i++)
            {
                NATSubnetMaskAbbriev.Items.Add(i);
            }
            for (int i = 0; i <= 32; i++)
            {
                PATSubnetAbbriev.Items.Add(i);
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
            if (DynNATChecked.Checked)
            {
                FinalText += GetDynamicNAT();
            }
            if (PatChecked.Checked)
            {
                FinalText += GetDynamicPAT();
            }
            if (StaticNATChecked.Checked)
            {
                FinalText += GetStaticNAT();
            }
            return FinalText;
        }
        private string GetStaticNAT()
        {
            string StaticNAT = "";
            StaticNAT += "object network " + StaticNATObjNameText.Text + "\n";
            StaticNAT += "host " + HostIpText.Text + "\n";
            StaticNAT += "nat ( " + PATRealText.Text + " , " + PATMappedText.Text + " ) static " + InlineHostIpText.Text + "\n";
            StaticNAT += "exit \n";
           
            return StaticNAT;
        }
        private string GetDynamicPAT()
        {
            string DynamicPAT = "";
            DynamicPAT += "object network " + PATSubnetNameText.Text + "\n";
            DynamicPAT += "subnet " + PATSubnetIpText.Text + " " + GetPATSubnet() + "\n";
            DynamicPAT += "nat ( " + PATRealText.Text + " , " + PATMappedText.Text + " ) dynamic interface \n";
            DynamicPAT += "exit \n";

            return DynamicPAT;
        }
        private string GetDynamicNAT()
        {
            string DynamicNAT = "";
            DynamicNAT += "object network " + RangeObjNameText.Text + "\n";
            DynamicNAT += "range " + FirstAddText.Text + " " + LastAddText.Text + "\n";
            DynamicNAT += "exit \n";
            DynamicNAT += "object network " + NATSubnetObjNameText.Text + "\n";
            DynamicNAT += "subnet " + NATSubnetIPText.Text + " " + GetNATSubnet() + "\n";
            DynamicNAT += "nat ( " + DynNATRealIFCText.Text + " , " + DynNATMappedIFCText.Text + " ) dynamic " + DynNATMappedOBJText.Text + "\n";
            DynamicNAT += "exit \n";
            
            return DynamicNAT;
        }
        private string GetPATSubnet()
        {
            if (PATShouldUseIP.Checked)
            {
                return PATSubnetIpText.Text;
            }

            uint targ = Convert.ToUInt32(PATSubnetAbbriev.SelectedItem.ToString());
            //(2 ^ 32 - 1) - (2 ^ (32 - mask) - 1)
            long mask = ((long)(Math.Pow(2, 32) - 1)) - ((long)(Math.Pow(2, (32 - targ)) - 1));
            return IPAddress.Parse(mask.ToString()).ToString();
        }
        private string GetNATSubnet()
        {
            if (NATShouldUseIP.Checked)
            {
                return NATSubnetMaskText.Text;
            }

            uint targ = Convert.ToUInt32(NATSubnetMaskAbbriev.SelectedItem.ToString());
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
            NATSubnetMaskAbbriev.Enabled = !NATShouldUseIP.Checked;
            NATSubnetMaskText.Enabled = NATShouldUseIP.Checked;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void PATShouldUseIP_CheckedChanged(object sender, EventArgs e)
        {
            PATSubnetAbbriev.Enabled = !PATShouldUseIP.Checked;
            PATSubnetIipText.Enabled = PATShouldUseIP.Checked;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ASANAT_Load(object sender, EventArgs e)
        {

        }

        private void DynNATChecked_CheckedChanged(object sender, EventArgs e)
        {
            RangeObjNameText.Enabled = DynNATChecked.Checked;
            FirstAddText.Enabled = DynNATChecked.Checked;
            LastAddText.Enabled = DynNATChecked.Checked;
            NATSubnetObjNameText.Enabled = DynNATChecked.Checked;
            NATSubnetIPText.Enabled = DynNATChecked.Checked;
            DynNATMappedIFCText.Enabled = DynNATChecked.Checked;
            DynNATRealIFCText.Enabled = DynNATChecked.Checked;
            DynNATMappedOBJText.Enabled = DynNATChecked.Checked;
        }

        private void PatChecked_CheckedChanged(object sender, EventArgs e)
        {
            PATSubnetNameText.Enabled = PatChecked.Checked;
            PATSubnetIpText.Enabled = PatChecked.Checked;
            PATRealText.Enabled = PatChecked.Checked;
            PATMappedText.Enabled = PatChecked.Checked;
        }

        private void StaticNATChecked_CheckedChanged(object sender, EventArgs e)
        {
            StaticNATMappedText.Enabled = StaticNATChecked.Checked;
            HostIpText.Enabled = StaticNATChecked.Checked;
            StaticNATObjNameText.Enabled = StaticNATChecked.Checked;
            StaticNATRealText.Enabled = StaticNATChecked.Checked;
            InlineHostIpText.Enabled = StaticNATChecked.Checked;
        }
    }
}
