namespace Hotel_Management_System.User_Control
{
    partial class UC_CheckIn
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.gbGuestCheckIn = new System.Windows.Forms.GroupBox();
            this.linkLabelGetCheckInData = new System.Windows.Forms.LinkLabel();
            this.txtGetCheckInID = new System.Windows.Forms.TextBox();
            this.txtPrepaid = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearDataLinkLabel = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoBooked = new System.Windows.Forms.RadioButton();
            this.rdoNotBooking = new System.Windows.Forms.RadioButton();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDetailRoomNo = new System.Windows.Forms.TextBox();
            this.labelRoomNo = new System.Windows.Forms.Label();
            this.txtDetailAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDetailCheckInID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CheckInDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbGuestCheckIn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckInDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Location = new System.Drawing.Point(31, 24);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(174, 46);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(140, 88);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(178, 31);
            this.txtDuration.TabIndex = 17;
            this.txtDuration.Tag = "Duration";
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(140, 137);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(137, 31);
            this.txtGuestID.TabIndex = 24;
            this.txtGuestID.TabStop = false;
            this.txtGuestID.Tag = "Guest ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Guest ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Duration:";
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIn.Location = new System.Drawing.Point(140, 36);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(178, 31);
            this.dtpDateIn.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Date in:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Unit Price:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(140, 236);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(178, 31);
            this.txtUnitPrice.TabIndex = 17;
            this.txtUnitPrice.Tag = "Unit Price";
            // 
            // gbGuestCheckIn
            // 
            this.gbGuestCheckIn.Controls.Add(this.linkLabelGetCheckInData);
            this.gbGuestCheckIn.Controls.Add(this.dtpDateIn);
            this.gbGuestCheckIn.Controls.Add(this.txtGetCheckInID);
            this.gbGuestCheckIn.Controls.Add(this.txtPrepaid);
            this.gbGuestCheckIn.Controls.Add(this.txtUnitPrice);
            this.gbGuestCheckIn.Controls.Add(this.txtDuration);
            this.gbGuestCheckIn.Controls.Add(this.label1);
            this.gbGuestCheckIn.Controls.Add(this.txtStaffID);
            this.gbGuestCheckIn.Controls.Add(this.txtGuestID);
            this.gbGuestCheckIn.Controls.Add(this.label3);
            this.gbGuestCheckIn.Controls.Add(this.label8);
            this.gbGuestCheckIn.Controls.Add(this.label7);
            this.gbGuestCheckIn.Controls.Add(this.label5);
            this.gbGuestCheckIn.Controls.Add(this.label6);
            this.gbGuestCheckIn.Controls.Add(this.label4);
            this.gbGuestCheckIn.Location = new System.Drawing.Point(19, 62);
            this.gbGuestCheckIn.Name = "gbGuestCheckIn";
            this.gbGuestCheckIn.Size = new System.Drawing.Size(524, 392);
            this.gbGuestCheckIn.TabIndex = 26;
            this.gbGuestCheckIn.TabStop = false;
            this.gbGuestCheckIn.Text = "Guest CheckIn";
            // 
            // linkLabelGetCheckInData
            // 
            this.linkLabelGetCheckInData.AutoSize = true;
            this.linkLabelGetCheckInData.Location = new System.Drawing.Point(386, 349);
            this.linkLabelGetCheckInData.Name = "linkLabelGetCheckInData";
            this.linkLabelGetCheckInData.Size = new System.Drawing.Size(129, 22);
            this.linkLabelGetCheckInData.TabIndex = 26;
            this.linkLabelGetCheckInData.TabStop = true;
            this.linkLabelGetCheckInData.Text = "Get CheckIn";
            this.linkLabelGetCheckInData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGetCheckInData_LinkClicked);
            // 
            // txtGetCheckInID
            // 
            this.txtGetCheckInID.Location = new System.Drawing.Point(198, 340);
            this.txtGetCheckInID.Name = "txtGetCheckInID";
            this.txtGetCheckInID.ReadOnly = true;
            this.txtGetCheckInID.Size = new System.Drawing.Size(162, 31);
            this.txtGetCheckInID.TabIndex = 17;
            this.txtGetCheckInID.Tag = "Get CheckIn ID";
            // 
            // txtPrepaid
            // 
            this.txtPrepaid.Location = new System.Drawing.Point(140, 281);
            this.txtPrepaid.Name = "txtPrepaid";
            this.txtPrepaid.Size = new System.Drawing.Size(178, 31);
            this.txtPrepaid.TabIndex = 17;
            this.txtPrepaid.Tag = "Prepaid";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(140, 185);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(137, 31);
            this.txtStaffID.TabIndex = 24;
            this.txtStaffID.TabStop = false;
            this.txtStaffID.Tag = "Staff ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Get CheckIn ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Staff ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Prepaid:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ClearDataLinkLabel);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Location = new System.Drawing.Point(619, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 202);
            this.panel1.TabIndex = 27;
            // 
            // ClearDataLinkLabel
            // 
            this.ClearDataLinkLabel.AutoSize = true;
            this.ClearDataLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearDataLinkLabel.Location = new System.Drawing.Point(67, 169);
            this.ClearDataLinkLabel.Name = "ClearDataLinkLabel";
            this.ClearDataLinkLabel.Size = new System.Drawing.Size(111, 22);
            this.ClearDataLinkLabel.TabIndex = 11;
            this.ClearDataLinkLabel.TabStop = true;
            this.ClearDataLinkLabel.Text = "Clear Data";
            this.ClearDataLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearDataLinkLabel_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(31, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(174, 46);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoBooked);
            this.groupBox2.Controls.Add(this.rdoNotBooking);
            this.groupBox2.Location = new System.Drawing.Point(108, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 49);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // rdoBooked
            // 
            this.rdoBooked.AutoSize = true;
            this.rdoBooked.Location = new System.Drawing.Point(189, 17);
            this.rdoBooked.Name = "rdoBooked";
            this.rdoBooked.Size = new System.Drawing.Size(98, 26);
            this.rdoBooked.TabIndex = 1;
            this.rdoBooked.Text = "Booked";
            this.rdoBooked.UseVisualStyleBackColor = true;
            this.rdoBooked.CheckedChanged += new System.EventHandler(this.rdoBooked_CheckedChanged);
            // 
            // rdoNotBooking
            // 
            this.rdoNotBooking.AutoSize = true;
            this.rdoNotBooking.Checked = true;
            this.rdoNotBooking.Location = new System.Drawing.Point(19, 17);
            this.rdoNotBooking.Name = "rdoNotBooking";
            this.rdoNotBooking.Size = new System.Drawing.Size(139, 26);
            this.rdoNotBooking.TabIndex = 0;
            this.rdoNotBooking.TabStop = true;
            this.rdoNotBooking.Text = "Not Booking";
            this.rdoNotBooking.UseVisualStyleBackColor = true;
            this.rdoNotBooking.CheckedChanged += new System.EventHandler(this.rdoNotBooking_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDetailRoomNo);
            this.groupBox3.Controls.Add(this.labelRoomNo);
            this.groupBox3.Controls.Add(this.txtDetailAmount);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtDetailCheckInID);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(619, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 198);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detail";
            // 
            // txtDetailRoomNo
            // 
            this.txtDetailRoomNo.Location = new System.Drawing.Point(142, 84);
            this.txtDetailRoomNo.Name = "txtDetailRoomNo";
            this.txtDetailRoomNo.Size = new System.Drawing.Size(137, 31);
            this.txtDetailRoomNo.TabIndex = 24;
            this.txtDetailRoomNo.TabStop = false;
            this.txtDetailRoomNo.Tag = "Room No";
            // 
            // labelRoomNo
            // 
            this.labelRoomNo.AutoSize = true;
            this.labelRoomNo.Location = new System.Drawing.Point(26, 87);
            this.labelRoomNo.Name = "labelRoomNo";
            this.labelRoomNo.Size = new System.Drawing.Size(99, 22);
            this.labelRoomNo.TabIndex = 21;
            this.labelRoomNo.Text = "Room No:";
            // 
            // txtDetailAmount
            // 
            this.txtDetailAmount.Location = new System.Drawing.Point(142, 139);
            this.txtDetailAmount.Name = "txtDetailAmount";
            this.txtDetailAmount.Size = new System.Drawing.Size(137, 31);
            this.txtDetailAmount.TabIndex = 24;
            this.txtDetailAmount.TabStop = false;
            this.txtDetailAmount.Tag = "Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 21;
            this.label10.Text = "Amount:";
            // 
            // txtDetailCheckInID
            // 
            this.txtDetailCheckInID.Location = new System.Drawing.Point(142, 36);
            this.txtDetailCheckInID.Name = "txtDetailCheckInID";
            this.txtDetailCheckInID.Size = new System.Drawing.Size(137, 31);
            this.txtDetailCheckInID.TabIndex = 24;
            this.txtDetailCheckInID.TabStop = false;
            this.txtDetailCheckInID.Tag = "CheckIn ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "CheckIn ID:";
            // 
            // CheckInDataGridView
            // 
            this.CheckInDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CheckInDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CheckInDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CheckInDataGridView.Location = new System.Drawing.Point(19, 530);
            this.CheckInDataGridView.Name = "CheckInDataGridView";
            this.CheckInDataGridView.Size = new System.Drawing.Size(925, 159);
            this.CheckInDataGridView.TabIndex = 30;
            this.CheckInDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckInDataGridView_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(19, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 35);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(159, 477);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 36);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(288, 479);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 35);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(441, 480);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 34);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // UC_CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.CheckInDataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbGuestCheckIn);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UC_CheckIn";
            this.Size = new System.Drawing.Size(990, 759);
            this.gbGuestCheckIn.ResumeLayout(false);
            this.gbGuestCheckIn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckInDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.GroupBox gbGuestCheckIn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel ClearDataLinkLabel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPrepaid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoBooked;
        private System.Windows.Forms.RadioButton rdoNotBooking;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox txtGetCheckInID;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDetailRoomNo;
        private System.Windows.Forms.Label labelRoomNo;
        private System.Windows.Forms.TextBox txtDetailAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDetailCheckInID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView CheckInDataGridView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel linkLabelGetCheckInData;
    }
}
