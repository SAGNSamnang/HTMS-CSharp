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
    public static class EmployeeDB
    {
        public static void AddEmployee(Employee emp)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string insertStatement =
                    "INSERT INTO tbStaff (StaffName, StaffGender, StaffPhone, StaffAddress, StaffEmail," +
                    "StaffNationality, StaffPosition, StaffSalary) " +
                    "VALUES (@name, @gender, @phone, @address, @email, @nationality, @position, @salary)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            insertCommand.Parameters.AddWithValue(
                "@name", emp.StaffName);
            insertCommand.Parameters.AddWithValue(
                "@gender", emp.StaffGender);
            insertCommand.Parameters.AddWithValue(
                "@phone", emp.StaffPhone);
            insertCommand.Parameters.AddWithValue(
                "@address", emp.StaffAddress);
            insertCommand.Parameters.AddWithValue(
                "@email", emp.StaffEmail);
            insertCommand.Parameters.AddWithValue(
                "@nationality", emp.Nationality);
            insertCommand.Parameters.AddWithValue(
                "@position", emp.StaffPosition);
            insertCommand.Parameters.AddWithValue(
                "@salary", emp.StaffSalary);
            try
            {         
                con.Open();   
                insertCommand.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public static void UpdateEmployeeData(Employee emp, int key)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string updateStatement =
                "UPDATE tbStaff SET StaffName=@name, StaffGender=@gender, StaffPhone=@phone, " +
                "StaffAddress=@address, StaffEmail=@email, StaffNationality=@nationality, " +
                "StaffPosition=@position, StaffSalary=@salary " +
                "WHERE StaffID=@id";
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, con);
            updateCommand.Parameters.AddWithValue(
                        "@name", emp.StaffName);
            updateCommand.Parameters.AddWithValue(
                "@gender", emp.StaffGender);
            updateCommand.Parameters.AddWithValue(
                "@phone", emp.StaffPhone);
            updateCommand.Parameters.AddWithValue(
                "@address", emp.StaffAddress);
            updateCommand.Parameters.AddWithValue(
                "@email", emp.StaffEmail);
            updateCommand.Parameters.AddWithValue(
                "@nationality", emp.Nationality);
            updateCommand.Parameters.AddWithValue(
                "@position", emp.StaffPosition);
            updateCommand.Parameters.AddWithValue(
                "@salary", emp.StaffSalary);
            updateCommand.Parameters.AddWithValue(
                "@id", key);
            try
            {
                con.Open();
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("Data updated");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public static void DeleteEmployeeData(Employee emp, int key)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string deleteStatement =
                "DELETE FROM tbStaff WHERE StaffID = @StaffID";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, con);
            deleteCommand.Parameters.AddWithValue(
                "@StaffID", key);
            try
            {
                con.Open();
                deleteCommand.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(
                    ex.Message, ex.GetType().ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public static Employee GetEmployee(int staffID)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string selectStatement =
                "SELECT StaffID, StaffName, StaffGender, StaffPhone, " +
                "StaffAddress, StaffEmail, StaffNationality, StaffPosition, StaffSalary " +
                "FROM tbStaff " +
                "WHERE StaffID = @StaffID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, con);
            selectCommand.Parameters.AddWithValue(
                "@StaffID", staffID);
            try
            {
                con.Open();
                SqlDataReader empReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (empReader.Read())
                {
                    Employee emp = new Employee();
                    emp.StaffID = (int)empReader["StaffID"];
                    emp.StaffName = empReader["StaffName"].ToString();
                    emp.StaffGender = empReader["StaffGender"].ToString();
                    emp.StaffPhone = empReader["StaffPhone"].ToString();
                    emp.StaffAddress = empReader["StaffAddress"].ToString();
                    emp.StaffEmail = empReader["StaffEmail"].ToString();
                    emp.Nationality = empReader["StaffNationality"].ToString();
                    emp.StaffPosition = empReader["StaffPosition"].ToString();
                    emp.StaffSalary = Convert.ToDecimal(empReader["StaffSalary"]);
                    return emp;
                }
                else
                {
                    return null;
                }
            }catch(SqlException ex)
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
