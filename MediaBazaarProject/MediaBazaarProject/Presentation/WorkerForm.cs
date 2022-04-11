using MediaBazaarProject.Business;
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
        string role = string.Empty;
        public WorkerForm()
        {
            InitializeComponent();
        }

        public WorkerForm(User u,string role)
        {
            InitializeComponent();
            this.role = role;
            user = u;
            if(role == "sales")
            {
                btnWarehouse.Visible = false;
            }
            else if(role == "warehouse")
            {
                btnSales.Visible = false;
            }
        }

        private Product SelectedProduct()
        {
            if(TabWorker.SelectedTab == tabSales)
            {
                Product product;

                object selectedProduct = lbxStockSales.SelectedItem;
                product = (Product)selectedProduct;
                return product;
            }
            else if(TabWorker.SelectedTab == tabWarehouse)
            {
                Product product;

                object selectedProduct = lbxStockWarehouse.SelectedItem;
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

             DateTime date=dateWorker.Value;

            foreach (Shift shift in shiftManager.GetShiftsForWorker(date, user.Id))
            {
                lbxShiftEmployeeDay.Items.Add(shift.ShiftType.ToString());
            }
        }

        private void dateWorker_ValueChanged(object sender, EventArgs e)
        {
            lbxShiftEmployeeDay.Items.Clear();

            DateTime date = new DateTime();
            date = dateWorker.Value;

            foreach (Shift shift in shiftManager.GetShiftsForWorker(date, user.Id))
            {
                lbxShiftEmployeeDay.Items.Add(shift.ShiftType.ToString());
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
            List<Request> requests = requestManager.GetAllRequestsList();
            lbxRequestSales.Items.Clear();
            lbxStockSales.Items.Clear();
            foreach (Request r in requests)
            {
                lbxRequestSales.Items.Add(r);
            }
            foreach(Product p in products)
            {
                lbxStockSales.Items.Add(p/*.ToSales()*/);
            }
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            TabWorker.SelectedTab = tabWarehouse;
            List<Product> products = productManager.GetAllProductsList();
            List<Request> requests = requestManager.GetAllRequestsList();
            lbxRequestWarehouse.Items.Clear();
            lbxStockWarehouse.Items.Clear();
            foreach (Request r in requests)
            {
                lbxRequestWarehouse.Items.Add(r);
            }
            foreach(Product p in products)
            {
                lbxStockWarehouse.Items.Add(p/*.ToWarehouse()*/);
            }
        }

        private void btnRequestItem_Click(object sender, EventArgs e)
        {
            Product product = SelectedProduct();
            requestManager.Create(user.Id,product.ProductId,Convert.ToInt32(nudAmountSales.Value),EnumRequestStatus.PENDING);
            MessageBox.Show("Item has been requested");
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            Product product = SelectedProduct();
            productManager.Edit(product, product.ProductName, product.ProductDescription, product.ProductManufacturer, product.ProductCategory, product.QuantityWarehouse + Convert.ToInt32(nudAmountWarehouse.Value), product.QuantitySales);
            MessageBox.Show("Stock has been added");
        }

        private void btnAcceptRequest_Click(object sender, EventArgs e)
        {
            //Request request = SelectedRequest();
            //Product product = SelectedProduct();
            
            //if(request.RequestedAmount <= product.QuantityWarehouse)
            //{
            //    requestManager.Edit(request, request.EmployeeId, request.ProductId, request.RequestedAmount, EnumRequestStatus.ACCEPTED);
            //    productManager.Edit(product, product.ProductName, product.ProductDescription, product.ProductManufacturer, product.ProductCategory, product.QuantityWarehouse - request.RequestedAmount, product.QuantitySales + request.RequestedAmount);
            //    MessageBox.Show("Request has been Accepted");
            //}
            //else if(request.RequestedAmount > product.QuantityWarehouse && product.QuantityWarehouse > 0)
            //{
            //    int dif = Math.Abs(product.QuantityWarehouse - request.RequestedAmount);
            //    requestManager.Edit(request, request.EmployeeId, request.ProductId, request.RequestedAmount, EnumRequestStatus.PARTIALLY);
            //    productManager.Edit(product, product.ProductName, product.ProductDescription, product.ProductManufacturer, product.ProductCategory, product.QuantityWarehouse - request.RequestedAmount + dif, product.QuantitySales + request.RequestedAmount - dif);
            //    MessageBox.Show("Request has been  partially Accepted");
            //}
            
        }

        private void btnRejectRequest_Click(object sender, EventArgs e)
        {
            Request request = SelectedRequest();
            requestManager.Edit(request, request.EmployeeId,request.ProductId,request.RequestedAmount, EnumRequestStatus.REJECTED);
            MessageBox.Show("Request has been denied");
        }
    }
}
