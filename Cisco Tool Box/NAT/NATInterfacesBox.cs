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
    public partial class NATInterfacesBox : UserControl
    {
        public NATInterfacesBox()
        {
            InitializeComponent();
        }

        private void InterfaceIDText_TextChanged(object sender, EventArgs e)
        {

        }
        public string GetInterfaces()
        {
            string CommandText = "";
            CommandText += "interface " + InterfaceIDText.Text + "\n";

            if (InChecked.Checked)
            {
                CommandText += "ip nat inside \n";
            }

            if (OutChecked.Checked)
            {
                CommandText += "ip nat outside \n";
            }

            return CommandText;
        }
    }
}
