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
    public partial class frmInformationBooking : Form
    {

        public Guest guest;

        public Booking booking;

        public Category roomType;

        public BookingDetial bookingDetial;


        public frmInformationBooking()
        {
            InitializeComponent();
        }
        //
        // Guest
        //
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
            txtGuestID.Text = "";
            SearchAndUpdateBookingLinkLab.Text = "Search";
            txtGuestID.ReadOnly = true;
        }

        private void linkLabelSaveInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool check = false;
            if (IsValidataOfGuest())
            {
                check = true;
                guest = new Guest();
                this.PutGuestData(guest);
                try
                {
                    if(check == true)
                    {
                        DialogResult result = MessageBox.Show(
                            "Are you sure you want to add this data into database?", "Information",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if(result == DialogResult.OK)
                        {
                            guest.GuestID = GuestDB.AddGuest(guest);
                            txtGuestID.Text = guest.GuestID.ToString();
                            this.DisplayDataOfGuest();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void lLabelDeleteInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                            }
                        }
                        else
                        {
                            this.ClearDataOfGuestForm();
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

        private void lLabelClearInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearDataOfGuestForm();
        }

        private void lLabelSeachAndUpdateInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changeControl(txtGuestID, txtName);
            if(SearchAndUpdateBookingLinkLab.Text == "Search")
            {
                SearchAndUpdateBookingLinkLab.Text = "Get Guest";
                txtGuestID.Focus();
            }
            else if(SearchAndUpdateBookingLinkLab.Text == "Get Guest")
            {
                SearchAndUpdateBookingLinkLab.Text = "Update";
                int id = Convert.ToInt32(txtGuestID.Text);
                this.GetGuest(id);
                if (guest == null)
                {
                    MessageBox.Show(
                        "No employee with this id." +
                        "Please try again.",
                        "Employee not found!");
                    this.ClearDataOfGuestForm();
                }
                else
                {
                    this.DisplayDataOfGuest();
                }
            }
            else if(SearchAndUpdateBookingLinkLab.Text == "Update")
            {
                ModifyGuest modifyGuestForm = new ModifyGuest();
                modifyGuestForm.addGuest = false;
                modifyGuestForm.guest = guest;
                //DialogResult result = MessageBox.Show(
                //    "Are you sure you want to update this data? ", "Update",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = modifyGuestForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    guest = modifyGuestForm.guest;
                    this.DisplayDataOfGuest();
                }
                else if(result == DialogResult.Retry)
                {
                    this.GetGuest(guest.GuestID);
                    if(guest != null)
                    {
                        this.DisplayDataOfGuest();
                    }
                    else
                    {
                        this.ClearDataOfGuestForm();
                    }
                }
            }
        }

        private void changeControl(TextBox textBox, TextBox textBox1)
        {
            textBox.ReadOnly = false;
            if (textBox.Text == "")
            {
                textBox1.ReadOnly = true;
            }
            else
                textBox1.ReadOnly = false;
        }

        private void GetGuest(int guestID)
        {
            try
            {
                guest = GuestDB.GetGuest(guestID);
            }
            catch(SqlException ex)
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

        //
        // Booking
        //
        private bool IsValidataOfBooking()
        {
            return
                // datatimepicker
                Validator.IsPresent(txtDuration) &&
                Validator.IsDecimal(txtGuestPrepaid) &&
                Validator.IsPresent(txtBookingGuestID) &&
                Validator.IsInt32(txtBookingGuestID) &&
                Validator.IsPresent(txtBookingStaffID) &&
                Validator.IsInt32(txtBookingStaffID);
        }

        private void GetBooking(int bookingID)
        {
            try
            {
                booking = BookingDB.GetBooking(bookingID);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ClearDataOfBookingForm()
        {
            SearchAndUpdateBooking.Text = "Search";
            dtpDate.Value = DateTime.Today;
            txtDuration.Text = "";
            txtGuestPrepaid.Text = "";
            txtBookingGuestID.Text = "";
            txtBookingStaffID.Text = "";
        }

        private void DisplayDataOfBooking()
        {
            string dtp = booking.BookingDate;
            dtpDate.Value.ToString(dtp);
            txtDuration.Text = Convert.ToString(booking.Duration);
            txtGuestPrepaid.Text = Convert.ToString(booking.TotalPrepaid);
            txtGuestID.Text = Convert.ToString(booking.GuestID);
            txtBookingStaffID.Text = Convert.ToString(booking.StaffID);
        }

        private void PutDataOfBooking(Booking booking)
        {
            booking.BookingDate = dtpDate.Value.ToShortDateString();
            booking.Duration = Convert.ToInt32(txtDuration.Text);
            booking.TotalPrepaid = Convert.ToDecimal(txtGuestPrepaid.Text);
            booking.GuestID = Convert.ToInt32(txtBookingGuestID.Text);
            booking.StaffID = Convert.ToInt32(txtBookingStaffID.Text);
        }

        private void lLabelClearBooking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearDataOfBookingForm();
        }

        private void llabelSearchAndUpdateBooking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changeControl(txtBookingID, txtDuration);
            if (SearchAndUpdateBooking.Text == "Search")
            {
                SearchAndUpdateBooking.Text = "Get Booking";
                txtBookingID.Focus();
            }
            else if (SearchAndUpdateBooking.Text == "Get Booking")
            {
                SearchAndUpdateBooking.Text = "Update";
                int id = Convert.ToInt32(txtBookingID.Text);
                this.GetBooking(id);
                if (booking == null)
                {
                    MessageBox.Show(
                        "No booking with this id." +
                        "Please try again.",
                        "Booking information not found!");
                    this.ClearDataOfBookingForm();
                }
                else
                {
                    this.DisplayDataOfBooking();
                }
            }
            else if (SearchAndUpdateBooking.Text == "Update")
            {
                ModifyGuest modifyGuestForm = new ModifyGuest();
                modifyGuestForm.addGuest = false;
                modifyGuestForm.guest = guest;
                //DialogResult result = MessageBox.Show(
                //    "Are you sure you want to update this data? ", "Update",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = modifyGuestForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    guest = modifyGuestForm.guest;
                    this.DisplayDataOfGuest();
                }
                else if (result == DialogResult.Retry)
                {
                    this.GetGuest(guest.GuestID);
                    if (guest != null)
                    {
                        this.DisplayDataOfGuest();
                    }
                    else
                    {
                        this.ClearDataOfGuestForm();
                    }
                }
            }
        }

        private void lLabelDeleteBooking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (IsValidataOfBooking())
            {
                DialogResult result = MessageBox.Show(
                "Are you sure you want to delete " +
                booking.BookingID + "?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (!BookingDB.DeleteBookingData(booking))
                        {
                            MessageBox.Show("Another user has " +
                                "updated or deleted" +
                                "that booking.", "Database Error");

                            this.GetBooking(booking.BookingID);

                            if (booking != null)
                            {
                                this.DisplayDataOfBooking();
                            }
                            else
                            {
                                this.ClearDataOfBookingForm();
                            }
                        }
                        else
                        {
                            this.ClearDataOfBookingForm();
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

        private void linkLabelSaveBooking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool check = false;
            if (IsValidataOfBooking())
            {
                check = true;
                booking = new Booking();
                this.PutDataOfBooking(booking);
                try
                {
                    if (check == true)
                    {
                        DialogResult result = MessageBox.Show(
                            "Are you sure you want to add this data into database?", "Information",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            booking.BookingID = BookingDB.AddBooking(booking);
                            txtBookingID.Text = booking.BookingID.ToString();
                            this.DisplayDataOfBooking();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
        //
        // Booking Detial
        //
        private bool IsValidataBookingDetial()
        {
            return
                Validator.IsPresent(txtDetailBooking) &&
                Validator.IsPresent(txtDetailRoomNo) &&
                Validator.IsInt32(txtDetailBooking) &&
                Validator.IsInt32(txtDetailRoomNo);
        }

        private void PutDataOfBookingDetail(BookingDetial bd)
        {
            bd.BookingID = Convert.ToInt32(txtDetailBooking.Text);
            bd.RoomNo = Convert.ToInt32(txtDetailRoomNo.Text);
        }

        private void ClearBookingDetail()
        {
            txtDetailBooking.Text = "";
            txtDetailRoomNo.Text = "";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (IsValidataBookingDetial())
            {
                check = true;
                bookingDetial = new BookingDetial();
                this.PutDataOfBookingDetail(bookingDetial);
                try
                {
                    if (check == true)
                    {
                        DialogResult result = MessageBox.Show(
                            "Are you sure you want to add this data into database?", "Information",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            DataAccess.Add(bookingDetial);
                            this.ClearBookingDetail();
                            this.ClearBookingDetail();
                            this.ClearDataOfGuestForm();
                        }
                        else
                        {
                            this.Close();
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
            Forms.frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Hide();
        }
    }
}
