namespace Hotel_Management_System.Forms
{
    partial class frmInformationBooking
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbGuestInfo = new System.Windows.Forms.GroupBox();
            this.lLabelClearInfo = new System.Windows.Forms.LinkLabel();
            this.SearchAndUpdateBookingLinkLab = new System.Windows.Forms.LinkLabel();
            this.lLabelDeleteInfo = new System.Windows.Forms.LinkLabel();
            this.linkLabelSaveInfo = new System.Windows.Forms.LinkLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.gbBooking = new System.Windows.Forms.GroupBox();
            this.lLabelClearBooking = new System.Windows.Forms.LinkLabel();
            this.SearchAndUpdateBooking = new System.Windows.Forms.LinkLabel();
            this.lLabelDeleteBooking = new System.Windows.Forms.LinkLabel();
            this.linkLabelSaveBooking = new System.Windows.Forms.LinkLabel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.txtBookingStaffID = new System.Windows.Forms.TextBox();
            this.txtBookingGuestID = new System.Windows.Forms.TextBox();
            this.txtGuestPrepaid = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.txtDetailRoomNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDetailBooking = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbGuestInfo.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.gbBooking.SuspendLayout();
            this.gbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Booking Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 2);
            this.panel1.TabIndex = 16;
            // 
            // gbGuestInfo
            // 
            this.gbGuestInfo.Controls.Add(this.lLabelClearInfo);
            this.gbGuestInfo.Controls.Add(this.SearchAndUpdateBookingLinkLab);
            this.gbGuestInfo.Controls.Add(this.lLabelDeleteInfo);
            this.gbGuestInfo.Controls.Add(this.linkLabelSaveInfo);
            this.gbGuestInfo.Controls.Add(this.txtName);
            this.gbGuestInfo.Controls.Add(this.txtNationality);
            this.gbGuestInfo.Controls.Add(this.txtPhone);
            this.gbGuestInfo.Controls.Add(this.label2);
            this.gbGuestInfo.Controls.Add(this.txtAddress);
            this.gbGuestInfo.Controls.Add(this.label5);
            this.gbGuestInfo.Controls.Add(this.label7);
            this.gbGuestInfo.Controls.Add(this.gbGender);
            this.gbGuestInfo.Controls.Add(this.label8);
            this.gbGuestInfo.Controls.Add(this.label9);
            this.gbGuestInfo.Controls.Add(this.txtGuestID);
            this.gbGuestInfo.Location = new System.Drawing.Point(12, 79);
            this.gbGuestInfo.Name = "gbGuestInfo";
            this.gbGuestInfo.Size = new System.Drawing.Size(402, 471);
            this.gbGuestInfo.TabIndex = 41;
            this.gbGuestInfo.TabStop = false;
            this.gbGuestInfo.Text = "Guest Info";
            // 
            // lLabelClearInfo
            // 
            this.lLabelClearInfo.AutoSize = true;
            this.lLabelClearInfo.Location = new System.Drawing.Point(6, 446);
            this.lLabelClearInfo.Name = "lLabelClearInfo";
            this.lLabelClearInfo.Size = new System.Drawing.Size(59, 22);
            this.lLabelClearInfo.TabIndex = 44;
            this.lLabelClearInfo.TabStop = true;
            this.lLabelClearInfo.Text = "Clear";
            this.lLabelClearInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLabelClearInfo_LinkClicked);
            // 
            // SearchAndUpdateBookingLinkLab
            // 
            this.SearchAndUpdateBookingLinkLab.AutoSize = true;
            this.SearchAndUpdateBookingLinkLab.Location = new System.Drawing.Point(110, 446);
            this.SearchAndUpdateBookingLinkLab.Name = "SearchAndUpdateBookingLinkLab";
            this.SearchAndUpdateBookingLinkLab.Size = new System.Drawing.Size(74, 22);
            this.SearchAndUpdateBookingLinkLab.TabIndex = 44;
            this.SearchAndUpdateBookingLinkLab.TabStop = true;
            this.SearchAndUpdateBookingLinkLab.Text = "Search";
            this.SearchAndUpdateBookingLinkLab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLabelSeachAndUpdateInfo_LinkClicked);
            // 
            // lLabelDeleteInfo
            // 
            this.lLabelDeleteInfo.AutoSize = true;
            this.lLabelDeleteInfo.Location = new System.Drawing.Point(239, 446);
            this.lLabelDeleteInfo.Name = "lLabelDeleteInfo";
            this.lLabelDeleteInfo.Size = new System.Drawing.Size(70, 22);
            this.lLabelDeleteInfo.TabIndex = 44;
            this.lLabelDeleteInfo.TabStop = true;
            this.lLabelDeleteInfo.Text = "Delete";
            this.lLabelDeleteInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLabelDeleteInfo_LinkClicked);
            // 
            // linkLabelSaveInfo
            // 
            this.linkLabelSaveInfo.AutoSize = true;
            this.linkLabelSaveInfo.Location = new System.Drawing.Point(339, 446);
            this.linkLabelSaveInfo.Name = "linkLabelSaveInfo";
            this.linkLabelSaveInfo.Size = new System.Drawing.Size(57, 22);
            this.linkLabelSaveInfo.TabIndex = 44;
            this.linkLabelSaveInfo.TabStop = true;
            this.linkLabelSaveInfo.Text = "Save";
            this.linkLabelSaveInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSaveInfo_LinkClicked);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 31);
            this.txtName.TabIndex = 29;
            this.txtName.Tag = "Name";
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(139, 344);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(221, 31);
            this.txtNationality.TabIndex = 32;
            this.txtNationality.Tag = "Nationality";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(139, 291);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(221, 31);
            this.txtPhone.TabIndex = 32;
            this.txtPhone.Tag = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Name:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(139, 199);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(221, 70);
            this.txtAddress.TabIndex = 31;
            this.txtAddress.Tag = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "Nationality:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 37;
            this.label7.Text = "Phone:";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdoFemale);
            this.gbGender.Controls.Add(this.rdoMale);
            this.gbGender.Location = new System.Drawing.Point(24, 81);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(336, 100);
            this.gbGender.TabIndex = 30;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Please select gender:";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(191, 47);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(94, 26);
            this.rdoFemale.TabIndex = 2;
            this.rdoFemale.Tag = "Female";
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(66, 47);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(73, 26);
            this.rdoMale.TabIndex = 1;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "Get Guest ID:";
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(166, 397);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.ReadOnly = true;
            this.txtGuestID.Size = new System.Drawing.Size(194, 31);
            this.txtGuestID.TabIndex = 39;
            this.txtGuestID.TabStop = false;
            this.txtGuestID.Tag = "Get Guest ID";
            // 
            // gbBooking
            // 
            this.gbBooking.Controls.Add(this.lLabelClearBooking);
            this.gbBooking.Controls.Add(this.SearchAndUpdateBooking);
            this.gbBooking.Controls.Add(this.lLabelDeleteBooking);
            this.gbBooking.Controls.Add(this.linkLabelSaveBooking);
            this.gbBooking.Controls.Add(this.dtpDate);
            this.gbBooking.Controls.Add(this.txtBookingID);
            this.gbBooking.Controls.Add(this.txtBookingStaffID);
            this.gbBooking.Controls.Add(this.txtBookingGuestID);
            this.gbBooking.Controls.Add(this.txtGuestPrepaid);
            this.gbBooking.Controls.Add(this.txtDuration);
            this.gbBooking.Controls.Add(this.label18);
            this.gbBooking.Controls.Add(this.label4);
            this.gbBooking.Controls.Add(this.label13);
            this.gbBooking.Controls.Add(this.label14);
            this.gbBooking.Controls.Add(this.label6);
            this.gbBooking.Controls.Add(this.label12);
            this.gbBooking.Controls.Add(this.label3);
            this.gbBooking.Location = new System.Drawing.Point(456, 79);
            this.gbBooking.Name = "gbBooking";
            this.gbBooking.Size = new System.Drawing.Size(465, 471);
            this.gbBooking.TabIndex = 42;
            this.gbBooking.TabStop = false;
            this.gbBooking.Text = "Booking";
            // 
            // lLabelClearBooking
            // 
            this.lLabelClearBooking.AutoSize = true;
            this.lLabelClearBooking.Location = new System.Drawing.Point(41, 446);
            this.lLabelClearBooking.Name = "lLabelClearBooking";
            this.lLabelClearBooking.Size = new System.Drawing.Size(59, 22);
            this.lLabelClearBooking.TabIndex = 44;
            this.lLabelClearBooking.TabStop = true;
            this.lLabelClearBooking.Text = "Clear";
            this.lLabelClearBooking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLabelClearBooking_LinkClicked);
            // 
            // SearchAndUpdateBooking
            // 
            this.SearchAndUpdateBooking.AutoSize = true;
            this.SearchAndUpdateBooking.Location = new System.Drawing.Point(168, 446);
            this.SearchAndUpdateBooking.Name = "SearchAndUpdateBooking";
            this.SearchAndUpdateBooking.Size = new System.Drawing.Size(74, 22);
            this.SearchAndUpdateBooking.TabIndex = 44;
            this.SearchAndUpdateBooking.TabStop = true;
            this.SearchAndUpdateBooking.Text = "Search";
            this.SearchAndUpdateBooking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llabelSearchAndUpdateBooking_LinkClicked);
            // 
            // lLabelDeleteBooking
            // 
            this.lLabelDeleteBooking.AutoSize = true;
            this.lLabelDeleteBooking.Location = new System.Drawing.Point(319, 446);
            this.lLabelDeleteBooking.Name = "lLabelDeleteBooking";
            this.lLabelDeleteBooking.Size = new System.Drawing.Size(70, 22);
            this.lLabelDeleteBooking.TabIndex = 44;
            this.lLabelDeleteBooking.TabStop = true;
            this.lLabelDeleteBooking.Text = "Delete";
            this.lLabelDeleteBooking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLabelDeleteBooking_LinkClicked);
            // 
            // linkLabelSaveBooking
            // 
            this.linkLabelSaveBooking.AutoSize = true;
            this.linkLabelSaveBooking.Location = new System.Drawing.Point(402, 446);
            this.linkLabelSaveBooking.Name = "linkLabelSaveBooking";
            this.linkLabelSaveBooking.Size = new System.Drawing.Size(57, 22);
            this.linkLabelSaveBooking.TabIndex = 44;
            this.linkLabelSaveBooking.TabStop = true;
            this.linkLabelSaveBooking.Text = "Save";
            this.linkLabelSaveBooking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSaveBooking_LinkClicked);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(132, 40);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(321, 31);
            this.dtpDate.TabIndex = 41;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(200, 374);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.Size = new System.Drawing.Size(176, 31);
            this.txtBookingID.TabIndex = 39;
            this.txtBookingID.Tag = "Get Booking ID";
            // 
            // txtBookingStaffID
            // 
            this.txtBookingStaffID.Location = new System.Drawing.Point(146, 322);
            this.txtBookingStaffID.Name = "txtBookingStaffID";
            this.txtBookingStaffID.Size = new System.Drawing.Size(176, 31);
            this.txtBookingStaffID.TabIndex = 39;
            this.txtBookingStaffID.Tag = "Staff ID";
            // 
            // txtBookingGuestID
            // 
            this.txtBookingGuestID.Location = new System.Drawing.Point(146, 265);
            this.txtBookingGuestID.Name = "txtBookingGuestID";
            this.txtBookingGuestID.Size = new System.Drawing.Size(176, 31);
            this.txtBookingGuestID.TabIndex = 39;
            this.txtBookingGuestID.Tag = "Guest ID";
            // 
            // txtGuestPrepaid
            // 
            this.txtGuestPrepaid.Location = new System.Drawing.Point(187, 150);
            this.txtGuestPrepaid.Name = "txtGuestPrepaid";
            this.txtGuestPrepaid.Size = new System.Drawing.Size(202, 31);
            this.txtGuestPrepaid.TabIndex = 39;
            this.txtGuestPrepaid.Tag = "Total prepaid";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(132, 95);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(151, 31);
            this.txtDuration.TabIndex = 39;
            this.txtDuration.Tag = "Duration";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 377);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 22);
            this.label18.TabIndex = 40;
            this.label18.Text = "Get Booking ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 22);
            this.label13.TabIndex = 40;
            this.label13.Text = "Staff ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 265);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 22);
            this.label14.TabIndex = 40;
            this.label14.Text = "Guest ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "Day";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 22);
            this.label12.TabIndex = 40;
            this.label12.Text = "Total prepaid:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Duration";
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.txtDetailRoomNo);
            this.gbDetail.Controls.Add(this.label16);
            this.gbDetail.Controls.Add(this.txtDetailBooking);
            this.gbDetail.Controls.Add(this.label15);
            this.gbDetail.Location = new System.Drawing.Point(945, 92);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(289, 168);
            this.gbDetail.TabIndex = 43;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Detail";
            // 
            // txtDetailRoomNo
            // 
            this.txtDetailRoomNo.Location = new System.Drawing.Point(132, 97);
            this.txtDetailRoomNo.Name = "txtDetailRoomNo";
            this.txtDetailRoomNo.Size = new System.Drawing.Size(133, 31);
            this.txtDetailRoomNo.TabIndex = 39;
            this.txtDetailRoomNo.Tag = "Room No";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 22);
            this.label16.TabIndex = 40;
            this.label16.Text = "Room No:";
            // 
            // txtDetailBooking
            // 
            this.txtDetailBooking.Location = new System.Drawing.Point(132, 40);
            this.txtDetailBooking.Name = "txtDetailBooking";
            this.txtDetailBooking.Size = new System.Drawing.Size(133, 31);
            this.txtDetailBooking.TabIndex = 39;
            this.txtDetailBooking.Tag = "Booking ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 22);
            this.label15.TabIndex = 40;
            this.label15.Text = "Booking ID:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(1022, 281);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(137, 37);
            this.btnAccept.TabIndex = 44;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1022, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 37);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmInformationBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 583);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.gbBooking);
            this.Controls.Add(this.gbGuestInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmInformationBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Information";
            this.gbGuestInfo.ResumeLayout(false);
            this.gbGuestInfo.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbBooking.ResumeLayout(false);
            this.gbBooking.PerformLayout();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbGuestInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.GroupBox gbBooking;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtBookingStaffID;
        private System.Windows.Forms.TextBox txtGuestPrepaid;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookingGuestID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.TextBox txtDetailRoomNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDetailBooking;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel linkLabelSaveInfo;
        private System.Windows.Forms.LinkLabel linkLabelSaveBooking;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lLabelClearInfo;
        private System.Windows.Forms.LinkLabel SearchAndUpdateBookingLinkLab;
        private System.Windows.Forms.LinkLabel lLabelDeleteInfo;
        private System.Windows.Forms.LinkLabel lLabelClearBooking;
        private System.Windows.Forms.LinkLabel llabelSearchAndUpdateBooking;
        private System.Windows.Forms.LinkLabel lLabelDeleteBooking;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.LinkLabel SearchAndUpdateBooking;
    }
}