using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;

namespace Controles
{
    public partial class FormControls : Form
    {
        private readonly ColoresARGB _colores = new ColoresARGB();
        public FormControls()
        {
            InitializeComponent();
        }

        

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ProgressBarTop.Value < ProgressBarTop.Maximum )
            {
                ProgressBarTop.Value++;

            }
            else
            {
                ProgressBarTop.SliderColor = _colores.RandomColor();
                ProgressBarTop.Value=1;

            }
        }

        private void BtnNs_Click_1(object sender, EventArgs e)
        {
            ProgressBarTop.Visible = true;
            Timer.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
