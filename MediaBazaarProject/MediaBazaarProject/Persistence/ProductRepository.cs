using MediaBazaarProject.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazaarProject.Persistence
{
    public class ProductRepository
    {
        EnumManager enumManager = new EnumManager();
        public List<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {

                string sql = "SELECT * FROM products ORDER BY ProductId";
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
                    product.ProductManufacturer= dr.GetString("ProductManufacturer");
                    product.QuantityWarehouse = dr.GetInt32("QuantityWarehouse");
                    product.QuantitySales= dr.GetInt32("QuantitySales");
                    product.ProductCategory = enumManager.GetProductCategory(dr.GetString("ProductCategory"));
                    allProducts.Add(product);
                }
            }

            return allProducts;
        }

        //public List<Product> GetProductsByCategory()
        //{

        //}

        //public Product GetProduct(int id)
        //{

        //}
        public void CreateProduct(Product product)
        {
            try 
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "insert into products (ProductName,ProductDesc,ProductManufacturer,QuantityWarehouse,QuantitySales,ProductCategory) values (@ProductName,@ProductDesc,@ProductManufacturer,@QuantityWarehouse,@QuantitySales,@ProductCategory)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("ProductDesc", product.ProductDescription);
                    cmd.Parameters.AddWithValue("ProductManufacturer", product.ProductManufacturer);
                    cmd.Parameters.AddWithValue("ProductCategory", product.ProductCategory);
                    cmd.Parameters.AddWithValue("QuantityWarehouse", product.QuantityWarehouse);
                    cmd.Parameters.AddWithValue("QuantitySales", product.QuantitySales);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            } catch {
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
                    string sql = "UPDATE products SET ProductName=@ProductName,ProductDesc=@ProductDesc,ProductManufacturer=@ProductManufacturer,QuantityWarehouse=@QuantityWarehouse,QuantitySales=@QuantitySales,ProductCategory=@ProductCategory where ProductId=@ProductId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("ProductDesc", product.ProductDescription);
                    cmd.Parameters.AddWithValue("ProductManufacturer", product.ProductManufacturer);
                    cmd.Parameters.AddWithValue("ProductCategory", product.ProductCategory);
                    cmd.Parameters.AddWithValue("QuantityWarehouse", product.QuantityWarehouse);
                    cmd.Parameters.AddWithValue("QuantitySales", product.QuantitySales);
                    cmd.Parameters.AddWithValue("ProductId", product.ProductId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch {
                throw new Exception("There has been an error in ProductRepository");
            }
        }

        public Product GetProductById(int id)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "SELECT * FROM products WHERE ProductId=@ProductId";

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
                    product.ProductManufacturer = dateReader.GetString("ProductManufacturer");
                    product.QuantitySales = dateReader.GetInt32("QuantitySales");
                    product.QuantityWarehouse = dateReader.GetInt32("QuantityWarehouse");
                }
                return product;
            }
        }

        //public bool DeleteProduct(Product product)
        //{

        //}

    }
}
