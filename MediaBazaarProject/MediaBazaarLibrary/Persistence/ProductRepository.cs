using MediaBazaarLibrary.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazaarLibrary.Persistence
{
    public class ProductRepository
    {
        EnumManager enumManager = new EnumManager();
        public List<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {

                string sql = "SELECT ProductId, ProductName, ProductDesc, ProductPrice, ProductManufacturer, QuantityWarehouse, QuantitySales, Barcode, category.categoryname AS CategoryName FROM products INNER JOIN category on ProductCategoryId=categoryid";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();


                Product product = null;
                while (dr.Read())
                {
                    product = new Product();
                    product.ProductId = dr.GetInt32("ProductId");
                    product.ProductName = dr.GetString("ProductName");
                    product.ProductDescription = dr.GetString("ProductDesc");
                    product.ProductPrice = dr.GetDouble("ProductPrice");
                    product.ProductManufacturer = dr.GetString("ProductManufacturer");
                    product.QuantityWarehouse = dr.GetInt32("QuantityWarehouse");
                    product.QuantitySales = dr.GetInt32("QuantitySales");
                    product.ProductCategory = dr.GetString("CategoryName");
                    product.Barcode = dr.GetInt32("Barcode");
                    allProducts.Add(product);
                }
            }

            return allProducts;
        }

        public void CreateProduct(Product product)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "insert into products (ProductName,ProductDesc,ProductPrice,ProductManufacturer,QuantityWarehouse,QuantitySales, Barcode) values (@ProductName,@ProductDesc,@ProductPrice,@ProductManufacturer,@QuantityWarehouse,@QuantitySales, @Barcode)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("ProductDesc", product.ProductDescription);
                    cmd.Parameters.AddWithValue("ProductPrice", product.ProductPrice);
                    cmd.Parameters.AddWithValue("ProductManufacturer", product.ProductManufacturer);
                    cmd.Parameters.AddWithValue("QuantityWarehouse", product.QuantityWarehouse);
                    cmd.Parameters.AddWithValue("QuantitySales", product.QuantitySales);
                    cmd.Parameters.AddWithValue("Barcode", product.Barcode);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    sql = "UPDATE products, category SET products.ProductCategoryId=category.categoryid WHERE products.ProductCategoryId=0 AND category.categoryname=@ProdCategoryName";
                    cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("ProdCategoryName", product.ProductCategory);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw new Exception("There has been an error in ProductRepository-CreateProductMethod"); //just for demo, shouldnt say which method
            }

        }

        public void RemoveProduct(Product product)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "Delete from products where ProductId = @ProductId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("ProductId", product.ProductId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw new Exception("There has been an error in ProductRepository-RemoveMethod"); //just for demo, shouldnt say which method
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "UPDATE products SET ProductName=@ProductName,ProductDesc=@ProductDesc,ProductPrice=@ProductPrice,ProductManufacturer=@ProductManufacturer,QuantityWarehouse=@QuantityWarehouse,QuantitySales=@QuantitySales, Barcode=@Barcode, ProductCategoryId=0 where ProductId=@ProductId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("ProductDesc", product.ProductDescription);
                    cmd.Parameters.AddWithValue("ProductPrice", product.ProductPrice);
                    cmd.Parameters.AddWithValue("ProductManufacturer", product.ProductManufacturer);
                    cmd.Parameters.AddWithValue("ProductCategory", product.ProductCategory);
                    cmd.Parameters.AddWithValue("QuantityWarehouse", product.QuantityWarehouse);
                    cmd.Parameters.AddWithValue("QuantitySales", product.QuantitySales);
                    cmd.Parameters.AddWithValue("ProductId", product.ProductId);
                    cmd.Parameters.AddWithValue("Barcode", product.Barcode);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    sql = "UPDATE products, category SET products.ProductCategoryId=category.categoryid WHERE products.ProductCategoryId=0 AND category.categoryname=@ProdCategoryName";
                    cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("ProdCategoryName", product.ProductCategory);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw new Exception("There has been an error in ProductRepository");
            }
        }

        public Product GetProductById(int id)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "SELECT ProductId, ProductName, ProductDesc, ProductPrice, ProductManufacturer, QuantityWarehouse, QuantitySales, Barcode, category.categoryname AS CategoryName FROM products INNER JOIN category on ProductCategoryId=categoryid WHERE ProductId=@ProductId";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ProductId", id);

                conn.Open();
                Product product = new Product();
                MySqlDataReader dateReader = cmd.ExecuteReader();

                while (dateReader.Read())
                {
                    product.ProductId = dateReader.GetInt32("ProductId");
                    product.ProductName = dateReader.GetString("ProductName");
                    product.ProductDescription = dateReader.GetString("ProductDesc");
                    product.ProductPrice = dateReader.GetDouble("ProductPrice");
                    product.ProductManufacturer = dateReader.GetString("ProductManufacturer");
                    product.ProductCategory = dateReader.GetString("CategoryName");
                    product.QuantitySales = dateReader.GetInt32("QuantitySales");
                    product.QuantityWarehouse = dateReader.GetInt32("QuantityWarehouse");
                    product.Barcode = dateReader.GetInt32("Barcode");


                }
                return product;
            }
        }
    }
}
