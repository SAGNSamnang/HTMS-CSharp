using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    public static class HotelManagementDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Hotel_Management_System;Integrated Security=True";
            SqlConnection connection =
                new SqlConnection(connectionString);
            return connection;
        }

    }
}
