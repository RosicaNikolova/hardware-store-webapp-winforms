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
    public partial class CategoriesForm : Form
    {
        CategoryManager categoryManager = new CategoryManager();

        public CategoriesForm()
        {
            InitializeComponent();
            foreach (Category category in categoryManager.GetCategories())
            {
                lbCategories.Items.Add(category.Name);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            lbCategories.Items.Clear();
            categoryManager.AddCategory(tbCategoryName.Text);
            foreach (Category category in categoryManager.GetCategories())
            {
                lbCategories.Items.Add(category.Name);
            }
        }
    }
}
