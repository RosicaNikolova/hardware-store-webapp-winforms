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

        public double ProductPrice { get; set; }

        public string ProductManufacturer { get; set; }

        public string ProductCategory { get; set; }

        public int QuantityWarehouse { get; set; }

        public int QuantitySales { get; set; }
        public int Barcode { get; set; }
        public override string ToString()
        {
            return $"{this.ProductId}, \t {this.ProductName}, \t {this.ProductPrice}, \t {this.ProductCategory}, \t {this.ProductManufacturer}";
        }

    }

}
