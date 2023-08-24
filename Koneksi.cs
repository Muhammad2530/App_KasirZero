using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
//1
using System.Data.SqlClient;

namespace App_KasirZero
{
    class Koneksi
    {
        //2 Membuat Connection String dengan Public supaya bisa digunakan di berbagai class
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=LAPTOP-CC1BDN9N;Initial Catalog=db_kasir_zero;Integrated Security=true"; ;
            return Conn;
        }
    }
}
