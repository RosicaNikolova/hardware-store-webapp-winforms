using MediaBazaarLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class CategoryManager
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        public List<Category> GetCategories()
        {
            return categoryRepository.GetCategories();
        }

        public void AddCategory(string name)
        {
            categoryRepository.AddCategory(name);
        }
    }
}
