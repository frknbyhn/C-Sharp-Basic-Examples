using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] arabalar = new String[5];
          
            arabalar[0] = "reno";
            arabalar[1] = "tofaş";
            arabalar[2] = "mastek";
            arabalar[3] = "subaru";
            arabalar[4] = "porş";
           // MessageBox.Show(arabalar[3]);
           // Array.Clear(arabalar,2,1);
           // Array.Reverse(arabalar);
          // MessageBox.Show ( Array.IndexOf(arabalar, "tofaşsas").ToString ());
         //   Array.Sort(arabalar);
            MessageBox.Show(arabalar[2]);
           // MessageBox.Show(arabalar[3]);
            String[] arabalar2={"reno","fiat","porş"};

          //  int[,] sayilar = new int[3, 2];
          //  sayilar[0, 1] = 4;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] matris = new int[3, 2];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
matris[i,j]=Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("sayi gir","","",-1,-1));
                }//j for
            }//i for

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    textBox1.Text = textBox1.Text + matris[i, j].ToString();
                 
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[][] aile = new String[3][];
            aile [0]=new String[]{"kamil","sebehattin","osman"};
            aile[1] = new String[] { "bart simsın", "cart simsın" };
            aile[2] = new String[] {"feyzullah","emruulah","kamurallah","haydi yallah" };
           
            for (int i=0;i<aile[0].Length;i++)
                listBox1.Items.Add (aile[0][i]);
            for (int i = 0; i < aile[1].Length; i++)
                listBox2.Items.Add(aile[1][i]);
            for (int i = 0; i < aile[2].Length; i++)
                listBox3.Items.Add(aile[2][i]);

        }
    }
}
