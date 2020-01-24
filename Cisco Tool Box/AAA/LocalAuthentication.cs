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
    public partial class LocalAAA : Form
    {
        public LocalAAA()
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
            FinalText += "aaa new-model \n";
            FinalText += "aaa authentication login ";
            if (DefaultChecked.Checked)
            {
                FinalText += "default ";
            }
            if (ListnameChecked.Checked)
            {
                FinalText += "listname " + ListnameText.Text + " ";
            }
            FinalText += MethodOneText.Text + " ";
            FinalText += MethodTwoText.Text + " ";
            FinalText += MethodThreeText.Text + " ";
            FinalText += MethodFourText.Text + " ";
            FinalText += "\n";
            FinalText += "aaa local authentication attempts max-fail " + MaxFailText.Text + "\n";

            return FinalText;
        }
        private void ListnameChecked_CheckedChanged(object sender, EventArgs e)
        {
            ListnameText.Enabled = ListnameChecked.Checked;
        }
    }
}
