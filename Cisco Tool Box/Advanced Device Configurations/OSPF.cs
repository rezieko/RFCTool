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
    public partial class OSPF : Form
    {
        private List<NetworkBox> Boxes = new List<NetworkBox>();
        public OSPF()
        {
            InitializeComponent();
            BoxPanel.FlowDirection = FlowDirection.TopDown;
            BoxPanel.Location = new Point(12, 130);
            numericUpDown1_ValueChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }
        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += "router ospf " + ProcessIDText.Text + "\n";
            FinalText += GetRouterID();
            FinalText += GetNetwork();
            FinalText += GetPassiveInt();

            return FinalText;
        }
        private string GetNetwork()
        {
            string FinalNetwork = ""; 
            foreach(var box in Boxes)
            {
                FinalNetwork += box.GetText();
            }
            return FinalNetwork;
        }
        private string GetRouterID()
        {
            if (RouterIDChecked.Checked)
            {
                return "router " + RouterIDText.Text + "\n";
            }
            return "";
        }
        private string GetPassiveInt()
        {
            if (PassiveIntCheck.Checked)
            {
                return "passive-interface " + InterfaceText.Text + "\n";
            }
            return "";
        }   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RouterIDChecked_CheckedChanged(object sender, EventArgs e)
        {
            RouterIDText.Enabled = RouterIDChecked.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void NetworkAddressText_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            InterfaceText.Enabled = PassiveIntCheck.Checked;
        }

        private void OSPF_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            while (BoxPanel.Controls.Count != NumNetworks.Value)
            {
                if (BoxPanel.Controls.Count < NumNetworks.Value)
                {
                    NetworkBox V = new NetworkBox();
                    Boxes.Add(V);
                    BoxPanel.Controls.Add(V);
                }
                else
                {
                    NetworkBox V = Boxes[Boxes.Count - 1];
                    Boxes.Remove(V);
                    BoxPanel.Controls.Remove(V);
                }
            }
        }
    }
}
