
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            CountCheckIn();
            CountFood();
            CountOrder();
            CountCheckOut();
            CountGuest();
            CountEmployee();
            CountSingleRoom();
            CountDoubleRoom();
            CountVIPRoom();
            CountBooking();
        }
        private void CountGuest()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string queries = "SELECT COUNT(*) FROM tbGuest";
                SqlCommand command = new SqlCommand(queries, con);
                var count = command.ExecuteScalar();
                lblGuestCount.Text = count.ToString();
                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void CountEmployee()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string queries = "SELECT COUNT(*) FROM tbStaff";
                SqlCommand command = new SqlCommand(queries, con);
                var count = command.ExecuteScalar();
                lblEmployeeCount.Text = count.ToString();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void CountSingleRoom()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM tbRoomType WHERE RoomTypeName = 'Single Room'";
                SqlCommand command = new SqlCommand(query, con);
                var count = command.ExecuteScalar();
                lblCountSingleRoom.Text = count.ToString();
                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void CountDoubleRoom()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM tbRoomType WHERE RoomTypeName = 'Double Room'";
                SqlCommand command = new SqlCommand(query, con);
                var count = command.ExecuteScalar();
                lblCountDoubleRoom.Text = count.ToString();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void CountVIPRoom()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM tbRoomType WHERE RoomTypeName = 'VIP Room'";
                SqlCommand command = new SqlCommand(query, con);
                var count = command.ExecuteScalar();
                lblCountVIPRoom.Text = count.ToString();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void CountBooking()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string query = "select count(*) from tbBooking";
                SqlCommand command = new SqlCommand(query, con);
                var count = command.ExecuteScalar();
                lbleCountBooking.Text = count.ToString();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void CountCheckIn()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM tbCheckIn";
                SqlCommand command = new SqlCommand(query, con);
                var count = command.ExecuteScalar();
                lblCheckInCount.Text = count.ToString();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void CountFood()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM tbFood";
                SqlCommand command = new SqlCommand(query, con);
                var count = command.ExecuteScalar();
                lblCountFood.Text = count.ToString();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void CountOrder()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM tbOrders";
                SqlCommand command = new SqlCommand(query, con);
                var count = command.ExecuteScalar();
                lblCountOrder.Text = count.ToString();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void CountCheckOut()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM tbCheckOut";
                SqlCommand command = new SqlCommand(query, con);
                var count = command.ExecuteScalar();
                lblCountCheckOut.Text = count.ToString();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            CountCheckIn();
            CountFood();
            CountOrder();
            CountCheckOut();
            CountGuest();
            CountEmployee();
            CountSingleRoom();
            CountDoubleRoom();
            CountVIPRoom();
            CountBooking();
        }
        private void AddUserControl(UserControl userControl)
        {
            pnlDashboard.Controls.Clear();
            pnlDashboard.Dock = DockStyle.Fill;
            pnlDashboard.Controls.Add(userControl);
            pnlDashboard.BringToFront();
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmInformationBooking bookingForm = new frmInformationBooking();
            bookingForm.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            frmReservation reservationForm = new frmReservation();
            reservationForm.Show();
        }

        private void btnRoomManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRoomManage roomManageForm = new frmRoomManage();
            roomManageForm.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployee empForm = new frmEmployee();
            empForm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport reportForm = new frmReport();
            reportForm.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrder orderForm = new frmOrder();
            orderForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlHome.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlHome.Hide();
            pnlDashboard.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
