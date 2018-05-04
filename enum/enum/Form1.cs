using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace @enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum aylar
        {
            OCAK,ŞUBAT,MART,NİSAN
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // aylar ay = aylar.ŞUBAT;
         //   MessageBox.Show(Convert.ToInt32(ay).ToString());
           String[] ay =Enum.GetNames(typeof(aylar));

           foreach (string aydegeri in ay)
           {

               comboBox1.Items.Add(aydegeri);
           }

        }

        private void button1_Click(object sender, EventArgs e)
        {
       bool kontrol= Enum.IsDefined(typeof(aylar), "MAYIS");
       if (kontrol == true)
       {
           MessageBox.Show("aradığınız değer var");
       }
       else
       {
           MessageBox.Show("aradığınız değer yok");
       }


        }


    }
}
