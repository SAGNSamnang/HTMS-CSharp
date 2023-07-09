using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class Booking
    {
        public int BookingID { get; set; }

        public string BookingDate { get; set; }

        public int Duration { get; set; }

        public decimal TotalPrepaid { get; set; }

        public int GuestID { get; set; }

        public int StaffID { get; set; }
    }
}
