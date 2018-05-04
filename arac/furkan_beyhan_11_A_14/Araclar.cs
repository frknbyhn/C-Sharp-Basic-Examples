using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace furkan_beyhan_11_A_14
{
    class Araclar:Itasit
    {

        int  üretim_yılı, tekerleksay, vitessay, motorsay, ağırlık;
        string model,marka, gövde_tipi;


        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public string Gövde_tipi
        {
            get { return gövde_tipi; }
            set { gövde_tipi = value; }
        }
        

        public int Üretim_yılı
        {
            get { return üretim_yılı; }
            set { üretim_yılı = value; }
        }

        public int Tekerleksay
        {
            get { return tekerleksay; }
            set { tekerleksay = value; }
        }

        public int Vitessay
        {
            get { return vitessay; }
            set { vitessay = value; }
        }

        public int Motorsay
        {
            get { return motorsay; }
            set { motorsay = value; }
        }

        public int Ağırlık
        {
            get { return ağırlık; }
            set { ağırlık = value; }
        }

        public virtual void bilgiver()
        { }
        


        


    }
}
