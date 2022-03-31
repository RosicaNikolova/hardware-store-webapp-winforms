﻿using MediaBazaarProject.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarProject.Business
{
    class ProductManager
    {
        ProductRepository productRepository = new ProductRepository();
        EnumManager enumManager = new EnumManager();
        public List<Product> GetAllProductsList() {
            return productRepository.GetAllProducts();
        }
        public void Create(string prName, string prDesc, string prManu, EnumCategory prCateg, int qWare, int qSale)
        {
            try
            {
                Product product = new Product();
                product.ProductName = prName;
                product.ProductDescription = prDesc;
                product.ProductManufacturer = prManu;
                product.ProductCategory = prCateg;
                product.QuantityWarehouse = qWare;
                product.QuantitySales = qSale;
                productRepository.CreateProduct(product);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        internal void Edit(Product updatedProduct, string prName, string prDesc, string prManu, EnumCategory prCateg, int qWare, int qSale)
        {
            try
            {
                Product product = updatedProduct;
                product.ProductName = prName;
                product.ProductDescription = prDesc;
                product.ProductManufacturer = prManu;
                product.ProductCategory = prCateg;
                product.QuantityWarehouse = qWare;
                product.QuantitySales = qSale;
                productRepository.UpdateProduct(product);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }

        }
    }
}