
using Hotel_Management_System.User_Control;
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
    public partial class frmReservation : Form
    {
        public frmReservation()
        {
            InitializeComponent();
            UC_Guest guest = new UC_Guest();
            AddUserControl(guest);
        }
        private void AddUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userControl);
            panelContainer.BringToFront();
        }

        private void checkOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UC_CheckOut checkOut = new UC_CheckOut();
            AddUserControl(checkOut);
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Guest guest = new UC_Guest();
            AddUserControl(guest);
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_CheckIn checkIn = new UC_CheckIn();
            AddUserControl(checkIn);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
