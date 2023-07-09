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
    public static class CheckInDB
    {
        public static int Save(CheckIn checkIn)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string insertStatement =
                    "INSERT INTO tbCheckIn (CheckInDate, Duration, GuestID, StaffID, UnitPrice, " +
                    "Prepaid) " +
                    "VALUES (@date, @duration, @guestID, @staffID, @price, @prepaid)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            insertCommand.Parameters.AddWithValue(
                "@date", checkIn.Date);
            insertCommand.Parameters.AddWithValue(
                "@duration", checkIn.Duration);
            insertCommand.Parameters.AddWithValue(
                "@guestID", checkIn.GuestID);
            insertCommand.Parameters.AddWithValue(
                "@staffID", checkIn.StaffID);
            insertCommand.Parameters.AddWithValue(
                "@price", checkIn.UnitPrice);
            insertCommand.Parameters.AddWithValue(
                "@prepaid", checkIn.Prepaid);
            try
            {
                con.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement = "SELECT IDENT_CURRENT('tbCheckIn') FROM tbCheckIn";
                SqlCommand selectCommand = new SqlCommand(selectStatement, con);
                int checkInID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return checkInID;
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
        public static void UpdateCheckInData(CheckIn checkIn, int key)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string updateStatement =
                "UPDATE tbCheckIn SET CheckInDate=@date, Duration=@duration, GuestID=@guestID, " +
                "StaffID=@staffID, UnitPrice=@price, Prepaid=@prepaid "+
                "WHERE CheckInID = @id";
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, con);
            updateCommand.Parameters.AddWithValue(
                "@date", checkIn.Date);
            updateCommand.Parameters.AddWithValue(
                "@duration", checkIn.Duration);
            updateCommand.Parameters.AddWithValue(
                "@guestID", checkIn.GuestID);
            updateCommand.Parameters.AddWithValue(
                "@staffID", checkIn.StaffID);
            updateCommand.Parameters.AddWithValue(
                "@price", checkIn.UnitPrice);
            updateCommand.Parameters.AddWithValue(
                "@prepaid", checkIn.Prepaid);
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
        public static void DeleteCheckInData(CheckIn checkIn, int key)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string deleteStatement =
                "DELETE FROM tbCheckIn WHERE CheckInID = @CheckInID";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, con);
            deleteCommand.Parameters.AddWithValue(
                "@CheckInID", key);
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
        public static CheckIn GetCheckIn(int checkInID)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string selectStatement =
                "SELECT CheckInID, CheckInDate, Duration, GuestID, StaffID, UnitPrice, Prepaid " +
                "FROM tbCheckIn " +
                "WHERE CheckInID = @CheckInID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, con);
            selectCommand.Parameters.AddWithValue(
                "@CheckInID", checkInID);
            try
            {
                con.Open();
                SqlDataReader checkInReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (checkInReader.Read())
                {
                    CheckIn checkIn = new CheckIn();
                    checkIn.CheckInID = (int)checkInReader["CheckInID"];
                    checkIn.Date = checkInReader["CheckInDate"].ToString();
                    checkIn.Duration = (int)checkInReader["Duration"];
                    checkIn.GuestID = (int)checkInReader["GuestID"];
                    checkIn.StaffID = (int)checkInReader["StaffID"];
                    checkIn.UnitPrice = (decimal)checkInReader["UnitPrice"];
                    checkIn.Prepaid = (decimal)checkInReader["Prepaid"];
                    return checkIn;
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
