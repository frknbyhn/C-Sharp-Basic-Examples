using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sifretahminoyunu
{
    public partial class Form1 : Form
    {
        int sayi,hak,sn,dak;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            while (true)
            {
                int tahmin = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("tahmin gir", "tahmin", "", -1, -1));

                if (hak != 4)
                {
                    if (tahmin != sayi)
                    {
                        hak++;
                        if (tahmin > sayi) MessageBox.Show("tahmini küçült");
                        if (tahmin < sayi) MessageBox.Show("tahmini büyült");

                    }
                    else
                    {
                        MessageBox.Show(hak + ". hakkınızda bildiniz");
                        timer1.Stop();
                        MessageBox.Show("oyunda kaldığınız süre =" + dak + " dakika " + sn + " saniye");

                    }

                }
                else
                {

                    MessageBox.Show("bilemediniz 5 hakkınız bitti");
                    timer1.Stop();
                    MessageBox.Show("oyunda kaldığınız süre =" + dak + " dakika " + sn + " saniye");
                    MessageBox.Show(sayi.ToString());
                }
                if (hak == 5)
                    break;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sn++;
            if (sn == 60) dak++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random uret = new Random();
          sayi = uret.Next(100);
     
            

        }
    }
}
