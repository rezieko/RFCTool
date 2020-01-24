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
    public partial class ExcludedAddressBox : UserControl
    {
        public ExcludedAddressBox()
        {
            InitializeComponent();
        }
        public string GetExcludedAddress()
        {
            return "ip dhcp excluded-address " + LowerAddressText.Text + " " + HigherAddressText.Text + "\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExcludedAddressBox_Load(object sender, EventArgs e)
        {

        }
    }
}
