using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace @while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac=0;
            int toplam=0;
            while (sayac<100)
            {
                sayac++;
              //  sayac=sayac+2;

                if (sayac == 50)
                    continue;
comboBox1.Items.Add(sayac);
                //toplam = toplam + sayac;


            }
           // MessageBox.Show("toplam =" + toplam);
           
        }
    }
}
