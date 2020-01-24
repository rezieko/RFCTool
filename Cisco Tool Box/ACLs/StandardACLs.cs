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
    public partial class StandardACLs : Form
    {
        private List<StandardPermitDenyRemarkBox> Boxes = new List<StandardPermitDenyRemarkBox>();
        public StandardACLs()
        {
            InitializeComponent();
            BoxPanel.FlowDirection = FlowDirection.TopDown;
            BoxPanel.Location = new Point(15, 171);
            NumericUpDown1_ValueChanged(null, null);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }
        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += "ip access-list standard " + IDText.Text + "\n";
            FinalText += GetControls() + "exit \n";
            FinalText += GetInterface();
            FinalText += GetVTY();


            return FinalText;
        }
        private string GetVTY()
        {
            if (VTYInChecked.Checked)
            {
                string GetVTYText = "";
                GetVTYText += "line vty 0 4 \n";
                GetVTYText += "login local \n";
                GetVTYText += "transport input ssh \n";

                if (VTYInChecked.Checked)
                {
                    return GetVTYText + "access-class " + IDText.Text + " in \n";
                }

                if (VTYOutChecked.Checked)
                {
                    return GetVTYText + "access-class " + IDText.Text + " out \n";
                }
            }
            return "";
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
            return "";


        }
        private string GetControls()
        {
            string FinalNetwork = "";
            foreach (var box in Boxes)
            {
                FinalNetwork += box.GetControlsText();
            }
            return FinalNetwork;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            while (BoxPanel.Controls.Count != NumControls.Value)
            {
                if (BoxPanel.Controls.Count < NumControls.Value)
                {
                    StandardPermitDenyRemarkBox V = new StandardPermitDenyRemarkBox();
                    Boxes.Add(V);
                    BoxPanel.Controls.Add(V);
                }
                else
                {
                    StandardPermitDenyRemarkBox V = Boxes[Boxes.Count - 1];
                    Boxes.Remove(V);
                    BoxPanel.Controls.Remove(V);
                }
            }
        }

        private void StandardACLs_Load(object sender, EventArgs e)
        {

        }

        private void InterfaceChecked_CheckedChanged(object sender, EventArgs e)
        {
            InterfaceText.Enabled = InterfaceChecked.Checked;
        }

        private void InterfaceInChecked_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
