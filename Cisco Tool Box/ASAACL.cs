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



            return FinalText;
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

        }
    }
}
