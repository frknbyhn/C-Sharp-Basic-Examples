using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hatakontrolü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                String islemsec = islem.Text;

                switch (islemsec)
                {
                    case "+":
                        sonuc.Text = "islem sonucu" + Convert.ToString(sayi1 + sayi2);
                        break;
                    case "-":
                        sonuc.Text = "islem sonucu" + Convert.ToString(sayi1 - sayi2);
                        break;
                    case "*":
                        sonuc.Text = "islem sonucu" + Convert.ToString(sayi1 * sayi2);
                        break;
                    case "/":
                        sonuc.Text = "islem sonucu" + Convert.ToString(sayi1 / sayi2);
                        break;
                    default:
                        throw new InvalidOperationException
                        ("geçersiz işlem yapıldı");
                }

            }//try

            catch (FormatException)
            {
                MessageBox.Show("rakam girin");

            }
            catch (OverflowException)
            {
                MessageBox.Show("büyük rakam girdin");

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("yanlış işlem secimi yaptınız");
            }
            catch (Exception)
            {
                MessageBox.Show("bilinmeyen bir hata oluştu programcıyı arayın");
            }

            MessageBox.Show("nbr");
        }

       
    }
}
