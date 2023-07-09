namespace Hotel_Management_System.Forms
{
    partial class frmOrder
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
            this.gbFoodAndBeverage = new System.Windows.Forms.GroupBox();
            this.linkLabelDelete = new System.Windows.Forms.LinkLabel();
            this.linkLabelModify = new System.Windows.Forms.LinkLabel();
            this.linkLabelAdd = new System.Windows.Forms.LinkLabel();
            this.linkLabelGetFood = new System.Windows.Forms.LinkLabel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.txtOrderPrice = new System.Windows.Forms.TextBox();
            this.linkLabelGetOrder = new System.Windows.Forms.LinkLabel();
            this.txtOrderType = new System.Windows.Forms.TextBox();
            this.txtOrderQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDetialFoodID = new System.Windows.Forms.TextBox();
            this.txtDetialOrderID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewFood = new System.Windows.Forms.DataGridView();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewOrderDetial = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbFoodAndBeverage.SuspendLayout();
            this.gbOrder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetial)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFoodAndBeverage
            // 
            this.gbFoodAndBeverage.Controls.Add(this.linkLabelDelete);
            this.gbFoodAndBeverage.Controls.Add(this.linkLabelModify);
            this.gbFoodAndBeverage.Controls.Add(this.linkLabelAdd);
            this.gbFoodAndBeverage.Controls.Add(this.linkLabelGetFood);
            this.gbFoodAndBeverage.Controls.Add(this.txtPrice);
            this.gbFoodAndBeverage.Controls.Add(this.txtQty);
            this.gbFoodAndBeverage.Controls.Add(this.txtName);
            this.gbFoodAndBeverage.Controls.Add(this.txtFoodID);
            this.gbFoodAndBeverage.Controls.Add(this.label4);
            this.gbFoodAndBeverage.Controls.Add(this.label3);
            this.gbFoodAndBeverage.Controls.Add(this.label2);
            this.gbFoodAndBeverage.Controls.Add(this.label1);
            this.gbFoodAndBeverage.Location = new System.Drawing.Point(29, 149);
            this.gbFoodAndBeverage.Name = "gbFoodAndBeverage";
            this.gbFoodAndBeverage.Size = new System.Drawing.Size(395, 325);
            this.gbFoodAndBeverage.TabIndex = 0;
            this.gbFoodAndBeverage.TabStop = false;
            this.gbFoodAndBeverage.Text = "Food And Beverage";
            // 
            // linkLabelDelete
            // 
            this.linkLabelDelete.AutoSize = true;
            this.linkLabelDelete.Location = new System.Drawing.Point(249, 279);
            this.linkLabelDelete.Name = "linkLabelDelete";
            this.linkLabelDelete.Size = new System.Drawing.Size(70, 22);
            this.linkLabelDelete.TabIndex = 4;
            this.linkLabelDelete.TabStop = true;
            this.linkLabelDelete.Text = "Delete";
            this.linkLabelDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDelete_LinkClicked);
            // 
            // linkLabelModify
            // 
            this.linkLabelModify.AutoSize = true;
            this.linkLabelModify.Location = new System.Drawing.Point(129, 279);
            this.linkLabelModify.Name = "linkLabelModify";
            this.linkLabelModify.Size = new System.Drawing.Size(72, 22);
            this.linkLabelModify.TabIndex = 3;
            this.linkLabelModify.TabStop = true;
            this.linkLabelModify.Text = "Modify";
            this.linkLabelModify.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelModify_LinkClicked);
            // 
            // linkLabelAdd
            // 
            this.linkLabelAdd.AutoSize = true;
            this.linkLabelAdd.Location = new System.Drawing.Point(31, 279);
            this.linkLabelAdd.Name = "linkLabelAdd";
            this.linkLabelAdd.Size = new System.Drawing.Size(51, 22);
            this.linkLabelAdd.TabIndex = 2;
            this.linkLabelAdd.TabStop = true;
            this.linkLabelAdd.Text = "Add";
            this.linkLabelAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAdd_LinkClicked);
            // 
            // linkLabelGetFood
            // 
            this.linkLabelGetFood.AutoSize = true;
            this.linkLabelGetFood.Location = new System.Drawing.Point(249, 52);
            this.linkLabelGetFood.Name = "linkLabelGetFood";
            this.linkLabelGetFood.Size = new System.Drawing.Size(46, 22);
            this.linkLabelGetFood.TabIndex = 1;
            this.linkLabelGetFood.TabStop = true;
            this.linkLabelGetFood.Text = "Get";
            this.linkLabelGetFood.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGetFood_LinkClicked);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(133, 209);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(167, 31);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TabStop = false;
            this.txtPrice.Tag = "Price";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(133, 157);
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(100, 31);
            this.txtQty.TabIndex = 3;
            this.txtQty.TabStop = false;
            this.txtQty.Tag = "Qty";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 105);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(167, 31);
            this.txtName.TabIndex = 1;
            this.txtName.TabStop = false;
            this.txtName.Tag = "Name";
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(133, 49);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(100, 31);
            this.txtFoodID.TabIndex = 0;
            this.txtFoodID.Tag = "Food ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Qty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food ID:";
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.txtGuestID);
            this.gbOrder.Controls.Add(this.txtOrderPrice);
            this.gbOrder.Controls.Add(this.linkLabelGetOrder);
            this.gbOrder.Controls.Add(this.txtOrderType);
            this.gbOrder.Controls.Add(this.txtOrderQty);
            this.gbOrder.Controls.Add(this.label9);
            this.gbOrder.Controls.Add(this.txtOrderID);
            this.gbOrder.Controls.Add(this.label5);
            this.gbOrder.Controls.Add(this.label6);
            this.gbOrder.Controls.Add(this.label7);
            this.gbOrder.Controls.Add(this.label8);
            this.gbOrder.Location = new System.Drawing.Point(508, 149);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(395, 308);
            this.gbOrder.TabIndex = 1;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Orders";
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(133, 259);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.ReadOnly = true;
            this.txtGuestID.Size = new System.Drawing.Size(167, 31);
            this.txtGuestID.TabIndex = 5;
            this.txtGuestID.TabStop = false;
            this.txtGuestID.Tag = "Guest ID";
            // 
            // txtOrderPrice
            // 
            this.txtOrderPrice.Location = new System.Drawing.Point(133, 209);
            this.txtOrderPrice.Name = "txtOrderPrice";
            this.txtOrderPrice.ReadOnly = true;
            this.txtOrderPrice.Size = new System.Drawing.Size(167, 31);
            this.txtOrderPrice.TabIndex = 4;
            this.txtOrderPrice.TabStop = false;
            this.txtOrderPrice.Tag = "Price";
            // 
            // linkLabelGetOrder
            // 
            this.linkLabelGetOrder.AutoSize = true;
            this.linkLabelGetOrder.Location = new System.Drawing.Point(254, 52);
            this.linkLabelGetOrder.Name = "linkLabelGetOrder";
            this.linkLabelGetOrder.Size = new System.Drawing.Size(46, 22);
            this.linkLabelGetOrder.TabIndex = 6;
            this.linkLabelGetOrder.TabStop = true;
            this.linkLabelGetOrder.Text = "Get";
            this.linkLabelGetOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGetOrder_LinkClicked);
            // 
            // txtOrderType
            // 
            this.txtOrderType.Location = new System.Drawing.Point(133, 105);
            this.txtOrderType.Name = "txtOrderType";
            this.txtOrderType.ReadOnly = true;
            this.txtOrderType.Size = new System.Drawing.Size(167, 31);
            this.txtOrderType.TabIndex = 3;
            this.txtOrderType.TabStop = false;
            this.txtOrderType.Tag = "Type";
            // 
            // txtOrderQty
            // 
            this.txtOrderQty.Location = new System.Drawing.Point(133, 157);
            this.txtOrderQty.Name = "txtOrderQty";
            this.txtOrderQty.ReadOnly = true;
            this.txtOrderQty.Size = new System.Drawing.Size(100, 31);
            this.txtOrderQty.TabIndex = 3;
            this.txtOrderQty.TabStop = false;
            this.txtOrderQty.Tag = "Qty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Guest ID:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(133, 49);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 31);
            this.txtOrderID.TabIndex = 5;
            this.txtOrderID.Tag = "Order ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Qty:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Order ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.txtDetialFoodID);
            this.groupBox1.Controls.Add(this.txtDetialOrderID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(989, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 234);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Detial";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(133, 160);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(167, 31);
            this.txtAmount.TabIndex = 13;
            this.txtAmount.Tag = "Amount";
            // 
            // txtDetialFoodID
            // 
            this.txtDetialFoodID.Location = new System.Drawing.Point(133, 105);
            this.txtDetialFoodID.Name = "txtDetialFoodID";
            this.txtDetialFoodID.Size = new System.Drawing.Size(100, 31);
            this.txtDetialFoodID.TabIndex = 12;
            this.txtDetialFoodID.Tag = "Food ID";
            // 
            // txtDetialOrderID
            // 
            this.txtDetialOrderID.Location = new System.Drawing.Point(133, 49);
            this.txtDetialOrderID.Name = "txtDetialOrderID";
            this.txtDetialOrderID.Size = new System.Drawing.Size(100, 31);
            this.txtDetialOrderID.TabIndex = 11;
            this.txtDetialOrderID.Tag = "Order ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Amount:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Food ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Order ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(458, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 398);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(952, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 398);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(29, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1282, 5);
            this.panel3.TabIndex = 3;
            // 
            // dataGridViewFood
            // 
            this.dataGridViewFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFood.Location = new System.Drawing.Point(12, 515);
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.Size = new System.Drawing.Size(437, 188);
            this.dataGridViewFood.TabIndex = 4;
            this.dataGridViewFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFood_CellClick);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(469, 515);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(477, 188);
            this.dataGridViewOrders.TabIndex = 4;
            this.dataGridViewOrders.Click += new System.EventHandler(this.dataGridViewOrders_Click);
            // 
            // dataGridViewOrderDetial
            // 
            this.dataGridViewOrderDetial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderDetial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetial.Location = new System.Drawing.Point(963, 515);
            this.dataGridViewOrderDetial.Name = "dataGridViewOrderDetial";
            this.dataGridViewOrderDetial.Size = new System.Drawing.Size(362, 188);
            this.dataGridViewOrderDetial.TabIndex = 4;
            this.dataGridViewOrderDetial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderDetial_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(94, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(257, 30);
            this.label11.TabIndex = 5;
            this.label11.Text = "Food And Beverage";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(638, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 30);
            this.label14.TabIndex = 5;
            this.label14.Text = "Orders";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1093, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 30);
            this.label15.TabIndex = 5;
            this.label15.Text = "Detial";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Location = new System.Drawing.Point(989, 404);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(322, 35);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(989, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(322, 35);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Location = new System.Drawing.Point(508, 463);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(81, 35);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(813, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(719, 463);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(613, 463);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmOrder
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1337, 760);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridViewOrderDetial);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.dataGridViewFood);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFoodAndBeverage);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.gbFoodAndBeverage.ResumeLayout(false);
            this.gbFoodAndBeverage.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFoodAndBeverage;
        private System.Windows.Forms.LinkLabel linkLabelDelete;
        private System.Windows.Forms.LinkLabel linkLabelModify;
        private System.Windows.Forms.LinkLabel linkLabelGetFood;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.TextBox txtOrderQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDetialFoodID;
        private System.Windows.Forms.TextBox txtDetialOrderID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewFood;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel linkLabelAdd;
        private System.Windows.Forms.LinkLabel linkLabelGetOrder;
        private System.Windows.Forms.TextBox txtOrderType;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}