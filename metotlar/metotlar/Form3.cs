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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panelcek_CheckedChanged(object sender, EventArgs e)
        {
            if (panelcek.Checked == true)
            {
                panel1.Visible = false;
            }//if
            else
            {
                panel1.Visible = true;
            }
        }
    }
}
