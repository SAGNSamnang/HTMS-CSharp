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
    public partial class frmOrder : Form
    {
        public Food food;

        public Order order;

        public OrderDetial orderDetial;

        public frmOrder()
        {
            InitializeComponent();
            FillDataGridViewFood();
            FillDataGridViewOrder();
            FillDataGridViewOrderDetial();
        }

        private void FillDataGridViewFood()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            con.Open();
            string query = "SELECT *FROM tbFood";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewFood.DataSource = dataSet.Tables[0];
            con.Close();
        }

        private bool IsValidataOfFood()
        {
            return
                Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtQty) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsInt32(txtQty) &&
                Validator.IsDecimal(txtPrice);
        }

        private void PutFoodData(Food food)
        {
            food.Name = txtName.Text;
            food.Qty = Convert.ToInt32(txtQty.Text);
            food.Price = Convert.ToDecimal(txtPrice.Text);
        }

        private void DisplayFoodData()
        {
            txtName.Text = food.Name;
            txtQty.Text = food.Qty.ToString();
            txtPrice.Text = food.Price.ToString();
        }

        private void GetFood(int foodID)
        {
            try
            {
                food = FoodDB.GetFood(foodID);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        
        private void ClearFoodData()
        {
            txtName.Text = "";
            txtQty.Text = "";
            txtPrice.Text = "";
        }

        private void linkLabelAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sub_Forms.AddAndModifyFood addFoodForm = new Sub_Forms.AddAndModifyFood();
            addFoodForm.addFood = true;
            DialogResult result = addFoodForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                food = addFoodForm.food;
                txtFoodID.Text = food.FoodID.ToString();
                this.DisplayFoodData();
                FillDataGridViewFood();
            }
        }

        private void linkLabelModify_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sub_Forms.AddAndModifyFood modifyFoodForm = new Sub_Forms.AddAndModifyFood();
            modifyFoodForm.food = food;
            modifyFoodForm.addFood = false;
            DialogResult result = modifyFoodForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                food = modifyFoodForm.food;
                this.DisplayFoodData();
            }
            else if(result == DialogResult.Retry)
            {
                this.GetFood(food.FoodID);
                if(food != null)
                {
                    this.DisplayFoodData();
                }
                else
                {
                    this.ClearFoodData();
                }
            }
            FillDataGridViewFood();
        }

        private void linkLabelDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Delete " + food.Name + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    if (!FoodDB.DeleteFood(food))
                    {
                        MessageBox.Show(
                            "Another user has " +
                            "updated or deleted " +
                            "that food.", "Database Error");
                        this.GetFood(food.FoodID);
                        if(food != null)
                        {
                            this.DisplayFoodData();
                        }
                        else
                        {
                            this.ClearFoodData();
                            FillDataGridViewFood();
                        }
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                this.ClearFoodData();
                FillDataGridViewFood();
            }
        }

        private void linkLabelGetFood_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Validator.IsPresent(txtFoodID) && Validator.IsInt32(txtFoodID))
            {
                int foodID = Convert.ToInt32(txtFoodID.Text);
                this.GetFood(foodID);
                if (food == null)
                {
                    MessageBox.Show(
                        "No food with this ID. " +
                        "Please try again.",
                        "Food Not Found");
                    this.ClearFoodData();
                }
                else
                {
                    this.DisplayFoodData();
                }
            }
        }

        private void dataGridViewFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFoodID.Text = dataGridViewFood.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridViewFood.CurrentRow.Cells[1].Value.ToString();
            txtQty.Text = dataGridViewFood.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dataGridViewFood.CurrentRow.Cells[3].Value.ToString();
        }
        //
        // Order
        //
        private void FillDataGridViewOrder()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            con.Open();
            string query = "SELECT *FROM tbOrders";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewOrders.DataSource = dataSet.Tables[0];
            con.Close();
        }

        private bool IsValidataOfOrder()
        {
            return
                Validator.IsPresent(txtOrderType) &&
                Validator.IsPresent(txtOrderQty) &&
                Validator.IsPresent(txtOrderPrice) &&
                Validator.IsPresent(txtGuestID)&&
                Validator.IsInt32(txtOrderQty)&&
                Validator.IsInt32(txtGuestID)&&
                Validator.IsDecimal(txtOrderPrice);
        }

        private void PutOrderData(Order order)
        {
            order.OrderType = txtOrderType.Text;
            order.OrderQty = Convert.ToInt32(txtOrderQty.Text);
            order.UnitPrice = Convert.ToDecimal(txtOrderPrice.Text);
            order.GuestID = Convert.ToInt32(txtGuestID.Text);
        }

        private void DisplayOrderData()
        {
            txtOrderType.Text = order.OrderType;
            txtOrderQty.Text = order.OrderQty.ToString();
            txtOrderPrice.Text = order.UnitPrice.ToString();
            txtGuestID.Text = order.GuestID.ToString();
        }

        private void GetOrder(int orderID)
        {
            try
            {
                order = OrderDB.GetOrder(orderID);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ClearOrderData()
        {
            txtOrderType.Text = "";
            txtOrderQty.Text = "";
            txtOrderPrice.Text = "";
            txtGuestID.Text = "";
        }

        private void linkLabelGetOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Validator.IsPresent(txtOrderID) && Validator.IsInt32(txtOrderID))
            {
                int orderID = Convert.ToInt32(txtOrderID.Text);
                this.GetOrder(orderID);
                if (order == null)
                {
                    MessageBox.Show(
                        "No order with this ID. " +
                        "Please try again.",
                        "Order Not Found");
                    this.ClearOrderData();
                }
                else
                {
                    this.DisplayOrderData();
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Sub_Forms.AddAndModifyOrders addOrderForm = new Sub_Forms.AddAndModifyOrders();
            addOrderForm.addOrder = true;
            DialogResult result = addOrderForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                order = addOrderForm.order;
                txtOrderID.Text = order.OrderID.ToString();
                this.DisplayOrderData();
                FillDataGridViewOrder();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Sub_Forms.AddAndModifyOrders modifyOrderForm = new Sub_Forms.AddAndModifyOrders();
            modifyOrderForm.order = order;
            modifyOrderForm.addOrder = false;
            
            DialogResult result = modifyOrderForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                order = modifyOrderForm.order;
                this.DisplayOrderData();
                FillDataGridViewOrder();
            }
            else if (result == DialogResult.Retry)
            {
                this.GetOrder(order.OrderID);
                if (order != null)
                {
                    this.DisplayOrderData();
                }
                else
                {
                    this.ClearOrderData();
                    FillDataGridViewOrder();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Delete " + order.OrderType + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (!OrderDB.DeleteOrder(order))
                    {
                        MessageBox.Show(
                            "Another user has " +
                            "updated or deleted " +
                            "that order.", "Database Error");
                        this.GetOrder(order.OrderID);
                        if (order != null)
                        {
                            this.DisplayOrderData();
                        }
                        else
                        {
                            this.ClearOrderData();
                            FillDataGridViewOrder();
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
            this.ClearOrderData();
        }

        private void dataGridViewOrders_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = dataGridViewOrders.CurrentRow.Cells[0].Value.ToString();
            txtOrderType.Text = dataGridViewOrders.CurrentRow.Cells[1].Value.ToString();
            txtOrderQty.Text = dataGridViewOrders.CurrentRow.Cells[2].Value.ToString();
            txtOrderPrice.Text = dataGridViewOrders.CurrentRow.Cells[3].Value.ToString();
            txtGuestID.Text = dataGridViewOrders.CurrentRow.Cells[4].Value.ToString();
        }

        //
        // Order detial
        //
        private void FillDataGridViewOrderDetial()
        {
            SqlConnection con = HotelManagementDB.GetConnection();
            con.Open();
            string query = "SELECT *FROM tbOrdersDetial";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewOrderDetial.DataSource = ds.Tables[0];
            con.Close();
        }

        private bool IsValidataOrderDetial()
        {
            return
                Validator.IsPresent(txtDetialOrderID) &&
                Validator.IsPresent(txtDetialFoodID) &&
                Validator.IsPresent(txtAmount) &&
                Validator.IsInt32(txtDetialOrderID) &&
                Validator.IsInt32(txtDetialFoodID) &&
                Validator.IsDecimal(txtAmount);
        }

        private void PutDataOfOrderDetial(OrderDetial orderDetial)
        {
            orderDetial.OrderID = Convert.ToInt32(txtDetialOrderID.Text);
            orderDetial.FoodID = Convert.ToInt32(txtDetialFoodID.Text);
            orderDetial.Amount = Convert.ToDecimal(txtAmount.Text);
        }

        private void ClearDataOfOrderDetial()
        {
            txtDetialOrderID.Text = "";
            txtDetialFoodID.Text = "";
            txtAmount.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (IsValidataOrderDetial())
            {
                check = true;
                orderDetial = new OrderDetial();
                this.PutDataOfOrderDetial(orderDetial);
                try
                {
                    if (check == true)
                    {
                        DialogResult result = MessageBox.Show(
                            "Are you sure you want to add this data into database?", "Information",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            DataAccess.Add(orderDetial);
                            FillDataGridViewOrderDetial();
                            this.ClearDataOfOrderDetial();
                            this.ClearFoodData();
                            this.ClearOrderData();
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

        private void dataGridViewOrderDetial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDetialOrderID.Text = dataGridViewOrderDetial.CurrentRow.Cells[0].Value.ToString();
            txtDetialFoodID.Text = dataGridViewOrderDetial.CurrentRow.Cells[1].Value.ToString();
            txtAmount.Text = dataGridViewOrderDetial.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
