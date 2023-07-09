using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public static class OrderDB
    {
        public static Order GetOrder(int orderID)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string selectStatement =
                "SELECT OrderID, OrderType, OrderQty, UnitPrice, GuestID " +
                "FROM tbOrders " +
                "WHERE OrderID = @OrderID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, con);
            selectCommand.Parameters.AddWithValue(
                "@OrderID", orderID);
            try
            {
                con.Open();
                SqlDataReader orderReader = selectCommand.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                if (orderReader.Read())
                {
                    Order order = new Order();
                    order.OrderID = (int)orderReader["OrderID"];
                    order.OrderType = orderReader["OrderType"].ToString();
                    order.OrderQty = (int)orderReader["OrderQty"];
                    order.UnitPrice = (decimal)orderReader["UnitPrice"];
                    order.GuestID = (int)orderReader["GuestID"];
                    return order;
                }
                else
                {
                    return null;
                }
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

        public static int AddOrder(Order order)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string insertStatement = "INSERT INTO tbOrders(OrderType, OrderQty, UnitPrice, GuestID) " +
                "VALUES (@type, @qty, @price, @guestid)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            insertCommand.Parameters.AddWithValue(
                "@type", order.OrderType);
            insertCommand.Parameters.AddWithValue(
                "@qty", order.OrderQty);
            insertCommand.Parameters.AddWithValue(
                "@price", order.UnitPrice);
            insertCommand.Parameters.AddWithValue(
                "@guestid", order.GuestID);
            try
            {
                con.Open();
                insertCommand.ExecuteNonQuery();
                string selectCommand = "SELECT IDENT_CURRENT('tbOrders') FROM tbOrders";
                SqlCommand command = new SqlCommand(selectCommand, con);
                int orderID = Convert.ToInt32(command.ExecuteScalar());
                return orderID;
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
        public static bool UpdateOrder(Order oldOrder, Order newOrder)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string updateStatement =
                "UPDATE tbOrders SET " +
                "OrderType = @NewOrderType," +
                "OrderQty = @NewOrderQty," +
                "UnitPrice = @NewUnitPrice " +
                "GuestID = @NewGuestID " +
                "WHERE OrderType = @OldOrderType " +
                "AND OrderQty = @OldOrderQty " +
                "AND UnitPrice = @OldUnitPrice " +
                "AND GuestID = @OldGuestID";
            SqlCommand updateCommand = new SqlCommand(updateStatement, con);
            updateCommand.Parameters.AddWithValue(
                "@NewOrderType", newOrder.OrderType);
            updateCommand.Parameters.AddWithValue(
                "@NewOrderQty", newOrder.OrderQty);
            updateCommand.Parameters.AddWithValue(
                "@NewUnitPrice", newOrder.UnitPrice);
            updateCommand.Parameters.AddWithValue(
                "@NewGuestID", newOrder.GuestID);

            updateCommand.Parameters.AddWithValue(
                "@OldOrderType", oldOrder.OrderType);
            updateCommand.Parameters.AddWithValue(
                "@OldOrderQty", oldOrder.OrderQty);
            updateCommand.Parameters.AddWithValue(
                "@OldUnitPrice", oldOrder.UnitPrice);
            updateCommand.Parameters.AddWithValue(
                "@OldGuestID", oldOrder.GuestID);

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
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public static bool DeleteOrder(Order order)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string deleteStatement =
                "DELETE FROM tbOrders " +
                "WHERE OrderType = @type " +
                "AND OrderQty = @qty " +
                "AND UnitPrice = @price " +
                "AND GuestID = @guestID";
            SqlCommand deleteCommand =
                new SqlCommand(deleteStatement, con);

            deleteCommand.Parameters.AddWithValue(
                "@type", order.OrderType);
            deleteCommand.Parameters.AddWithValue(
                "@qty", order.OrderQty);
            deleteCommand.Parameters.AddWithValue(
                "@price", order.UnitPrice);
            deleteCommand.Parameters.AddWithValue(
                "@guestID", order.GuestID);
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
