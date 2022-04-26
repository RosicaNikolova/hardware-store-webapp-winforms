using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductManufacturer { get; set; }

        public string ProductCategory { get; set; }

        public int QuantityWarehouse { get; set; }

        public int QuantitySales { get; set; }
        public override string ToString()
        {
            return $"Product Id: {this.ProductId}, Product Name: {this.ProductName}, Category: {this.ProductCategory}, Manufacturer: {this.ProductManufacturer}";
        }

    }

}
