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
    public partial class CryptoACLandMap : Form
    {
        private List<CryptoACL> Boxes = new List<CryptoACL>();
        public CryptoACLandMap()
        {
            InitializeComponent();
            BoxPanel.FlowDirection = FlowDirection.TopDown;
            BoxPanel.Location = new Point(13, 323);
            NumAcls_ValueChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }
        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += GetCryptoACL();
            FinalText += GetCryptoMap();

            return FinalText;
        }
        private string GetCryptoMap()
        {
            string CryptoMap = "";
            CryptoMap += "crypto map " + MapNameText.Text + " " + SeqNumText.Text + " ";
            if (ManualChecked.Checked)
            {
                CryptoMap += "ipsec-manual ";
            }
            if (IsakmpChecked.Checked)
            {
                CryptoMap += "ipsec-isakmp ";
            }
            if (DynamicChecked.Checked)
            {
                CryptoMap += "dynamic " + DynMapNameText.Text;
            }
            CryptoMap += "\n";

            CryptoMap += "match address " + MatchAclText.Text + "\n";

            CryptoMap += "set peer ";
            if (HostnameChecked.Checked)
            {
                CryptoMap += HostnameText.Text + " ";
            }
            if (IpAddChecked.Checked)
            {
                CryptoMap += IpAddText.Text + " ";
            }
            CryptoMap += "\n";

            CryptoMap += "set pfs " + PfsGroupCombo.SelectedItem + "\n";

            CryptoMap += "set transform-set " + TransformText.Text + "\n";

            CryptoMap += "security-association lifetime ";
            if (SecondsChecked.Checked)
            {
                CryptoMap += "seconds " + SecsText.Text;
            }
            if (KilobytesChecked.Checked)
            {
                CryptoMap += "kilobytes " + KilobyteText.Text;
            }
            CryptoMap += "\n";
                                          
            return CryptoMap;
        }
        private string GetCryptoACL()
        {
            string FinalACL = "";
            foreach (var box in Boxes)
            {
                FinalACL += box.GetCryptoACL();
            }
            return FinalACL;
        }

        private void HostnameChecked_CheckedChanged(object sender, EventArgs e)
        {
            IpAddText.Enabled = false;
        }

        private void IpAddChecked_CheckedChanged(object sender, EventArgs e)
        {
            HostnameText.Enabled = false;
        }

        private void DynamicChecked_CheckedChanged(object sender, EventArgs e)
        {
            DynMapNameText.Enabled = DynamicChecked.Checked;
        }

        private void SecondsChecked_CheckedChanged(object sender, EventArgs e)
        {
            KilobyteText.Enabled = false;
        }

        private void KilobytesChecked_CheckedChanged(object sender, EventArgs e)
        {
            SecsText.Enabled = false;
        }

        private void ManualChecked_CheckedChanged(object sender, EventArgs e)
        {
            DynamicChecked.Enabled = false;
            DynMapNameText.Enabled = false; 
        }

        private void NumAcls_ValueChanged(object sender, EventArgs e)
        {
            while (BoxPanel.Controls.Count != NumAcls.Value)
            {
                if (BoxPanel.Controls.Count < NumAcls.Value)
                {
                    CryptoACL V = new CryptoACL();
                    Boxes.Add(V);
                    BoxPanel.Controls.Add(V);
                }
                else
                {
                    CryptoACL V = Boxes[Boxes.Count - 1];
                    Boxes.Remove(V);
                    BoxPanel.Controls.Remove(V);
                }
            }
        }
    }
}
