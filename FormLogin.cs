using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//3
using System.Data.SqlClient;

namespace App_KasirZero
{
    public partial class FormLogin : Form
    {
        //4
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;

        //5 Memanggil Koneksi
        Koneksi Konn = new Koneksi();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_loginKasir_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection Conn = Konn.GetConn();
            {
                Conn.Open();
                cmd = new SqlCommand("select * from tbl_kasir where KodeKasir = '" + txb_KodeKasir.Text + "' and PasswordKasir= '" + txb_PassKasir.Text + "'", Conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    


                    FormMenuUtama.menu.menuLogin.Enabled = false;
                    FormMenuUtama.menu.menuLogout.Enabled = true;
                    FormMenuUtama.menu.menuMaster.Enabled = true;
                    FormMenuUtama.menu.menuTransaksi.Enabled = true;
                    FormMenuUtama.menu.menuLaporan.Enabled = true;
                    FormMenuUtama.menu.menuUtility.Enabled = true;
                    FormMenuUtama frmUtama = new FormMenuUtama();

                    FormMenuUtama frmMenuUtama = new FormMenuUtama();
                    //frmMenuUtama.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kode Kasir atau Password Salah! ");
                }
            }




           /* if (txb_KodeKasir.Text == "KSR001" && txb_PassKasir.Text == "admin")
            {
                FormMenuUtama frmMenuUtama = new FormMenuUtama();
                frmMenuUtama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kode Kasir atau Password Salah !");
            }*/
        }

        private void btn_CancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txb_PassKasir.PasswordChar = 'x';
            txb_KodeKasir.Text = "KSR001";
            txb_PassKasir.Text = "ADMIN";
        }
    }
}
