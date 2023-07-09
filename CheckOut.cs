using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class CheckOut
    {
        public CheckOut() { }
        public int CheckOutID { get; set; }
        public int GuestID { get; set; }
        public int StaffID { get; set; }
        public string Date { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
