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
    public partial class UC_CheckIn : UserControl
    {
        public CheckIn checkIn;

        public CheckInDetial checkInDetial;

        int key = 0;

        public UC_CheckIn()
        {
            InitializeComponent();
            FillCheckInDataGridView();
        }

        private void GuestHasBooking()
        {
            dtpDateIn.Enabled = false;
            txtDuration.Enabled = false;
            txtStaffID.Enabled = false;
            txtUnitPrice.Enabled = false;
            txtPrepaid.Enabled = false;
            txtGuestID.Focus();
        }

        private void GuestNotBooking()
        {
            dtpDateIn.Enabled = true;
            txtDuration.Enabled = true;
            txtGuestID.Enabled = true;
            txtStaffID.Enabled = true;
            txtUnitPrice.Enabled = true;
            txtPrepaid.Enabled = true;
            dtpDateIn.Focus();
        }

        private void FillCheckInDataGridView()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT *FROM tbCheckIn";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                CheckInDataGridView.DataSource = dataSet.Tables[0];
                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(
                    ex.Message, ex.GetType().ToString());
            }
        }

        private void PutCheckInData(CheckIn checkIn)
        {
            checkIn.Date = dtpDateIn.Value.ToString();
            checkIn.Duration = Convert.ToInt32(txtDuration.Text);
            checkIn.GuestID = Convert.ToInt32(txtGuestID.Text);

            checkIn.StaffID = Convert.ToInt32(txtStaffID.Text);
            checkIn.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            checkIn.Prepaid = Convert.ToDecimal(txtPrepaid.Text);
        }

        private void DisplayCheckInData()
        {
            dtpDateIn.Value = Convert.ToDateTime(checkIn.Date);
            txtDuration.Text = checkIn.Duration.ToString();
            txtGuestID.Text = checkIn.GuestID.ToString();
            txtStaffID.Text = checkIn.StaffID.ToString();
            txtUnitPrice.Text = checkIn.UnitPrice.ToString();
            txtPrepaid.Text = checkIn.Prepaid.ToString();
        }

        private void ClearCheckInData()
        {
            dtpDateIn.Value = DateTime.Today;
            txtDuration.Text = "";
            txtGuestID.Text = "";
            txtStaffID.Text = "";
            txtUnitPrice.Text = "";
            txtPrepaid.Text = "";
        }

        private bool IsValidata()
        {
            return
                Validator.IsPresent(txtDuration) &&
                Validator.IsPresent(txtGuestID) &&
                Validator.IsPresent(txtStaffID) &&
                Validator.IsPresent(txtUnitPrice) &&
                Validator.IsPresent(txtPrepaid) &&
                Validator.IsInt32(txtDuration) &&
                Validator.IsInt32(txtGuestID) &&
                Validator.IsInt32(txtStaffID) &&
                Validator.IsDecimal(txtUnitPrice) &&
                Validator.IsDecimal(txtPrepaid);
        }

        private void GetCheckIn(int checkInID)
        {
            try
            {
                checkIn = CheckInDB.GetCheckIn(checkInID);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void rdoBooked_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBooked.Checked == true)
            {
                GuestHasBooking();
            }
        }

        private void rdoNotBooking_CheckedChanged(object sender, EventArgs e)
        {
            GuestNotBooking();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidata())
            {
                checkIn = new CheckIn();
                this.PutCheckInData(checkIn);
                try
                {
                    checkIn.CheckInID = CheckInDB.Save(checkIn);
                    txtGetCheckInID.Text = checkIn.CheckInID.ToString();
                    this.DisplayCheckInData();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(
                        ex.Message, ex.GetType().ToString());
                }
                FillCheckInDataGridView();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidata())
            {
                checkIn = new CheckIn();
                this.PutCheckInData(checkIn);
                try
                {
                    CheckInDB.UpdateCheckInData(checkIn, key);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                FillCheckInDataGridView();
            }
            else
            {
                ClearCheckInData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsValidata())
            {
                checkIn = new CheckIn();
                this.PutCheckInData(checkIn);
                try
                {
                    CheckInDB.DeleteCheckInData(checkIn, key);      
                    this.ClearCheckInData();
                    txtGetCheckInID.Text = "";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                FillCheckInDataGridView();
            }
            else
            {
                this.ClearCheckInData();
                txtGetCheckInID.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearCheckInData();
            txtGetCheckInID.Text = "";
            txtGetCheckInID.Focus();
            txtGetCheckInID.ReadOnly = false;
        }

        private void linkLabelGetCheckInData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkLabelGetCheckInData.Text == "Get CheckIn")
            {
                txtGetCheckInID.ReadOnly = false;
                txtGetCheckInID.Focus();
                linkLabelGetCheckInData.Text = "Search";
            }
            else if(linkLabelGetCheckInData.Text == "Search")
            {
                int id = Convert.ToInt32(txtGetCheckInID.Text);
                this.GetCheckIn(id);
                if(checkIn == null)
                {
                    MessageBox.Show(
                        "No checkin with this ID." +
                        "Please try again.", "CheckIn Not Found");
                    this.ClearCheckInData();
                }
                else
                {
                    key = Convert.ToInt32(txtGetCheckInID.Text);
                    this.DisplayCheckInData();
                }
            }
        }

        private void CheckInDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = CheckInDataGridView.Rows[index];
            txtGetCheckInID.Text = row.Cells[0].Value.ToString();
            dtpDateIn.Value = Convert.ToDateTime(row.Cells[1].Value.ToString());
            txtDuration.Text = row.Cells[2].Value.ToString();
            txtGuestID.Text = row.Cells[3].Value.ToString();
            txtStaffID.Text = row.Cells[4].Value.ToString();
            txtUnitPrice.Text = row.Cells[5].Value.ToString();
            txtPrepaid.Text = row.Cells[6].Value.ToString();
            key = Convert.ToInt32(row.Cells[0].Value.ToString());
        }

        private void PutDataOfCheckInDetial(CheckInDetial checkInDetial)
        {
            checkInDetial.CheckInID = Convert.ToInt32(txtDetailCheckInID.Text);
            checkInDetial.RoomNo = Convert.ToInt32(txtDetailRoomNo.Text);
            checkInDetial.Amount = Convert.ToInt32(txtDetailAmount.Text);
        }

        private void ClearCheckInDetial()
        {
            txtDetailCheckInID.Text = "";
            txtDetailRoomNo.Text = "";
            txtDetailAmount.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (Validator.IsPresent(txtDetailCheckInID) && Validator.IsPresent(txtDetailRoomNo) &&
                Validator.IsPresent(txtDetailAmount) && Validator.IsInt32(txtDetailCheckInID) &&
                Validator.IsInt32(txtDetailRoomNo) && Validator.IsDecimal(txtDetailAmount))
            {
                check = true;
                checkInDetial = new CheckInDetial();
                this.PutDataOfCheckInDetial(checkInDetial);
                try
                {
                    if (check == true)
                    {
                        DialogResult result = MessageBox.Show(
                            "Are you sure you want to add this data into database?", "Information",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            DataAccess.Add(checkInDetial);
                            this.ClearCheckInDetial();
                            this.ClearCheckInData();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ClearCheckInDetial();
            this.ClearCheckInData();
        }

        private void ClearDataLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ClearCheckInDetial();
        }
    }
}
