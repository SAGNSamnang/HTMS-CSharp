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
    public static class CategoryDB
    {
        public static Category GetCategory(int roomTypeID)
        {
            // Declare SqlConnection (con) that use (GetConnection()) method in static class [HotolManagementDB] for connect to database server
            SqlConnection con = HotelManagementDB.GetConnection();

            // Using Sql query to get data from tbRoomType table in database server
            string selectStatement =
                "SELECT RoomTypeID, RoomTypeName, UnitPrice "
                + "FROM tbRoomType "
                + "WHERE RoomTypeID = @RoomTypeID";

            // Used for sent sql statement to database server vai connection (con)
            SqlCommand selectCommnand = new SqlCommand(selectStatement, con);


            selectCommnand.Parameters.AddWithValue(
                "@RoomTypeID", roomTypeID);

            // Use try-catch to handle error
            try
            {
                // Open the connection to work with data
                con.Open();

                //-> ??
                SqlDataReader categoryReader =
                    selectCommnand.ExecuteReader(CommandBehavior.SingleRow);

                // Read data one by one from SqlDataReader to load in class [Category]
                if (categoryReader.Read())
                {
                    // Create object customer for working with data in class [Customer]
                    Category category = new Category();

                    // Use Object customer vai CustomerID property to hole data from SqlDataReader object
                    // and convert to its Int32
                    category.RoomTypeID = (int)categoryReader["RoomTypeID"];
                    category.RoomTypeName = categoryReader["RoomTypeName"].ToString();
                    category.UnitPrice = (decimal)categoryReader["UnitPrice"];
                    // return Customer object
                    return category;
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

        public static void AddCategory(Category category)
        {
            SqlConnection connection = HotelManagementDB.GetConnection();
            string insertStatement =
                "INSERT INTO tbRoomType(RoomTypeName, UnitPrice) " +
                "VALUES(@name, @price)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@name", category.RoomTypeName);
            insertCommand.Parameters.AddWithValue(
                "@price", category.UnitPrice);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool UpdateCategory(Category oldCategory, Category newCategory)
        {
            SqlConnection con = HotelManagementDB.GetConnection();

            string updateStatement =
                "UPDATE tbRoomType SET " +
                "RoomTypeName = @NewRoomTypeName, " +
                "UnitPrice = @NewUnitPrice " +
                "WHERE RoomTypeName = @OldRoomTypeName " +
                "AND UnitPrice = @OldUnitPrice";

            SqlCommand updateCommand =
                new SqlCommand(updateStatement, con);

            updateCommand.Parameters.AddWithValue(
                "@NewRoomTypeName", newCategory.RoomTypeName);
            updateCommand.Parameters.AddWithValue(
                "@NewUnitPrice", newCategory.UnitPrice);

            updateCommand.Parameters.AddWithValue(
                "@OldRoomTypeName", oldCategory.RoomTypeName);
            updateCommand.Parameters.AddWithValue(
                "@OldUnitPrice", oldCategory.UnitPrice);

            try
            {
                con.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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
        public static bool DeleteCategory(Category category)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string deleteStatement =
                "DELETE FROM tbRoomType " +
                "WHERE RoomTypeName = @name " +
                "AND UnitPrice = @price";

            SqlCommand deleteCommand =
                new SqlCommand(deleteStatement, con);

            deleteCommand.Parameters.AddWithValue(
                "@name", category.RoomTypeName);
            deleteCommand.Parameters.AddWithValue(
                "@price", category.UnitPrice);

            try
            {
                con.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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
        public static List<Category> GetRoomType()
        {
            List<Category> categorys = new List<Category>();
            SqlConnection con = HotelManagementDB.GetConnection();
            string selectStatement =
                "SELECT RoomTypeID, RoomTypeName " +
                "FROM tbRoomType " +
                "ORDER BY RoomTypeName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, con);
            try
            {
                con.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Category cate = new Category();
                    cate.RoomTypeID = reader["RoomTypeID"].GetHashCode();
                    cate.RoomTypeName = reader["RoomTypeName"].ToString();
                    categorys.Add(cate);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return categorys;
        }
    }
}
