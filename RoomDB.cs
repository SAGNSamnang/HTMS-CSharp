using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public static class RoomDB
    {
        public static Room GetRoom(int roomNo)
        {
            // Declare SqlConnection (con) that use (GetConnection()) method in static class [MMABooksDB] for connect to database server
            SqlConnection con = HotelManagementDB.GetConnection();

            // Using Sql query to get data from Customer table in database server
            string selectStatement =
                "SELECT RoomNo, RoomType, Status, RoomPhone "
                + "FROM tbRoom "
                + "WHERE RoomNo = @RoomNo";

            // Used for sent sql statement to database server vai connection (con)
            SqlCommand selectCommnand = new SqlCommand(selectStatement, con);

            // Use command object to store data in dataset via customerID
            selectCommnand.Parameters.AddWithValue(
                "@RoomNo", roomNo);

            // Use try-catch to handle error
            try
            {
                // Open the connection to work with data
                con.Open();

                //-> ??
                SqlDataReader roomReader =
                    selectCommnand.ExecuteReader(CommandBehavior.SingleRow);

                // Read data one by one from SqlDataReader to load in class [Customer]
                if (roomReader.Read())
                {
                    // Create object customer for working with data in class [Customer]
                    Room room = new Room();

                    // Use Object customer vai CustomerID property to hole data from SqlDataReader object
                    // and convert to its Int32
                    room.RoomNo = (int)roomReader["RoomNo"];
                    room.RoomType = (int)roomReader["RoomType"];
                    room.Status = roomReader["Status"].ToString();
                    room.PhoneNumber = roomReader["RoomPhone"].ToString();
                    // return Customer object
                    return room;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
        }

        public static int AddRoom(Room room)
        {
            SqlConnection connection = HotelManagementDB.GetConnection();
            string insertStatement =
                "INSERT INTO tbRoom(RoomType, Status, RoomPhone) " +
                "VALUES (@roomType, @status, @roomPhone)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@roomType", room.RoomType);
            insertCommand.Parameters.AddWithValue(
                "@status", room.Status);
            insertCommand.Parameters.AddWithValue(
                "@roomPhone", room.PhoneNumber);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('tbRoom') FROM tbRoom";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int roomNo = Convert.ToInt32(
                    selectCommand.ExecuteScalar());
                return roomNo;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdateRoom(Room oldRoom, Room newRoom)
        {
            SqlConnection con = HotelManagementDB.GetConnection();

            string updateStatement =
                "UPDATE tbRoom SET " +
                "RoomType = @NewRoomType, " +
                "Status = @NewStatus, " +
                "RoomPhone = @NewRoomPhone " +
                "WHERE RoomType = @OldRoomType " +
                "AND Status = @OldStatus " +
                "AND RoomPhone = @OldRoomPhone";

            SqlCommand updateCommand =
                new SqlCommand(updateStatement, con);
            updateCommand.Parameters.AddWithValue(
                "@NewRoomType", newRoom.RoomType);
            updateCommand.Parameters.AddWithValue(
                "@NewStatus", newRoom.Status);
            updateCommand.Parameters.AddWithValue(
                "@NewRoomPhone", newRoom.PhoneNumber);

            updateCommand.Parameters.AddWithValue(
                "@OldRoomType", oldRoom.RoomType);
            updateCommand.Parameters.AddWithValue(
                "@OldStatus", oldRoom.Status);
            updateCommand.Parameters.AddWithValue(
                "@OldRoomPhone", oldRoom.PhoneNumber);
            try
            {
                con.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch(SqlException e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
        }

        public static bool DeleteRoom(Room room)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string deleteStatement =
                "DELETE FROM tbRoom " +
                "WHERE RoomType = @roomType " +
                "AND Status = @status " +
                "AND RoomPhone = @roomPhone";
            SqlCommand deleteCommand =
                new SqlCommand(deleteStatement, con);

            deleteCommand.Parameters.AddWithValue(
                "@roomType", room.RoomType);
            deleteCommand.Parameters.AddWithValue(
                "@status", room.Status);
            deleteCommand.Parameters.AddWithValue(
                "@roomPhone", room.PhoneNumber);
            try
            {
                con.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }catch(SqlException e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
