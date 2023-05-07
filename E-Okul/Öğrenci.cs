using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_Okul
{
    public partial class Öğrenci : Form
    {
        readonly MySqlConnection con = new MySqlConnection(@"Server=94.73.150.60;Database=u9176804_ismail;Uid=u9176804_ismailnedanli;Pwd='Jaguark.4722';");
        MySqlCommand cmd;
        MySqlDataReader dr;
        
        public Öğrenci()
        {
            InitializeComponent();
            DisplayData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();   
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (tc.Text != string.Empty || ad.Text != string.Empty)
            {
                cmd = new MySqlCommand("select * from ogrenci where tc='" + tc.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Öğrenci zaten mevcut, lütfen başka birini deneyin ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new MySqlCommand("insert into ogrenci (tc,ad,soyad,no,sinif,bolum) values(@tc,@ad,@soyad,@no,@sinif,@bolum)", con);
                    cmd.Parameters.AddWithValue("@tc", tc.Text);
                    cmd.Parameters.AddWithValue("@ad", ad.Text);
                    cmd.Parameters.AddWithValue("@soyad", soyad.Text);
                    cmd.Parameters.AddWithValue("@no", no.Text);
                    cmd.Parameters.AddWithValue("@sinif", sinif.Text);
                    cmd.Parameters.AddWithValue("@bolum", bolum.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanlara değer giriniz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplayData();
            ClearData();
            con.Close();
        }

        private void Öğrenci_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter sorgu = new MySqlDataAdapter("select * from sinif ORDER BY sinif_id ASC", con);
            MySqlDataAdapter sorgu2 = new MySqlDataAdapter("select * from bolum ORDER BY bolum_id ASC", con);
            sorgu.Fill(dt);
            sorgu2.Fill(dt2);
            sinif.ValueMember = "sinif_id";
            sinif.DisplayMember = "sinif_Adi";
            sinif.DataSource = dt;

            bolum.ValueMember = "bolum_id";
            bolum.DisplayMember = "bolum_adi";
            bolum.DataSource = dt2;
            DisplayData();
        }

        private void DisplayData()
        {
            DataTable dt3 = new DataTable();
            MySqlDataAdapter sorgu3 = new MySqlDataAdapter($"select * from ogrenci;", con);
            sorgu3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            con.Close();
        }
        int ID = 0;
        private void ClearData()
        {
            tc.Text = "";
            ad.Text= "";
            soyad.Text = "";
            no.Text = "";
            sinif.ResetText();
            bolum.ResetText();
            ID = 0;
        }
        void KayıtSil(int id)
        {
            cmd = new MySqlCommand("DELETE FROM ogrenci WHERE id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(id);
            }
            DisplayData();
            ClearData();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("update ogrenci set tc=@tc, ad=@ad, soyad=@soyad, no=@no, sinif=@sinif, bolum=@bolum where ID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@tc", tc.Text);
            cmd.Parameters.AddWithValue("@ad", ad.Text);
            cmd.Parameters.AddWithValue("@soyad", soyad.Text);
            cmd.Parameters.AddWithValue("@no", no.Text);
            cmd.Parameters.AddWithValue("@sinif", sinif.Text);
            cmd.Parameters.AddWithValue("@bolum", bolum.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Öğrenci güncellendi.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            DisplayData();
            ClearData();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClearData();
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            soyad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            no.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            sinif.SelectedText = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            bolum.SelectedText = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    } 
}
