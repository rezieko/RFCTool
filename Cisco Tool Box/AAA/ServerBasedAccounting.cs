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
    public partial class ServerBasedAccounting : Form
    {
        public ServerBasedAccounting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }
        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += "aaa accounting " + AccountingCombo.SelectedItem + " ";
            if (DefaultChecked.Checked)
            {
                FinalText += "default ";
            }
            if (ListnameChecked.Checked)
            {
                FinalText += "listname " + ListnameText.Text + " ";
            }
            FinalText += StartCombo.SelectedItem + " ";
            if (BroadcastChecked.Checked)
            {
                FinalText += "broadcast ";
            }
            FinalText += MethodOneText.Text + " " + MethodTwoText.Text + " " + MethodThreeText.Text + " " + MethodFourText.Text + "\n";


            return FinalText;
        }

        private void ListnameChecked_CheckedChanged(object sender, EventArgs e)
        {
            ListnameText.Enabled = ListnameChecked.Checked;
        }
    }
}
