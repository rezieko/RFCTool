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
    public partial class ServerBasedAuthentication : Form
    {
        public ServerBasedAuthentication()
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
            FinalText += GetTacacsConfig();
            FinalText += GetRadiusConfig();
            return FinalText;
        }
        private string GetTacacsConfig()
        {
            string TacacsText = "";
            if (TacacsConfigChecked.Checked)
            {
                TacacsText += "tacacs-server host " + TacacsHostIpText.Text + " single-connection \n";
                TacacsText += "tacacs-server key " + TacacsKeyText.Text + "\n";
                TacacsText += "aaa authentication login ";

                if (TacacsDefaultChecked.Checked)
                {
                    TacacsText += "default ";
                }

                if (TacacsListnameChecked.Checked)
                {
                    TacacsText += "listname " + TacacsListnameText.Text + " ";
                }

                TacacsText += "group ";

                if (GroupTacacsChecked.Checked)
                {
                    TacacsText += "tacacs ";
                }

                if (GroupTacacsPlusChecked.Checked)
                {
                    TacacsText += "tacacs+ ";
                }

                TacacsText += "local-case \n";
            }
            
            
            return TacacsText;
        }

        private string GetRadiusConfig()
        {
            string RadiusText = "";
            RadiusText += "";
            if (RadiusConfigChecked.Checked)
            {
                RadiusText += "radius-server host " + RadiusHostIpText.Text + "\n";
                RadiusText += "radius-server key " + RadiusKeyText.Text + "\n";
                RadiusText += "aaa authentication login ";

                if (RadiusDefaultChecked.Checked)
                {
                    RadiusText += "default ";
                }

                if (RadiusListnameChecked.Checked)
                {
                    RadiusText += "listname " + RadiusListnameText.Text + " ";
                }

                RadiusText += "group radius local-case \n";
            }


            return RadiusText;
        }
    }
}
