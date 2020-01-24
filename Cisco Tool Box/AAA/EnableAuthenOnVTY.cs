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
    public partial class EnableAuthenOnVTY : Form
    {
        public EnableAuthenOnVTY()
        {
            InitializeComponent();            
        }
   
        private void ListnameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }
        private string GetFinalText()
        {
            string CommandText = "";
            CommandText += "login authentication ";
            if (DefaultChecked.Checked)
            {
                CommandText += "default ";
            }
            if (ListnameChecked.Checked)
            {
                CommandText += "listname " + ListnameText.Text + " ";
            }
            CommandText += "\n";

            return CommandText;
        }

        private void EnableAuthenOnVTY_Load(object sender, EventArgs e)
        {

        }
    }
}
