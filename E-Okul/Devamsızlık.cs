using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Okul
{
    public partial class Devamsızlık : Form
    {
        readonly MySqlConnection con = new MySqlConnection(@"Server=94.73.150.60;Database=u9176804_ismail;Uid=u9176804_ismailnedanli;Pwd='Jaguark.4722';");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Devamsızlık()
        {
            InitializeComponent();
            DisplayData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        private void DisplayData()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter sorgu = new MySqlDataAdapter($"select * from devamsizlik;", con);
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Devamsızlık_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter sorgu = new MySqlDataAdapter("select * from ogrenci ORDER BY id ASC", con);
            sorgu.Fill(dt);
            ogrenci.ValueMember = "id";
            ogrenci.DisplayMember = "tc";
            ogrenci.DataSource = dt;

            DisplayData();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            if (ogrenci.Text != string.Empty)
            {
                cmd = new MySqlCommand("select * from devamsizlik where ogrenci_id='" + ogrenci.SelectedValue + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Bu tarih zaten öğrenciye atanmıştır, lütfen başka tarih deneyin ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new MySqlCommand("insert into devamsizlik (ogrenci_id,devamsizlik) values(@ogrenci_id,@devamsizlik)", con);
                    cmd.Parameters.AddWithValue("@ogrenci_id", ogrenci.SelectedValue);
                    cmd.Parameters.AddWithValue("@devamsizlik", DateTime.Now.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Devamsızlık Ekleme Başarılı", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen alanları doldurunuz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplayData();
            ClearData();
            con.Close();
        }

        public void ClearData()
        {
            ogrenci.ResetText();
        }

        void DevamsizlikSil(int id)
        {
            cmd = new MySqlCommand("DELETE FROM devamsizlik WHERE id=@id", con);
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
                DevamsizlikSil(id);
            }
            DisplayData();
        }
    }
}
