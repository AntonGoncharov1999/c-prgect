using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cramer_methotCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1 ряд
            int a = Convert.ToInt32(textBox1.Text);
            int d = Convert.ToInt32(textBox2.Text);
            int g = Convert.ToInt32(textBox3.Text);
            //2 ряд
            int b = Convert.ToInt32(textBox4.Text);
            int k = Convert.ToInt32(textBox5.Text);
            int n = Convert.ToInt32(textBox6.Text);
            //3 ряд
            int c = Convert.ToInt32(textBox7.Text);
            int f = Convert.ToInt32(textBox8.Text);
            int p = Convert.ToInt32(textBox9.Text);
            // коофицент
            int x1 = Convert.ToInt32(textBox10.Text);
            int x2 = Convert.ToInt32(textBox11.Text);
            int x3 = Convert.ToInt32(textBox12.Text);

            // вычесление дискреминант дельт 

            /*
             a b c  x1
             d k f  x2
             g n p  x3
            */ 

            int delta = (a * k * p + n *  d * c + g * b * f) - (c * k * g + n * a * f + p * d * f);

            if (delta != 0)
            {

                int delta_x = (x1 * k * p + n * x2 * c + x3 * b * f) - (c * k * x3 + n * x1 * f + p * x2 * f);

                int delta_y = (a * x2 * p + x3 * d * c + g * x1 * f) - (c * x2 * g + x3 * a * f + p * d * x1);

                int delta_z = (a * k * x3 + n * d * x1 + g * b * x2) - (x1 * k * g + n * a * x2 + x3 * d * f);

                // вычесление 
                int res1 = delta_x / delta;
                int res2 = delta_y / delta;
                int res3 = delta_z / delta;
                // отображения 
                // значений дискреминанта 

                label8.Text = Convert.ToString(delta);
                label7.Text = Convert.ToString(delta_x);
                label6.Text = Convert.ToString(delta_y);
                label5.Text = Convert.ToString(delta_z);

                // итогов делений дельт х у z на дельту

                label12.Text = Convert.ToString(res1);
                label11.Text = Convert.ToString(res2);
                label10.Text = Convert.ToString(res3);
            }
            else
            {
                label13.Text = "не решается методом крамера проверьте значения";
            }

        }
    }
}
