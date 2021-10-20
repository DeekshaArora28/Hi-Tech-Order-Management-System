using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.DAL;
using System.Data;
using System.Data.SqlClient;

using Hi_Tech_Order_Management_System.BLL;
namespace Hi_Tech_Order_Management_System.DAL
{
    public class EmployeeDB
    {
        public static void SaveRecord(Employee emp)
        {
            
            using (SqlConnection connect = UtilityDB.ConnectDb())
            {
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO Employees \n" +
                                                      "VALUES (@EmployeeId, @FirstName, @LastName, @PhoneNumber,@JobId)", connect);
                cmdInsert.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
                cmdInsert.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmdInsert.Parameters.AddWithValue("@LastName", emp.LastName);
                cmdInsert.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNUmber);
                cmdInsert.Parameters.AddWithValue("@JobId", emp.JobId);
                cmdInsert.ExecuteNonQuery();
            }
        }

        public static List<Employee> GetRecordList()
        {
            List<Employee> listEmp = new List<Employee>();

            SqlConnection connDB = UtilityDB.ConnectDb();

            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Employees", connDB);

            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp;
            while (sqlReader.Read())
            {

                emp = new Employee();

                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.PhoneNUmber = sqlReader["PhoneNumber"].ToString();
                emp.JobId = Convert.ToInt32(sqlReader["JobId"]);

                listEmp.Add(emp);

            }
            return listEmp;

        }

        public static void UpdateRecord(Employee emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDb();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.CommandText = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, PhoneNUmber = @PhoneNumber, JobId = @JobId WHERE EmployeeId = @EmployeeId";
            cmdUpdate.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            cmdUpdate.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdUpdate.Parameters.AddWithValue("@LastName", emp.LastName);
            cmdUpdate.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNUmber);
            cmdUpdate.Parameters.AddWithValue("@JobId", emp.JobId);
            cmdUpdate.Connection = connDB;
            cmdUpdate.ExecuteNonQuery();
            connDB.Close();
        }


        public static Employee GetRecord(int empId)
        {
            SqlConnection connDB = UtilityDB.ConnectDb();

            SqlCommand cmdSelect = new SqlCommand();

            cmdSelect.CommandText = "SELECT * FROM Employees " +
                                    "WHERE EmployeeId = " + empId;
            cmdSelect.Connection = connDB;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp = new Employee();
            if (sqlReader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobId = Convert.ToInt32(sqlReader["JobId"]);
                emp.PhoneNUmber = sqlReader["PhoneNumber"].ToString();

            }
            else
            {
                emp = null;
            }

            return emp;
        }


        public static List<Employee> GetRecordByName(string name)
        {
            Employee stud;
            List<Employee> listStud = new List<Employee>();
            using (SqlConnection connect = UtilityDB.ConnectDb())
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Employees \n WHERE LastName = @LastName", connect);
                cmdSelect.Parameters.AddWithValue("@LastName", name);
                SqlDataReader sqlReader = cmdSelect.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        stud = new Employee();
                        stud.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                        stud.LastName = sqlReader["LastName"].ToString();
                        stud.FirstName = sqlReader["FirstName"].ToString();
                        stud.PhoneNUmber = sqlReader["PhoneNumber"].ToString();
                        stud.JobId= Convert.ToInt32(sqlReader["JobId"]);
                        listStud.Add(stud);
                    }

                }
                else
                {
                    listStud = null;
                }
            }
            return listStud;
        }

        public static void DeleteRecord(int EmpId)
        {
            SqlConnection connDb = UtilityDB.ConnectDb();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.CommandText = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId";
            cmdDelete.Parameters.AddWithValue("@EmployeeId", EmpId);
            cmdDelete.Connection = connDb;
            cmdDelete.ExecuteNonQuery();
            connDb.Close();
        }











    }
}
