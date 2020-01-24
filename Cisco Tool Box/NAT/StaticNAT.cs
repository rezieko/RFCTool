﻿using System;
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
    public partial class StaticNAT : Form
    {
        private List<NATInterfacesBox> Boxes = new List<NATInterfacesBox>();
        public StaticNAT()
        {
            InitializeComponent();
            InterfacesPanel.FlowDirection = FlowDirection.TopDown;
            InterfacesPanel.Location = new Point(15, 123);
            NumInterfaces_ValueChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetFinalText());
            Close();
        }

        private string GetFinalText()
        {
            string FinalText = "";
            FinalText += "ip nat inside source static " + LocalAddrText.Text + " " + GlobalAddrText.Text + "\n";
            FinalText += GetInterfaces();

            return FinalText;
        }
        private string GetInterfaces()
        {
            string FinalNetwork = "";
            foreach (var box in Boxes)
            {
                FinalNetwork += box.GetInterfaces();
            }
            return FinalNetwork;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NumInterfaces_ValueChanged(object sender, EventArgs e)
        {
            while (InterfacesPanel.Controls.Count != NumInterfaces.Value)
            {
                if (InterfacesPanel.Controls.Count < NumInterfaces.Value)
                {
                    NATInterfacesBox V = new NATInterfacesBox();
                    Boxes.Add(V);
                    InterfacesPanel.Controls.Add(V);
                }
                else
                {
                    NATInterfacesBox V = Boxes[Boxes.Count - 1];
                    Boxes.Remove(V);
                    InterfacesPanel.Controls.Remove(V);
                }
            }            
        }

        private void LocalAddrText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
