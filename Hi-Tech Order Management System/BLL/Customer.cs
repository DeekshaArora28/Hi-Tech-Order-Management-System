using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.DAL;
namespace Hi_Tech_Order_Management_System.BLL
{
    public class Customer
    {
        private int customerId;
        private string customerName;
        private string streetName;
        private string province;
        private string city;
        private string postalCode;
        private string contactName;
        private string contactEmail;
        private string creditLimit;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string StreetName { get => streetName; set => streetName = value; }
        public string Province { get => province; set => province = value; }
        public string City { get => city; set => city = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string ContactEmail { get => contactEmail; set => contactEmail = value; }
        public string CreditLimit { get => creditLimit; set => creditLimit = value; }
    

    public List<Customer> GetEmployeeList()
    {
        return CustomerDB.ListRecord();
    }

  }
}
