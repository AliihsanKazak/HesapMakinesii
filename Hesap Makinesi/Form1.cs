using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toplama_Click(object sender, EventArgs e)
        {
                int sayi1 =Convert.ToInt32(mtsayi1.Text);
            int sayi2 = Convert.ToInt32(mtsayi2.Text);
            lblsonuc.Text = (sayi1+ sayi2).ToString();
        }

        private void cikarma_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(mtsayi1.Text);
            int sayi2 = Convert.ToInt32(mtsayi2.Text);
            lblsonuc.Text = (sayi1 - sayi2).ToString();
        }

        private void carpma_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(mtsayi1.Text);
            int sayi2 = Convert.ToInt32(mtsayi2.Text);
            lblsonuc.Text = (sayi1 * sayi2).ToString();
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToInt32(mtsayi1.Text);
            double sayi2 = Convert.ToInt32(mtsayi2.Text);
            double bolme = sayi1 / sayi2 ;
            lblsonuc.Text = (bolme).ToString();
        }
    }
}
 