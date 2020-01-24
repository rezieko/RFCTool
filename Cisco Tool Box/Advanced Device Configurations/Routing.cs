using System;
using System.Windows.Forms;

namespace Cisco_Tool_Box
{
    public partial class Routing : Form
    {
        public Routing()
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
            FinalText += GetStaticRoute();
            FinalText += GetDefault();

            return FinalText;
        }
        
        private string GetDefault()
        {
            if (DefaultChecked.Checked)
            {
                string DefaultText = "";

                DefaultText += "ip route 0.0.0.0 0.0.0.0 ";
                if (InterfaceIDChecked.Checked && NextHopIPChecked.Checked)
                {
                    return DefaultText += InterfaceIDText.Text + " " + NextHopIPText.Text;
                }
                
                if (InterfaceIDChecked.Checked)
                {
                    return DefaultText += InterfaceIDText.Text;
                }

                if (NextHopIPChecked.Checked)
                {
                    return DefaultText += NextHopIPText.Text;
                }

                DefaultText += "\n";

                return DefaultText;
            }
            return "";
            
        }
        
        private string GetStaticRoute()
        {
            if (StaticRouteChecked.Checked)
            {
                if (InterfaceIDChecked.Checked && NextHopIPChecked.Checked)
                {
                    return "ip route " + NetworkText.Text + " " + GetSubnet() + " " + InterfaceIDText.Text + " " + NextHopIPText.Text + "\n";
                }

                else if (InterfaceIDChecked.Checked)
                {
                    return "ip route " + NetworkText.Text + " " + GetSubnet() + " " + InterfaceIDText.Text + "\n";
                }

                else if (NextHopIPChecked.Checked)
                {
                    return "ip route " + NetworkText.Text + " " + GetSubnet() + " " + NextHopIPText.Text + "\n";
                }                               
                return "ip route " + NetworkText.Text + " " + GetSubnet() + "\n";
            }
            return "";
        }
        private string GetSubnet()
        {
            if (ShouldUseIPChecked.Checked)
            {
                return SubnetMaskText.Text;
            }

            uint targ = Convert.ToUInt32(SubnetMaskAbbriev.SelectedItem.ToString());
            //(2 ^ 32 - 1) - (2 ^ (32 - mask) - 1)
            long mask = ((long)(Math.Pow(2, 32) - 1)) - ((long)(Math.Pow(2, (32 - targ)) - 1));
            return System.Net.IPAddress.Parse(mask.ToString()).ToString();
        }

        private void SubnetMaskAbbriev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShouldUseIPChecked_CheckedChanged(object sender, EventArgs e)
        {
            SubnetMaskAbbriev.Enabled = !ShouldUseIPChecked.Checked;
            SubnetMaskText.Enabled = ShouldUseIPChecked.Checked;
        }

        private void StaticRouteChecked_CheckedChanged(object sender, EventArgs e)
        {
            NetworkText.Enabled = StaticRouteChecked.Checked;
            SubnetMaskAbbriev.Enabled = StaticRouteChecked.Checked;
            SubnetMaskText.Enabled = StaticRouteChecked.Checked;
            InterfaceIDText.Enabled = StaticRouteChecked.Checked;
            NextHopIPText.Enabled = StaticRouteChecked.Checked;
        }

        private void NetworkText_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            InterfaceIDText.Enabled = DefaultChecked.Checked;
            NextHopIPText.Enabled = DefaultChecked.Checked;
        }
    }
}
