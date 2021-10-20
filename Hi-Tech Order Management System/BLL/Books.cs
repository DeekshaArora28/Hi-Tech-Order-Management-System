using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.BLL;
using Hi_Tech_Order_Management_System.DAL;

namespace Hi_Tech_Order_Management_System.BLL
{
    public class Books
    {
        private int isbn;
        private string booktitle;
        private int qoh;
        private string unitPrice;
        private int categoryId;
        private int publisherId;

        public int Isbn { get => isbn; set => isbn = value; }
        public string Booktitle { get => booktitle; set => booktitle = value; }
        public int Qoh { get => qoh; set => qoh = value; }
        public string UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public int PublisherId { get => publisherId; set => publisherId = value; }


        public List<Books> GetList()
        {
            return BooksDB.GetBookList();
        }

        public void SaveBook(Books bks)
        {
            BooksDB.SaveRecord(bks);
        }

    }


}
