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

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            if (nsProgressBar1.Value < nsProgressBar1.Maximum)
            {
                nsProgressBar1.Value++;
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            nsProgressBar1.Value = 0;
            timer1.Start();
            
        }
    }
}
