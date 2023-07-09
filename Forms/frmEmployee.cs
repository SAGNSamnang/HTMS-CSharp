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
    public partial class frmEmployee : Form
    {
        public Employee emp;
        int key = 0;

        public frmEmployee()
        {
            InitializeComponent();
            populate();
        }
        //
        // Read Data from Sql server and fill it in DataGridView
        public void populate()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            try
            {
                con.Open();
                string queries = "SELECT *FROM dbo.tbStaff";
                SqlDataAdapter da = new SqlDataAdapter(queries, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgvStaff.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //
        //Add Employee Data
        //
        private void AddEmployeeData()
        {
            emp = new Employee();
            this.PutEmployeeData(emp);
            try
            {
               EmployeeDB.AddEmployee(emp);

            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            populate();
        }
        //
        //Update Employee Data
        //
        private void UpdateData()
        {
            if (IsValidata())
            {
                emp = new Employee();
                this.PutEmployeeData(emp);
                try
                {
                    EmployeeDB.UpdateEmployeeData(emp, key);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                populate();
            }
            else
            {
                ClearData();
            }
        }
        //
        //Delete employee data
        //
        private void DeleteData()
        {
            if (IsValidata())
            {
                emp = new Employee();
                this.PutEmployeeData(emp);
                try
                {
                    EmployeeDB.DeleteEmployeeData(emp, key);
                    ClearData();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                populate();
            }
            else
            {
                ClearData();
            }
        }
        //
        // Method for put data into class from controls
        //
        private void PutEmployeeData(Employee emp)
        {
            emp.StaffName = txtName.Text;
            string gender;
            if(rdoMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            emp.StaffGender = gender;
            emp.StaffPhone = txtPhone.Text;
            emp.StaffAddress = txtAddress.Text;
            emp.StaffEmail = txtEmail.Text;
            emp.Nationality = cboNationality.SelectedItem.ToString();
            emp.StaffPosition = cboPosition.SelectedItem.ToString();
            emp.StaffSalary = Convert.ToDecimal(txtSalary.Text);
        }
        //
        // Search info via staff id
        //
        private void GetEmployee(int staffID)
        {
            try
            {
                emp = EmployeeDB.GetEmployee(staffID);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        //
        // retreive data from class and show it in controls
        //
        private void DisplayData()
        {
            txtName.Text = emp.StaffName;
            string gender = emp.StaffGender;
            if (gender == "Male")
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }
            txtPhone.Text = emp.StaffPhone;
            txtAddress.Text = emp.StaffAddress;
            txtEmail.Text = emp.StaffEmail;
            cboNationality.SelectedItem = emp.Nationality;
            cboPosition.SelectedItem = emp.StaffPosition;
            txtSalary.Text = emp.StaffSalary.ToString();
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
        }
        //
        //Clear data
        //
        private void ClearData()
        {
            txtStaffID.Text = "";
            txtName.Text = "";
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            cboNationality.SelectedIndex = -1;
            cboPosition.SelectedIndex = -1;
            txtSalary.Text = "";
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }
        private bool IsValidata()
        {
            return
                Validator.IsPresent(txtStaffID) &&
                Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtPhone) &&
                Validator.IsPresent(txtAddress) &&
                Validator.IsPresent(txtEmail) &&
                Validator.IsPresent(cboNationality) &&
                Validator.IsPresent(cboPosition) &&
                Validator.IsPresent(txtSalary) &&
                Validator.IsInt32(txtStaffID) &&
                Validator.IsDecimal(txtSalary);
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int staffID = Convert.ToInt32(txtStaffID.Text);
            this.GetEmployee(staffID);
            if(emp == null)
            {
                MessageBox.Show(
                    "No employee with this id." +
                    "Please try again.",
                    "Employee not found!");
                ClearData();
            }
            else
            {
                DisplayData();
            }
        }
        
        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvStaff.CurrentRow.Cells[1].Value.ToString();
            string gender = dgvStaff.CurrentRow.Cells[2].Value.ToString();
            if (gender == "Male")
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }
            txtPhone.Text = dgvStaff.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = dgvStaff.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgvStaff.CurrentRow.Cells[5].Value.ToString();
            cboNationality.SelectedItem = dgvStaff.CurrentRow.Cells[6].Value.ToString();
            cboPosition.SelectedItem = dgvStaff.CurrentRow.Cells[7].Value.ToString();
            txtSalary.Text = dgvStaff.CurrentRow.Cells[8].Value.ToString();
            if (txtName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvStaff.CurrentRow.Cells[0].Value.ToString());
            }
            txtStaffID.Text = key.ToString();
        }

        private void linkLabelClearData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearData();
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain mainForm = new frmMain();
            mainForm.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
    }
}
