namespace Hotel_Management_System.User_Control
{
    partial class UC_CheckOut
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCheckOut = new System.Windows.Forms.GroupBox();
            this.linkLabelGetCheckOutData = new System.Windows.Forms.LinkLabel();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtCheckOutID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.txtCheckOutDetial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dataGridViewCheckOut = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbCheckOut.SuspendLayout();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guest ID:";
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(138, 57);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(180, 31);
            this.txtGuestID.TabIndex = 1;
            this.txtGuestID.Tag = "Guest ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price:";
            // 
            // gbCheckOut
            // 
            this.gbCheckOut.Controls.Add(this.linkLabelGetCheckOutData);
            this.gbCheckOut.Controls.Add(this.dtpCheckOutDate);
            this.gbCheckOut.Controls.Add(this.label1);
            this.gbCheckOut.Controls.Add(this.label3);
            this.gbCheckOut.Controls.Add(this.label4);
            this.gbCheckOut.Controls.Add(this.label8);
            this.gbCheckOut.Controls.Add(this.label2);
            this.gbCheckOut.Controls.Add(this.txtStaffID);
            this.gbCheckOut.Controls.Add(this.txtCheckOutID);
            this.gbCheckOut.Controls.Add(this.txtPrice);
            this.gbCheckOut.Controls.Add(this.txtGuestID);
            this.gbCheckOut.Location = new System.Drawing.Point(24, 23);
            this.gbCheckOut.Name = "gbCheckOut";
            this.gbCheckOut.Size = new System.Drawing.Size(460, 357);
            this.gbCheckOut.TabIndex = 2;
            this.gbCheckOut.TabStop = false;
            this.gbCheckOut.Text = "CheckOut";
            // 
            // linkLabelGetCheckOutData
            // 
            this.linkLabelGetCheckOutData.AutoSize = true;
            this.linkLabelGetCheckOutData.Location = new System.Drawing.Point(297, 308);
            this.linkLabelGetCheckOutData.Name = "linkLabelGetCheckOutData";
            this.linkLabelGetCheckOutData.Size = new System.Drawing.Size(148, 22);
            this.linkLabelGetCheckOutData.TabIndex = 27;
            this.linkLabelGetCheckOutData.TabStop = true;
            this.linkLabelGetCheckOutData.Text = "Get CheckOut";
            this.linkLabelGetCheckOutData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGetCheckOutData_LinkClicked);
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(138, 193);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(180, 31);
            this.dtpCheckOutDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "CheckOut Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Staff ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "CheckOut ID:";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(138, 116);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(180, 31);
            this.txtStaffID.TabIndex = 1;
            this.txtStaffID.Tag = "Staff ID";
            // 
            // txtCheckOutID
            // 
            this.txtCheckOutID.Location = new System.Drawing.Point(180, 305);
            this.txtCheckOutID.Name = "txtCheckOutID";
            this.txtCheckOutID.ReadOnly = true;
            this.txtCheckOutID.Size = new System.Drawing.Size(86, 31);
            this.txtCheckOutID.TabIndex = 1;
            this.txtCheckOutID.Tag = "CheckOut ID";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(138, 253);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(180, 31);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.Tag = "Price";
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.txtCheckOutDetial);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.txtRoomNo);
            this.gbDetail.Controls.Add(this.label7);
            this.gbDetail.Controls.Add(this.label6);
            this.gbDetail.Controls.Add(this.txtAmount);
            this.gbDetail.Location = new System.Drawing.Point(582, 29);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(337, 278);
            this.gbDetail.TabIndex = 3;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Detail";
            // 
            // txtCheckOutDetial
            // 
            this.txtCheckOutDetial.Location = new System.Drawing.Point(141, 57);
            this.txtCheckOutDetial.Name = "txtCheckOutDetial";
            this.txtCheckOutDetial.Size = new System.Drawing.Size(180, 31);
            this.txtCheckOutDetial.TabIndex = 1;
            this.txtCheckOutDetial.Tag = "CheckOut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "CheckOut:";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(141, 116);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(180, 31);
            this.txtRoomNo.TabIndex = 1;
            this.txtRoomNo.Tag = "Room No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Room No:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(141, 181);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(180, 31);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Tag = "Amount";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(582, 336);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(337, 44);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dataGridViewCheckOut
            // 
            this.dataGridViewCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCheckOut.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckOut.Location = new System.Drawing.Point(24, 448);
            this.dataGridViewCheckOut.Name = "dataGridViewCheckOut";
            this.dataGridViewCheckOut.Size = new System.Drawing.Size(895, 209);
            this.dataGridViewCheckOut.TabIndex = 5;
            this.dataGridViewCheckOut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCheckOut_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(150, 404);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(282, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(411, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // UC_CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridViewCheckOut);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.gbCheckOut);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UC_CheckOut";
            this.Size = new System.Drawing.Size(1026, 676);
            this.gbCheckOut.ResumeLayout(false);
            this.gbCheckOut.PerformLayout();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCheckOut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.TextBox txtCheckOutDetial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCheckOutID;
        private System.Windows.Forms.DataGridView dataGridViewCheckOut;
        private System.Windows.Forms.LinkLabel linkLabelGetCheckOutData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}
