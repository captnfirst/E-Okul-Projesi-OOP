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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_Okul
{
    public partial class Ders_Yönlendir : Form
    {
        readonly MySqlConnection con = new MySqlConnection(@"Server=94.73.150.60;Database=u9176804_ismail;Uid=u9176804_ismailnedanli;Pwd='Jaguark.4722';");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Ders_Yönlendir()
        {
            InitializeComponent();
            DisplayData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ders ders = new Ders();
            ders.Show();
            this.Hide();
        }

        private void yonlendir_Click(object sender, EventArgs e)
        {
            if (ogrenci.Text != string.Empty || ders.Text != string.Empty)
            {
                cmd = new MySqlCommand("select * from ders_yonlendirme where ogrenci_id='"+ogrenci.SelectedValue+"' AND ders_id='" + ders.SelectedValue + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Ders zaten öğrenciye atanmıştır, lütfen başka ders deneyin ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new MySqlCommand("insert into ders_yonlendirme (ogrenci_id,ders_id) values(@ogrenci_id,@ders_id)", con);
                    cmd.Parameters.AddWithValue("@ogrenci_id", ogrenci.SelectedValue);
                    cmd.Parameters.AddWithValue("@ders_id", ders.SelectedValue);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ders Yönlendirme Başarılı", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ClearData()
        {
            ogrenci.ResetText();
            ders.ResetText();
        }

        private void Ders_Yönlendir_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter sorgu = new MySqlDataAdapter("select * from ogrenci ORDER BY id ASC", con);
            MySqlDataAdapter sorgu2 = new MySqlDataAdapter("select * from ders ORDER BY id ASC", con);
            sorgu.Fill(dt);
            sorgu2.Fill(dt2);
            ogrenci.ValueMember = "id";
            ogrenci.DisplayMember = "tc";
            ogrenci.DataSource = dt;

            ders.ValueMember = "id";
            ders.DisplayMember = "ders_adi";
            ders.DataSource = dt2;
            DisplayData();

        }
        private void DisplayData()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter sorgu = new MySqlDataAdapter($"select * from ders_yonlendirme;", con);
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void DersYönSil(int id)
        {
            cmd = new MySqlCommand("DELETE FROM ders_yonlendirme WHERE id=@id", con);
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
                DersYönSil(id);
            }
            DisplayData();
        }
    }
}
