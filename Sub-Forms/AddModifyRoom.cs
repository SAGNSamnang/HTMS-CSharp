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
    public partial class AddModifyRoom : Form
    {
        public bool addRoom;
        public Room room;

        public AddModifyRoom()
        {
            InitializeComponent();
        }
        private bool IsValidata()
        {
            return
                Validator.IsPresent(cboRoomType) &&
                Validator.IsPresent(txtRoomPhone);
        }

        private void PutRoomData(Room room)
        {
            room.RoomType = cboRoomType.SelectedValue.GetHashCode();
            string status;
            if (rdoFree.Checked)
            {
                status = "Free";
            }
            else
            {
                status = "Not Free";
            }
            room.Status = status;
            room.PhoneNumber = txtRoomPhone.Text;
        }
        private void DisplayRoomData()
        {
            cboRoomType.SelectedValue = room.RoomType;
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
        }
        private void LoadRoomTypeComboBox()
        {
            List<Category> categorys = new List<Category>();
            try
            {
                categorys = CategoryDB.GetRoomType();
                cboRoomType.DataSource = categorys;
                cboRoomType.DisplayMember = "RoomTypeName";
                cboRoomType.ValueMember = "RoomTypeID";
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message, ex.GetType().ToString());
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidata())
            {
                if (addRoom)
                {
                    room = new Room();
                    this.PutRoomData(room);
                    try
                    {
                        room.RoomNo = RoomDB.AddRoom(room);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show(
                            ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    Room newRoom = new Room();
                    newRoom.RoomNo = room.RoomNo;
                    this.PutRoomData(newRoom);
                    try
                    {
                        if(!RoomDB.UpdateRoom(room, newRoom))
                        {
                            MessageBox.Show(
                                "Another user has updated or " +
                                "deleted that room.",
                                "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            room = newRoom;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void AddModifyRoom_Load(object sender, EventArgs e)
        {
            this.LoadRoomTypeComboBox();
            if (addRoom)
            {
                this.Text = "Add Room";
                cboRoomType.SelectedIndex = -1;
            }
            else
            {
                this.Text = "Modify Room";
                this.DisplayRoomData();
            }
        }
    }
}
