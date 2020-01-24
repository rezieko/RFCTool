using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cisco_Tool_Box
{
    public partial class NetworkBox : UserControl
    {
        public NetworkBox()
        {
            InitializeComponent();
        }
        public string GetText()
        {
            return "network " + NetworkText.Text + " " + WildcardText.Text + " area " + AreaIDText.Text + "\n";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NetworkBox_Load(object sender, EventArgs e)
        {

        }
    }
}
