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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void kayitAc_Click(object sender, EventArgs e)
        {
            Form1 KayitFormu = new Form1();
            KayitFormu.ShowDialog();
        }

        private void listele_Click(object sender, EventArgs e)
        {

        }
    }
}
