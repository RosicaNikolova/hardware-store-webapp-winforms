using MediaBazaarLibrary.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Persistence
{
    public class CategoryRepository
    {
        public List<Category> GetCategories()
        {
            try
            {
                List<Category> allCategories = new List<Category>();
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {

                    string sql = "SELECT categoryname FROM category";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();


                    Category category;
                    while (dr.Read())
                    {
                        category = new Category();
                        category.Name = dr.GetString("categoryname");
                        allCategories.Add(category);
                    }
                }

                return allCategories;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public void AddCategory(string name)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "INSERT INTO category (categoryname) VALUES (@categoryname)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("categoryname", name);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
