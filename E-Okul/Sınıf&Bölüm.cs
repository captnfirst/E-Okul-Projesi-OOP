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
    public partial class Sınıf_Bölüm : Form
    {
        readonly MySqlConnection con = new MySqlConnection(@"Server=94.73.150.60;Database=u9176804_ismail;Uid=u9176804_ismailnedanli;Pwd='Jaguark.4722';");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Sınıf_Bölüm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void snf_ekle_Click(object sender, EventArgs e)
        {
            if (sinif.Text != string.Empty)
            {
                cmd = new MySqlCommand("select * from sinif where sinif_Adi='" + sinif.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Sınıf zaten mevcut, lütfen başka sınıf deneyin ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new MySqlCommand("insert into sinif (sinif_Adi) values(@sinif_Adi)", con);
                    cmd.Parameters.AddWithValue("@sinif_Adi", sinif.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sınıf oluşturuldu.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen sınıf alana değer giriniz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplayData();
            ClearData();
            con.Close();
        }

        private void DisplayData()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter sorgu = new MySqlDataAdapter($"select * from sinif;", con);
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;

            DataTable dt2 = new DataTable();
            MySqlDataAdapter sorgu2 = new MySqlDataAdapter($"select * from bolum;", con);
            sorgu2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void Sınıf_Bölüm_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void blm_ekle_Click(object sender, EventArgs e)
        {
            if (bolum.Text != string.Empty)
            {
                cmd = new MySqlCommand("select * from bolum where bolum_adi='" + bolum.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Bölüm zaten mevcut, lütfen başka bölüm deneyin ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new MySqlCommand("insert into bolum (bolum_adi) values(@bolum_adi)", con);
                    cmd.Parameters.AddWithValue("@bolum_adi", bolum.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bölüm oluşturuldu.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bölüm alana değer giriniz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplayData();
            ClearData();
            con.Close();
        }

        void BolumKayıtSil(int id2)
        {
            cmd = new MySqlCommand("DELETE FROM bolum WHERE bolum_id=@bolum_id", con);
            cmd.Parameters.AddWithValue("@bolum_id", id2);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void blm_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
            {
                int id2 = Convert.ToInt32(drow.Cells[0].Value);
                BolumKayıtSil(id2);
            }
            DisplayData();
        }

        void SınıfKayıtSil(int id)
        {
            cmd = new MySqlCommand("DELETE FROM sinif WHERE sinif_id=@sinif_id", con);
            cmd.Parameters.AddWithValue("@sinif_id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void snf_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                SınıfKayıtSil(id);
            }
            DisplayData();
        }

        private void ClearData()
        {
            sinif.Text = "";
            bolum.Text = "";
        }
    }
}
