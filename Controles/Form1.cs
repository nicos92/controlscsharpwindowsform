using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nsProgressBar1.Value < nsProgressBar1.Maximum - 1)
            {
                nsProgressBar1.Value++;
            }
        }

        private void nsButton1_Click_1(object sender, EventArgs e)
        {
            nsProgressBar1.Visible = true;
            timer1.Start();

        }
    }
}
