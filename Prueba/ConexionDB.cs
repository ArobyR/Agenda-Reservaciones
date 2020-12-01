﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using AgendaCita;


namespace AgendaCita
{
    class ConexionDB
    {
        public static SqlConnection GetSqlWinAuthenticationConnection()
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=reservaciones;Integrated Security=True");
            cn.Open();
            return cn;
        }

        public static MySqlConnection GetMySqlConnection ()
        {
            string server = "127.0.0.1";
            string database = "agenda1";
            string uid = "root";
            string pwd = "";

            MySqlConnection cn = new MySqlConnection(); // or here
            cn.ConnectionString = $"Server={server}; database={database}; uid={uid}; pwd={pwd};";
            cn.Open();

            return cn;
        }
    }

}
