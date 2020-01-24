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
    public partial class SecureLocalDatabase : Form
    {
        public SecureLocalDatabase()
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
            FinalText += GetUser();
            
            if (ConsoleChecked.Checked)
            {
                FinalText += "line console 0 \n";
                FinalText += "login local \n";
            }

            if (VtyChecked.Checked)
            {
                FinalText += "line vty 0 4 \n";
                FinalText += "login local \n";
            }

            if (AuxChecked.Checked)
            {
                FinalText += "line aux 0 \n";
                FinalText += "login local \n";
            }

            return FinalText;
        }
        private string GetUser()
        {
            return "username " + UserText.Text + " " + PassTypeCombo.SelectedItem + " " + PassText.Text + "\n";
        }
    }
}
