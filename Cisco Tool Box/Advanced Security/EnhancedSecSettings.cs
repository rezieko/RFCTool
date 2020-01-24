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
    public partial class EnhancedSecSettings : Form
    {
        public EnhancedSecSettings()
        {
            InitializeComponent();
        }

        private void MinPassLengthText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }
        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += "security passwords min-length " + MinPassLengthText.Text + "\n";
            FinalText += "exec-timeout " + TimeoutMinsText.Text + " " + TimeoutSecsText.Text + "\n";
            FinalText += GetLoginSec();

            return FinalText;
        }
        private string GetLoginSec()
        {
            string GetLoginSec = "";
            GetLoginSec += "login block-for " + BlockSecsText.Text + " attempts " + AttemptsText.Text + " within " + WithinSecsText.Text + "\n";
            GetLoginSec += "login quiet-mode access-class " + ACLText.Text + "\n";
            GetLoginSec += "login delay " + DelaySecsText.Text + "\n";

            if (SuccessLogChecked.Checked)
            {
                GetLoginSec += "login on-success log \n";
            }

            if (FailureLogChecked.Checked)
            {
                GetLoginSec += "login on-failure log \n";
            }
            
            if (ThresholdChecked.Checked)
            {
                GetLoginSec += "security authentication failure rate " + ThresholdRateText.Text + " log \n";
            }

            return GetLoginSec;
        }

        private void TimeoutMinsText_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ThresholdRateText.Enabled = ThresholdChecked.Checked;
        }

        private void ThresholdRateText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
