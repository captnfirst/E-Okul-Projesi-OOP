using MySql.Data.MySqlClient;
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
    public partial class durum : Form
    {
        readonly MySqlConnection con = new MySqlConnection(@"Server=94.73.150.60;Database=u9176804_ismail;Uid=u9176804_ismailnedanli;Pwd='Jaguark.4722';");
        MySqlCommand cmd;
        MySqlDataReader dr;

        public durum()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        private void Durum_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter sorgu = new MySqlDataAdapter("select * from ogrenci ORDER BY id ASC", con);
            sorgu.Fill(dt);
            ogrenci.ValueMember = "id";
            ogrenci.DisplayMember = "tc";
            ogrenci.DataSource = dt;
        }
        List<Label> dersLabelListesi = new List<Label>();
        List<TextBox> dersTextBoxListesi = new List<TextBox>();
        bool key=false;
        private void ogrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("select * from ogrenci where id='" + ogrenci.SelectedValue + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ad.Text = dr["ad"].ToString();
                soyad.Text = dr["soyad"].ToString();
                no.Text = dr["no"].ToString();
                sinif.Text = dr["sinif"].ToString();
                bolum.Text = dr["bolum"].ToString();
            }
            dr.Close();
            con.Close();

            // Devamsızlık sayısını hesapla
            int devamsizlikSayisi = 0;
            cmd = new MySqlCommand("SELECT COUNT(*) AS devamsizlik FROM devamsizlik WHERE ogrenci_id =' " + ogrenci.SelectedValue + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                devamsizlikSayisi = Convert.ToInt32(dr["devamsizlik"]);
            }
            dr.Close();
            con.Close();

            // Devamsızlık sayısını textbox'a yazdır
            devamsizlik.Text = devamsizlikSayisi.ToString();
            
            // Öğrencinin Notunun Gelmesi
            int labelX = 0;
            int textBoxX = 0;
            if (key)
            {
                foreach (Label label in dersLabelListesi)
                    this.Controls.Remove(label); // Label'ı form'dan kaldır
                dersLabelListesi.Clear(); // Listeyi boşalt

                foreach (TextBox textBox in dersTextBoxListesi)
                    this.Controls.Remove(textBox); // TextBox'ı form'dan kaldır
                dersTextBoxListesi.Clear(); // Listeyi boşalt

                key = false;
            }
            else
                key = true;

            cmd = new MySqlCommand("select ders.id, ders.ders_adi, notlar.puan from ders inner join ders_yonlendirme on ders.id=ders_yonlendirme.ders_id left join tbl_not notlar on notlar.ders_id=ders.id and notlar.ogrenci_id='" + ogrenci.SelectedValue + "' where ders_yonlendirme.ogrenci_id='" + ogrenci.SelectedValue + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            int dersSayisi = 0;
            while (dr.Read())
            {

                string dersAdi = dr["ders_adi"].ToString();
                int ders_id = Convert.ToInt32(dr["id"]);
                int puan = 0;
                if (dr["puan"] != DBNull.Value)
                {
                    puan = Convert.ToInt32(dr["puan"]);
                }
                Label label = new Label();
                label.Text = dersAdi;
                labelX += label.Width + 1;
                label.Location = new Point(labelX - 80, 275 + (dersSayisi * 20)); // Yeni label'ın konumu
                this.Controls.Add(label); // Label'ı form'a ekle
                dersLabelListesi.Add(label);

                TextBox textBox = new TextBox();
                textBox.Name = ders_id.ToString(); // Name alanını ders ID'sine göre ayarla
                textBoxX += textBox.Width + 1;
                textBox.Location = new Point(textBoxX - 80, 300 + (dersSayisi * 20)); // Yeni textbox'ın konumu
                textBox.Text = puan.ToString();
                textBox.Enabled= false;
                this.Controls.Add(textBox); // Textbox'ı form'a ekle
                dersTextBoxListesi.Add(textBox);

            }
            dr.Close();
            con.Close();

            int toplamPuan = 0;
            foreach (TextBox textBox in dersTextBoxListesi)
            {
                if (!string.IsNullOrEmpty(textBox.Text))
                {
                    int puan = Convert.ToInt32(textBox.Text);
                    toplamPuan += puan;
                    dersSayisi++;
                }
            }
            double ortalama = (double)toplamPuan / dersSayisi;

            // Geçme/Kalma durumuna göre yazdırma
            if (ortalama >= 50)
            {
                textBox1.Text = "Geçti";
            }
            else
            {
                textBox1.Text = "Kaldı";
            }

        }

    }
}
