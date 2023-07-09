using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management_System.User_Control;
using Hotel_Management_System.Forms;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    public partial class UC_Guest : UserControl
    {
        public Guest guest;

        public UC_Guest()
        {
            InitializeComponent();
            FillGuestDataGridView();
        }
        private bool IsValidataOfGuest()
        {
            return
                Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtAddress) &&
                Validator.IsPresent(txtPhone) &&
                Validator.IsPresent(txtNationality);
        }

        private void PutGuestData(Guest guest)
        {
            guest.Name = txtName.Text;
            string gender;
            if (rdoMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            guest.Gender = gender;
            guest.Address = txtAddress.Text;
            guest.Nationality = txtNationality.Text;
            guest.PhoneNumber = txtPhone.Text;
        }

        private void ClearDataOfGuestForm()
        {
            txtName.Text = "";
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtAddress.Text = "";
            txtNationality.Text = "";
            txtPhone.Text = "";
            txtGuestID.ReadOnly = true;
        }

        private void GetGuest(int guestID)
        {
            try
            {
                guest = GuestDB.GetGuest(guestID);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayDataOfGuest()
        {
            txtName.Text = guest.Name;
            string gender = guest.Gender;
            if (gender == "Male")
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }
            txtAddress.Text = guest.Address;
            txtNationality.Text = guest.Nationality;
            txtPhone.Text = guest.PhoneNumber;
        }

        private void FillGuestDataGridView()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT *FROM tbGuest";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                GuestDataGridView.DataSource = dataSet.Tables[0];
                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModifyGuest addGuestForm = new ModifyGuest();
            addGuestForm.addGuest = true;
            addGuestForm.guest = guest;

            DialogResult result = addGuestForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                guest = addGuestForm.guest;
                txtGuestID.Text = guest.GuestID.ToString();
                this.DisplayDataOfGuest();
                FillGuestDataGridView();
            }  
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyGuest modifyGuestForm = new ModifyGuest();
            modifyGuestForm.addGuest = false;
            modifyGuestForm.guest = guest;
            DialogResult result = modifyGuestForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                guest = modifyGuestForm.guest;
                this.DisplayDataOfGuest();
                FillGuestDataGridView();
            }
            else if(result == DialogResult.Retry)
            {
                this.GetGuest(guest.GuestID);
                if(guest != null)
                {
                    this.DisplayDataOfGuest();
                    FillGuestDataGridView();
                }
                else
                {
                    this.ClearDataOfGuestForm();
                }
            }
        }

        private void btnGetGuest_Click(object sender, EventArgs e)
        {
            if(Validator.IsPresent(txtGuestID) && Validator.IsInt32(txtGuestID))
            {
                int guestID = Convert.ToInt32(txtGuestID.Text);
                this.GetGuest(guestID);
                if(guest == null)
                {
                    MessageBox.Show("No guest with this ID." +
                        "Please try again.", "Guest Not Found");
                    this.ClearDataOfGuestForm();
                }
                else
                {
                    this.DisplayDataOfGuest();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsValidataOfGuest())
            {
                DialogResult result = MessageBox.Show(
                "Are you sure you want to delete " +
                guest.Name + "?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (!GuestDB.DeleteGuestData(guest))
                        {
                            MessageBox.Show("Another user has " +
                                "updated or deleted" +
                                "that guest.", "Database Error");

                            this.GetGuest(guest.GuestID);

                            if (guest != null)
                            {
                                this.DisplayDataOfGuest();
                            }
                            else
                            {
                                this.ClearDataOfGuestForm();
                                txtGuestID.Focus();
                                FillGuestDataGridView();
                            }
                        }
                        else
                        {
                            txtGuestID.Focus();
                            this.ClearDataOfGuestForm();
                            FillGuestDataGridView();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ClearDataOfGuestForm();
        }
    }
}
