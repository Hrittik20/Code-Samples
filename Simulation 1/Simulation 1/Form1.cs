using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        const double g = 9.81;
        const double dt = 0.01;
        const double rho = 1.29;
        const double C = 0.15;

        double height;
        double speed;
        double sina;
        double cosa;
        double t;
        double size;
        double weight;
        double beta;
        double k;
        double max_y;

        double vx, vy, vx_old, vy_old;
        double x, y;

        private void btLaunch_Click(object sender, EventArgs e)
        {
            height = (double)edHeight.Value;
            double angle = (double)edAngle.Value;
            speed = (double)edSpeed.Value;
            size = (double)edSize.Value;
            weight = (double)edWeight.Value;

            sina = Math.Sin(angle * Math.PI / 180);
            cosa = Math.Cos(angle * Math.PI / 180);

            beta = 0.5 * C * size * rho;
            k = beta / weight;

            vx = speed * cosa;
            vy = speed * sina;

            chart1.Series[0].Points.Clear();

            t = 0;
            x = 0;
            y = height;
            max_y = y;

            chart1.Series[0].Points.AddXY(x, y);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            double v = (double)Math.Sqrt((double)(vx * vx + vy * vy));  
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
            if (max_y<y)
            {
                max_y = y;
            }
            chart1.Series[0].Points.AddXY(x, y);


            if (y <= 0)
            {
                textBox1.Text = dt.ToString();
                textBox2.Text = Math.Round(x,2).ToString();
                textBox3.Text = Math.Round(max_y,2).ToString();
                textBox4.Text = Math.Round(v, 2).ToString();
                timer1.Stop();
            }
        }
    }
}
