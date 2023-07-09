using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public static class UserDB
    {
        public static void Add(User user)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string insertStatement = "INSERT INTO tbUsers (UserName, UserEmail, UserPassword) " +
                "VALUES (@name, @email, @password)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            insertCommand.Parameters.AddWithValue(
                "@name", user.Name);
            insertCommand.Parameters.AddWithValue(
                "@email", user.Email);
            insertCommand.Parameters.AddWithValue(
                "@password", user.Password);
            try
            {
                con.Open();
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Successful");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
