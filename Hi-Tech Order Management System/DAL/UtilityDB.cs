using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Hi_Tech_Order_Management_System.DAL
{
    public static class UtilityDB
    {
        public static SqlConnection ConnectDb()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["EmployeeDB_Connection"].ConnectionString;
            conn.Open();
            return conn;

        }
    }
}
