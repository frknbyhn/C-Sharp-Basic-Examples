using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace diziornek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] notlar = new int[5];
            int toplam = 0;
            for (int i = 0; i < 5; i++)
            {
                notlar[i] = Convert.ToInt32
                    (Microsoft.VisualBasic.Interaction.InputBox((i + 1) + ".notu giriniz", "not girişi", "", -1, -1));
                toplam += notlar[i];
            }

            int ortalama = toplam / 5;

            if (ortalama >= 45) MessageBox.Show(ortalama + " ortalama ile geçtiniz");
            else MessageBox.Show(ortalama + " ortalama ile kaldınız");

          

        }
    }
}
