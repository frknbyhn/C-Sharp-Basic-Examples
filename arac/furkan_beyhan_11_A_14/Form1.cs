using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace furkan_beyhan_11_A_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
    
        int x = 0;
        ArrayList list1 = new ArrayList();
        Deniz_araclari deniz1 = new Deniz_araclari();
        Otomobil oto1 = new Otomobil();
        Ağır_vasıta ağır1 = new Ağır_vasıta();

        private void button1_Click(object sender, EventArgs e)
        {//kaydet
            try
            {
            if (aracbox.Text=="Otomobil")
            {
            
            oto1.Marka = markatext.Text;
            oto1.Model = modeltext.Text;
            oto1.Tekerleksay = Convert.ToInt32( tekerlexbox.Text) ;
            oto1.Vitessay = Convert.ToInt32(vitesbox.Text);
            oto1.Üretim_yılı = Convert.ToInt32(yıltext.Text);
            list1.Add(oto1);
            markatext.Text = "";
            modeltext.Text = "";
            tekerlexbox.Text = "";
            motorbox.Text  = "";
            yıltext.Text = "";
            vitesbox.Text = "";

            if (list1.Count < 2)
            {
                listBox1.Items.Add(((Otomobil)list1[x]).Marka + "---" + ((Otomobil)list1[x]).Model + "---" + ((Otomobil)list1[x]).Üretim_yılı+"---"+ ((Otomobil)list1[x]).Vitessay);
            }

            else 
            {
                MessageBox.Show("Araç girme hakkın doldu");
                x++;
            
            }
                if (aracbox.Text=="Deniz Araçları")
                {
                   
                    deniz1.Marka=markatext.Text;
                    deniz1.Model=modeltext.Text;
                    deniz1.Üretim_yılı=Convert.ToInt32(yıltext.Text);
                    deniz1.Gövde_tipi=govdetext.Text;
                    deniz1.Motorsay=Convert.ToInt32(motorbox.Text);
                    list1.Add(deniz1);
                    markatext.Text = "";
                    modeltext.Text = "";
                    yıltext.Text = "";
                    motorbox.Text = "";
                    govdetext.Text="";

                    if (list1.Count < 2)
                    {
                        listBox1.Items.Add(((Deniz_araclari)list1[x]).Marka + "---" + ((Deniz_araclari)list1[x]).Model + "---" + ((Deniz_araclari)list1[x]).Üretim_yılı + "---" + ((Deniz_araclari)list1[x]).Motorsay);

                    }
                    else
                        MessageBox.Show("Araç girme hakkın doldu");
                
                }
                if (aracbox.Text == "Ağır Vasıtalar")
                {
                    ağır1.Marka = markatext.Text;
                    ağır1.Model = modeltext.Text;
                    ağır1.Üretim_yılı = Convert.ToInt32(yıltext.Text);
                    ağır1.Tekerleksay = Convert.ToInt32(tekerlexbox.Text);
                    ağır1.Ağırlık = Convert.ToInt32(agirliktext.Text);
                    list1.Add(ağır1);
                    markatext.Text = "";
                    modeltext.Text = "";
                    yıltext.Text = "";
                    tekerlexbox.Text = "";
                    agirliktext.Text = "";

                    if (list1.Count < 2)
                    {
                        listBox1.Items.Add(((Ağır_vasıta)list1[x]).Marka + "---" + ((Ağır_vasıta)list1[x]).Model + "---" + ((Ağır_vasıta)list1[x]).Üretim_yılı + "---" + ((Ağır_vasıta)list1[x]).Tekerleksay + "---" + ((Ağır_vasıta)list1[x]).Ağırlık);

                    }
                    else
                        MessageBox.Show("Araç girme hakkın doldu");
                }
                
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("harf gir");

            }
            catch (OverflowException)
            {
                MessageBox.Show("büyük rakam girdin");

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("yanlış işlem secimi yaptınız");
            }
            catch (Exception)
            {
                MessageBox.Show("bilinmeyen bir hata oluştu programcıyı arayın");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {//arama
            try
            {
           markatext.Text = Microsoft.VisualBasic.Interaction.InputBox("Aranacak markayı gir :", "ARAMA","", -1, -1);
           modeltext.Text = Microsoft.VisualBasic.Interaction.InputBox("Aranacak modeli gir :", "MODEL", "", -1, -1);

           listBox1.Items.Add(markatext.Text);
           listBox1.Items.Add(modeltext.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("harf gir");

            }
            catch (OverflowException)
            {
                MessageBox.Show("büyük rakam girdin");

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("yanlış işlem secimi yaptınız");
            }
            catch (Exception)
            {
                MessageBox.Show("bilinmeyen bir hata oluştu programcıyı arayın");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {//temizle
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {//tüm öğeleri ekle
            listBox1.Items.Add(list1);
        }

    }
            
        
    }

