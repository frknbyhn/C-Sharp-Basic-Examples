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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        int alanhesapla(int kisa, int uzun)
        {
            int sonuc = kisa * uzun;
            return sonuc;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisa=Convert.ToInt32 (kisatext.Text );
            int uzun=Convert.ToInt32 (uzuntext.Text );

           int alansonuc= alanhesapla(kisa, uzun);
           MessageBox.Show(alansonuc.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kisa = Convert.ToInt32(kisatext.Text);
            int uzun = Convert.ToInt32(uzuntext.Text);

            int alansonuc = alanhesapla(kisa, uzun);
            MessageBox.Show(alansonuc.ToString());
        }
    }
}
