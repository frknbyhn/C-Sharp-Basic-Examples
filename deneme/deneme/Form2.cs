using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form2 : Form
    {
        int s1;
        int s2;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            s1 =Convert.ToInt32(sayi1.Text);
           s2 = Int32.Parse(sayi2.Text);
            int toplam = s1 + s2;
            MessageBox.Show("toplama işleminizin sonucu=" + toplam.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
          s1 = Convert.ToInt32(sayi1.Text);
         s2 = Int32.Parse(sayi2.Text);
            int fark = s1 - s2;
            MessageBox.Show("çıkarma işleminizin sonucu=" + fark.ToString());
        }
    }
}
