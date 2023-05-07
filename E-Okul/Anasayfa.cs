using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Okul
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Öğrenci ogrenci = new Öğrenci();
            ogrenci.Show();
            this.Hide();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sınıf_Bölüm sinif_bolum = new Sınıf_Bölüm();
            sinif_bolum.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ders ders = new Ders();
            ders.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Devamsızlık devamsızlık = new Devamsızlık();
            devamsızlık.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Not not = new Not();
            not.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            durum durum = new durum();
            durum.Show();
            this.Hide();
        }
    }
}
