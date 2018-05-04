using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace @switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            int secim =Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("seçiminizi girin 1-bilişim tek. 2-makina 3-elektronik", "seçiminiz", "",-1, -1));
            switch (secim)
            {
                case 1:
                    MessageBox.Show("bilişim sınıfları 9-a,10-a,11-a");
                    break;
                case 2:
                    MessageBox.Show("makina sınıfları 9-c,10-c,11-c");
                    break;
                default: 
                    
             MessageBox.Show ("ceryan bölümleri 9-b,10-b");
                    break;

            }

        }
    }
}
