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
    public partial class AddAndModifyOrders : Form
    {
        public bool addOrder;
        public Order order;

        public AddAndModifyOrders()
        {
            InitializeComponent();
        }
        private bool IsValidata()
        {
            return
                Validator.IsPresent(txtOrderType) &&
                Validator.IsPresent(txtOrderQty) &&
                Validator.IsPresent(txtOrderPrice) &&
                Validator.IsPresent(txtGuestID)&&
                Validator.IsInt32(txtOrderQty) &&
                Validator.IsDecimal(txtGuestID);
        }
        public void PutOrderData(Order order)
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

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (IsValidata())
            {
                if (addOrder)
                {
                    order = new Order();
                    this.PutOrderData(order);
                    try
                    {
                        order.OrderID = OrderDB.AddOrder(order);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    Order newOrder = new Order();
                    newOrder.OrderID = order.OrderID;
                    this.PutOrderData(newOrder);
                    if(!OrderDB.UpdateOrder(order, newOrder))
                    {
                        MessageBox.Show(
                               "Another user has updated or " +
                               "deleted that Order.",
                               "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        order = newOrder;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void AddAndModifyOrders_Load(object sender, EventArgs e)
        {
            if (addOrder)
            {
                this.Text = "Add Order";
            }
            else
            {
                this.Text = "Modify";
                this.DisplayOrderData();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
