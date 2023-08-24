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
    public partial class FormTransJual : Form
    {
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        public FormTransJual()
        {
            InitializeComponent();
        }

        void KondisiAwal()
        {
            lbl_NamaBarang.Text = "";
            lbl_HargaBarang.Text = "";
            lbl_NamaKasir.Text = "";
            lbl_Kembali.Text = "";
            lbl_Total.Text = "";
            lbl_Item.Text = "";
            textBox_Dibayar_FTJual.Text = "";
            textBox_JmlBarang_FTJual.Text = "";
            textBox_KdBarang_FTJual.Text = "";
            lbl_Tanggal.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        void BuatKolom()
        {
            SqlConnection Conn = konn.GetConn();
            Conn.Open();
            cmd = new SqlCommand("select * from tbl_detail_jual", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tbl_detail_jual");
            dataGridView_FTJual.DataSource = ds;
            dataGridView_FTJual.DataMember = "tbl_detail_jual";
            /*dataGridView_FTJual.AllowUserToAddRows = false;*/
            dataGridView_FTJual.Refresh();
            dataGridView_FTJual.Columns.Clear();
            dataGridView_FTJual.Columns.Add("KodeBarang", "Kode Barang");
            dataGridView_FTJual.Columns.Add("NamaBarang", "Nama");
            dataGridView_FTJual.Columns.Add("HargaBarang", "Harga");
            dataGridView_FTJual.Columns.Add("JumlahBarang", "Jumlah");
            dataGridView_FTJual.Columns.Add("SubTotalBarang", "SubTotal");
            dataGridView_FTJual.Columns[0].Width = 145;
            dataGridView_FTJual.Columns[1].Width = 200;
            dataGridView_FTJual.Columns[2].Width = 150;
            dataGridView_FTJual.Columns[3].Width = 150;
            dataGridView_FTJual.Columns[4].Width = 150;
            //dataGridView_FTJual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FormTransJual_Load(object sender, EventArgs e)
        {
            KondisiAwal();
            //BuatKolom();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Jam.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
    }
}
