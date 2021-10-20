using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Hi_Tech_Order_Management_System.BLL;


namespace Hi_Tech_Order_Management_System.DAL
{
    public class OrdersDB
    {
        //public static List<Customer> ListRecording()
        //{
        //    List<Orders> listOrders = new List<Orders>();
        //    using (SqlConnection conn = UtilityDB.ConnectDb())
        //    {
        //        Orders aOrders;
        //        SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Orders", conn);
        //        SqlDataReader reader = cmdSelect.ExecuteReader();

        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                aOrders = new Orders();
        //                aOrders.OrderId = Convert.ToInt32(reader["OrderId"]);
        //                aOrders.OrderStatus = reader["OrderStatus"].ToString();
        //                aOrders.RequiredDate = reader["RequiredDate"].ToString();
        //                aOrders.ShippingDate = reader["ShippingDate"].ToString();
        //                aOrders.OrderDate = reader["OrderType"].ToString();
        //                aOrders.OrderType = reader["OrderDate"].ToString(); ;



        //                listOrders.Add(aOrders);

        //            }

        //        }

        //        else
        //        {
        //            listOrders = null;
        //        }
        //    }

        //        return listOrders;

            }
        }
    

        

