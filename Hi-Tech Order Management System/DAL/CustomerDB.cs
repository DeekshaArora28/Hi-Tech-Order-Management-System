using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Hi_Tech_Order_Management_System.BLL;
namespace Hi_Tech_Order_Management_System.DAL
{
    public class CustomerDB
    {
        public static List<Customer> ListRecord()
        {
            List<Customer> listCustomer = new List<Customer>();
            using (SqlConnection conn = UtilityDB.ConnectDb())
            {
                Customer aCustomer;
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Customers", conn);
                SqlDataReader reader = cmdSelect.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        aCustomer = new Customer();
                        aCustomer.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                        aCustomer.CustomerName = reader["CustomerName"].ToString();
                        aCustomer.StreetName = reader["StreetName"].ToString();
                        aCustomer.Province = reader["Province"].ToString();
                        aCustomer.City = reader["City"].ToString();
                        aCustomer.PostalCode = reader["PostalCode"].ToString();
                        aCustomer.CustomerName = reader["ContactName"].ToString();
                        aCustomer.ContactEmail = reader["ContactEmail"].ToString();
                        aCustomer.CreditLimit = reader["CreditLimit"].ToString();



                        listCustomer.Add(aCustomer);

                    }

                }

                else
                {
                    listCustomer = null;
                }
            }

            return listCustomer;

        }

    }
}
