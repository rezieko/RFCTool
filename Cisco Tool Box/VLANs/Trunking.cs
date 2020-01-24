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
    public partial class I802form : Form
    {
        private List<InterfaceVlanBox> Boxes = new List<InterfaceVlanBox>();

        public I802form()
        {
            InitializeComponent();
            NumberOfInterfaces_ValueChanged(null, null);
        }

        private void I802form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
        }
        private string GetFinalText()
        {
            string FinalText = "";
            foreach(var box in Boxes)
            {
                FinalText += box.GetText();
            }                    
            
            return FinalText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NumberOfInterfaces_ValueChanged(object sender, EventArgs e)
        {           
            while(DevicesLayout.Controls.Count != NumberOfInterfaces.Value)
            {
                if(DevicesLayout.Controls.Count < NumberOfInterfaces.Value)
                {
                    InterfaceVlanBox V = new InterfaceVlanBox();
                    Boxes.Add(V);
                    DevicesLayout.Controls.Add(V);
                }
                else
                {
                    InterfaceVlanBox V = Boxes[Boxes.Count - 1];
                    Boxes.Remove(V);
                    DevicesLayout.Controls.Remove(V);
                }
            }
        }
    }
}
