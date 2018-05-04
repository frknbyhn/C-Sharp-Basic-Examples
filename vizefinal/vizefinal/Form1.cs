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
    public partial class Form1 : Form
    {
        int hak = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (kuladi.Text == "coskunoz" && sifre.Text == "12345")
            {
                Form2 formum = new Form2();
                formum.Show();
            }
            else
            {
                hak = hak - 1;
                MessageBox.Show("bilemdiniz kalan hakkınız=" + hak);
                if (hak == 0)
                {
                    MessageBox.Show("hakkınız bitti");
                    button1.Enabled = false;
                }


            }
        }
    }
}
