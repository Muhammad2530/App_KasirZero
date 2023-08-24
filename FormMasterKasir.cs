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
    public partial class FormMasterKasir : Form
    {
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        void munculLevel()
        {
            comboBox_LvlKasir_FormKasir.Items.Add("ADMIN");
            comboBox_LvlKasir_FormKasir.Items.Add("USER");
        }

        void KondisiAwal()
        {
            textBox_KdKasir_FKasir.Text = "";
            textBox_nmKasir_FKasir.Text = "";
            textBox_PwdKasir_FKasir.Text = "";
            comboBox_LvlKasir_FormKasir.Text = "";
            munculLevel();
            MunculDataKasir();
        }
        public FormMasterKasir()
        {
            InitializeComponent();
        }

        private void btn_tutup_formKasir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void MunculDataKasir()
        {
            SqlConnection Conn = konn.GetConn();
            Conn.Open();
            cmd = new SqlCommand("select * from tbl_kasir", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tbl_kasir");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tbl_kasir";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }
        private void FormMasterKasir_Load(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void btn_input_formKasir_Click(object sender, EventArgs e)
        {
            if (textBox_KdKasir_FKasir.Text.Trim() == "" || textBox_nmKasir_FKasir.Text.Trim() == "" || textBox_PwdKasir_FKasir.Text.Trim() == "" || comboBox_LvlKasir_FormKasir.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua Form Terisi Semua");
            }
            else
            {
                SqlConnection Conn = konn.GetConn();
                cmd = new SqlCommand("Insert into tbl_kasir values ('" + textBox_KdKasir_FKasir.Text + "','" + textBox_nmKasir_FKasir.Text + "','" + textBox_PwdKasir_FKasir.Text + "','" + comboBox_LvlKasir_FormKasir.Text + "')", Conn);
                Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diinput");
                KondisiAwal();
            }
        }

        private void textBox_KdKasir_FKasir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                using (SqlConnection Conn = konn.GetConn())
                {
                    string query = "SELECT * FROM tbl_kasir WHERE KodeKasir = @KodeKasir";
                    using (cmd = new SqlCommand(query, Conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@KodeKasir", textBox_KdKasir_FKasir.Text);
                        Conn.Open();

                        using (SqlDataReader rd = cmd.ExecuteReader())

                            if (rd.Read())
                            {
                                textBox_KdKasir_FKasir.Text = rd[0].ToString();
                                textBox_nmKasir_FKasir.Text = rd[1].ToString();
                                textBox_PwdKasir_FKasir.Text = rd[2].ToString();
                                comboBox_LvlKasir_FormKasir.Text = rd[3].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Data tidak ada!");
                            }
                    }
                    
                }
                
            }
        }

        private void btn_edit_formKasir_Click(object sender, EventArgs e)
        {
            if (textBox_KdKasir_FKasir.Text.Trim() == "" || textBox_nmKasir_FKasir.Text.Trim() == "" || textBox_PwdKasir_FKasir.Text.Trim() == "" || comboBox_LvlKasir_FormKasir.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua Form Terisi Semua");
            }
            else
            {
                SqlConnection Conn = konn.GetConn();
                cmd = new SqlCommand("update tbl_kasir set NamaKasir='" + textBox_nmKasir_FKasir.Text + "',PasswordKasir='" + textBox_PwdKasir_FKasir.Text + "',LevelKasir='" + comboBox_LvlKasir_FormKasir.Text + "' WHERE KodeKasir= '" + textBox_KdKasir_FKasir.Text + "'", Conn);
                Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diedit");
                KondisiAwal();
            }
        }

        private void btn_hapus_formKasir_Click(object sender, EventArgs e)
        {
            if (textBox_KdKasir_FKasir.Text.Trim() == "" || textBox_nmKasir_FKasir.Text.Trim() == "" || textBox_PwdKasir_FKasir.Text.Trim() == "" || comboBox_LvlKasir_FormKasir.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua Form Terisi Semua");
            }
            else
            {
                SqlConnection Conn = konn.GetConn();
                cmd = new SqlCommand("Delete tbl_kasir  WHERE KodeKasir= '" + textBox_KdKasir_FKasir.Text + "'", Conn);
                Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil dihapus");
                KondisiAwal();
            }
        }
    }
}

