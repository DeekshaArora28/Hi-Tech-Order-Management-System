using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.DAL;
using System.Data;
using System.Data.SqlClient;
using Hi_Tech_Order_Management_System.BLL;
//using Hi_Tech_Order_Management_System.DAL;
namespace Hi_Tech_Order_Management_System.DAL
{
    public class UserDB
    {
        public static void SaveRecord(User emp)
        {

            using (SqlConnection connect = UtilityDB.ConnectDb())
            {
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO UserAccount \n" +
                                                      "VALUES (@UserName, @Password, @EmployeeId)", connect);
                cmdInsert.Parameters.AddWithValue("@UserName", emp.UserName);
                cmdInsert.Parameters.AddWithValue("@Password", emp.Password);
                cmdInsert.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
                cmdInsert.ExecuteNonQuery();
            }

        }

        public static List<User> GetRecordList()
        {
            List<User> listEmp = new List<User>();

            SqlConnection connDB = UtilityDB.ConnectDb();

            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM UserAccount", connDB);

            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            User emp;
            while (sqlReader.Read())
            {

                emp = new User();

                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.Password = sqlReader["Password"].ToString();
                emp.UserName = sqlReader["UserName"].ToString();                

                listEmp.Add(emp);

            }
            return listEmp;

        }

        public static User GetRecord(int usrId)
        {
            SqlConnection connDB = UtilityDB.ConnectDb();

            SqlCommand cmdSelect = new SqlCommand();

            cmdSelect.CommandText = "SELECT * FROM UserAccount " +
                                    "WHERE EmployeeId = " + usrId;
            cmdSelect.Connection = connDB;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            User usr = new User();
            if (sqlReader.Read())
            {
                usr.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                usr.UserName = sqlReader["UserName"].ToString();
                usr.Password = sqlReader["Password"].ToString();


            }
            else
            {
                usr = null;
            }

            return usr;
        }

            public static void UpdateRecord(User usr)
            {
                SqlConnection connDB = UtilityDB.ConnectDb();
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.CommandText = "UPDATE UserAccount SET UserName = @UserName, Password = @Password WHERE EmployeeId = @EmployeeId";
                cmdUpdate.Parameters.AddWithValue("@EmployeeId", usr.EmployeeId);
                cmdUpdate.Parameters.AddWithValue("@UserName", usr.UserName);
                cmdUpdate.Parameters.AddWithValue("@Password", usr.Password);
                
                cmdUpdate.Connection = connDB;
                cmdUpdate.ExecuteNonQuery();
                connDB.Close();
            }

        public static void DeleteRecord(int UserName)
        {
            SqlConnection connDb = UtilityDB.ConnectDb();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.CommandText = "DELETE FROM UserAccount WHERE UserName = @UserName";
            cmdDelete.Parameters.AddWithValue("@UserName", UserName);
            cmdDelete.Connection = connDb;
            cmdDelete.ExecuteNonQuery();
            connDb.Close();
        }

    }


    }

