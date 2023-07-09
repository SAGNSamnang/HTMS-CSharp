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
    public static class DataAccess
    {
        //
        // Booking Detial
        //
        public static void Add(BookingDetial bookingDetial)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string insertStatement =
                    "INSERT INTO tbBookingDetial (BookingID, RoomNo) " +
                    "VALUES (@id, @no)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            insertCommand.Parameters.AddWithValue(
                "@id", bookingDetial.BookingID);
            insertCommand.Parameters.AddWithValue(
                "@no", bookingDetial.RoomNo);
            try
            {
                con.Open();
                insertCommand.ExecuteNonQuery();
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
        //
        // CheckIn Detial
        //
        public static void Add(CheckInDetial checkInDetial)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string insertStatement =
                    "INSERT INTO tbCheckInDetial (CheckInID, RoomNo, Amount) " +
                    "VALUES (@id, @no, @amount)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            insertCommand.Parameters.AddWithValue(
                "@id", checkInDetial.CheckInID);
            insertCommand.Parameters.AddWithValue(
                "@no", checkInDetial.RoomNo);
            insertCommand.Parameters.AddWithValue(
                "@amount", checkInDetial.Amount);
            try
            {
                con.Open();
                insertCommand.ExecuteNonQuery();
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
        //
        //CheckOut Detail
        //
        public static void Add(CheckOutDetial checkOutDetial)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string insertStatement =
                    "INSERT INTO tbCheckOutDetial (CheckOutID, RoomNo, Amount) " +
                    "VALUES (@id, @no, @amount)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            insertCommand.Parameters.AddWithValue(
                "@id", checkOutDetial.CheckOutID);
            insertCommand.Parameters.AddWithValue(
                "@no", checkOutDetial.RoomNo);
            insertCommand.Parameters.AddWithValue(
                "@amount", checkOutDetial.Amount);
            try
            {
                con.Open();
                insertCommand.ExecuteNonQuery();
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
        //
        //Order Detail
        //
        public static void Add(OrderDetial orderDetial)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string insertStatement =
                    "INSERT INTO tbOrdersDetial (OrderID, FoodID, Amount) " +
                    "VALUES (@oid, @fid, @amount)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            insertCommand.Parameters.AddWithValue(
                "@oid", orderDetial.OrderID);
            insertCommand.Parameters.AddWithValue(
                "@fid", orderDetial.FoodID);
            insertCommand.Parameters.AddWithValue(
                "@amount", orderDetial.Amount);
            try
            {
                con.Open();
                insertCommand.ExecuteNonQuery();
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
    }
}
