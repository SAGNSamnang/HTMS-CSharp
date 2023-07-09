using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management_System.Forms
{
    public partial class frmRoomCategory : Form
    {
        public frmRoomCategory()
        {
            InitializeComponent();
            populate();
        }

        public void populate()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            con.Open();
            string queries = "Select *From tbRoomType";
            SqlDataAdapter da = new SqlDataAdapter(queries, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvCategory.DataSource = ds.Tables[0];
            con.Close();
        }
        public void InsertRooms()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string insertStatement =
                "INSERT INTO tbRoomType (RoomTypeName, UnitPrice) VALUES (@Rtn, @Up)";
                SqlCommand insertCommand =
                    new SqlCommand(insertStatement, con);
                insertCommand.Parameters.AddWithValue(
                    "@Rtn", txtName.Text);
                insertCommand.Parameters.AddWithValue(
                    "@Up", txtPrice.Text);
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Category inserted!");
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            populate();
        }
        int key = 0;
        public void EditCategory()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            if (IsValidateData())
            {
                try
                {
                    con.Open();
                    string updateStatement =
                        "UPDATE tbRoomType SET RoomTypeName = @Rtn, UnitPrice = @Un " +
                        "WHERE RoomTypeID = @Rti";
                    SqlCommand updateCommand = new SqlCommand(updateStatement, con);
                    updateCommand.Parameters.AddWithValue(
                        "@Rtn", txtName.Text);
                    updateCommand.Parameters.AddWithValue(
                        "@Un", txtPrice.Text);
                    updateCommand.Parameters.AddWithValue(
                        "@Rti", key);
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Category updated!");
                    con.Close();
                    populate();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        ex.Message, ex.GetType().ToString());
                }
            }
        }
        public void DeleteCategory()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            if (IsValidateData())
            {           
                try
                {
                    con.Open();
                    string deleteStatement =
                        "DELETE FROM tbRoomType WHERE RoomTypeID = @RoomTypeID";
                    SqlCommand deleteCommand = new SqlCommand(deleteStatement, con);
                    deleteCommand.Parameters.AddWithValue(
                        "@RoomTypeID", key);
                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show(
                        "Delete category!!");
                    con.Close();
                    populate();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(
                        ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertRooms();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryID.Text = dgvCategory.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgvCategory.CurrentRow.Cells[2].Value.ToString();
            if (txtName.Text == "")
            {
                key = 0;
                btnModify.Enabled = false;
                btnModify.Enabled = false;
            }
            else
            {
                key = Convert.ToInt32(dgvCategory.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            EditCategory();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }
        private bool IsValidateData()
        {
            return
                Validator.IsPresent(txtCategoryID) &&
                Validator.IsInt32(txtCategoryID) &&
                Validator.IsPresent(txtName) &&
                Validator.IsInt32(txtPrice);
        }
    }
}
