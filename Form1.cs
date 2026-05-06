using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace nesne_tabanli_temelleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            
            string ad = tbAd.Text;
            string soyad = tbSoyad.Text;
            int yas = int.Parse(tbYas.Text);
            float not = float.Parse(tbNot.Text);
            
            Program.kaydet(ad, soyad, yas, not);

        }
    }
}
