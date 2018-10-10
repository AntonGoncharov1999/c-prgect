using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           



            

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int d = Convert.ToInt32(textBox3.Text);
            int k = Convert.ToInt32(textBox4.Text);
            int c = Convert.ToInt32(textBox9.Text);
            int f = Convert.ToInt32(textBox8.Text);
            int n = Convert.ToInt32(textBox5.Text);
            int p = Convert.ToInt32(textBox7.Text);
            int g = Convert.ToInt32(textBox6.Text);

            int[,] massiv = new int[3, 3]
            {
                {a, b, c },
                {d, k, f },
                {g, n, p }
            };
            //определяем миноры
                // 0 ряд

            int[,] minor_a= new int[2, 2]
            {
                {k, f },
                {n, p }
            };

            int[,] minor_b = new int[2, 2]
            {
                {d, f },
                {g, p }
            };

              int[,] minor_c = new int[2, 2]
            {
                {d, k },
                {g, n }
            };

            // 1 ряд

            int[,] minor_d = new int[2, 2]
            {
                {b, c },
                {n, p }
            };

            int[,] minor_k = new int[2, 2]
            {
                {a, c },
                {g, p }
            };

            int[,] minor_f = new int[2, 2]
            {
                {a, b },
                {g, n }
            };

            // 2 ряд

            int[,] minor_g = new int[2, 2]
            {
                {b, c },
                {k, f }
            };

            int[,] minor_n = new int[2, 2]
            {
                {a, c },
                {d, f }
            };

            int[,] minor_p = new int[2, 2]
          {
                {a, b },
                {d, k }
          };

            // вычесляем миноры
            // ряд 0
            int v_minor_a = minor_a[0, 0] * minor_a[1, 1] - minor_a[1, 0] * minor_a[0, 1];
            int v_minor_b = minor_b[0, 0] * minor_b[1, 1] - minor_b[1, 0] * minor_b[0, 1];
            int v_minor_c = minor_c[0, 0] * minor_c[1, 1] - minor_c[1, 0] * minor_c[0, 1];
                // ряд 1
            int v_minor_d = minor_d[0, 0] * minor_d[1, 1] - minor_d[1, 0] * minor_d[0, 1];
            int v_minor_k = minor_k[0, 0] * minor_k[1, 1] - minor_k[1, 0] * minor_k[0, 1];
            int v_minor_f = minor_f[0, 0] * minor_f[1, 1] - minor_f[1, 0] * minor_f[0, 1];
                // ряд 2
            int v_minor_g = minor_g[0, 0] * minor_g[1, 1] - minor_g[1, 0] * minor_g[0, 1];
            int v_minor_n = minor_n[0, 0] * minor_n[1, 1] - minor_n[1, 0] * minor_n[0, 1];
            int v_minor_p = minor_p[0, 0] * minor_p[1, 1] - minor_p[1, 0] * minor_p[0, 1];

            int dd = -v_minor_d ;
            int bb = -v_minor_b ;
            int ff = -v_minor_f ;
            int nn = -v_minor_n ;
            // матрица миноров
            int[,] minori = new int[3, 3]
            {
                {v_minor_a, v_minor_b, v_minor_c },
                {v_minor_d, v_minor_k, v_minor_f },
                {v_minor_g, v_minor_n, v_minor_p }
            };
            // Находим матрицу алгебраических дополнений
            int[,] alg_dopol = new int[3, 3]
            {
                {v_minor_a, bb, v_minor_c },
                {dd, v_minor_k, ff },
                {v_minor_g, nn, v_minor_p }
            };

            //выводы в лэйблы
                //minor
                    // ряд 0
            label5.Text = Convert.ToString(v_minor_a);
            label6.Text = Convert.ToString(v_minor_b);
            label7.Text = Convert.ToString(v_minor_c);
                    // ряд 1
            label10.Text = Convert.ToString(v_minor_d);
            label9.Text = Convert.ToString(v_minor_k);
            label8.Text = Convert.ToString(v_minor_f);
                    // ряд 2
            label13.Text = Convert.ToString(v_minor_g);
            label12.Text = Convert.ToString(v_minor_n);
            label11.Text = Convert.ToString(v_minor_p);
                //матрица алгебраических дополнений
                    // ряд 0
            label22.Text = Convert.ToString(v_minor_a);
            label21.Text = Convert.ToString(bb);
            label20.Text = Convert.ToString(v_minor_c);
                    // ряд 1
            label19.Text = Convert.ToString(dd);
            label18.Text = Convert.ToString(v_minor_k);
            label17.Text = Convert.ToString(ff);
                    // ряд 2
            label16.Text = Convert.ToString(v_minor_g);
            label15.Text = Convert.ToString(nn);
            label14.Text = Convert.ToString(v_minor_p);


            /*
             a b c  x1  00 01 02
             d k f  x2  10 11 12
             g n p  x3  20 12 22
            */
            //находим определитель матрицы.




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
