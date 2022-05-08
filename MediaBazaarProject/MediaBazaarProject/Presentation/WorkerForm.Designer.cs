﻿
namespace MediaBazaarProject
{
    partial class WorkerForm
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
            this.TabWorker = new System.Windows.Forms.TabControl();
            this.tabWorkerHome = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.lbxShiftEmployeeDay = new System.Windows.Forms.ListBox();
            this.lblshift = new System.Windows.Forms.Label();
            this.dateWorker = new System.Windows.Forms.DateTimePicker();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.lblSalesQuantity = new System.Windows.Forms.Label();
            this.lbSalesQuantity = new System.Windows.Forms.ListBox();
            this.lblInventorySales = new System.Windows.Forms.Label();
            this.lblRequestSales = new System.Windows.Forms.Label();
            this.lbxRequestSales = new System.Windows.Forms.ListBox();
            this.btnHomeSales = new System.Windows.Forms.Button();
            this.nudAmountSales = new System.Windows.Forms.NumericUpDown();
            this.lblAmountSales = new System.Windows.Forms.Label();
            this.btnRequestItem = new System.Windows.Forms.Button();
            this.lbxStockSales = new System.Windows.Forms.ListBox();
            this.tabWarehouse = new System.Windows.Forms.TabPage();
            this.btnResetFiltersWarehouse = new System.Windows.Forms.Button();
            this.btnFilterProductsWarehouse = new System.Windows.Forms.Button();
            this.tbFilterProductsWarehouse = new System.Windows.Forms.TextBox();
            this.lblFilterProductsByWarehouse = new System.Windows.Forms.Label();
            this.rbFilterProductsByBrandWarehouse = new System.Windows.Forms.RadioButton();
            this.rbFilterProductsByCategoryWarehouse = new System.Windows.Forms.RadioButton();
            this.rbFilterProductsByNameWarehouse = new System.Windows.Forms.RadioButton();
            this.lblWarehouseQuantity = new System.Windows.Forms.Label();
            this.lbWarehouseQuantity = new System.Windows.Forms.ListBox();
            this.lblInventoryWarehouse = new System.Windows.Forms.Label();
            this.lblRequestWarehouse = new System.Windows.Forms.Label();
            this.btnRejectRequest = new System.Windows.Forms.Button();
            this.btnAcceptRequest = new System.Windows.Forms.Button();
            this.lbxRequestWarehouse = new System.Windows.Forms.ListBox();
            this.btnHomeWarehouse = new System.Windows.Forms.Button();
            this.nudAmountWarehouse = new System.Windows.Forms.NumericUpDown();
            this.lblAmountWarehouse = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.lbxStockWarehouse = new System.Windows.Forms.ListBox();
            this.TabWorker.SuspendLayout();
            this.tabWorkerHome.SuspendLayout();
            this.tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountSales)).BeginInit();
            this.tabWarehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // TabWorker
            // 
            this.TabWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabWorker.Controls.Add(this.tabWorkerHome);
            this.TabWorker.Controls.Add(this.tabSales);
            this.TabWorker.Controls.Add(this.tabWarehouse);
            this.TabWorker.Location = new System.Drawing.Point(-6, -15);
            this.TabWorker.Name = "TabWorker";
            this.TabWorker.SelectedIndex = 0;
            this.TabWorker.Size = new System.Drawing.Size(1999, 583);
            this.TabWorker.TabIndex = 15;
            // 
            // tabWorkerHome
            // 
            this.tabWorkerHome.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabWorkerHome.Controls.Add(this.btnLogOut);
            this.tabWorkerHome.Controls.Add(this.btnWarehouse);
            this.tabWorkerHome.Controls.Add(this.btnSales);
            this.tabWorkerHome.Controls.Add(this.lbxShiftEmployeeDay);
            this.tabWorkerHome.Controls.Add(this.lblshift);
            this.tabWorkerHome.Controls.Add(this.dateWorker);
            this.tabWorkerHome.Location = new System.Drawing.Point(4, 24);
            this.tabWorkerHome.Name = "tabWorkerHome";
            this.tabWorkerHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkerHome.Size = new System.Drawing.Size(1991, 555);
            this.tabWorkerHome.TabIndex = 0;
            this.tabWorkerHome.Text = "WorkerHome";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLogOut.Location = new System.Drawing.Point(926, 178);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(130, 124);
            this.btnLogOut.TabIndex = 25;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.BackColor = System.Drawing.Color.CadetBlue;
            this.btnWarehouse.Location = new System.Drawing.Point(40, 166);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(130, 124);
            this.btnWarehouse.TabIndex = 24;
            this.btnWarehouse.Text = "Warehouse requests";
            this.btnWarehouse.UseVisualStyleBackColor = false;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSales.Location = new System.Drawing.Point(220, 166);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(130, 124);
            this.btnSales.TabIndex = 23;
            this.btnSales.Text = "Sales Request";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // lbxShiftEmployeeDay
            // 
            this.lbxShiftEmployeeDay.FormattingEnabled = true;
            this.lbxShiftEmployeeDay.ItemHeight = 15;
            this.lbxShiftEmployeeDay.Location = new System.Drawing.Point(495, 166);
            this.lbxShiftEmployeeDay.Name = "lbxShiftEmployeeDay";
            this.lbxShiftEmployeeDay.Size = new System.Drawing.Size(212, 94);
            this.lbxShiftEmployeeDay.TabIndex = 22;
            // 
            // lblshift
            // 
            this.lblshift.AutoSize = true;
            this.lblshift.Location = new System.Drawing.Point(527, 114);
            this.lblshift.Name = "lblshift";
            this.lblshift.Size = new System.Drawing.Size(104, 15);
            this.lblshift.TabIndex = 21;
            this.lblshift.Text = "Shifts for the date:";
            // 
            // dateWorker
            // 
            this.dateWorker.Location = new System.Drawing.Point(456, 50);
            this.dateWorker.MaxDate = new System.DateTime(2022, 3, 22, 0, 0, 0, 0);
            this.dateWorker.MinDate = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            this.dateWorker.Name = "dateWorker";
            this.dateWorker.Size = new System.Drawing.Size(286, 21);
            this.dateWorker.TabIndex = 20;
            this.dateWorker.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            this.dateWorker.ValueChanged += new System.EventHandler(this.dateWorker_ValueChanged);
            // 
            // tabSales
            // 
            this.tabSales.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabSales.Controls.Add(this.lblSalesQuantity);
            this.tabSales.Controls.Add(this.lbSalesQuantity);
            this.tabSales.Controls.Add(this.lblInventorySales);
            this.tabSales.Controls.Add(this.lblRequestSales);
            this.tabSales.Controls.Add(this.lbxRequestSales);
            this.tabSales.Controls.Add(this.btnHomeSales);
            this.tabSales.Controls.Add(this.nudAmountSales);
            this.tabSales.Controls.Add(this.lblAmountSales);
            this.tabSales.Controls.Add(this.btnRequestItem);
            this.tabSales.Controls.Add(this.lbxStockSales);
            this.tabSales.Location = new System.Drawing.Point(4, 24);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSales.Size = new System.Drawing.Size(1991, 555);
            this.tabSales.TabIndex = 1;
            this.tabSales.Text = "SalesTab";
            // 
            // lblSalesQuantity
            // 
            this.lblSalesQuantity.AutoSize = true;
            this.lblSalesQuantity.Location = new System.Drawing.Point(1627, 69);
            this.lblSalesQuantity.Name = "lblSalesQuantity";
            this.lblSalesQuantity.Size = new System.Drawing.Size(83, 15);
            this.lblSalesQuantity.TabIndex = 35;
            this.lblSalesQuantity.Text = "Sales quantity";
            // 
            // lbSalesQuantity
            // 
            this.lbSalesQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSalesQuantity.FormattingEnabled = true;
            this.lbSalesQuantity.ItemHeight = 15;
            this.lbSalesQuantity.Location = new System.Drawing.Point(1627, 90);
            this.lbSalesQuantity.Name = "lbSalesQuantity";
            this.lbSalesQuantity.Size = new System.Drawing.Size(176, 364);
            this.lbSalesQuantity.TabIndex = 34;
            // 
            // lblInventorySales
            // 
            this.lblInventorySales.AutoSize = true;
            this.lblInventorySales.Location = new System.Drawing.Point(948, 69);
            this.lblInventorySales.Name = "lblInventorySales";
            this.lblInventorySales.Size = new System.Drawing.Size(55, 15);
            this.lblInventorySales.TabIndex = 33;
            this.lblInventorySales.Text = "Inventory";
            // 
            // lblRequestSales
            // 
            this.lblRequestSales.AutoSize = true;
            this.lblRequestSales.Location = new System.Drawing.Point(282, 69);
            this.lblRequestSales.Name = "lblRequestSales";
            this.lblRequestSales.Size = new System.Drawing.Size(59, 15);
            this.lblRequestSales.TabIndex = 32;
            this.lblRequestSales.Text = "Requests";
            // 
            // lbxRequestSales
            // 
            this.lbxRequestSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxRequestSales.FormattingEnabled = true;
            this.lbxRequestSales.ItemHeight = 15;
            this.lbxRequestSales.Location = new System.Drawing.Point(282, 90);
            this.lbxRequestSales.Name = "lbxRequestSales";
            this.lbxRequestSales.Size = new System.Drawing.Size(660, 364);
            this.lbxRequestSales.TabIndex = 31;
            // 
            // btnHomeSales
            // 
            this.btnHomeSales.Location = new System.Drawing.Point(1715, 28);
            this.btnHomeSales.Name = "btnHomeSales";
            this.btnHomeSales.Size = new System.Drawing.Size(75, 23);
            this.btnHomeSales.TabIndex = 30;
            this.btnHomeSales.Text = "Home";
            this.btnHomeSales.UseVisualStyleBackColor = true;
            this.btnHomeSales.Click += new System.EventHandler(this.btnHomeSales_Click);
            // 
            // nudAmountSales
            // 
            this.nudAmountSales.Location = new System.Drawing.Point(153, 47);
            this.nudAmountSales.Name = "nudAmountSales";
            this.nudAmountSales.Size = new System.Drawing.Size(120, 21);
            this.nudAmountSales.TabIndex = 26;
            // 
            // lblAmountSales
            // 
            this.lblAmountSales.AutoSize = true;
            this.lblAmountSales.Location = new System.Drawing.Point(78, 49);
            this.lblAmountSales.Name = "lblAmountSales";
            this.lblAmountSales.Size = new System.Drawing.Size(52, 15);
            this.lblAmountSales.TabIndex = 25;
            this.lblAmountSales.Text = "Amount:";
            // 
            // btnRequestItem
            // 
            this.btnRequestItem.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRequestItem.Location = new System.Drawing.Point(78, 142);
            this.btnRequestItem.Name = "btnRequestItem";
            this.btnRequestItem.Size = new System.Drawing.Size(130, 124);
            this.btnRequestItem.TabIndex = 24;
            this.btnRequestItem.Text = "Request Item";
            this.btnRequestItem.UseVisualStyleBackColor = false;
            this.btnRequestItem.Click += new System.EventHandler(this.btnRequestItem_Click);
            // 
            // lbxStockSales
            // 
            this.lbxStockSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxStockSales.FormattingEnabled = true;
            this.lbxStockSales.ItemHeight = 15;
            this.lbxStockSales.Location = new System.Drawing.Point(948, 90);
            this.lbxStockSales.Name = "lbxStockSales";
            this.lbxStockSales.Size = new System.Drawing.Size(680, 364);
            this.lbxStockSales.TabIndex = 0;
            // 
            // tabWarehouse
            // 
            this.tabWarehouse.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabWarehouse.Controls.Add(this.btnResetFiltersWarehouse);
            this.tabWarehouse.Controls.Add(this.btnFilterProductsWarehouse);
            this.tabWarehouse.Controls.Add(this.tbFilterProductsWarehouse);
            this.tabWarehouse.Controls.Add(this.lblFilterProductsByWarehouse);
            this.tabWarehouse.Controls.Add(this.rbFilterProductsByBrandWarehouse);
            this.tabWarehouse.Controls.Add(this.rbFilterProductsByCategoryWarehouse);
            this.tabWarehouse.Controls.Add(this.rbFilterProductsByNameWarehouse);
            this.tabWarehouse.Controls.Add(this.lblWarehouseQuantity);
            this.tabWarehouse.Controls.Add(this.lbWarehouseQuantity);
            this.tabWarehouse.Controls.Add(this.lblInventoryWarehouse);
            this.tabWarehouse.Controls.Add(this.lblRequestWarehouse);
            this.tabWarehouse.Controls.Add(this.btnRejectRequest);
            this.tabWarehouse.Controls.Add(this.btnAcceptRequest);
            this.tabWarehouse.Controls.Add(this.lbxRequestWarehouse);
            this.tabWarehouse.Controls.Add(this.btnHomeWarehouse);
            this.tabWarehouse.Controls.Add(this.nudAmountWarehouse);
            this.tabWarehouse.Controls.Add(this.lblAmountWarehouse);
            this.tabWarehouse.Controls.Add(this.btnAddStock);
            this.tabWarehouse.Controls.Add(this.lbxStockWarehouse);
            this.tabWarehouse.Location = new System.Drawing.Point(4, 24);
            this.tabWarehouse.Name = "tabWarehouse";
            this.tabWarehouse.Padding = new System.Windows.Forms.Padding(3);
            this.tabWarehouse.Size = new System.Drawing.Size(1991, 555);
            this.tabWarehouse.TabIndex = 2;
            this.tabWarehouse.Text = "WarehouseTab";
            // 
            // btnResetFiltersWarehouse
            // 
            this.btnResetFiltersWarehouse.Location = new System.Drawing.Point(1514, 63);
            this.btnResetFiltersWarehouse.Name = "btnResetFiltersWarehouse";
            this.btnResetFiltersWarehouse.Size = new System.Drawing.Size(94, 24);
            this.btnResetFiltersWarehouse.TabIndex = 43;
            this.btnResetFiltersWarehouse.Text = "Reset filters";
            this.btnResetFiltersWarehouse.UseVisualStyleBackColor = true;
            this.btnResetFiltersWarehouse.Click += new System.EventHandler(this.btnResetFiltersWarehouse_Click);
            // 
            // btnFilterProductsWarehouse
            // 
            this.btnFilterProductsWarehouse.Location = new System.Drawing.Point(1414, 63);
            this.btnFilterProductsWarehouse.Name = "btnFilterProductsWarehouse";
            this.btnFilterProductsWarehouse.Size = new System.Drawing.Size(94, 24);
            this.btnFilterProductsWarehouse.TabIndex = 42;
            this.btnFilterProductsWarehouse.Text = "Filter";
            this.btnFilterProductsWarehouse.UseVisualStyleBackColor = true;
            this.btnFilterProductsWarehouse.Click += new System.EventHandler(this.btnFilterProductsWarehouse_Click);
            // 
            // tbFilterProductsWarehouse
            // 
            this.tbFilterProductsWarehouse.Location = new System.Drawing.Point(1283, 63);
            this.tbFilterProductsWarehouse.Name = "tbFilterProductsWarehouse";
            this.tbFilterProductsWarehouse.Size = new System.Drawing.Size(125, 21);
            this.tbFilterProductsWarehouse.TabIndex = 41;
            // 
            // lblFilterProductsByWarehouse
            // 
            this.lblFilterProductsByWarehouse.AutoSize = true;
            this.lblFilterProductsByWarehouse.Location = new System.Drawing.Point(1039, 46);
            this.lblFilterProductsByWarehouse.Name = "lblFilterProductsByWarehouse";
            this.lblFilterProductsByWarehouse.Size = new System.Drawing.Size(53, 15);
            this.lblFilterProductsByWarehouse.TabIndex = 40;
            this.lblFilterProductsByWarehouse.Text = "Filter By:";
            // 
            // rbFilterProductsByBrandWarehouse
            // 
            this.rbFilterProductsByBrandWarehouse.AutoSize = true;
            this.rbFilterProductsByBrandWarehouse.Location = new System.Drawing.Point(1209, 67);
            this.rbFilterProductsByBrandWarehouse.Name = "rbFilterProductsByBrandWarehouse";
            this.rbFilterProductsByBrandWarehouse.Size = new System.Drawing.Size(58, 19);
            this.rbFilterProductsByBrandWarehouse.TabIndex = 39;
            this.rbFilterProductsByBrandWarehouse.TabStop = true;
            this.rbFilterProductsByBrandWarehouse.Text = "Brand";
            this.rbFilterProductsByBrandWarehouse.UseVisualStyleBackColor = true;
            // 
            // rbFilterProductsByCategoryWarehouse
            // 
            this.rbFilterProductsByCategoryWarehouse.AutoSize = true;
            this.rbFilterProductsByCategoryWarehouse.Location = new System.Drawing.Point(1114, 67);
            this.rbFilterProductsByCategoryWarehouse.Name = "rbFilterProductsByCategoryWarehouse";
            this.rbFilterProductsByCategoryWarehouse.Size = new System.Drawing.Size(73, 19);
            this.rbFilterProductsByCategoryWarehouse.TabIndex = 38;
            this.rbFilterProductsByCategoryWarehouse.TabStop = true;
            this.rbFilterProductsByCategoryWarehouse.Text = "Category";
            this.rbFilterProductsByCategoryWarehouse.UseVisualStyleBackColor = true;
            // 
            // rbFilterProductsByNameWarehouse
            // 
            this.rbFilterProductsByNameWarehouse.AutoSize = true;
            this.rbFilterProductsByNameWarehouse.Location = new System.Drawing.Point(1039, 67);
            this.rbFilterProductsByNameWarehouse.Name = "rbFilterProductsByNameWarehouse";
            this.rbFilterProductsByNameWarehouse.Size = new System.Drawing.Size(59, 19);
            this.rbFilterProductsByNameWarehouse.TabIndex = 37;
            this.rbFilterProductsByNameWarehouse.TabStop = true;
            this.rbFilterProductsByNameWarehouse.Text = "Name";
            this.rbFilterProductsByNameWarehouse.UseVisualStyleBackColor = true;
            // 
            // lblWarehouseQuantity
            // 
            this.lblWarehouseQuantity.AutoSize = true;
            this.lblWarehouseQuantity.Location = new System.Drawing.Point(1627, 69);
            this.lblWarehouseQuantity.Name = "lblWarehouseQuantity";
            this.lblWarehouseQuantity.Size = new System.Drawing.Size(115, 15);
            this.lblWarehouseQuantity.TabIndex = 36;
            this.lblWarehouseQuantity.Text = "Warehouse quantity";
            // 
            // lbWarehouseQuantity
            // 
            this.lbWarehouseQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbWarehouseQuantity.FormattingEnabled = true;
            this.lbWarehouseQuantity.ItemHeight = 15;
            this.lbWarehouseQuantity.Location = new System.Drawing.Point(1627, 90);
            this.lbWarehouseQuantity.Name = "lbWarehouseQuantity";
            this.lbWarehouseQuantity.Size = new System.Drawing.Size(176, 334);
            this.lbWarehouseQuantity.TabIndex = 35;
            // 
            // lblInventoryWarehouse
            // 
            this.lblInventoryWarehouse.AutoSize = true;
            this.lblInventoryWarehouse.Location = new System.Drawing.Point(948, 54);
            this.lblInventoryWarehouse.Name = "lblInventoryWarehouse";
            this.lblInventoryWarehouse.Size = new System.Drawing.Size(55, 15);
            this.lblInventoryWarehouse.TabIndex = 34;
            this.lblInventoryWarehouse.Text = "Inventory";
            // 
            // lblRequestWarehouse
            // 
            this.lblRequestWarehouse.AutoSize = true;
            this.lblRequestWarehouse.Location = new System.Drawing.Point(304, 54);
            this.lblRequestWarehouse.Name = "lblRequestWarehouse";
            this.lblRequestWarehouse.Size = new System.Drawing.Size(59, 15);
            this.lblRequestWarehouse.TabIndex = 33;
            this.lblRequestWarehouse.Text = "Requests";
            // 
            // btnRejectRequest
            // 
            this.btnRejectRequest.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRejectRequest.Location = new System.Drawing.Point(153, 153);
            this.btnRejectRequest.Name = "btnRejectRequest";
            this.btnRejectRequest.Size = new System.Drawing.Size(112, 98);
            this.btnRejectRequest.TabIndex = 32;
            this.btnRejectRequest.Text = "Reject Request";
            this.btnRejectRequest.UseVisualStyleBackColor = false;
            this.btnRejectRequest.Click += new System.EventHandler(this.btnRejectRequest_Click);
            // 
            // btnAcceptRequest
            // 
            this.btnAcceptRequest.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAcceptRequest.Location = new System.Drawing.Point(22, 153);
            this.btnAcceptRequest.Name = "btnAcceptRequest";
            this.btnAcceptRequest.Size = new System.Drawing.Size(112, 98);
            this.btnAcceptRequest.TabIndex = 31;
            this.btnAcceptRequest.Text = "Accept Request";
            this.btnAcceptRequest.UseVisualStyleBackColor = false;
            this.btnAcceptRequest.Click += new System.EventHandler(this.btnAcceptRequest_Click);
            // 
            // lbxRequestWarehouse
            // 
            this.lbxRequestWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxRequestWarehouse.FormattingEnabled = true;
            this.lbxRequestWarehouse.ItemHeight = 15;
            this.lbxRequestWarehouse.Location = new System.Drawing.Point(282, 90);
            this.lbxRequestWarehouse.Name = "lbxRequestWarehouse";
            this.lbxRequestWarehouse.Size = new System.Drawing.Size(647, 334);
            this.lbxRequestWarehouse.TabIndex = 30;
            this.lbxRequestWarehouse.SelectedIndexChanged += new System.EventHandler(this.lbxRequestWarehouse_SelectedIndexChanged);
            // 
            // btnHomeWarehouse
            // 
            this.btnHomeWarehouse.Location = new System.Drawing.Point(1706, 22);
            this.btnHomeWarehouse.Name = "btnHomeWarehouse";
            this.btnHomeWarehouse.Size = new System.Drawing.Size(75, 23);
            this.btnHomeWarehouse.TabIndex = 29;
            this.btnHomeWarehouse.Text = "Home";
            this.btnHomeWarehouse.UseVisualStyleBackColor = true;
            this.btnHomeWarehouse.Click += new System.EventHandler(this.btnHomeWarehouse_Click);
            // 
            // nudAmountWarehouse
            // 
            this.nudAmountWarehouse.Location = new System.Drawing.Point(153, 47);
            this.nudAmountWarehouse.Name = "nudAmountWarehouse";
            this.nudAmountWarehouse.Size = new System.Drawing.Size(120, 21);
            this.nudAmountWarehouse.TabIndex = 28;
            // 
            // lblAmountWarehouse
            // 
            this.lblAmountWarehouse.AutoSize = true;
            this.lblAmountWarehouse.Location = new System.Drawing.Point(78, 49);
            this.lblAmountWarehouse.Name = "lblAmountWarehouse";
            this.lblAmountWarehouse.Size = new System.Drawing.Size(52, 15);
            this.lblAmountWarehouse.TabIndex = 27;
            this.lblAmountWarehouse.Text = "Amount:";
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAddStock.Location = new System.Drawing.Point(78, 311);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(112, 98);
            this.btnAddStock.TabIndex = 24;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // lbxStockWarehouse
            // 
            this.lbxStockWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxStockWarehouse.FormattingEnabled = true;
            this.lbxStockWarehouse.ItemHeight = 15;
            this.lbxStockWarehouse.Location = new System.Drawing.Point(948, 90);
            this.lbxStockWarehouse.Name = "lbxStockWarehouse";
            this.lbxStockWarehouse.Size = new System.Drawing.Size(680, 334);
            this.lbxStockWarehouse.TabIndex = 0;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1813, 561);
            this.Controls.Add(this.TabWorker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            this.TabWorker.ResumeLayout(false);
            this.tabWorkerHome.ResumeLayout(false);
            this.tabWorkerHome.PerformLayout();
            this.tabSales.ResumeLayout(false);
            this.tabSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountSales)).EndInit();
            this.tabWarehouse.ResumeLayout(false);
            this.tabWarehouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountWarehouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabWorker;
        private System.Windows.Forms.TabPage tabWorkerHome;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.ListBox lbxShiftEmployeeDay;
        private System.Windows.Forms.Label lblshift;
        private System.Windows.Forms.DateTimePicker dateWorker;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.TabPage tabWarehouse;
        private System.Windows.Forms.NumericUpDown nudAmountSales;
        private System.Windows.Forms.Label lblAmountSales;
        private System.Windows.Forms.Button btnRequestItem;
        private System.Windows.Forms.ListBox lbxStockSales;
        private System.Windows.Forms.NumericUpDown nudAmountWarehouse;
        private System.Windows.Forms.Label lblAmountWarehouse;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.ListBox lbxStockWarehouse;
        private System.Windows.Forms.Button btnHomeSales;
        private System.Windows.Forms.Button btnHomeWarehouse;
        private System.Windows.Forms.ListBox lbxRequestSales;
        private System.Windows.Forms.ListBox lbxRequestWarehouse;
        private System.Windows.Forms.Button btnRejectRequest;
        private System.Windows.Forms.Button btnAcceptRequest;
        private System.Windows.Forms.Label lblInventorySales;
        private System.Windows.Forms.Label lblRequestSales;
        private System.Windows.Forms.Label lblInventoryWarehouse;
        private System.Windows.Forms.Label lblRequestWarehouse;
        private System.Windows.Forms.Label lblSalesQuantity;
        private System.Windows.Forms.ListBox lbSalesQuantity;
        private System.Windows.Forms.Label lblWarehouseQuantity;
        private System.Windows.Forms.ListBox lbWarehouseQuantity;
        private System.Windows.Forms.Button btnResetFiltersWarehouse;
        private System.Windows.Forms.Button btnFilterProductsWarehouse;
        private System.Windows.Forms.TextBox tbFilterProductsWarehouse;
        private System.Windows.Forms.Label lblFilterProductsByWarehouse;
        private System.Windows.Forms.RadioButton rbFilterProductsByBrandWarehouse;
        private System.Windows.Forms.RadioButton rbFilterProductsByCategoryWarehouse;
        private System.Windows.Forms.RadioButton rbFilterProductsByNameWarehouse;
        private System.Windows.Forms.Button btnLogOut;
    }
}