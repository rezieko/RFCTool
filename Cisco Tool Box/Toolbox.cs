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
    //NO ONE WILL EVER SEE THIS AGAIN
    public partial class Toolbox : Form
    {
        public Toolbox()
        {
            InitializeComponent();
            MouseDown += Form1_MouseDown;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new IPv4ConfigForm().Show();
            OverrideTopMost(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("en \nconf t \n");
        }
        

        private void Toolbox_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new IPDefaultGateway().Show();
            OverrideTopMost(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new I802form().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.aelius.com/njh/subnet_sheet.html");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1kVK-HXbq-Q5xYlBLPWMGFiUnGDmDQYXQqWPpEMurnOY/edit?usp=sharing");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://150566673.netacad.com/login/canvas");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("125299cp");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("JUAZ-JTKX-SPBWcp1A");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("michael.claiborn@cfisd.net");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBox1.Checked;
            OverrideTopMost(false);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new RIPProtocol().Show();
            OverrideTopMost(false);
        }
        private void OverrideTopMost(bool ShouldOverride)
        {
            if (ShouldOverride)
            {
                TopMost = false;
            }
            else
            {
                TopMost = checkBox1.Checked;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new OSPF().Show();
            OverrideTopMost(false);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new BasicConfig().Show();
            OverrideTopMost(false);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new InterfaceSecurity().Show();
            OverrideTopMost(false);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new MACAddressSecurity().Show();
            OverrideTopMost(false);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new VLAN().Show();
            OverrideTopMost(false);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new EncapsulationDot1Q().Show();
            OverrideTopMost(false);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new Routing().Show();
            OverrideTopMost(false);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://scoreboard.uscyberpatriot.org/team.php?team=12-5299");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new StandardACLs().Show();
            OverrideTopMost(false);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ExtendedACLs().Show();
            OverrideTopMost(false);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new DHCP().Show();
            OverrideTopMost(false);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new StaticNAT().Show();
            OverrideTopMost(false);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new DynamicNAT().Show();
            OverrideTopMost(false);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new PortFowarding().Show();
            OverrideTopMost(false);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.adminsub.net/ipv4-subnet-calculator/192.169.120.0/0.0.3.255");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new Passwords().Show();
            OverrideTopMost(false);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new SecureLocalDatabase().Show();
            OverrideTopMost(false);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new EnhancedSecSettings().Show();
            OverrideTopMost(false);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new SSH().Show();
            OverrideTopMost(false);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new AssignAdminRole().Show();
            OverrideTopMost(false);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new MonitorAndManagingDevices().Show();
            OverrideTopMost(false);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new NTP().Show();
            OverrideTopMost(false);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new LocalAAA().Show();
            OverrideTopMost(false);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ServerBasedAuthentication().Show();
            OverrideTopMost(false);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new EnableAuthenOnVTY().Show();
            OverrideTopMost(false);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ServerBasedAuthorization().Show();
            OverrideTopMost(false);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ServerBasedAccounting().Show();
            OverrideTopMost(false);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new GREVPN().Show();
            OverrideTopMost(false);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new CompatibleIPSecVPNACLs().Show();
            OverrideTopMost(false);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ISAKMPPara().Show();
            OverrideTopMost(false);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new TransformSet().Show();
            OverrideTopMost(false);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new CryptoACLandMap().Show();
            OverrideTopMost(false);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ASABasics().Show();
            OverrideTopMost(false);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ASAInterfaces().Show();
            OverrideTopMost(false);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ASADefaultRoute().Show();
            OverrideTopMost(false);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ASARemoteAccessServices().Show();
            OverrideTopMost(false);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ASANTP().Show();
            OverrideTopMost(false);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ASADHCP().Show();
            OverrideTopMost(false);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new Objects().Show();
            OverrideTopMost(false);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ObjectGroup().Show();
            OverrideTopMost(false);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ASAAAA().Show();
            OverrideTopMost(false);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ASANAT().Show();
            OverrideTopMost(false);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new ASAACL().Show();
            OverrideTopMost(false);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            OverrideTopMost(true);
            new MPF().Show();
            OverrideTopMost(false);
        }
    }
}
