﻿using Microsoft.Data.SqlClient;

namespace ListOut.ListDataDal
{
    public class MyConnection
    {
        public static SqlConnection GetConnection()
        {
            string conn = "Server=.;database=TODOLIST;Intgrated Security=True;";
            SqlConnection myConn = new SqlConnection(conn);
            return myConn;
        }
    }
}
