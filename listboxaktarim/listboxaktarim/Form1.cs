using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace listboxaktarim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Object sehir in listBox1.SelectedItems)
            {
                listBox2.Items.Add(sehir);

            }
            int elemansay = listBox1.Items.Count;
            for (int i = 0; i <elemansay ; i++)
            {

                listBox1.Items.Remove(listBox1.SelectedItems);

            }

        }
    }
}
