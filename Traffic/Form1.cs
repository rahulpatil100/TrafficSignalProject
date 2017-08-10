using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            redStopLight.Visible = true;
            yellowStopLight.Visible = false;
            greenStopLight.Visible = false;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (redStopLight.Visible == true)
            {
                redStopLight.Visible = false;
                yellowStopLight.Visible = false;
                greenStopLight.Visible = true;
            }
            else if (greenStopLight.Visible == true)
            {
                redStopLight.Visible = false;
                yellowStopLight.Visible = true;
                greenStopLight.Visible = false;
            }

            else if (yellowStopLight.Visible == true)
            {
                redStopLight.Visible = true;
                yellowStopLight.Visible = false;
                greenStopLight.Visible = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (yellowStopLight.Visible == true)
            {
                car.Left = car.Left += 5;
            }

            if (greenStopLight.Visible == true)
            {
                car.Left = car.Left += 10;
            }
        }
    }
}
