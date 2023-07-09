using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.Forms
{
    public partial class frmRegister : Form
    {
        public User user;

        public frmRegister()
        {
            InitializeComponent();
        }
        #region Custom control
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

        private void ptbPasswordShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(ptbPasswordShow, "Show Password");
        }

        private void ptbPasswordHide_MouseHover(object sender, EventArgs e)
        {
            // SetToolTip(Control con, string caption)
            toolTip1.SetToolTip(ptbPasswordHide, "Hide Password");
        }
        private void ptbPasswordShow_Click(object sender, EventArgs e)
        {
            ptbPasswordShow.Hide();
            txtPassword.UseSystemPasswordChar = false;
            ptbPasswordHide.Show();
        }

        private void ptbPasswordHide_Click(object sender, EventArgs e)
        {
            ptbPasswordHide.Hide();
            txtPassword.UseSystemPasswordChar = true;
            ptbPasswordShow.Show();
        }
        private void ptbCPasswordShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(ptbCPasswordShow, "Show Password");
        }

        private void ptbCPasswordHide_MouseHover(object sender, EventArgs e)
        {
            // SetToolTip(Control con, string caption)
            toolTip1.SetToolTip(ptbCPasswordHide, "Hide Password");
        }
        private void ptbCPasswordShow_Click(object sender, EventArgs e)
        {
            ptbCPasswordShow.Hide();
            txtConfirmPassword.UseSystemPasswordChar = false;
            ptbCPasswordHide.Show();
        }

        private void ptbCPasswordHide_Click(object sender, EventArgs e)
        {
            ptbCPasswordHide.Hide();
            txtConfirmPassword.UseSystemPasswordChar = true;
            ptbCPasswordShow.Show();
        }

        private void ptbBack_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();

        }
        #endregion

        private bool IsValidata()
        {
            return
                Validator.IsPresent(txtUsername) &&
                Validator.IsPresent(txtEmail) &&
                Validator.IsPresent(txtPassword) &&
                Validator.IsPresent(txtConfirmPassword);
        }
        private void PutUserData(User user)
        {
            user.Name = txtUsername.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
        }
        private void ClearUserData()
        {
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (IsValidata())
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    user = new User();
                    this.PutUserData(user);
                    try
                    {
                        UserDB.Add(user);
                        this.ClearUserData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }

                }
                else
                {
                    MessageBox.Show(txtPassword.Tag + " must be the same of " + txtConfirmPassword.Tag);
                }
            }
        }
    }
}
