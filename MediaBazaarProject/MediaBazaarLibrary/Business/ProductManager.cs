using MediaBazaarLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class ProductManager
    {
        ProductRepository productRepository = new ProductRepository();
        EnumManager enumManager = new EnumManager();
        public List<Product> GetAllProductsList() {
            return productRepository.GetAllProducts();
        }
        public void Create(string prName, string prDesc, double prPrice, string prManu, string prCateg, int qWare, int qSale, int prBarcode)
        {
            try
            {
                if (productRepository.GetProductByBarcode(prBarcode) == false)
                {
                    Product product = new Product();
                    product.ProductName = prName;
                    product.ProductDescription = prDesc;
                    product.ProductPrice = prPrice;
                    product.ProductManufacturer = prManu;
                    product.ProductCategory = prCateg;
                    product.QuantityWarehouse = qWare;
                    product.QuantitySales = qSale;
                    product.Barcode = prBarcode;
                    productRepository.CreateProduct(product);
                }
                else {
                    throw new Exception("Barcode already exists!");
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public void Edit(Product updatedProduct, string prName, string prDesc, double prPrice, string prManu, string prCateg, int qWare, int qSale, int prBarcode)
        {
            try
            {
                Product product = updatedProduct;
                product.ProductName = prName;
                product.ProductDescription = prDesc;
                product.ProductPrice = prPrice;
                product.ProductManufacturer = prManu;
                product.ProductCategory = prCateg;
                product.QuantityWarehouse = qWare;
                product.QuantitySales = qSale;
                product.Barcode = prBarcode;
                productRepository.UpdateProduct(product);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }

        }
        public void Remove(Product removeProduct)
        {
            try
            {
                productRepository.RemoveProduct(removeProduct);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public Product GetById(int id)
        {
            return productRepository.GetProductById(id);
        }
    }
}
