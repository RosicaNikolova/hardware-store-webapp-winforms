using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarProject.Business
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductManufacturer { get; set; }

        public string QuantityWarehouse { get; set; }

        public string QuantitySales { get; set; }

        public string ProductCategory { get; set; }
    }
}
