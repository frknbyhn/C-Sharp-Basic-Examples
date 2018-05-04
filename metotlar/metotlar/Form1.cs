using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void toplamaislemi()
        {
            //metotlar çağrıldıkları yere geri döner
            int s1 = Convert.ToInt32(sayi1.Text);
            int s2 = Convert.ToInt32(sayi2.Text);
            int toplam = s1 + s2;
            MessageBox.Show(toplam.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            toplamaislemi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toplamaislemi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //toplamaislemi();
           // toplamaislemi2(6, 90);
            MessageBox.Show(toplamaislemi3(9, 3).ToString());
        }

        void toplamaislemi2(int s1, int s2)
        {
            int toplam = s1 + s2;
            MessageBox.Show(toplam.ToString());

        }

        int toplamaislemi3(int s1,int s2)
        {
            int toplam = s1 + s2;
            return toplam;
        }
    }
}
