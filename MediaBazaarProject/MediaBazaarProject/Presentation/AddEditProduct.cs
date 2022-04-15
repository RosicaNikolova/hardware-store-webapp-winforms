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
            foreach (var item in enumManager.ListCategories())
            {
                cbCate.Items.Add(item.ToString());
            }
        }
        //For editting
        public AddEditProduct(int option, Product product)
        {
            productForUpdate = product;
            optionForm = option;
            InitializeComponent();
            foreach (var item in enumManager.ListCategories())
            {
                cbCate.Items.Add(item.ToString());
            }
            btnAddEdit.Text = "Edit";
            lblForm.Text = "Edit Product Form";
            tbName.Text = productForUpdate.ProductName;
            tbDesc.Text = productForUpdate.ProductDescription;
            tbManu.Text = productForUpdate.ProductManufacturer;
            cbCate.Text = productForUpdate.ProductCategory.ToString();
            tbQWare.Text = productForUpdate.QuantityWarehouse.ToString();
            tbQSale.Text = productForUpdate.QuantitySales.ToString();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (tbName.Text != string.Empty && tbDesc.Text != string.Empty && tbManu.Text != string.Empty && cbCate.Text != string.Empty && tbQWare.Text != string.Empty && tbQSale.Text != string.Empty)
            {
                if (optionForm == 1)
                {
                    productManager.Create(tbName.Text, tbDesc.Text, tbManu.Text, enumManager.GetProductCategory(cbCate.Text), Convert.ToInt32(tbQWare.Text), Convert.ToInt32(tbQSale.Text));
                    MessageBox.Show("Product Added!!!");
                    this.Close();
                }
                else
                {
                    if (productForUpdate != null)
                    {
                        productManager.Edit(productForUpdate, tbName.Text, tbDesc.Text, tbManu.Text, enumManager.GetProductCategory(cbCate.Text), Convert.ToInt32(tbQWare.Text), Convert.ToInt32(tbQSale.Text));
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

