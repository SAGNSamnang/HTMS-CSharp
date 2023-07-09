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
    public partial class ModifyGuest : Form
    {
        public bool addGuest;
        public Guest guest;

        public ModifyGuest()
        {
            InitializeComponent();
        }
        private bool IsValidata()
        {
            return
                Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtAddress) &&
                Validator.IsPresent(txtNationality) &&
                Validator.IsPresent(txtPhone);
        }

        private void DisplayGuest()
        {
            txtName.Text = guest.Name;
            string gender = guest.Gender;
            if (gender == "Male")
                rdoMale.Checked = true;
            else
                rdoFemale.Checked = true;
            txtAddress.Text = guest.Address;
            txtNationality.Text = guest.Nationality;
            txtPhone.Text = guest.PhoneNumber;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidata())
            {
                if (addGuest)
                {
                    guest = new Guest();
                    this.PutGuestData(guest);
                    try
                    {
                        guest.GuestID = GuestDB.AddGuest(guest);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            ex.GetType().ToString());
                    }
                }
                else
                {
                    Guest newGuest = new Guest();
                    newGuest.GuestID = guest.GuestID;
                    this.PutGuestData(newGuest);

                    try
                    {
                        if (!GuestDB.UpdateGuestData(guest, newGuest))
                        {
                            MessageBox.Show(
                                "Another user has updated or " +
                                "deleted that guest.",
                                "Database Error");

                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            // change data
                            guest = newGuest;

                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            ex.GetType().ToString());
                    }
                }
            }
        }

        private void PutGuestData(Guest guest)
        {
            guest.Name = txtName.Text;
            string gender;
            if(rdoFemale.Checked == true)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }
            guest.Gender = gender;
            guest.Address = txtAddress.Text;
            guest.Nationality = txtNationality.Text;
            guest.PhoneNumber = txtPhone.Text;
        }

        private void frmModifyGuest_Load(object sender, EventArgs e)
        {
            if (addGuest)
            {
                this.Text = "Guest information";
            }
            else
            {
                this.Text = "Modify Guest";
                this.DisplayGuest();
            }
        }
    }
}
