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

namespace MediaBazaarProject.Presentation
{
    public partial class AddEditProduct : Form
    {
        EnumManager enumManager = new EnumManager();
        CategoryManager categoryManager = new CategoryManager();
        ProductManager productManager = new ProductManager();
        private int optionForm;
        private Product productForUpdate;
        //for creating product

        public AddEditProduct(int option)
        {
            optionForm = option;
            InitializeComponent();
            btnAddEdit.Text = "Add";
            lblForm.Text = "Add Product Form";
            foreach (Category category in categoryManager.GetCategories())
            {
                cbCate.Items.Add(category.Name);
            }
        }
        //For editting
        public AddEditProduct(int option, Product product)
        {
            productForUpdate = product;
            optionForm = option;
            InitializeComponent();
            foreach (Category category in categoryManager.GetCategories())
            {
                cbCate.Items.Add(category.Name);
            }
            btnAddEdit.Text = "Edit";
            lblForm.Text = "Edit Product Form";
            tbName.Text = productForUpdate.ProductName;
            tbDesc.Text = productForUpdate.ProductDescription;
            tbPrPrice.Text = productForUpdate.ProductPrice.ToString();
            tbManu.Text = productForUpdate.ProductManufacturer;
            cbCate.Text = productForUpdate.ProductCategory.ToString();
            tbQWare.Text = productForUpdate.QuantityWarehouse.ToString();
            tbQSale.Text = productForUpdate.QuantitySales.ToString();
            tbBarcode.Text = productForUpdate.Barcode.ToString();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (tbName.Text != string.Empty && tbDesc.Text != string.Empty && tbManu.Text != string.Empty && cbCate.Text != string.Empty && tbQWare.Text != string.Empty && tbQSale.Text != string.Empty && tbBarcode.Text != string.Empty)
            {
                if (optionForm == 1)
                {
                    productManager.Create(tbName.Text, tbDesc.Text, Convert.ToDouble(tbPrPrice.Text), tbManu.Text, cbCate.Text, Convert.ToInt32(tbQWare.Text), Convert.ToInt32(tbQSale.Text), Convert.ToInt32(tbBarcode.Text));
                    MessageBox.Show("Product Added!!!");
                    this.Close();
                }
                else
                {
                    if (productForUpdate != null)
                    {
                        productManager.Edit(productForUpdate, tbName.Text, tbDesc.Text, Convert.ToDouble(tbPrPrice.Text), tbManu.Text, cbCate.Text, Convert.ToInt32(tbQWare.Text), Convert.ToInt32(tbQSale.Text), Convert.ToInt32(tbBarcode.Text));
                        MessageBox.Show("Product edited!!!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("There has been an error in the system.");
                        this.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Not all boxes were filled in!!!");
            }
        }

    }
}

