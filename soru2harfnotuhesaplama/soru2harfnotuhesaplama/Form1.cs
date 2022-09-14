using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru2harfnotuhesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize1 = Convert.ToDouble(textBox1.Text);
            double vize2 = Convert.ToDouble(textBox2.Text);
            double final = Convert.ToDouble(textBox3.Text);
            double ortalama = 0;
            string harfNotu;

            if(vize1 <0 || vize1>100)                                     // eger sınav degerlerini 100 den buyuk verirseler hata uyurası verilecek
            {
                MessageBox.Show("Sınav değeri 0-100 arasında olmalıdır.");
            }
            else if((vize2 < 0 || vize2 > 100))
            {
                MessageBox.Show("Sınav değeri 0-100 arasında olmalıdır.");
            }
            else if((final < 0 || final > 100))
            {
                MessageBox.Show("Sınav değeri 0-100 arasında olmalıdır.");
            }

            else
            {
                ortalama = (vize1*3/10) + (vize2 * 3/10) + (final * 4/10);

                if(ortalama<=100 && ortalama >= 90)
                {
                    harfNotu = "AA";
                }
                else if(ortalama<=89 && ortalama >= 85)
                {
                    harfNotu = "BA";
                }
                else if(ortalama<=84 && ortalama >= 80)
                {
                    harfNotu = "BB";
                }
                else if(ortalama <= 79 && ortalama >= 75)
                {
                    harfNotu = "CB";
                }
                else if (ortalama <= 74 && ortalama >= 65)
                {
                    harfNotu = "CC";
                }
                else if (ortalama <= 64 && ortalama >= 60)
                {
                    harfNotu = "DC";
                }
                else if (ortalama <= 59 && ortalama >= 50)
                {
                    harfNotu = "DD";
                }
                else
                {
                    harfNotu = "FF";
                }

                MessageBox.Show("Ortalama: " + ortalama + " " + "Harf notu: " + harfNotu);
            }
        }
    }
}
