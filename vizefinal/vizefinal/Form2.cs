using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vizefinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize = Convert.ToInt32( vizebaks.Text);
            int final = Convert.ToInt32(finalbaks.Text);

            double ort;

            if (butbaks.Text == "")
            {
               ort = (vize * 0.4) + (final * 0.6);
            }
            else {
                int but=Convert.ToInt32(butbaks.Text );
 ort = (vize * 0.4) + (but * 0.6);
            }

                if (ort >= 50)
                {
                    MessageBox.Show("sınıfı " + ort + " ile geçtiniz");
                }
                else
                {
                    if (butbaks.Text != "")
                    {
                        MessageBox.Show("butunleme hakkınıda kullandın eylül de gel");
                        button1.Enabled = false;
                    }
                    else
                    {


                        MessageBox.Show(ort + " ile kaldınız bütünleme notunu giriniz");
                        finalbaks.Visible = false;
                        label2.Visible = false;
                        butbaks.Visible = true;
                        label3.Visible = true;
                    }
                }

          


            }
            
        }
    }

