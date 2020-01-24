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
    public partial class ASAAAA : Form
    {
        public ASAAAA()
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
            if (LocalUserChecked.Checked)
            {
                FinalText += GetLocalUser();
            }
            if (ServerChecked.Checked)
            {
                FinalText += GetServer();
            }
            if (AuthenChecked.Checked)
            {
                FinalText += GetAuthentication();
            }

            return FinalText;
        }
        private string GetAuthentication()
        {
            string AuthenText = "";
            AuthenText += "aaa authentication " + TypeCombo.SelectedItem + " console ";
            if (LocalChecked.Checked)
            {
                AuthenText += "LOCAL ";
            }
            if (ServerGroupChecked.Checked)
            {
                AuthenText += ServerGroupText.Text + " ";
                if (LocalServerGroupChecked.Checked)
                {
                    AuthenText += "LOCAL ";
                }
            }
            AuthenText += "\n";

            return AuthenText;
        }
        private string GetServer()
        {
            string ServerText = "";
            ServerText += "aaa-server " + TagText.Text + " protocol " + ProtocolCombo.SelectedItem + "\n";
            ServerText += "aaa-server " + TagText.Text + " ";
            if (IntChecked.Checked)
            {
                ServerText += IntNameText.Text + " ";
            }
            ServerText += "host ";
            if (ServerIpChecked.Checked)
            {
                ServerText += ServerIpText.Text + " ";
            }
            if (ServerNameChecked.Checked)
            {
                ServerText += ServerNameText.Text + " ";
            }
            if (KeyChecked.Checked)
            {
                ServerText += KeyText.Text + " ";
            }
            ServerText += "\n";
            ServerText += "exit \n";

            return ServerText;
        }
        private string GetLocalUser()
        {
            string LocalUser = "";
            LocalUser += "username " + UserText.Text + " ";
            LocalUser += "password " + PassText.Text + " ";
            if (PrivLevelChecked.Checked)
            {
                LocalUser += "privilege " + PrivLevelText.Text;
            }
            LocalUser += "\n";

            return LocalUser;
        }

        private void PrivLevelChecked_CheckedChanged(object sender, EventArgs e)
        {
            PrivLevelText.Enabled = PrivLevelChecked.Checked;
        }

        private void IntChecked_CheckedChanged(object sender, EventArgs e)
        {
            IntNameText.Enabled = IntChecked.Checked;
        }

        private void ServerIpChecked_CheckedChanged(object sender, EventArgs e)
        {
            ServerIpText.Enabled = ServerIpChecked.Checked;
        }

        private void ServerNameChecked_CheckedChanged(object sender, EventArgs e)
        {
            ServerNameText.Enabled = ServerNameChecked.Checked;
        }

        private void KeyChecked_CheckedChanged(object sender, EventArgs e)
        {
            KeyText.Enabled = KeyChecked.Checked;
        }

        private void ServerGroupChecked_CheckedChanged(object sender, EventArgs e)
        {
            ServerGroupText.Enabled = ServerGroupChecked.Checked;
        }

        private void ServerChecked_CheckedChanged(object sender, EventArgs e)
        {
            TagText.Enabled = ServerChecked.Checked;
        }

        private void LocalUserChecked_CheckedChanged(object sender, EventArgs e)
        {
            UserText.Enabled = LocalUserChecked.Checked;
            PassText.Enabled = LocalUserChecked.Checked;
        }
    }
}
