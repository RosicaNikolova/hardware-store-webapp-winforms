﻿using IronBarCode;
using MediaBazaarLibrary;
using MediaBazaarLibrary.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarProject
{
    public partial class WorkerForm : Form
    {
        User user;
        ShiftManager shiftManager = new ShiftManager();
        RequestManager requestManager = new RequestManager();
        ProductManager productManager = new ProductManager();
        Leave_Preference_RequestManager leaveRequestManager = new Leave_Preference_RequestManager();
        string role = string.Empty;
        double overallScannedPrice;

        public WorkerForm()
        {
            InitializeComponent();

            DateTime maxDate;
            maxDate = DateTime.Today.AddDays(7);
            dateWorker.MaxDate = maxDate;
            dateWorker.MinDate = DateTime.Today;
            overallScannedPrice = 0;
        }

        public WorkerForm(User u, string role)
        {
            InitializeComponent();

            this.role = role;
            user = u;
            if (role == "sales")
            {
                btnWarehouse.Visible = false;
                pbWarehouse.Visible = false;
            }
            else if (role == "warehouse")
            {
                btnSales.Visible = false;
                pbSales.Visible = false;
            }

            DateTime maxDate;
            maxDate = DateTime.Today.AddDays(7);
            dateWorker.MaxDate = maxDate;
            dateWorker.MinDate = DateTime.Today;
            overallScannedPrice = 0;
            tbOverallPrice.Enabled = false;
        }

        private Product SelectedProduct()
        {
            if (TabWorker.SelectedTab == tabSales)
            {
                Product product;

                object selectedProduct = lbxStockSales.SelectedItem;
                product = (Product)selectedProduct;
                return product;
            }
            else if (TabWorker.SelectedTab == tabWarehouse)
            {
                Product product;

                object selectedProduct = lbxStockWarehouse.SelectedItem;
                product = (Product)selectedProduct;
                return product;
            }
            else if (TabWorker.SelectedTab == tabBarcodeScanner)
            {
                Product product;

                object selectedProduct = lbProductsInSales.SelectedItem;
                product = (Product)selectedProduct;
                return product;
            }
            return null;
        }

        private Request SelectedRequest()
        {
            Request request;
            object selectedRequest = lbxRequestWarehouse.SelectedItem;
            request = (Request)selectedRequest;
            return request;
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            lbxShiftEmployeeDay.Items.Clear();

            DateTime date = dateWorker.MinDate;
            List<Shift> shiftsForWorker = new List<Shift>();
            shiftsForWorker = shiftManager.GetShiftsForWorkerForWeek(date, user.Id);


            foreach (Shift shift in shiftsForWorker)
            {
                if (dateWorker.Value == shift.Date)
                {
                    lbxShiftEmployeeDay.Items.Add(shift.ShiftType);
                }
            }
        }



        private void btnHomeWarehouse_Click(object sender, EventArgs e)
        {
            TabWorker.SelectedTab = tabWorkerHome;
        }

        private void btnHomeSales_Click(object sender, EventArgs e)
        {
            TabWorker.SelectedTab = tabWorkerHome;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            TabWorker.SelectedTab = tabSales;
            List<Product> products = productManager.GetAllProductsList();
            lbxStockSales.Items.Clear();
            lbSalesQuantity.Items.Clear();
            List<Request> requests = requestManager.GetAllRequestsList();
            lbxRequestSales.Items.Clear();
            foreach (Request r in requests)
            {
                lbxRequestSales.Items.Add(r);
            }
            foreach (Product p in products)
            {
                lbxStockSales.Items.Add(p);
                lbSalesQuantity.Items.Add(p.QuantitySales);
            }
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            TabWorker.SelectedTab = tabWarehouse;
            List<Product> products = productManager.GetAllProductsList();
            lbxStockWarehouse.Items.Clear();
            lbWarehouseQuantity.Items.Clear();
            List<Request> requests = requestManager.GetAllRequestsList();
            lbxRequestWarehouse.Items.Clear();
            foreach (Request r in requests)
            {
                lbxRequestWarehouse.Items.Add(r);
            }
            foreach (Product p in products)
            {
                lbxStockWarehouse.Items.Add(p);
                lbWarehouseQuantity.Items.Add(p.QuantityWarehouse);
            }
        }

        private void btnRequestItem_Click(object sender, EventArgs e)
        {
            if (nudAmountSales.Value > 0)
            {
                Product product = SelectedProduct();
                requestManager.Create(user.Id, product.ProductId, Convert.ToInt32(nudAmountSales.Value), EnumRequestStatus.PENDING, "");
                MessageBox.Show("Item has been requested");
                List<Request> requests = requestManager.GetAllRequestsList();
                lbxRequestSales.Items.Clear();
                foreach (Request r in requests)
                {
                    lbxRequestSales.Items.Add(r);
                }
            }
            else
            {
                MessageBox.Show("Please state a valid amount");
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            Product product = SelectedProduct();
            if (product != null)
            {
                if (nudAmountWarehouse.Value > 0)
                {
                    lbWarehouseQuantity.Items.Clear();
                    productManager.Edit(product, product.ProductName, product.ProductDescription, product.ProductPrice, product.ProductManufacturer, product.ProductCategory, product.QuantityWarehouse + Convert.ToInt32(nudAmountWarehouse.Value), product.QuantitySales, product.Barcode);
                    foreach (Product p in productManager.GetAllProductsList())
                    {
                        lbWarehouseQuantity.Items.Add(p.QuantityWarehouse);
                    }
                    MessageBox.Show("Stock has been added");
                }
                else
                {
                    MessageBox.Show("Please state a valid amount");
                }
            }
            else
            {
                MessageBox.Show("Please select a product");
            }
        }

        private void btnAcceptRequest_Click(object sender, EventArgs e)
        {
            Request request = SelectedRequest();
            Product product = productManager.GetById(request.ProductId);

            if (request != null)
            {
                if (request.Status == EnumRequestStatus.PENDING)
                {
                    if (request.RequestedAmount <= product.QuantityWarehouse)
                    {
                        requestManager.Edit(request, request.EmployeeId, request.ProductId, request.RequestedAmount, EnumRequestStatus.ACCEPTED, "");
                        productManager.Edit(product, product.ProductName, product.ProductDescription, product.ProductPrice, product.ProductManufacturer, product.ProductCategory, product.QuantityWarehouse - request.RequestedAmount, product.QuantitySales + request.RequestedAmount, product.Barcode);
                        MessageBox.Show("Request has been Accepted");
                    }
                    else if (request.RequestedAmount > product.QuantityWarehouse && product.QuantityWarehouse > 0)
                    {
                        int dif = Math.Abs(product.QuantityWarehouse - request.RequestedAmount);
                        requestManager.Edit(request, request.EmployeeId, request.ProductId, request.RequestedAmount, EnumRequestStatus.PARTIALLY, "Sending Remaining Stock");
                        productManager.Edit(product, product.ProductName, product.ProductDescription, product.ProductPrice, product.ProductManufacturer, product.ProductCategory, product.QuantityWarehouse - request.RequestedAmount + dif, product.QuantitySales + request.RequestedAmount - dif, product.Barcode);
                        MessageBox.Show("Request has been  partially Accepted");
                    }
                    else if (product.QuantityWarehouse == 0)
                    {
                        MessageBox.Show("Warehouse out of stock, Please reject request or add more stock");
                    }
                }
                else
                {
                    MessageBox.Show("product does not match requested product");
                }
            }
            else
            {
                MessageBox.Show("Please select request");
            }
            List<Request> requests = requestManager.GetAllRequestsList();
            List<Product> products = productManager.GetAllProductsList();
            lbxRequestWarehouse.Items.Clear();
            lbWarehouseQuantity.Items.Clear();
            foreach (Request r in requests)
            {
                lbxRequestWarehouse.Items.Add(r);
            }
            foreach (Product p in products)
            {
                lbWarehouseQuantity.Items.Add(p.QuantityWarehouse);
            }
        }

        private void btnRejectRequest_Click(object sender, EventArgs e)
        {
            Request request = SelectedRequest();
            string reason = tbxReasonRejection.Text;
            if(reason == String.Empty)
            {
                reason = "Request has been rejected";
            }
            if (request != null)
            {
                if (request.Status == EnumRequestStatus.PENDING)
                {
                    requestManager.Edit(request, request.EmployeeId, request.ProductId, request.RequestedAmount, EnumRequestStatus.REJECTED, reason);
                    MessageBox.Show("Request has been denied");
                    List<Request> requests = requestManager.GetAllRequestsList();
                    lbxRequestWarehouse.Items.Clear();
                    foreach (Request r in requests)
                    {
                        lbxRequestWarehouse.Items.Add(r);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a request");
            }
        }

        private void dateWorker_ValueChanged(object sender, EventArgs e)
        {
            lbxShiftEmployeeDay.Items.Clear();
            DateTime date = new DateTime();
            date = dateWorker.MinDate;
            List<Shift> shiftsForWorker = new List<Shift>();
            shiftsForWorker = shiftManager.GetShiftsForWorkerForWeek(date, user.Id);
            foreach (Shift shift in shiftsForWorker)
            {
                if (dateWorker.Value == shift.Date)
                {
                    lbxShiftEmployeeDay.Items.Add(shift.ShiftType.ToString());
                }
            }
        }

        private void btnFilterProductsWarehouse_Click(object sender, EventArgs e)
        {
            if (tbFilterProductsWarehouse.Text == "")
            {
                MessageBox.Show("Please provide input to filter by");
            }
            else
            {
                if (rbFilterProductsByNameWarehouse.Checked)
                {
                    lbxStockWarehouse.Items.Clear();
                    lbWarehouseQuantity.Items.Clear();
                    foreach (Product product in productManager.GetAllProductsList())
                    {
                        if (product.ProductName.Contains(tbFilterProductsWarehouse.Text))
                        {
                            lbxStockWarehouse.Items.Add(product);
                            lbWarehouseQuantity.Items.Add(product.QuantityWarehouse);
                        }
                    }
                }
                else if (rbFilterProductsByCategoryWarehouse.Checked)
                {
                    lbxStockWarehouse.Items.Clear();
                    lbWarehouseQuantity.Items.Clear();
                    foreach (Product product in productManager.GetAllProductsList())
                    {
                        if (product.ProductCategory.Contains(tbFilterProductsWarehouse.Text))
                        {
                            lbxStockWarehouse.Items.Add(product);
                            lbWarehouseQuantity.Items.Add(product.QuantityWarehouse);
                        }
                    }
                }
                else if (rbFilterProductsByBrandWarehouse.Checked)
                {
                    lbxStockWarehouse.Items.Clear();
                    lbWarehouseQuantity.Items.Clear();
                    foreach (Product product in productManager.GetAllProductsList())
                    {
                        if (product.ProductManufacturer.Contains(tbFilterProductsWarehouse.Text))
                        {
                            lbxStockWarehouse.Items.Add(product);
                            lbWarehouseQuantity.Items.Add(product.QuantityWarehouse);
                        }
                    }
                }
            }
        }

        private void btnResetFiltersWarehouse_Click(object sender, EventArgs e)
        {
            rbFilterProductsByNameWarehouse.Checked = false;
            rbFilterProductsByCategoryWarehouse.Checked = false;
            rbFilterProductsByBrandWarehouse.Checked = false;
            tbFilterProductsWarehouse.Text = "";
            lbxStockWarehouse.Items.Clear();
            lbWarehouseQuantity.Items.Clear();
            lbxRequestWarehouse.ClearSelected();

            foreach (Product product in productManager.GetAllProductsList())
            {
                lbxStockWarehouse.Items.Add(product);
                lbWarehouseQuantity.Items.Add(product.QuantityWarehouse);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbxRequestWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Request request = SelectedRequest();
            if (request != null)
            {
                Product product = productManager.GetById(request.ProductId);
                lbxStockWarehouse.Items.Clear();
                lbWarehouseQuantity.Items.Clear();
                lbxStockWarehouse.Items.Add(product);
                lbWarehouseQuantity.Items.Add(product.QuantityWarehouse);
            }
        }

        private void btnMyLeaveRequests_Click(object sender, EventArgs e)
        {
            TabWorker.SelectedTab = tabLeaveRequestsOverview;
            dgEmployeesRequests.DataSource = leaveRequestManager.GetLeaveRequestsTableEmployee(user.Id);
        }

        private void btnHomeFromLeaveRequests_Click(object sender, EventArgs e)
        {
            TabWorker.SelectedTab = tabWorkerHome;
        }

        private void btnBarcodeScanner_Click(object sender, EventArgs e)
        {
            TabWorker.SelectedTab = tabBarcodeScanner;

            List<Product> products = productManager.GetAllProductsList();
            lbProductsInSales.Items.Clear();

            foreach (Product product in products)
            {
                lbProductsInSales.Items.Add(product);
            }
        }

        int counter = 0;
        private void lbProductsInSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbScannedItemBarcode.Text = "";
            GeneratedBarcode MyBarCode = BarcodeWriter.CreateBarcode($"{SelectedProduct().Barcode}", BarcodeWriterEncoding.Code128);
            MyBarCode.SaveAsPng($"MyBarCode.png{counter}");
            tbScannedItemBarcode.Focus();

            pbSelectedItemBarcode.Image = Image.FromFile($"MyBarCode.png{counter}");

            counter++;
        }

        private void tbScannedItemBarcode_TextChanged(object sender, EventArgs e)
        {
            if (tbScannedItemBarcode.Text.Length == SelectedProduct().Barcode.ToString().Length)
            {
                overallScannedPrice += SelectedProduct().ProductPrice;
                tbOverallPrice.Text = $"€{overallScannedPrice}";
                lbScannedItems.Items.Add($"Name: {SelectedProduct().ProductName}, Price: {SelectedProduct().ProductPrice}, Sales quantity: {SelectedProduct().QuantitySales}");
                SelectedProduct().QuantitySales -= 1;
                productManager.Edit(SelectedProduct(), SelectedProduct().ProductName, SelectedProduct().ProductDescription, SelectedProduct().ProductPrice, SelectedProduct().ProductManufacturer, SelectedProduct().ProductCategory, SelectedProduct().QuantityWarehouse, SelectedProduct().QuantitySales, SelectedProduct().Barcode);
            }
        }

        private void btnClearScannedItemsList_Click(object sender, EventArgs e)
        {
            lbScannedItems.Items.Clear();
        }

        private void btnProductRepositoryHome_Click(object sender, EventArgs e)
        {
            TabWorker.SelectedTab = tabWorkerHome;
        }
    }
}
