using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_KasirZero
{
    public partial class FormMenuUtama : Form
    {
        public static FormMenuUtama menu;
        MenuStrip mnstrip;
        FormLogin frmLogin;
        FormTransJual frmTransJual;
        

        void frmLogin_fromClosed(object sender, FormClosedEventArgs e)//coding supaya formLogin tidak double
        {
            frmLogin = null;
        }

        FormMasterKasir frmKasir;
        void frmKasir_fromClosed(object sender, FormClosedEventArgs e)//coding supaya formLogin tidak double
        {
            frmKasir = null;
        }

        FormMasterBarang frmBarang;
        void frmBarang_fromClosed(object sender, FormClosedEventArgs e)//coding supaya formLogin tidak double
        {
            frmBarang = null;
        }

        void frmTransJual_fromClosed(object sender, FormClosedEventArgs e)//coding supaya formLogin tidak double
        {
            frmTransJual = null;
        }

        void MenuTerkunci() //memabuat void supaya semua menu terkunci, kecuali menu login karena secara tidak langsung belum login(tidak ada hak akses)
        {
            menuLogin.Enabled = true;
            menuLogout.Enabled = false;
            menuMaster.Enabled = false;
            menuTransaksi.Enabled = false;
            menuUtility.Enabled = false;
            menuLaporan.Enabled = false;
            menu = this;
        }
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //coding untuk mengaktifkan menu exit
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            MenuTerkunci(); //memanggil void MenuTerkunci untuk dieksekusi
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            if (frmLogin == null)
            {
                frmLogin = new FormLogin(); //membuat object formLogin baru dengan nama frmLogin
                frmLogin.FormClosed += new FormClosedEventHandler(frmLogin_fromClosed);
                frmLogin.ShowDialog();
            }
            else
            {
                frmLogin.Activate();
            }
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            MenuTerkunci();//supaya menu logout itu terkunci ketika belum melakukan login
        }

        private void kasirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKasir == null)
            {
                frmKasir = new FormMasterKasir(); //membuat object formLogin baru dengan nama frmLogin
                frmKasir.FormClosed += new FormClosedEventHandler(frmKasir_fromClosed);
                frmKasir.ShowDialog();
            }
            else
            {
                frmKasir.Activate();
            }
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmBarang == null)
            {
                frmBarang = new FormMasterBarang(); //membuat object formLogin baru dengan nama frmLogin
                frmBarang.FormClosed += new FormClosedEventHandler(frmBarang_fromClosed);
                frmBarang.ShowDialog();
            }
            else
            {
                frmBarang.Activate();
            }
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmTransJual == null)
            {
                frmTransJual = new FormTransJual(); //membuat object formLogin baru dengan nama frmLogin
                frmTransJual.FormClosed += new FormClosedEventHandler(frmTransJual_fromClosed);
                frmTransJual.ShowDialog();
            }
            else
            {
                frmTransJual.Activate();
            }
        }
    }
}
