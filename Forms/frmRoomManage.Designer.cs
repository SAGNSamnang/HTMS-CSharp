namespace Hotel_Management_System.Forms
{
    partial class frmRoomManage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPriceCategory = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabelSearch = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNotFree = new System.Windows.Forms.RadioButton();
            this.rdoFree = new System.Windows.Forms.RadioButton();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtRoomPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.RoomDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnEditAndSaveCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnClearCategory = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnModifyRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnRoomClear = new System.Windows.Forms.Button();
            this.linkLabelBack = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.txtPriceCategory);
            this.panel1.Controls.Add(this.txtCategoryName);
            this.panel1.Controls.Add(this.txtCategoryID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(108, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 208);
            this.panel1.TabIndex = 0;
            // 
            // txtPriceCategory
            // 
            this.txtPriceCategory.Location = new System.Drawing.Point(121, 142);
            this.txtPriceCategory.Name = "txtPriceCategory";
            this.txtPriceCategory.Size = new System.Drawing.Size(266, 31);
            this.txtPriceCategory.TabIndex = 3;
            this.txtPriceCategory.Tag = "Category Price";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(121, 83);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(266, 31);
            this.txtCategoryName.TabIndex = 2;
            this.txtCategoryName.Tag = "Category Name";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(164, 25);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(100, 31);
            this.txtCategoryID.TabIndex = 1;
            this.txtCategoryID.Tag = "Category ID";
            this.txtCategoryID.TextChanged += new System.EventHandler(this.txtCategoryID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1396, 4);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(475, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 455);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(553, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Management";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.linkLabelSearch);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.txtRoomType);
            this.panel3.Controls.Add(this.txtRoomPhone);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtRoomNo);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(828, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 219);
            this.panel3.TabIndex = 0;
            // 
            // linkLabelSearch
            // 
            this.linkLabelSearch.AutoSize = true;
            this.linkLabelSearch.Location = new System.Drawing.Point(295, 28);
            this.linkLabelSearch.Name = "linkLabelSearch";
            this.linkLabelSearch.Size = new System.Drawing.Size(74, 22);
            this.linkLabelSearch.TabIndex = 6;
            this.linkLabelSearch.TabStop = true;
            this.linkLabelSearch.Text = "Search";
            this.linkLabelSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSearch_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNotFree);
            this.groupBox1.Controls.Add(this.rdoFree);
            this.groupBox1.Location = new System.Drawing.Point(41, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 51);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // rdoNotFree
            // 
            this.rdoNotFree.AutoSize = true;
            this.rdoNotFree.Location = new System.Drawing.Point(263, 19);
            this.rdoNotFree.Name = "rdoNotFree";
            this.rdoNotFree.Size = new System.Drawing.Size(105, 26);
            this.rdoNotFree.TabIndex = 1;
            this.rdoNotFree.Text = "Not Free";
            this.rdoNotFree.UseVisualStyleBackColor = true;
            // 
            // rdoFree
            // 
            this.rdoFree.AutoSize = true;
            this.rdoFree.Checked = true;
            this.rdoFree.Location = new System.Drawing.Point(132, 19);
            this.rdoFree.Name = "rdoFree";
            this.rdoFree.Size = new System.Drawing.Size(67, 26);
            this.rdoFree.TabIndex = 0;
            this.rdoFree.TabStop = true;
            this.rdoFree.Text = "Free";
            this.rdoFree.UseVisualStyleBackColor = true;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(173, 74);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.ReadOnly = true;
            this.txtRoomType.Size = new System.Drawing.Size(266, 31);
            this.txtRoomType.TabIndex = 3;
            this.txtRoomType.Tag = "Room Type";
            // 
            // txtRoomPhone
            // 
            this.txtRoomPhone.Location = new System.Drawing.Point(173, 177);
            this.txtRoomPhone.Name = "txtRoomPhone";
            this.txtRoomPhone.ReadOnly = true;
            this.txtRoomPhone.Size = new System.Drawing.Size(266, 31);
            this.txtRoomPhone.TabIndex = 3;
            this.txtRoomPhone.Tag = "Room Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Room Type:";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(189, 22);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(100, 31);
            this.txtRoomNo.TabIndex = 1;
            this.txtRoomNo.Tag = "Room No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Room Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "RoomNo";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(715, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 635);
            this.panel5.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1026, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Room";
            // 
            // CategoryDataGridView
            // 
            this.CategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryDataGridView.Location = new System.Drawing.Point(28, 394);
            this.CategoryDataGridView.Name = "CategoryDataGridView";
            this.CategoryDataGridView.Size = new System.Drawing.Size(661, 280);
            this.CategoryDataGridView.TabIndex = 4;
            this.CategoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryDataGridView_CellClick_1);
            // 
            // RoomDataGridView
            // 
            this.RoomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomDataGridView.Location = new System.Drawing.Point(749, 394);
            this.RoomDataGridView.Name = "RoomDataGridView";
            this.RoomDataGridView.Size = new System.Drawing.Size(661, 280);
            this.RoomDataGridView.TabIndex = 4;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(108, 348);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(89, 29);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnEditAndSaveCategory
            // 
            this.btnEditAndSaveCategory.Location = new System.Drawing.Point(216, 348);
            this.btnEditAndSaveCategory.Name = "btnEditAndSaveCategory";
            this.btnEditAndSaveCategory.Size = new System.Drawing.Size(89, 29);
            this.btnEditAndSaveCategory.TabIndex = 5;
            this.btnEditAndSaveCategory.Text = "Edit";
            this.btnEditAndSaveCategory.UseVisualStyleBackColor = true;
            this.btnEditAndSaveCategory.Click += new System.EventHandler(this.btnEditAndSaveCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(332, 348);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(89, 29);
            this.btnDeleteCategory.TabIndex = 5;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnClearCategory
            // 
            this.btnClearCategory.Location = new System.Drawing.Point(454, 348);
            this.btnClearCategory.Name = "btnClearCategory";
            this.btnClearCategory.Size = new System.Drawing.Size(89, 29);
            this.btnClearCategory.TabIndex = 5;
            this.btnClearCategory.Text = "Clear";
            this.btnClearCategory.UseVisualStyleBackColor = true;
            this.btnClearCategory.Click += new System.EventHandler(this.btnClearCategory_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(828, 348);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(89, 29);
            this.btnAddRoom.TabIndex = 5;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnModifyRoom
            // 
            this.btnModifyRoom.Location = new System.Drawing.Point(951, 348);
            this.btnModifyRoom.Name = "btnModifyRoom";
            this.btnModifyRoom.Size = new System.Drawing.Size(89, 29);
            this.btnModifyRoom.TabIndex = 5;
            this.btnModifyRoom.Text = "Modify";
            this.btnModifyRoom.UseVisualStyleBackColor = true;
            this.btnModifyRoom.Click += new System.EventHandler(this.btnModifyRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(1076, 348);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(89, 29);
            this.btnDeleteRoom.TabIndex = 5;
            this.btnDeleteRoom.Text = "Delete";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnRoomClear
            // 
            this.btnRoomClear.Location = new System.Drawing.Point(1215, 348);
            this.btnRoomClear.Name = "btnRoomClear";
            this.btnRoomClear.Size = new System.Drawing.Size(89, 29);
            this.btnRoomClear.TabIndex = 5;
            this.btnRoomClear.Text = "Clear";
            this.btnRoomClear.UseVisualStyleBackColor = true;
            this.btnRoomClear.Click += new System.EventHandler(this.btnRoomClear_Click);
            // 
            // linkLabelBack
            // 
            this.linkLabelBack.AutoSize = true;
            this.linkLabelBack.LinkColor = System.Drawing.Color.Black;
            this.linkLabelBack.Location = new System.Drawing.Point(20, 24);
            this.linkLabelBack.Name = "linkLabelBack";
            this.linkLabelBack.Size = new System.Drawing.Size(71, 22);
            this.linkLabelBack.TabIndex = 6;
            this.linkLabelBack.TabStop = true;
            this.linkLabelBack.Text = "B a c k";
            this.linkLabelBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBack_LinkClicked);
            // 
            // frmRoomManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 707);
            this.Controls.Add(this.linkLabelBack);
            this.Controls.Add(this.btnRoomClear);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnModifyRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnClearCategory);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnEditAndSaveCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.RoomDataGridView);
            this.Controls.Add(this.CategoryDataGridView);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmRoomManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPriceCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView CategoryDataGridView;
        private System.Windows.Forms.DataGridView RoomDataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRoomPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnEditAndSaveCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnClearCategory;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnModifyRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnRoomClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNotFree;
        private System.Windows.Forms.RadioButton rdoFree;
        private System.Windows.Forms.LinkLabel linkLabelSearch;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.LinkLabel linkLabelBack;
    }
}