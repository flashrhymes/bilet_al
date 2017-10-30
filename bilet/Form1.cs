using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button19_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is Button&& ((Button)c).BackColor==SystemColors.GrayText)
                {
                    ((Button)c).BackColor = Color.Red;
                }
            }


        }
        private void allbtngray_click(object sender,EventArgs e)
        {
            Button graybtn = sender as Button;
            if (graybtn.BackColor == Color.Red)
            {
                graybtn.BackColor = SystemColors.Control;
            }
            else
            {
                graybtn.BackColor = SystemColors.GrayText;
            }
        }
    }
}
