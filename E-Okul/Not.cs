using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace E_Okul
{
    public partial class Not : Form
    {
        readonly MySqlConnection con = new MySqlConnection(@"Server=94.73.150.60;Database=u9176804_ismail;Uid=u9176804_ismailnedanli;Pwd='Jaguark.4722';");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Not()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
        private void Not_Load(object sender, EventArgs e)
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
        bool key = false;

        private void ogrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                label.Location = new Point(labelX - 90, 130 + (dersSayisi * 20)); // Yeni label'ın konumu
                this.Controls.Add(label); // Label'ı form'a ekle
                dersLabelListesi.Add(label);

                TextBox textBox = new TextBox();
                textBox.Name = ders_id.ToString(); // Name alanını ders ID'sine göre ayarla
                textBoxX += textBox.Width + 1;
                textBox.Location = new Point(textBoxX - 90, 160 + (dersSayisi * 20)); // Yeni textbox'ın konumu
                textBox.Text = puan.ToString();
                this.Controls.Add(textBox); // Textbox'ı form'a ekle
                dersTextBoxListesi.Add(textBox);

            }
            dr.Close();
            con.Close();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in dersTextBoxListesi)
            {
                int ders_id = Convert.ToInt32(textBox.Name); // TextBox'ın adından ders ID'sini al
                int ogrenci_id = Convert.ToInt32(ogrenci.SelectedValue); // ComboBox'dan öğrenci ID'sini al
                int puan = Convert.ToInt32(textBox.Text); // TextBox'ın içeriğini not olarak al
                cmd = new MySqlCommand("insert into tbl_not (ogrenci_id, ders_id, puan) values ('" + ogrenci_id + "', '" + ders_id + "', '" + puan + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Not Eklendi.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in dersTextBoxListesi)
            {
                int ders_id = Convert.ToInt32(textBox.Name); 
                int ogrenci_id = Convert.ToInt32(ogrenci.SelectedValue); 
                int puan = Convert.ToInt32(textBox.Text); 

                cmd = new MySqlCommand("update tbl_not set puan='" + puan + "' where ogrenci_id='" + ogrenci_id + "' and ders_id='" + ders_id + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Not güncellendi.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
