﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace GUI_Database
{
    class Database
    {
        public static SqlConnection ConnectDB()
        {
            string connString = @"Server=DESKTOP-AHJQ59S\SQLEXPRESS;Database=model;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}