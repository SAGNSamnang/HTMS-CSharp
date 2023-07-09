using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class Order
    {
        public Order(){}
        public int OrderID { get; set; }
        public string  OrderType { get; set; }
        public int OrderQty { get; set; }
        public decimal UnitPrice { get; set; }
        public int GuestID { get; set; }
    }
}
