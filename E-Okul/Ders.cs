using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class Ders : Form
    {
        readonly MySqlConnection con = new MySqlConnection(@"Server=94.73.150.60;Database=u9176804_ismail;Uid=u9176804_ismailnedanli;Pwd='Jaguark.4722';");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Ders()
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
            if (txt_ders.Text != string.Empty)
            {
                cmd = new MySqlCommand("select * from ders where ders_adi='" + txt_ders.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Ders zaten mevcut, lütfen başka ders deneyin ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new MySqlCommand("insert into ders (ders_adi) values(@ders_adi)", con);
                    cmd.Parameters.AddWithValue("@ders_adi", txt_ders.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ders oluşturuldu.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen ders alanına değer giriniz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplayData();
            ClearData();
            con.Close();
        }

        private void Ders_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter sorgu = new MySqlDataAdapter($"select * from ders;", con);
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void ClearData()
        {
            txt_ders.Text = "";
        }
        void DersSil(int id)
        {
            cmd = new MySqlCommand("DELETE FROM ders WHERE id=@id", con);
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
                DersSil(id);
            }
            DisplayData();
        }

        private void yonlendir_Click(object sender, EventArgs e)
        {
            Ders_Yönlendir yönlendir = new Ders_Yönlendir();
            yönlendir.Show();
            this.Hide();
        }
    }
}
