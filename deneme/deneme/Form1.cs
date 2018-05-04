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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(adsoyad.Text);
            adsoyad.ForeColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad,soyad;
            ad = "kamil";
            soyad = "ok";
            MessageBox.Show(ad + soyad);
            //int x = 4;
            adsoyad.Text.Substring(1, 5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 formum=new Form2() ;
            formum.Show();
         
        }
    }
}
