using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing00;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace harfsayisikelimesayisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = "Ülkeye yararlı bir \n insan olmak için \n vergi ödemenin şimdi \n tam zamanıdır";
            int uzunluk = kelime.Length;
            int kelimesayisi = 1, satirsayisi = 1,harfsayisi=0 ;
           
            for (int i = 0; i < uzunluk; i++)
            {
                harfsayisi++;
                string karakter = kelime.Substring(i, 1);
                switch (karakter)
                {
                    case " ":
                        kelimesayisi++;
                        harfsayisi --;
                        break;
                    case "\n":
                        satirsayisi++;
                        harfsayisi --;
                        kelimesayisi--;
                        break;
                        
                }
             

            }

            MessageBox.Show("cümledeki harf sayisi=" +harfsayisi  + " kelime sayisi=" + kelimesayisi +
                 "satir sayisi=" + satirsayisi);


        }
    }
}
