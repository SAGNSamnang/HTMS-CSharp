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
    public static class GuestDB
    {
        public static int AddGuest(Guest guest)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string insertStatement =
                    "INSERT INTO tbGuest (GuestName, GuestGender, GuestAddress, GuestNationality, GuestPhone) " +
                    "VALUES (@name, @gender, @address, @nationality, @phone)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            insertCommand.Parameters.AddWithValue(
                "@name", guest.Name);
            insertCommand.Parameters.AddWithValue(
                "@gender", guest.Gender);
            insertCommand.Parameters.AddWithValue(
                "@address", guest.Address);
            insertCommand.Parameters.AddWithValue(
                "@nationality", guest.Nationality);
            insertCommand.Parameters.AddWithValue(
                "@phone", guest.PhoneNumber);
            try
            {
                con.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('tbGuest') FROM tbGuest";
                SqlCommand selectCommand =
                    new SqlCommand(selectStatement, con);
                int guestID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return guestID;
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

        public static bool UpdateGuestData(Guest oldGuest, Guest newGuest)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string updateStatement =
                "UPDATE tbGuest SET GuestName=@NewName, GuestGender=@NewGender, " +
                "GuestAddress=@NewAddress, GuestNationality=@NewNationality, GuestPhone=@NewPhone " +
                "WHERE GuestName=@OldName AND GuestGender=@OldGender AND " +
                "GuestAddress=@OldAddress AND GuestNationality=@OldNationality AND GuestPhone=@OldPhone";
            
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, con);
            //new guest
            updateCommand.Parameters.AddWithValue("@NewName", newGuest.Name);
            updateCommand.Parameters.AddWithValue("@NewGender", newGuest.Gender);
            updateCommand.Parameters.AddWithValue("@NewAddress", newGuest.Address);
            updateCommand.Parameters.AddWithValue("@NewNationality", newGuest.Nationality);
            updateCommand.Parameters.AddWithValue("@NewPhone", newGuest.PhoneNumber);
            //old guest
            updateCommand.Parameters.AddWithValue("@OldName", oldGuest.Name);
            updateCommand.Parameters.AddWithValue("@OldGender", oldGuest.Gender);
            updateCommand.Parameters.AddWithValue("@OldAddress", oldGuest.Address);
            updateCommand.Parameters.AddWithValue("@OldNationality", oldGuest.Nationality);
            updateCommand.Parameters.AddWithValue("@OldPhone", oldGuest.PhoneNumber);
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

        public static bool DeleteGuestData(Guest guest)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string deleteStatement =
                "DELETE FROM tbGuest " +
                "WHERE GuestName = @Name " +
                "AND GuestGender = @Gender " +
                "AND GuestAddress = @Address " +
                "AND GuestNationality = @Nationality " +
                "AND GuestPhone = @Phone";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, con);
            deleteCommand.Parameters.AddWithValue(
                "@Name", guest.Name);
            deleteCommand.Parameters.AddWithValue(
                "@Gender", guest.Gender);
            deleteCommand.Parameters.AddWithValue(
                "@Address", guest.Address);
            deleteCommand.Parameters.AddWithValue(
                "@Nationality", guest.Nationality);
            deleteCommand.Parameters.AddWithValue(
                "@Phone", guest.PhoneNumber);
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

        public static Guest GetGuest(int guestID)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string selectStatement =
                "SELECT GuestID, GuestName, GuestGender, " +
                "GuestAddress, GuestNationality, GuestPhone " +
                "FROM tbGuest " +
                "WHERE GuestID = @GuestID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, con);
            selectCommand.Parameters.AddWithValue(
                "@GuestID", guestID);
            try
            {
                con.Open();
                SqlDataReader guestReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (guestReader.Read())
                {
                    Guest guest = new Guest();
                    guest.GuestID = (int)guestReader["GuestID"];
                    guest.Name = guestReader["GuestName"].ToString();
                    guest.Gender = guestReader["GuestGender"].ToString();
                    guest.Address = guestReader["GuestAddress"].ToString();
                    guest.Nationality = guestReader["GuestNationality"].ToString();
                    guest.PhoneNumber = guestReader["GuestPhone"].ToString();
                    return guest;
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

        public static Guest DisplayGustData()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string selectStatement =
                "SELECT GuestID, GuestName, GuestGender, " +
                "GuestAddress, GuestNationality, GuestPhone " +
                "FROM tbGuest";
            SqlCommand selectCommand = new SqlCommand(selectStatement, con);
            try
            {
                con.Open();
                SqlDataReader guestReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (guestReader.Read())
                {
                    Guest guest = new Guest();
                    guest.GuestID = (int)guestReader["GuestID"];
                    guest.Name = guestReader["GuestName"].ToString();
                    guest.Gender = guestReader["GuestGender"].ToString();
                    guest.Address = guestReader["GuestAddress"].ToString();
                    guest.Nationality = guestReader["GuestNationality"].ToString();
                    guest.PhoneNumber = guestReader["GuestPhone"].ToString();
                    return guest;
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
