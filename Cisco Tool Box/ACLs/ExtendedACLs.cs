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
    public partial class ExtendedACLs : Form
    {
        private List<ExtendedPermitDenyRemarkBox> Boxes = new List<ExtendedPermitDenyRemarkBox>();
        public ExtendedACLs()
        {
            InitializeComponent();
            BoxPanel.FlowDirection = FlowDirection.TopDown;
            BoxPanel.Location = new Point(11, 142);
            NumericUpDown1_ValueChanged(null, null);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());            
        }
        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += "ip access-list extended " + IDText.Text + "\n";
            FinalText += GetExtendedACLControls() + "exit \n";
            FinalText += GetInterface();

            return FinalText;

        }

        private void ExtendedACLs_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private string GetInterface()
        {
            if (InterfaceChecked.Checked)
            {
                if (InterfaceInChecked.Checked)
                {
                    return "interface " + InterfaceText.Text + "\n" + "ip access-group " + IDText.Text + " in \n" + "exit \n";
                }
                if (InterfaceOutChecked.Checked)
                {
                    return "interface " + InterfaceText.Text + "\n" + "ip access-group " + IDText.Text + " out \n" + "exit \n";
                }
            }
            return "";        }
 
        private string GetExtendedACLControls()
        {
            string FinalNetwork = "";
            foreach (var box in Boxes)
            {
                FinalNetwork += box.GetExtendedControlsText();
            }
            return FinalNetwork;
        }
        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            while (BoxPanel.Controls.Count != NumControls.Value)
            {
                if (BoxPanel.Controls.Count < NumControls.Value)
                {
                    ExtendedPermitDenyRemarkBox V = new ExtendedPermitDenyRemarkBox();
                    Boxes.Add(V);
                    BoxPanel.Controls.Add(V);
                }
                else
                {
                    ExtendedPermitDenyRemarkBox V = Boxes[Boxes.Count - 1];
                    Boxes.Remove(V);
                    BoxPanel.Controls.Remove(V);
                }
            }
        }

        private void InterfaceChecked_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InterfaceInChecked_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void IDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void InterfaceText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
