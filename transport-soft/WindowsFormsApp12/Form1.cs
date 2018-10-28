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
            int[] massiv_1 = new int[2] { a, b }; // 0 1 i
            int[] massiv_2 = new int[4] { aa, bb, cc, dd }; // 0 1 2 3 4 j
            int[,] massiv_3 = new int[2, 4]
                {                                         // ij ij ij ij ij
                        { ab1, ab2, ab3, ab4 },           // 00 01 02 03 04
                        { aab1, aab2, aab3, aab4 }        // 10 11 12 13 14
                };

            if (comboBox1.Text == "Северо-западного угла")
            {
                int i = 0;
                int j = 0;
                // проход по массиву
                while (i < 2 && j < 4)
                    
                    {
                        if (massiv_1[i] == 0) { i++; }
                        if (massiv_2[j] == 0) { j++; }
                        if (massiv_3[i, j] == 0) { i++; j++; }
                        massiv_1[i] -= massiv_3[i, j];
                        massiv_2[j] -= massiv_3[i,j];
                    };
                // считаю массив
                int res = 0;
                for(i = 0; i < 2; i++)
                    {
                        for (j = 0; j < 4; j++)
                        {
                            res += (massiv_3[i,j] * massiv_3[j,i]);
                        };
                    };
                // 0
                label17.Text = Convert.ToString(massiv_3[0, 0]);
                label13.Text = Convert.ToString(massiv_3[0, 1]);
                label15.Text = Convert.ToString(massiv_3[0, 2]);
                label16.Text = Convert.ToString(massiv_3[0, 3]);
                // 1
                label21.Text = Convert.ToString(massiv_3[1, 0]);
                label18.Text = Convert.ToString(massiv_3[1, 1]);
                label19.Text = Convert.ToString(massiv_3[1, 2]);
                label20.Text = Convert.ToString(massiv_3[1, 3]);
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
