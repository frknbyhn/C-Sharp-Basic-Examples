using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace alanhesaplawhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say=0;

            while (true)
            {
                say++;
                int secim = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("seçiminizi giriniz 1-daire 2-kare 3-dikdörtgen", "alanhesapla", "", -1, 1));
                switch (secim)
                {
                    case 1:
                        int r = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("daire yarıçapı girin", "daire alan", "", -1, -1));
                        MessageBox.Show("dairenin alanı" + 3.14 * Math.Pow(r, 2));
                        break;
                    case 2:
                        int a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("karenin kenarını girin", "kare  alan", "", -1, -1));
                        MessageBox.Show("karenin alanı" + Math.Pow(a, 2));
                        break;
                    case 3:
                        int c = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("uzun kenarını girin", "kare  alan", "", -1, -1));
                        int b = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("kısa kenarını girin", "kare  alan", "", -1, -1));
                        MessageBox.Show("dikdörtgen alanı" + b * c);
                        break;
                }

                int sart = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("devam etmek istermisin 1-evt 2-hayır", "kare  alan", "", -1, -1));
                if (sart == 2)
                {
                    MessageBox.Show("yapılan işlem sayisi=" + say);
                    break;
                }
            }

        }
    }
}
