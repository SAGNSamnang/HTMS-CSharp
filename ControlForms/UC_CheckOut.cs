using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management_System.User_Control
{
    public partial class UC_CheckOut : UserControl
    {
        public CheckOut checkOut;

        public CheckOutDetial checkOutDetial;

        int key = 0;

        public UC_CheckOut()
        {
            InitializeComponent();
            FillCheckOutDataGridView();
        }
        private void FillCheckOutDataGridView()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT *FROM tbCheckOut";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewCheckOut.DataSource = dataSet.Tables[0];
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    ex.Message, ex.GetType().ToString());
            }
        }

        private void PutCheckOutData(CheckOut checkOut)
        {
            checkOut.GuestID = Convert.ToInt32(txtGuestID.Text);
            checkOut.StaffID = Convert.ToInt32(txtStaffID.Text);
            checkOut.Date = dtpCheckOutDate.Value.ToString();
            checkOut.UnitPrice = Convert.ToDecimal(txtPrice.Text);
        }

        private void DisplayCheckOutData()
        {
            txtGuestID.Text = checkOut.GuestID.ToString();
            txtStaffID.Text = checkOut.StaffID.ToString();
            dtpCheckOutDate.Value = Convert.ToDateTime(checkOut.Date);
            txtPrice.Text = checkOut.UnitPrice.ToString();
        }

        private void ClearCheckOutData()
        {
            txtGuestID.Text = "";
            txtStaffID.Text = "";
            dtpCheckOutDate.Value = DateTime.Today;
            txtPrice.Text = "";
        }

        private bool IsValidata()
        {
            return
                Validator.IsPresent(txtGuestID) &&
                Validator.IsPresent(txtStaffID) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsInt32(txtGuestID) &&
                Validator.IsInt32(txtStaffID) &&
                Validator.IsDecimal(txtPrice);
        }

        private void GetCheckOut(int checkOutID)
        {
            try
            {
                checkOut = CheckOutDB.GetCheckOut(checkOutID);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidata())
            {
                checkOut = new CheckOut();
                this.PutCheckOutData(checkOut);
                try
                {
                    checkOut.CheckOutID = CheckOutDB.Save(checkOut);
                    txtCheckOutID.Text = checkOut.CheckOutID.ToString();
                    this.DisplayCheckOutData();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        ex.Message, ex.GetType().ToString());
                }
                FillCheckOutDataGridView();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidata())
            {
                checkOut = new CheckOut();
                this.PutCheckOutData(checkOut);
                try
                {
                    CheckOutDB.UpdateCheckOutData(checkOut, key);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                FillCheckOutDataGridView();
            }
            else
            {
                ClearCheckOutData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsValidata())
            {
                checkOut = new CheckOut();
                this.PutCheckOutData(checkOut);
                try
                {
                    CheckOutDB.DeleteCheckOutData(checkOut, key);
                    this.ClearCheckOutData();
                    txtCheckOutID.Text = "";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                FillCheckOutDataGridView();
            }
            else
            {
                this.ClearCheckOutData();
                txtCheckOutID.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearCheckOutData();
            txtCheckOutID.Text = "";
            txtCheckOutID.Focus();
            txtCheckOutID.ReadOnly = false;
        }

        private void linkLabelGetCheckOutData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelGetCheckOutData.Text == "Get CheckOut")
            {
                txtCheckOutID.ReadOnly = false;
                txtCheckOutID.Focus();
                linkLabelGetCheckOutData.Text = "Search";
            }
            else if (linkLabelGetCheckOutData.Text == "Search")
            {
                int id = Convert.ToInt32(txtCheckOutID.Text);
                this.GetCheckOut(id);
                if (checkOut == null)
                {
                    MessageBox.Show(
                        "No checkout with this ID." +
                        "Please try again.", "CheckIn Not Found");
                    this.ClearCheckOutData();
                }
                else
                {
                    key = Convert.ToInt32(txtCheckOutID.Text);
                    this.DisplayCheckOutData();
                }
            }
        }

        private void dataGridViewCheckOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridViewCheckOut.Rows[index];
            txtCheckOutID.Text = row.Cells[0].Value.ToString();
            txtGuestID.Text = row.Cells[1].Value.ToString();
            txtStaffID.Text = row.Cells[2].Value.ToString();
            dtpCheckOutDate.Value= Convert.ToDateTime(row.Cells[3].Value.ToString());
            txtPrice.Text = row.Cells[4].Value.ToString();
            key = Convert.ToInt32(row.Cells[0].Value.ToString());
        }

        private void PutDataOfCheckOutDetial(CheckOutDetial checkOutDetial)
        {
            checkOutDetial.CheckOutID = Convert.ToInt32(txtCheckOutDetial.Text);
            checkOutDetial.RoomNo = Convert.ToInt32(txtRoomNo.Text);
            checkOutDetial.Amount = Convert.ToInt32(txtAmount.Text);
        }

        private void ClearCheckOutDetial()
        {
            txtCheckOutID.Text = "";
            txtRoomNo.Text = "";
            txtPrice.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (Validator.IsPresent(txtCheckOutDetial) && Validator.IsPresent(txtRoomNo) &&
                Validator.IsPresent(txtAmount) && Validator.IsInt32(txtCheckOutDetial) &&
                Validator.IsInt32(txtRoomNo) && Validator.IsDecimal(txtAmount))
            {
                check = true;
                checkOutDetial = new CheckOutDetial();
                this.PutDataOfCheckOutDetial(checkOutDetial);
                try
                {
                    if (check == true)
                    {
                        DialogResult result = MessageBox.Show(
                            "Are you sure you want to add this data into database?", "Information",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            DataAccess.Add(checkOutDetial);
                            this.ClearCheckOutDetial();
                            this.ClearCheckOutData();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
    }
}
