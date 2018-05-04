using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace @struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       struct Diktorgenstruct
        {
            int kisaken;
           int uzunken;

            public Diktorgenstruct(int kisa,int uzun)
            {
                kisaken = kisa;
                uzunken = uzun;
            }
            public int alanhesapla()
            {
                int alan;
                alan = kisaken * uzunken;
                return alan;
            }


        }//diktorgen struct bitişi

        class Diktorgen
        {
           int kisakenar;
           int uzunkenar;

           public Diktorgen()
           {
               kisakenar = 3;
               uzunkenar = 4;
           }
           public int alanhesapla()
           {
               int alan;
               alan = kisakenar * uzunkenar;
               return alan;
           }




        }//diktorgen class bitişi

        Ogrenci yeniogrenci = new Ogrenci();
        struct Ogrenci
        {
           public  int no;
            public String ad;
           public  String soyad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            yeniogrenci.ad = adtext.Text;
            yeniogrenci.soyad = soyadtext.Text;
            yeniogrenci.no =Convert.ToInt32( notext.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(yeniogrenci.ad + yeniogrenci.soyad + yeniogrenci.no);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Diktorgen dik = new Diktorgen();
            MessageBox.Show(dik.alanhesapla().ToString());

            Diktorgenstruct dikstrcut = new Diktorgenstruct(6, 9);
            MessageBox.Show(dikstrcut.alanhesapla().ToString());
        }
    }
}
