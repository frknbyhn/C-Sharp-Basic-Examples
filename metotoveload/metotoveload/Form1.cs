using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace metotoveload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yaz(textBox1.Text);
        }

        void yaz(String metin)
        {
            MessageBox.Show(metin);
        }

        void yaz(String metin,Boolean tercih)
        {
            if (tercih == true)
                MessageBox.Show(metin.ToUpper());
            else
                MessageBox.Show(metin.ToLower());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yaz(textBox1.Text, true);
        }
    }
}
