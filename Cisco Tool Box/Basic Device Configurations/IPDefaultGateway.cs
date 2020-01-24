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
    public partial class IPDefaultGateway : Form
    {
        public IPDefaultGateway()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("ip default-gateway " + IPAddressText.Text + "\n");
            Close();
        }


        private void IPAddressText_TextChanged(object sender, EventArgs e)
        {

        }

        private void IPDefaultGateway_Load(object sender, EventArgs e)
        {

        }
    }
}
