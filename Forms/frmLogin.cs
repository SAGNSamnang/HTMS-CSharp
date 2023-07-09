using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
// using for hide database

namespace Hotel_Management_System
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        #region Custom controls
        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureBoxCancel_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxCancel, "Cancel");
        }

        private void pictureBoxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(ptbShow, "Show Password");
        }

        private void ptbHide_MouseHover(object sender, EventArgs e)
        {
            // SetToolTip(Control con, string caption)
            toolTip1.SetToolTip(ptbHide, "Hide Password");
        }

        private void ptbShow_Click(object sender, EventArgs e)
        {
            ptbShow.Hide();
            txtPassword.UseSystemPasswordChar = false;
            ptbHide.Show();
        }

        private void ptbHide_Click(object sender, EventArgs e)
        {
            ptbHide.Hide();
            txtPassword.UseSystemPasswordChar = true;
            ptbShow.Show();
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            string query = "SELECT *FROM tbUsers where UserName = '" + txtUsername.Text
                + "' and UserPassword = '" + txtPassword.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {  
                this.Hide();
                Forms.frmMain mainForm = new Forms.frmMain();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Something want wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Forms.frmRegister frmRegister = new Forms.frmRegister();
            frmRegister.Show();
        }
    }
}
