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
    public partial class PortFowarding : Form
    {
        private List<NATInterfacesBox> Boxes = new List<NATInterfacesBox>();
        public PortFowarding()
        {
            InitializeComponent();            
            InterfacesPanel.FlowDirection = FlowDirection.TopDown;
            InterfacesPanel.Location = new Point(15, 198);
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
            FinalText += GetPortForward();
            FinalText += GetInterfaces();

            return FinalText;
        }
        private string GetPortForward()
        {
            string PortForward = "";
            PortForward += "ip nat inside source static " + ProtocolCombo.SelectedItem + " ";
            PortForward += LocalAdrText.Text + " ";
            PortForward += LocalPortText.Text + " ";
            PortForward += GlobalAdrText.Text + " ";
            PortForward += GlobalPortText.Text + " ";

            if (ExtendableChecked.Checked)
            {
                PortForward += "extendable";
            }

            PortForward += "\n";

            return PortForward;
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

        private void ProtocolCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
