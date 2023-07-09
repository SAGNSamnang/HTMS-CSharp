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
    public static class FoodDB
    {
        public static Food GetFood(int foodID)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string selectStatement =
                "SELECT FoodID, FoodName, FoodQty, Price " +
                "FROM tbFood " +
                "WHERE FoodID = @FoodID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, con);
            selectCommand.Parameters.AddWithValue(
                "@FoodID", foodID);
            try
            {
                con.Open();
                SqlDataReader foodReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (foodReader.Read())
                {
                    Food food = new Food();
                    food.FoodID = (int)foodReader["FoodID"];
                    food.Name = foodReader["FoodName"].ToString();
                    food.Qty = (int)foodReader["FoodQty"];
                    food.Price = (decimal)foodReader["Price"];
                    return food;
                }
                else
                {
                    return null;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static int AddFood(Food food)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string insertStatement = "INSERT INTO tbFood(FoodName, FoodQty, Price) " +
                "VALUES (@name, @qty, @price)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            insertCommand.Parameters.AddWithValue(
                "@name", food.Name);
            insertCommand.Parameters.AddWithValue(
                "@qty", food.Qty);
            insertCommand.Parameters.AddWithValue(
                "@price", food.Price);
            try
            {
                con.Open();
                insertCommand.ExecuteNonQuery();
                string selectCommand = "SELECT IDENT_CURRENT('tbFood') FROM tbFood";
                SqlCommand command = new SqlCommand(selectCommand, con);
                int foodID = Convert.ToInt32(command.ExecuteScalar());
                return foodID;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public static bool UpdateFood(Food food, Food newFood)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string updateStatement =
                "UPDATE tbFood SET " +
                "FoodName = @NewFoodName," +
                "FoodQty = @NewFoodQty," +
                "Price = @newPrice " +
                "WHERE FoodName = @OldFoodName " +
                "AND FoodQty = @OldFoodQty " +
                "AND Price = @OldPrice";
            SqlCommand updateCommand = new SqlCommand(updateStatement, con);
            updateCommand.Parameters.AddWithValue(
                "@NewFoodName", newFood.Name);
            updateCommand.Parameters.AddWithValue(
                "@NewFoodQty", newFood.Qty);
            updateCommand.Parameters.AddWithValue(
                "@newPrice", newFood.Price);
            updateCommand.Parameters.AddWithValue(
                "OldFoodName", food.Name);
            updateCommand.Parameters.AddWithValue(
                "@OldFoodQty", food.Qty);
            updateCommand.Parameters.AddWithValue(
                "@OldPrice", food.Price);
            try
            {
                con.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public static bool DeleteFood(Food food)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string deleteStatement =
                "DELETE FROM tbFood " +
                "WHERE FoodName = @name " +
                "AND FoodQty = @qty " +
                "AND Price = @price";
            SqlCommand deleteCommand =
                new SqlCommand(deleteStatement, con);

            deleteCommand.Parameters.AddWithValue(
                "@name", food.Name);
            deleteCommand.Parameters.AddWithValue(
                "@qty", food.Qty);
            deleteCommand.Parameters.AddWithValue(
                "@price", food.Price);
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
    }
}
