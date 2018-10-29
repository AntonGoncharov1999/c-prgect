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
            //labels
            int l1=0, l2=0, l3=0, l4=0, l5=0, l6=0, l7=0, l8=0;
            //поставщики
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            //потребители
            int aa = Convert.ToInt32(textBox6.Text);
            int bb = Convert.ToInt32(textBox4.Text);
            int cc = Convert.ToInt32(textBox8.Text);
            int dd = Convert.ToInt32(textBox17.Text);

            // цены перевозок
                // 1 поставщик
            int ab1 = Convert.ToInt32(textBox3.Text);
            int ab2 = Convert.ToInt32(textBox5.Text);
            int ab3 = Convert.ToInt32(textBox7.Text);
            int ab4 = Convert.ToInt32(textBox9.Text);
                // 2 поставщик
            int aab1 = Convert.ToInt32(textBox13.Text);
            int aab2 = Convert.ToInt32(textBox12.Text);
            int aab3 = Convert.ToInt32(textBox11.Text);
            int aab4 = Convert.ToInt32(textBox10.Text);

            //запас
            int zapas = a + b;

            // massivs
            int[] m_1 = new int[2] { a, b }; // 0 1 i
            int[] m_2 = new int[4] { aa, bb, cc, dd }; // 0 1 2 3 4 j
            int[,] m_3 = new int[2, 4]
                {                                         // ij ij ij ij ij
                        { ab1, ab2, ab3, ab4 },           // 00 01 02 03 04
                        { aab1, aab2, aab3, aab4 }        // 10 11 12 13 14
                };

            int[,] m_4 = new int[2, 4]
               {                                         
                    {l1,l2,l3,l4 },
                    {l5,l6,l7,l8 }       
               };

            if (comboBox1.Text == "Северо-западного угла")
            {
                int i = 0;
                int j = 0;
                int z = 0;
                while (i < 2 && j < 4)
                    {   
                        int k = m_1[i] - m_2[j];
                        if (k > 0)
                        {
                            m_4[i, j] = m_2[j];
                            z = m_2[j] - m_2[j];
                            if(z == 0){ j++; };
                        }

                        if(k < 0)
                        {
                            m_4[i, j] = m_2[j];
                            z = m_1[i] - k;
                            if(z > 0){ i++; }
                        }
                        if(k == 0) { m_4[i, j] = 0;}
                    }
                //0
                label17.Text = Convert.ToString(l1);
                label13.Text = Convert.ToString(l2);
                label15.Text = Convert.ToString(l3);
                label16.Text = Convert.ToString(l4);
                //1
                label21.Text = Convert.ToString(l5);
                label18.Text = Convert.ToString(l6);
                label19.Text = Convert.ToString(l7);
                label20.Text = Convert.ToString(l8);
            }

            if (comboBox1.Text == "Наименьшей стоимости")
            {
               /*
                    1.Поиск минимамального элемента
                    2.Сравнение A[i] и B[j]. В таблицу стоимости записываем найменьший из них.
                    3.Меньший обнуляем, а из большего вычитаем меньшее.
                    4.Добавлеям использованный столбец/ строку к тем, среди которых поиск вестись не будет
                    5.Проверяем условие выхода, и переходим к п.1 в случае неудачи
                */
                label22.Text="В разработке";
            }
        }
    }
}
