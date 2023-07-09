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
    public static class BookingDB
    {
        public static int AddBooking(Booking booking)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string insertStatement =
                    "INSERT INTO tbBooking (BookingDate, Duration, TotalPrepaid, GuestID, StaffID) " +
                    "VALUES(@BookingDate, @Duration, @TotalPrepaid, @GuestID, @StaffID)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            insertCommand.Parameters.AddWithValue(
                "@BookingDate", booking.BookingDate);
            insertCommand.Parameters.AddWithValue(
                "@Duration", booking.Duration);
            insertCommand.Parameters.AddWithValue(
                "@TotalPrepaid", booking.TotalPrepaid);
            insertCommand.Parameters.AddWithValue(
                "@GuestID", booking.GuestID);
            insertCommand.Parameters.AddWithValue(
                "@StaffID", booking.StaffID);
            try
            {
                con.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                   "SELECT IDENT_CURRENT('tbBooking') FROM tbBooking";
                SqlCommand selectCommand =
                    new SqlCommand(selectStatement, con);
                int bookingID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return bookingID;
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

        public static bool UpdateBookingData(Booking oldBooking, Booking newBooking)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string updateStatement =
                "UPDATE tbBooking SET " +
                "BookingDate = @NewBookingDate, " +
                "Duration = @NewDuration, " +
                "TotalPrepaid = @NewTotalPrepaid, " +
                "GuestID = @NewGuestID, " +
                "StaffID = @NewStaffID " +
                "WHERE " +
                "BookingDate = @OldBookingDate, " +
                "Duration = @OldDuration, " +
                "TotalPrepaid = @OldTotalPrepaid, " +
                "GuestID = @OldGuestID, " +
                "StaffID = @OldStaffID";

            SqlCommand updateCommand =
                new SqlCommand(updateStatement, con);

            //new guest
            updateCommand.Parameters.AddWithValue("@NewBookingDate", newBooking.BookingDate);
            updateCommand.Parameters.AddWithValue("@NewDuration", newBooking.Duration);
            updateCommand.Parameters.AddWithValue("@NewTotalPrepaid", newBooking.TotalPrepaid);
            updateCommand.Parameters.AddWithValue("@NewGuestID", newBooking.GuestID);
            updateCommand.Parameters.AddWithValue("@NewStaffID", newBooking.StaffID);
            //old guest
            updateCommand.Parameters.AddWithValue("@OldBookingDate", oldBooking.BookingDate);
            updateCommand.Parameters.AddWithValue("@OldDuration", oldBooking.Duration);
            updateCommand.Parameters.AddWithValue("@OldTotalPrepaid", oldBooking.TotalPrepaid);
            updateCommand.Parameters.AddWithValue("@OldGuestID", oldBooking.GuestID);
            updateCommand.Parameters.AddWithValue("@OldStaffID", oldBooking.StaffID);
            try
            {
                con.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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

        public static bool DeleteBookingData(Booking booking)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string deleteStatement =
                "DELETE FROM tbBooking " +
                "WHERE  BookingDate= @BookingDate " +
                "AND Duration = @Duration " +
                "AND TotalPrepaid = @TotalPrepaid " +
                "AND GuestID = @GuestID " +
                "AND StaffID = @StaffID";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, con);
            deleteCommand.Parameters.AddWithValue(
                "@BookingDate", booking.BookingDate);
            deleteCommand.Parameters.AddWithValue(
                "@Duration", booking.Duration);
            deleteCommand.Parameters.AddWithValue(
                "@TotalPrepaid", booking.TotalPrepaid);
            deleteCommand.Parameters.AddWithValue(
                "@GuestID", booking.GuestID);
            deleteCommand.Parameters.AddWithValue(
                "@StaffID", booking.StaffID);
            try
            {
                con.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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

        public static Booking GetBooking(int bookingID)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string selectStatement =
                "SELECT BookingID, BookingDate, Duration, " +
                "TotalPrepaid, GuestID, StafID " +
                "FROM tbBooking " +
                "WHERE BookingID = @BookingID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, con);
            selectCommand.Parameters.AddWithValue(
                "@BookingID", bookingID);
            try
            {
                con.Open();
                SqlDataReader bookingReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (bookingReader.Read())
                {
                    Booking booking = new Booking();
                    booking.BookingID = (int)bookingReader["BookingID"];
                    booking.BookingDate = bookingReader["BookingDate"].ToString();
                    booking.Duration = (int)bookingReader["Duration"];
                    booking.TotalPrepaid = (decimal)bookingReader["TotalPrepaid"];
                    booking.GuestID = (int)bookingReader["GuestID"];
                    booking.StaffID = (int)bookingReader["StaffId"];
                    return booking;
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

        //public static Category GetPrice(int roomNo)
        //{
        //    SqlConnection con = HotelManagementDB.GetConnection();
        //    string selectStatement =
        //        "SELECT tbRoomType.UnitPrice " +
        //        "FROM tbRoomType " +
        //        "INNER JOIN tbRoom " +
        //        "ON tbRoom.RoomType = tbRoomType.RoomTypeID " +
        //        "WHERE RoomNo = @RoomNo";

        //    SqlCommand selectCommand = new SqlCommand(selectStatement, con);
        //    selectCommand.Parameters.AddWithValue(
        //        "@RoomNo", roomNo);
        //    try
        //    {
        //        con.Open();
        //        SqlDataReader roomReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
        //        if (roomReader.Read())
        //        {
        //            Category category = new Category();
        //            category.UnitPrice = (decimal)roomReader["UnitPrice"];
        //            return category;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

    }
}
