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
    public partial class TransformSet : Form
    {
        public TransformSet()
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
            FinalText += "crypto ipsec transform-set " + NameText.Text + " ";
            FinalText += Transform1Text.Text + " ";
            FinalText += Transform2Text.Text + " ";
            FinalText += Transform3Text.Text + " ";
            FinalText += Transform4Text.Text + " ";
            FinalText += "\n";
            return FinalText;
        }        
    }
}
