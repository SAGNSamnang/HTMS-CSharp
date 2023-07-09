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
    public partial class frmRoomManage : Form
    {
        public Category category;

        public Room room;

        public frmRoomManage()
        {
            InitializeComponent();
            FillCategoryDataGridView();
            this.ClearCategoryData();
            FillRoomDataGridView();
        }
        #region This code for work with Category
        public void FillCategoryDataGridView()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            con.Open();
            string queries = "SELECT *FROM tbRoomType";
            SqlDataAdapter da = new SqlDataAdapter(queries, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CategoryDataGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private bool IsValidataCategory()
        {
            return
                Validator.IsPresent(txtCategoryName) &&
                Validator.IsPresent(txtPriceCategory) &&
                Validator.IsDecimal(txtPriceCategory);
        }

        private void ClearCategoryData()
        {
            txtCategoryID.Text = "";
            txtCategoryName.Text = "";
            txtPriceCategory.Text = "";
            btnEditAndSaveCategory.Text = "Edit";
            btnEditAndSaveCategory.Enabled = false;
            btnDeleteCategory.Enabled = false;
            txtCategoryID.ReadOnly = false;
        }

        private void PutCategoryData(Category category)
        {
            category.RoomTypeName = txtCategoryName.Text;
            category.UnitPrice = Convert.ToDecimal(txtPriceCategory.Text);
        }

        private void GetCategory(int categoryID)
        {
            try
            {
                category = CategoryDB.GetCategory(categoryID);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayCategoryData()
        {
            txtCategoryName.Text = category.RoomTypeName;
            txtPriceCategory.Text = Convert.ToString(category.UnitPrice);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            bool check = false;

            if (IsValidataCategory())
            {
                check = true;
                category = new Category();
                this.PutCategoryData(category);
                DialogResult result = MessageBox.Show(
                            "Are you sure you want to add this data into database?", "Information",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(result == DialogResult.OK)
                {
                    CategoryDB.AddCategory(category);
                    FillCategoryDataGridView();
                    this.ClearCategoryData();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnEditAndSaveCategory_Click(object sender, EventArgs e)
        {
            if (btnEditAndSaveCategory.Text == "Edit")
            {
                txtCategoryID.ReadOnly = false;
                if(txtCategoryID.Text != "")
                {
                    btnEditAndSaveCategory.Text = "Update";
                }
                else
                {
                    btnEditAndSaveCategory.Text = "Search";
                    txtCategoryID.Focus();
                }    
            }
            else if(btnEditAndSaveCategory.Text == "Search")
            {
                if(txtCategoryID.Text == "")
                {
                    txtCategoryID.Focus();
                }
                else if(txtCategoryID.Text != "")
                {
                    int id = Convert.ToInt32(txtCategoryID.Text);
                    this.GetCategory(id);
                    if (category == null)
                    {
                        MessageBox.Show(
                            "ID not found!", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCategoryID.Focus();
                        txtCategoryID.Clear();
                        
                    }
                    else
                    {
                        this.DisplayCategoryData();
                        btnEditAndSaveCategory.Text = "Update";
                        btnDeleteCategory.Enabled = true;
                    }
                }
            }
            else if(btnEditAndSaveCategory.Text == "Update")
            {
                int id = Convert.ToInt32(txtCategoryID.Text);
                this.GetCategory(id);
                if (category == null)
                {
                    MessageBox.Show(
                        "Please select row first!", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.DisplayCategoryData();
                }
                Sub_Forms.ModifyCategory modifyCategoryForm = new Sub_Forms.ModifyCategory();
                modifyCategoryForm.controlCategory = false;
                modifyCategoryForm.category = category;
                
                DialogResult result = modifyCategoryForm.ShowDialog();
                if(result == DialogResult.OK)
                {
                    category = modifyCategoryForm.category;
                    this.DisplayCategoryData();
                    FillCategoryDataGridView();
                    this.ClearCategoryData();
                }
                else if(result == DialogResult.Retry)
                {
                    this.GetCategory(category.RoomTypeID);
                    if(category != null)
                    {
                        this.DisplayCategoryData();
                        FillCategoryDataGridView();
                        this.ClearCategoryData();
                    }
                    else
                    {
                        this.ClearCategoryData();
                    }    
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (IsValidataCategory())
            {
                DialogResult result = MessageBox.Show(
                "Are you sure you want to delete " +
                category.RoomTypeName + "?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (!CategoryDB.DeleteCategory(category))
                        {
                            MessageBox.Show("Another user has " +
                                "updated or deleted" +
                                "that category.", "Database Error");

                            this.GetCategory(category.RoomTypeID);

                            if (category != null)
                            {
                                this.DisplayCategoryData();
                            }
                            else
                            {
                                this.ClearCategoryData();
                                FillCategoryDataGridView();
                            }
                        }
                        else
                        {
                            this.ClearCategoryData();
                            FillCategoryDataGridView();
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

        private void btnClearCategory_Click(object sender, EventArgs e)
        {
            this.ClearCategoryData();
        }

        private void CategoryDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryID.Text = CategoryDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtCategoryName.Text = CategoryDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtPriceCategory.Text = CategoryDataGridView.CurrentRow.Cells[2].Value.ToString();
            if (txtCategoryID.Text != "" && txtCategoryName.Text != "" && txtPriceCategory.Text != "")
            {
                btnEditAndSaveCategory.Enabled = true;
                btnDeleteCategory.Enabled = true;
                btnAddCategory.Enabled = true;
                btnEditAndSaveCategory.Text = "Update";
            }
        }

        private void txtCategoryID_TextChanged(object sender, EventArgs e)
        {
            btnEditAndSaveCategory.Enabled = true;
            btnEditAndSaveCategory.Text = "Search";
        }

        #endregion

        #region This code for work with Room
        public void FillRoomDataGridView()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            con.Open();
            string queries = "SELECT *FROM tbRoom";
            SqlDataAdapter da = new SqlDataAdapter(queries, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomDataGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void DisplayRoomData()
        {
            txtRoomType.Text = Convert.ToString(room.RoomType);
            string status = room.Status;
            if(status == "Free")
            {
                rdoFree.Checked = true;
            }
            else
            {
                rdoNotFree.Checked = true;
            }
            txtRoomPhone.Text = room.PhoneNumber;
            btnModifyRoom.Enabled = true;
            btnDeleteRoom.Enabled = true;
        }

        private void GetRoom(int roomNo)
        {
            try
            {
                room = RoomDB.GetRoom(roomNo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ClearRoomData()
        {
            txtRoomNo.Text = "";
            txtRoomType.Text = "";
            rdoFree.Checked = false;
            rdoNotFree.Checked = false;
            txtRoomPhone.Text = "";
            btnModifyRoom.Enabled = false;
            btnDeleteRoom.Enabled = false;
            txtRoomNo.Focus();
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            Sub_Forms.AddModifyRoom addRoomForm = new Sub_Forms.AddModifyRoom();
            addRoomForm.addRoom = true;
            DialogResult result = addRoomForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                room = addRoomForm.room;
                txtRoomNo.Text = room.RoomNo.ToString();
                this.DisplayRoomData();
                FillRoomDataGridView();
            }
        }

        private void linkLabelSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(Validator.IsPresent(txtRoomNo) && Validator.IsInt32(txtRoomNo))
            {
                int roomNo = Convert.ToInt32(txtRoomNo.Text);
                this.GetRoom(roomNo);
                if(room == null)
                {
                    MessageBox.Show(
                        "No room with this Room NO. " +
                        "Please try again.",
                        "Customer Not Found");
                    this.ClearRoomData();
                }
                else
                {
                    this.DisplayRoomData();
                }
            }

        }

        private void btnModifyRoom_Click(object sender, EventArgs e)
        {
            Sub_Forms.AddModifyRoom modifyRoomForm = new Sub_Forms.AddModifyRoom();
            modifyRoomForm.addRoom = false;
            modifyRoomForm.room = room;
            DialogResult result = modifyRoomForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                room = modifyRoomForm.room;
                this.DisplayRoomData();
            }
            else if(result == DialogResult.Retry)
            {
                this.GetRoom(room.RoomNo);
                if(room != null)
                {
                    this.DisplayRoomData();
                }
                else
                {
                    this.ClearRoomData();
                }
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Delete " + room.RoomType + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    if (!RoomDB.DeleteRoom(room))
                    {
                        MessageBox.Show(
                            "Another user has " +
                            "updated or deleted " +
                            "that room.", "Database Error");

                        this.GetRoom(room.RoomNo);
                        if(room != null)
                        {
                            this.DisplayRoomData();
                        }
                        else
                        {
                            this.ClearRoomData();
                            this.FillRoomDataGridView();
                        }
                    }
                    else
                    {
                        this.ClearRoomData();
                        this.FillRoomDataGridView();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(
                        ex.Message, ex.GetType().ToString());
                }
            }
        }
        private void btnRoomClear_Click(object sender, EventArgs e)
        {
            this.ClearRoomData();
        }
        #endregion

        private void linkLabelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Close();
        }
    }
}
