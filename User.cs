﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class User
    {
        public User(){}
        public int UserID { get; set; }
        public string  Name { get; set; }
        public string  Email { get; set; }
        public string  Password { get; set; }
    }
}
