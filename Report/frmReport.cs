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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
            cboReport.SelectedIndex = 0;
        }

        private void FillReportDataGridView(string queries)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(queries, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridViewReport.DataSource = ds.Tables[0];
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

        private void ComboBoxSelectedIndex()
        {
            if (Validator.IsPresent(cboReport))
            {
                if (cboReport.SelectedIndex == 0)
                {
                    string day = DateTime.Today.ToShortDateString();
                    string queries = "SELECT cd.CheckInID, cd.RoomNo, CheckInDate, GuestName, GuestPhone, RoomTypeName, Duration, c.UnitPrice, StaffName "
                                     + "FROM tbGuest AS g INNER JOIN(tbStaff AS s INNER JOIN (tbCheckIn AS c "
                                     + "INNER JOIN (tbCheckInDetial AS cd INNER JOIN (tbRoom AS r INNER JOIN tbRoomType "
                                            + "rt ON r.RoomType = rt.RoomTypeID) ON "
                                            + "cd.RoomNo = r.RoomNo) ON "
                                            + "c.CheckInID = cd.CheckInID) ON "
                                            + "s.StaffID = c.StaffID) ON "
                                            + "g.GuestID = c.GuestID " +
                                            $"Where CheckInDate = '{day}'";
                    FillReportDataGridView(queries);
                }
                else if(cboReport.SelectedIndex == 1)
                {
                    string queries = "SELECT cd.CheckInID, cd.RoomNo, CheckInDate, GuestName, GuestPhone, RoomTypeName, Duration, c.UnitPrice, StaffName "
                                     + "FROM tbGuest AS g INNER JOIN(tbStaff AS s INNER JOIN (tbCheckIn AS c "
                                     + "INNER JOIN (tbCheckInDetial AS cd INNER JOIN (tbRoom AS r INNER JOIN tbRoomType "
                                            + "rt ON r.RoomType = rt.RoomTypeID) ON "
                                            + "cd.RoomNo = r.RoomNo) ON "
                                            + "c.CheckInID = cd.CheckInID) ON "
                                            + "s.StaffID = c.StaffID) ON "
                                            + "g.GuestID = c.GuestID " +
                                            "Where CheckInDate between '1/1/2023' and '12/1/2023'";
                    FillReportDataGridView(queries);
                }
                else if(cboReport.SelectedIndex == 2)
                {
                    string queries = "SELECT cd.CheckInID, cd.RoomNo, CheckInDate, GuestName, GuestPhone, RoomTypeName, Duration, c.UnitPrice, StaffName "
                                     + "FROM tbGuest AS g INNER JOIN(tbStaff AS s INNER JOIN (tbCheckIn AS c "
                                     + "INNER JOIN (tbCheckInDetial AS cd INNER JOIN (tbRoom AS r INNER JOIN tbRoomType "
                                            + "rt ON r.RoomType = rt.RoomTypeID) ON "
                                            + "cd.RoomNo = r.RoomNo) ON "
                                            + "c.CheckInID = cd.CheckInID) ON "
                                            + "s.StaffID = c.StaffID) ON "
                                            + "g.GuestID = c.GuestID " +
                                            "Where CheckInDate between '1/1/2022' and '12/1/2023'"; ;
                    FillReportDataGridView(queries);
                }
                else
                {

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string data = txtSearch.Text;
            string queries = "SELECT cd.CheckInID, cd.RoomNo, CheckInDate, GuestName, GuestPhone, RoomTypeName, Duration, c.UnitPrice, StaffName "
                           + "FROM tbGuest AS g INNER JOIN(tbStaff AS s INNER JOIN (tbCheckIn AS c "
                           + "INNER JOIN (tbCheckInDetial AS cd INNER JOIN (tbRoom AS r INNER JOIN tbRoomType "
                                   + "rt ON r.RoomType = rt.RoomTypeID) ON "
                                   + "cd.RoomNo = r.RoomNo) ON "
                                   + "c.CheckInID = cd.CheckInID) ON "
                                   + "s.StaffID = c.StaffID) ON "
                                   + "g.GuestID = c.GuestID " +
                                   $"Where CheckInDate = '{data}'";
            FillReportDataGridView(queries);
        }

        private bool IsValidata()
        {
            return
                Validator.IsPresent(txtSearch) &&
                Validator.IsPresent(cboReport);
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            ComboBoxSelectedIndex();
        }

        private void cboReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSelectedIndex();
        }
    }
}
