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
    public partial class MPF : Form
    {
        public MPF()
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
            if (ClassMapChecked.Checked)
            {
                FinalText += GetClassMap();
            }
            if (PolicyMapChecked.Checked)
            {
                FinalText += GetPolicyMap();
            }
            if (ServiceChecked.Checked)
            {
                FinalText += GetServicePolicy();
            }
            return FinalText;
        }
        private string GetServicePolicy()
        {
            string Service = "";
            Service += "service-policy " + ServPolNameText.Text + " ";
            if (GlobalChecked.Checked)
            {
                Service += "global ";
            }
            if (IntChecked.Checked)
            {
                Service += "interface " + IntText.Text + " ";
            }
            Service += "\n";

            return Service;
        }
        private string GetPolicyMap()
        {
            string PolicyMap = "";
            PolicyMap += "policy-map " + PolicyNameText.Text + "\n";
            PolicyMap += "description " + PolicyDescText.Text + "\n";
            PolicyMap += "class " + PolClassText.Text + "\n";
            if (ConnectionChecked.Checked)
            {
                PolicyMap += "set connection " + ConnectionText.Text + "\n";
            }
            if (InspectChecked.Checked)
            {
                PolicyMap += "inspect " + InspectText.Text + "\n";
            }
            if (PoliceChecked.Checked)
            {
                PolicyMap += "police " + PoliceText.Text + "\n";
            }

            return PolicyMap;
        }
        private string GetClassMap()
        {
            string ClassMap = "";
            ClassMap += "class-map " + ClassNameText.Text + "\n";
            ClassMap += "description " + ClassDescText.Text + "\n";
            ClassMap += "match ";
            if (AnyChecked.Checked)
            {
                ClassMap += "any ";
            }
            if (AclChecked.Checked)
            {
                ClassMap += "access-list " + AclText.Text + " ";
            }

            ClassMap += "\n";

            return ClassMap;
        }

        private void ServiceChecked_CheckedChanged(object sender, EventArgs e)
        {
            ServPolNameText.Enabled = ServiceChecked.Checked;
        }

        private void IntChecked_CheckedChanged(object sender, EventArgs e)
        {
            IntText.Enabled = IntChecked.Checked;
        }

        private void ConnectionChecked_CheckedChanged(object sender, EventArgs e)
        {
            ConnectionText.Enabled = ConnectionChecked.Checked;
        }

        private void InspectChecked_CheckedChanged(object sender, EventArgs e)
        {
            InspectText.Enabled = InspectChecked.Checked;
        }

        private void PoliceChecked_CheckedChanged(object sender, EventArgs e)
        {
            PoliceText.Enabled = PoliceChecked.Checked;
        }

        private void PolicyMapChecked_CheckedChanged(object sender, EventArgs e)
        {
            PolicyNameText.Enabled = PolicyMapChecked.Checked;
            PolicyDescText.Enabled = PolicyMapChecked.Checked;
            PolClassText.Enabled = PolicyMapChecked.Checked;
        }

        private void ClassMapChecked_CheckedChanged(object sender, EventArgs e)
        {
            ClassNameText.Enabled = ClassMapChecked.Checked;
            ClassDescText.Enabled = ClassMapChecked.Checked;
        }

        private void AnyChecked_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AclChecked_CheckedChanged(object sender, EventArgs e)
        {
            AclText.Enabled = AclChecked.Checked;
        }
    }
}
