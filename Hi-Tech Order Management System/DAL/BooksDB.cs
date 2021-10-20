using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.BLL;
using Hi_Tech_Order_Management_System.DAL;
using System.Data.SqlClient;



namespace Hi_Tech_Order_Management_System.DAL
{
    public class BooksDB
    {
        public static List<Books> GetBookList()
        {
            List<Books> listBooks = new List<Books>();

            SqlConnection connDB = UtilityDB.ConnectDb();

            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Books", connDB);

            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Books bks;
            while (sqlReader.Read())
            {

                bks = new Books();

                bks.Isbn = Convert.ToInt32(sqlReader["ISBN"]);
                bks.Qoh = Convert.ToInt32(sqlReader["QOH"]);
                bks.UnitPrice = sqlReader["UnitPrice"].ToString();
                bks.Booktitle = sqlReader["BookTitle"].ToString();
                bks.CategoryId = Convert.ToInt32(sqlReader["CategoryId"]);
                bks.PublisherId = Convert.ToInt32(sqlReader["PublisherId"]);

                listBooks.Add(bks);

            }
            return listBooks;

        }

        public static void SaveRecord(Books bks)
        {

            using (SqlConnection connect = UtilityDB.ConnectDb())
            {
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO Books \n" +
                                                      "VALUES (@ISBN, @BookTitle, @QOH, @UnitPrice,@CategoryId, @PublisherId)", connect);
                cmdInsert.Parameters.AddWithValue("@ISBN", bks.Isbn);
                cmdInsert.Parameters.AddWithValue("@BookTitle", bks.Booktitle);
                cmdInsert.Parameters.AddWithValue("@QOH", bks.Qoh);
                cmdInsert.Parameters.AddWithValue("@UnitPrice", bks.UnitPrice );
                cmdInsert.Parameters.AddWithValue("@PublisherId", bks.PublisherId);
                cmdInsert.Parameters.AddWithValue("@CategoryId", bks.CategoryId);
                cmdInsert.ExecuteNonQuery();
            }
        }

    }
}
