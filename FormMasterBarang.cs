using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App_KasirZero
{
    public partial class FormMasterBarang : Form
    {
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        void MunculSatuan()
        {
            comboBox_SatBarang_FBarang.Items.Add("PCS");
            comboBox_SatBarang_FBarang.Items.Add("BOX");
            comboBox_SatBarang_FBarang.Items.Add("BOTOL");
            comboBox_SatBarang_FBarang.Items.Add("PAX");
            comboBox_SatBarang_FBarang.Items.Add("KILO");
            comboBox_SatBarang_FBarang.Items.Add("KARUNG");
        }

        void KondisiAwal()
        {
            textBox_KdBarang_FBarang.Text = "";
            textBoxNmBarang_FBarang.Text = "";
            textBox_HBeli_FBarang.Text = "";
            textBox_HJual_FBarang.Text = "";
            textBox_JmlBarang_FBarang.Text = "";
            comboBox_SatBarang_FBarang.Text = "";
            MunculSatuan();
            MunculDataBarang();
        }

        void MunculDataBarang()
        {
            SqlConnection Conn = konn.GetConn();
            Conn.Open();
            cmd = new SqlCommand("select * from tbl_barang", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tbl_barang");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tbl_barang";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }
        public FormMasterBarang()
        {
            InitializeComponent();
        }

        private void FormMasterBarang_Load(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void btn_tutup_formBarang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_input_formBarang_Click(object sender, EventArgs e)
        {
            if (textBox_KdBarang_FBarang.Text.Trim() == "" || textBoxNmBarang_FBarang.Text.Trim() == "" || textBox_HBeli_FBarang.Text.Trim() == "" || textBox_HJual_FBarang.Text.Trim() == "" || textBox_JmlBarang_FBarang.Text.Trim() == "" || comboBox_SatBarang_FBarang.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua Form Terisi Semua");
            }
            else
            {
                SqlConnection Conn = konn.GetConn();
                cmd = new SqlCommand("Insert into tbl_barang values ('" + textBox_KdBarang_FBarang.Text + "','" + textBoxNmBarang_FBarang.Text + "','" + textBox_HBeli_FBarang.Text + "','" + textBox_HJual_FBarang.Text + "','" + textBox_JmlBarang_FBarang.Text + "','" + comboBox_SatBarang_FBarang.Text + "')", Conn);
                Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diinput");
                KondisiAwal();
            }
        }

        private void btn_edit_formBarang_Click(object sender, EventArgs e)
        {
            if (textBox_KdBarang_FBarang.Text.Trim() == "" || textBoxNmBarang_FBarang.Text.Trim() == "" || textBox_HBeli_FBarang.Text.Trim() == "" || textBox_HJual_FBarang.Text.Trim() == "" || textBox_JmlBarang_FBarang.Text.Trim() == "" || comboBox_SatBarang_FBarang.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua Form Terisi Semua");
            }
            else
            {
                SqlConnection Conn = konn.GetConn();
                cmd = new SqlCommand("update tbl_barang set NamaBarang= '" + textBoxNmBarang_FBarang.Text + "',HargaBeli= '" + textBox_HBeli_FBarang.Text + "',HargaJual= '" + textBox_HJual_FBarang.Text + "',JumlahBarang= '" + textBox_JmlBarang_FBarang.Text + "',SatuanBarang= '" + comboBox_SatBarang_FBarang.Text + "' where KodeBarang = '" + textBox_KdBarang_FBarang.Text + "'", Conn);
                Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diedit");
                KondisiAwal();
            }
        }

        private void textBox_KdBarang_FBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                using (SqlConnection Conn = konn.GetConn())
                {
                    string query = "SELECT * FROM tbl_barang WHERE KodeBarang = @KodeBarang";
                    using (cmd = new SqlCommand(query, Conn))
                    {

                        cmd.Parameters.AddWithValue("@KodeBarang", textBox_KdBarang_FBarang.Text);
                        Conn.Open();

                        using (SqlDataReader rd = cmd.ExecuteReader())

                            if (rd.Read())
                            {
                                textBox_KdBarang_FBarang.Text = rd[0].ToString();
                                textBoxNmBarang_FBarang.Text = rd[1].ToString();
                                textBox_HBeli_FBarang.Text = rd[2].ToString();
                                textBox_HJual_FBarang.Text = rd[3].ToString();
                                textBox_JmlBarang_FBarang.Text = rd[4].ToString();
                                comboBox_SatBarang_FBarang.Text = rd[5].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Data tidak ada!");
                            }
                    }

                }

            }
        }

        private void btn_hapus_formBarang_Click(object sender, EventArgs e)
        {
            if (textBox_KdBarang_FBarang.Text.Trim() == "" || textBoxNmBarang_FBarang.Text.Trim() == "" || textBox_HBeli_FBarang.Text.Trim() == "" || textBox_HJual_FBarang.Text.Trim() == "" || textBox_JmlBarang_FBarang.Text.Trim() == "" || comboBox_SatBarang_FBarang.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua Form Terisi Semua");
            }
            else
            {
                SqlConnection Conn = konn.GetConn();
                cmd = new SqlCommand("Delete tbl_barang where KodeBarang = '" + textBox_KdBarang_FBarang.Text + "'", Conn);
                Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil dihapus");
                KondisiAwal();
            }
        }
    }
}
