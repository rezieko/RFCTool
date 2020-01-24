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
    public partial class CompatibleIPSecVPNACLs : Form
    {
        private List<IPSecVPNACL> Boxes = new List<IPSecVPNACL>();
        public CompatibleIPSecVPNACLs()
        {
            InitializeComponent();
            BoxPanel.FlowDirection = FlowDirection.TopDown;
            BoxPanel.Location = new Point(13, 67);
            NumAcls_ValueChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }
        private string GetFinalText()
        {
            return GetIPSecACLControls();
        }
        private string GetIPSecACLControls()
        {
            string FinalNetwork = "";
            foreach (var box in Boxes)
            {
                FinalNetwork += box.GetIpSecVpnAclText();
            }
            return FinalNetwork;
        }

        private void NumAcls_ValueChanged(object sender, EventArgs e)
        {
            while (BoxPanel.Controls.Count != NumAcls.Value)
            {
                if (BoxPanel.Controls.Count < NumAcls.Value)
                {
                    IPSecVPNACL V = new IPSecVPNACL();
                    Boxes.Add(V);
                    BoxPanel.Controls.Add(V);
                }
                else
                {
                    IPSecVPNACL V = Boxes[Boxes.Count - 1];
                    Boxes.Remove(V);
                    BoxPanel.Controls.Remove(V);
                }
            }
        }
    }
}
