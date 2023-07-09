using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Hotel_Management_System
{
    public static class CheckOutDB
    {
        public static int Save(CheckOut checkOut)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string insertStatement =
                    "INSERT INTO tbCheckOut(GuestID, StaffID, CheckOutDate, UnitPrice) " +
                    "VALUES (@guestID, @staffID, @date, @price)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);

            insertCommand.Parameters.AddWithValue(
                "@guestID", checkOut.GuestID);
            insertCommand.Parameters.AddWithValue(
                "@staffID", checkOut.StaffID);
            insertCommand.Parameters.AddWithValue(
                "@date", checkOut.Date);
            insertCommand.Parameters.AddWithValue(
                "@price", checkOut.UnitPrice);
            try
            {
                con.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement = "SELECT IDENT_CURRENT('tbCheckOut') FROM tbCheckOut";
                SqlCommand selectCommand = new SqlCommand(selectStatement, con);
                int checkOutID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return checkOutID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static void UpdateCheckOutData(CheckOut checkOut, int key)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string updateStatement =
                "UPDATE tbCheckOut SET GuestID=@guestID, StaffID=@staffID, CheckOutDate=@date, " +
                "UnitPrice=@price " +
                "WHERE CheckOutID = @id";
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, con);
            
            updateCommand.Parameters.AddWithValue(
                "@guestID", checkOut.GuestID);
            updateCommand.Parameters.AddWithValue(
                "@staffID", checkOut.StaffID);
            updateCommand.Parameters.AddWithValue(
                "@date", checkOut.Date);
            updateCommand.Parameters.AddWithValue(
                "@price", checkOut.UnitPrice);
            updateCommand.Parameters.AddWithValue(
                "@id", key);
            try
            {
                con.Open();
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("Data updated");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public static void DeleteCheckOutData(CheckOut checkOut, int key)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string deleteStatement =
                "DELETE FROM tbCheckOut WHERE CheckOutID = @CheckOutID";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, con);
            deleteCommand.Parameters.AddWithValue(
                "@CheckOutID", key);
            try
            {
                con.Open();
                deleteCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    ex.Message, ex.GetType().ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public static CheckOut GetCheckOut(int checkOutID)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string selectStatement =
                "SELECT GuestID, StaffID, CheckOutDate, UnitPrice " +
                "FROM tbCheckOut " +
                "WHERE CheckOutID = @CheckOutID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, con);
            selectCommand.Parameters.AddWithValue(
                "@CheckOutID", checkOutID);
            try
            {
                con.Open();
                SqlDataReader checkInReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (checkInReader.Read())
                {
                    CheckOut checkOut = new CheckOut();
                    checkOut.CheckOutID = (int)checkInReader["CheckOutID"];
                    checkOut.GuestID = (int)checkInReader["GuestID"];
                    checkOut.StaffID = (int)checkInReader["StaffID"];
                    checkOut.Date = checkInReader["CheckOutDate"].ToString();
                    checkOut.UnitPrice = (decimal)checkInReader["UnitPrice"];
                    return checkOut;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
                //MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
