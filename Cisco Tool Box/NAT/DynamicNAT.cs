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
    public partial class DynamicNAT : Form
    {
        private List<NATInterfacesBox> Boxes = new List<NATInterfacesBox>();
        public DynamicNAT()
        {
            InitializeComponent();
            InterfacesPanel.FlowDirection = FlowDirection.TopDown;
            InterfacesPanel.Location = new Point(12, 308);
            NumInterfaces_ValueChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }

        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += "access-list " + ACLNumberText.Text + " " + SourceText.Text + " " + WildcardText.Text + "\n";
            FinalText += GetPool();            
            FinalText += GetSourceList();
            FinalText += GetInterfaces();


            return FinalText;
        }  
        private string GetSourceList()
        {
            string SourceList = "";
            SourceList += "ip nat inside source list " + ACLNumberText.Text + " ";
            
            if (SingleGlobalChecked.Checked)
            {
                SourceList += "interface " + SingleIntText.Text + " ";
            }

            else
            {
                SourceList += "pool " + PoolNameText.Text + " ";
            }

            if (OverloadChecked.Checked)
            {
                SourceList += "overload";
            }

            SourceList += "\n";

            return SourceList;

        }
        private string GetInterfaces()
        {
            string FinalNetwork = "";
            foreach (var box in Boxes)
            {
                FinalNetwork += box.GetInterfaces();
            }
            return FinalNetwork;
        }
        private string GetPool()
        {
            string PoolText = "";
            PoolText += "ip nat pool " + PoolNameText.Text + " ";
            PoolText += StartAddrText.Text + " ";
            PoolText += EndAddrText.Text + " ";
            
            if (NetmaskChecked.Checked)
            {
                PoolText += "netmask " + NetmaskText.Text + " ";
            }

            if (PrefixChecked.Checked)
            {
                PoolText += "prefix-length " + PrefixText.Text + " ";
            }

            PoolText += "\n";

            return PoolText;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NumInterfaces_ValueChanged(object sender, EventArgs e)
        {
            while (InterfacesPanel.Controls.Count != NumInterfaces.Value)
            {
                if (InterfacesPanel.Controls.Count < NumInterfaces.Value)
                {
                    NATInterfacesBox V = new NATInterfacesBox();
                    Boxes.Add(V);
                    InterfacesPanel.Controls.Add(V);
                }
                else
                {
                    NATInterfacesBox V = Boxes[Boxes.Count - 1];
                    Boxes.Remove(V);
                    InterfacesPanel.Controls.Remove(V);
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SingleIntText.Enabled = SingleGlobalChecked.Checked;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DynamicNAT_Load(object sender, EventArgs e)
        {

        }
    }
}
