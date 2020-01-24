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
    public partial class ASADefaultRoute : Form
    {
        public ASADefaultRoute()
        {
            InitializeComponent();
        }

        private void IntNameText_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }
        private string GetFinalText()
        {
            return "route " + IntNameText.Text + " 0.0.0.0 0.0.0.0 " + NextHopIpText.Text + "\n";
        }
    }
}
