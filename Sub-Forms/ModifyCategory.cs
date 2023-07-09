using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.Sub_Forms
{
    public partial class ModifyCategory : Form
    {
        public bool controlCategory;
        public Category category;

        public ModifyCategory()
        {
            InitializeComponent();
        }
        private void PutCategoryData(Category category)
        {
            category.RoomTypeName = txtCategoryName.Text;
            category.UnitPrice = Convert.ToDecimal(txtPriceCategory.Text);
        }

        private bool IsValidata()
        {
            return
                Validator.IsPresent(txtCategoryName) &&
                Validator.IsPresent(txtPriceCategory) &&
                Validator.IsDecimal(txtPriceCategory);
        }

        private void DisplayCategory()
        {
            txtCategoryName.Text = category.RoomTypeName;
            txtPriceCategory.Text = Convert.ToString(category.UnitPrice);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidata())
            {
                if (!controlCategory)
                {
                    Category newCategory = new Category();
                    newCategory.RoomTypeID = category.RoomTypeID;
                    this.PutCategoryData(newCategory);
                    try
                    {
                        if (!CategoryDB.UpdateCategory(category, newCategory))
                        {
                            MessageBox.Show(
                                "Another user has updated or " +
                                "deleted that category.",
                                "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            // change data
                            category = newCategory;

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

        private void ModifyCategory_Load(object sender, EventArgs e)
        {
            this.DisplayCategory();
        }
    }
}
