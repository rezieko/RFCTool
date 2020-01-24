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
    public partial class ASAACL : Form
    {
        private List<ASAACLControl> Boxes = new List<ASAACLControl>();
        public ASAACL()
        {
            InitializeComponent();
            BoxPanel.FlowDirection = FlowDirection.TopDown;
            BoxPanel.Location = new Point(13, 224);
            NumControls_ValueChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }
        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += GetACLControls();
            if (ApplyIntChecked.Checked)
            {
                FinalText += GetInterface();
            }
            return FinalText;
        }
        private string GetInterface()
        {
            string IntText = "";
            IntText += "access-group " + Acl1Text.Text + " ";
            if (In1Checked.Checked)
            {
                IntText += "in ";
            }
            if (Out1Checked.Checked)
            {
                IntText += "out ";
            }
            IntText += "interface " + Int1Text.Text + " ";
            if (PerUser1Checked.Checked)
            {
                IntText += "per-user-override ";
            }
            if (ControlPlane1Checked.Checked)
            {
                IntText += "control-plane ";
            }
            IntText += "access-group " + Acl2Text.Text + " ";
            if (In2Checked.Checked)
            {
                IntText += "in ";
            }
            if (Out2Checked.Checked)
            {
                IntText += "out ";
            }
            IntText += "interface " + Int2Text.Text + " ";
            if (PerUser2Checked.Checked)
            {
                IntText += "per-user-override ";
            }
            if (ControlPlane2Checked.Checked)
            {
                IntText += "control-plane ";
            }
            return IntText;
        }
        private string GetACLControls()
        {
            string FinalACL = "";
            foreach (var box in Boxes)
            {
                FinalACL += box.GetASAACL();
            }
            return FinalACL;
        }

        private void InterfaceChecked_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InterfaceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void InterfaceInChecked_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NumControls_ValueChanged(object sender, EventArgs e)
        {
            while (BoxPanel.Controls.Count != NumControls.Value)
            {
                if (BoxPanel.Controls.Count < NumControls.Value)
                {
                    ASAACLControl V = new ASAACLControl();
                    Boxes.Add(V);
                    BoxPanel.Controls.Add(V);
                }
                else
                {
                    ASAACLControl V = Boxes[Boxes.Count - 1];
                    Boxes.Remove(V);
                    BoxPanel.Controls.Remove(V);
                }
            }
        }
    }
}
