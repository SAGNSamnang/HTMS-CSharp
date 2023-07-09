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

namespace Hotel_Management_System.Sub_Forms
{
    public partial class AddAndModifyFood : Form
    {
        public bool addFood;
        public Food food;

        public AddAndModifyFood()
        {
            InitializeComponent();
        }

        private bool IsValidata()
        {
            return
                Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsPresent(txtQty) &&
                Validator.IsInt32(txtQty) &&
                Validator.IsDecimal(txtPrice);
        }

        public void PutFoodData(Food food)
        {
            food.Name = txtName.Text;
            food.Qty = Convert.ToInt32(txtQty.Text);
            food.Price = Convert.ToDecimal(txtPrice.Text);
        }

        public void DisplayFoodData()
        {
            txtName.Text = food.Name;
            txtQty.Text = food.Qty.ToString();
            txtPrice.Text = food.Price.ToString();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (IsValidata())
            {
                if (addFood)
                {
                    food = new Food();
                    this.PutFoodData(food);
                    try
                    {
                        food.FoodID = FoodDB.AddFood(food);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    Food newFood = new Food();
                    newFood.FoodID = food.FoodID;
                    this.PutFoodData(newFood);
                    try
                    {
                        if (!FoodDB.UpdateFood(food, newFood))
                        {
                            MessageBox.Show(
                                "Another user has updated or " +
                                "deleted that food.",
                                "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            food = newFood;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void AddAndModifyFood_Load(object sender, EventArgs e)
        {
            if (addFood)
            {
                this.Text = "Add Food";
            }
            else
            {
                this.Text = "Modify Food";
                this.DisplayFoodData();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
