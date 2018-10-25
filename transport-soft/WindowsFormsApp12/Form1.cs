using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Решить_Click(object sender, EventArgs e)
        {
            //поставщики
            int a = Convert.ToInt32(textBox1);
            int b = Convert.ToInt32(textBox2);

            //потребители
            int aa = Convert.ToInt32(textBox6);
            int bb = Convert.ToInt32(textBox4);
            int cc = Convert.ToInt32(textBox8);
            int dd = Convert.ToInt32(textBox17);

            // цены перевозок
                // 1 поставщик
            int ab1 = Convert.ToInt32(textBox3);
            int ab2 = Convert.ToInt32(textBox5);
            int ab3 = Convert.ToInt32(textBox7);
            int ab4 = Convert.ToInt32(textBox9);
                // 2 поставщик
            int aab1 = Convert.ToInt32(textBox13);
            int aab2 = Convert.ToInt32(textBox12);
            int aab3 = Convert.ToInt32(textBox11);
            int aab4 = Convert.ToInt32(textBox10);

            //запас
            int zapas = a + b;

            if (comboBox1.Text == "Северо-западного угла")
            {

                int x1 = a;
                int x2 = aa;
                int x3 = x1 - x2;

                label17.Text = Convert.ToString(x2);

                x2 = bb;
                

            }

            if (comboBox1.Text == "Наименьшей стоимости")
            {

            }
        }
    }
}
