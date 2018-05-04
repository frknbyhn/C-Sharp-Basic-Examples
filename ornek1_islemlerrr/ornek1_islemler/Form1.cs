using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ornek1_islemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dortislem_CheckedChanged(object sender, EventArgs e)
        {
            if (dortislem.Checked == true)
                panel4islem.Visible = true;
            else
                panel4islem.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void alanhesabi_CheckedChanged(object sender, EventArgs e)
        {
            if (alanhesabi.Checked == true)
                panelalan.Visible = true;
            else
                panelalan.Visible = false;
        }

        private void toplamacek_CheckedChanged(object sender, EventArgs e)
        {
            if (toplamacek.Checked == true)
            {
                dortislemgizle();
                toplamacek.Visible = true;
                sayibutongoster();
               
            }
            else
            {
                dortislemgoster();
                sayibutongizle();
            }
        }

        private void cikarmacek_CheckedChanged(object sender, EventArgs e)
        {
            if (cikarmacek.Checked == true)
            {

                dortislemgizle();
                cikarmacek.Visible = true;
                sayibutongoster();
            }
            else
            {
                dortislemgoster();
                sayibutongizle();
            }
        }

        void sayibutongizle()
        {
            panelsayi.Visible = false;
            button1.Visible = false;
        }

        void sayibutongoster()
        {
            panelsayi.Visible = true;
            button1.Visible = true;
        }

        void dortislemgoster()
        {
            cikarmacek.Visible = true;
            toplamacek.Visible = true;
            carpmacek.Visible = true;
            bolmecek.Visible = true;
        }

        void dortislemgizle()
        {
            sayi1.Text = "";
            sayi2.Text = "";

            toplamacek.Visible = false;
            cikarmacek.Visible = false;
            carpmacek.Visible = false;
            bolmecek.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dortislem.Checked == true)
            {//4 işlem seçili ise

                int say1 = Convert.ToInt32(sayi1.Text);
                int say2 = Convert.ToInt32(sayi2.Text);
                int toplam;
                if (toplamacek.Checked == true)
                    toplam = say1 + say2;
                else if (cikarmacek.Checked == true)
                    toplam = say1 - say2;
                else if (carpmacek.Checked == true)
                    toplam = say1 * say2;
                else
                    toplam = say1 / say2;

                MessageBox.Show("islem sonucu" + toplam);
            }
            else
            {//alan hesap radiıo seçili ise

                if (ucgencek.Checked == true)
                {
                    int ucgenyuksek = Convert.ToInt32(ucgen_h.Text);
                    int ucgentaban = Convert.ToInt32(ucgen_taban.Text);
                    MessageBox.Show("üçgenin alanı" + (ucgenyuksek * ucgentaban / 2));
                }
                else if (karecek.Checked == true)
                {
                    panelsayi.Visible = true;
                    int a_kenar = Convert.ToInt32(sayi1.Text);
                    int b_kenar = Convert.ToInt32(sayi2.Text);
                    MessageBox.Show("Karenin Alanı " +(a_kenar*b_kenar));

                    
                }

            }

        }

        private void ucgencek_CheckedChanged(object sender, EventArgs e)
        {
            if (ucgencek.Checked == true)
            {
                alangizle();
                ucgencek.Visible = true;
                panelucgenalan.Visible = true;
                button1.Visible = true;
            }
                else
                {
                    alangoster();
                    panelucgenalan.Visible = false;
                    button1.Visible = false;
                }
            }

         void alangizle()
        {
            karecek.Visible = false;
            ucgencek.Visible = false;
        }

         void alangoster()
        {
            karecek.Visible =true ;
            ucgencek.Visible = true;
        }

       


        }

       

       
    }

