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
        ProductManager productManager = new ProductManager();

        public CategoriesForm()
        {
            InitializeComponent();
            foreach (string category in productManager.GetAllCategories())
            {
                lbCategories.Items.Add(category);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            
        }
    }
}
