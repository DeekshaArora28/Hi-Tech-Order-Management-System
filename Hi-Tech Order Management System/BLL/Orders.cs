using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Order_Management_System.BLL
{
    class Orders
    {
        int orderId;
        string  orderDate;
        string orderType;
        string requiredDate;
        string orderStatus;
        string shippingDate;
        int employeeId;
        int customerId;

        public int OrderId { get => orderId; set => orderId = value; }
        public string OrderDate { get => orderDate; set => orderDate = value; }
        public string OrderType { get => orderType; set => orderType = value; }
        public string RequiredDate { get => requiredDate; set => requiredDate = value; }
        public string OrderStatus { get => orderStatus; set => orderStatus = value; }
        public string ShippingDate { get => shippingDate; set => shippingDate = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
    }

    
}
