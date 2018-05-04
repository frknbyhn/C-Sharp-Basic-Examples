using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace string_Fonk
{
    public partial class Form1 : Form1
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kelime = "kamil";
           int sayi= kelime.IndexOf("mi");
          //MessageBox.Show(sayi.ToString());  
          // kelime= kelime.Replace("i", "ü");
          // MessageBox.Show(kelime); 
          //  MessageBox.Show ( kelime.Substring(3, 1));
          // MessageBox.Show("tuncay \n salı");  
        }
    }
}
