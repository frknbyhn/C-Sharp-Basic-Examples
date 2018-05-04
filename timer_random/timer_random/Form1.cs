using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace timer_random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Random uret = new Random();
          int sayi=  uret.Next(1000000000);
          MessageBox.Show(sayi.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("ESC ye bas shgfdghf ZAAAAA XD");
            MessageBox.Show("KAPATAMAZSIN XDXDXD");
            MessageBox.Show("BENCEE KOMİK XDXDXD");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("HELAL LEN");
        }



       
    }
}
