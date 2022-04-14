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
        public EnumCategory ProductCategory { get; set; }

        public int QuantityWarehouse { get; set; }

        public int QuantitySales { get; set; }


        public override string ToString()
        {
            return $"ProductId: {this.ProductId}, Pr.Name: {this.ProductName},"; // SalesStock: {this.QuantitySales} Warehouse Stock: { this.QuantityWarehouse}
        }

        //public string ToWarehouse()
        //{   
        //    return $"ProductId: {this.ProductId}, Pr.Name: {this.ProductName}, WarehouseStock: {this.QuantityWarehouse}";
        //}
    }

}
