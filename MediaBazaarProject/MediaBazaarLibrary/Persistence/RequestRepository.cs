using MediaBazaarLibrary.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Persistence
{
    public class RequestRepository
    {
        EnumManager enumManager = new EnumManager();

        public List<Request> GetRequests()
        {
            List<Request> allRequests = new List<Request>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "SELECT employees.EmployeeId, products.ProductId, products.ProductName, request.RequestId, request.RequestedAmount, request.RequestStatus " +
                    "FROM request INNER JOIN products INNER JOIN employees " +
                    "ON request.ProductId = products.ProductId AND request.EmployeeId = employees.EmployeeID " +
                    "WHERE request.ProductId = products.ProductId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                Request request = null;
                while (dr.Read())
                {
                    request = new Request();
                    request.RequestId = dr.GetInt32("RequestId");
                    request.EmployeeId = dr.GetInt32("EmployeeId");
                    request.ProductId = dr.GetInt32("ProductId");
                    request.RequestedAmount = dr.GetInt32("RequestedAmount");
                    request.Status = enumManager.GetRequestStatus(dr.GetString("RequestStatus"));
                    allRequests.Add(request);
                }
            }
            return allRequests;
        }

        public void CreateRequest(Request request)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "INSERT into request (EmployeeId, ProductId, RequestedAmount, RequestStatus) VALUES(@EmployeeId, @ProductId, @RequestedAmount, @RequestStatus)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("EmployeeId", request.EmployeeId);
                    cmd.Parameters.AddWithValue("ProductId", request.ProductId);
                    cmd.Parameters.AddWithValue("RequestedAmount", request.RequestedAmount);
                    cmd.Parameters.AddWithValue("RequestStatus", request.Status.ToString());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw new Exception("There has been an error in RequestRepository");
            }

        }

        public void UpdateRequest(Request request)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "UPDATE request SET EmployeeId=@EmployeeId, ProductId=@ProductId, RequestedAmount=@RequestedAmount, RequestStatus=@RequestStatus where RequestId = @RequestId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("RequestId", request.RequestId);
                    cmd.Parameters.AddWithValue("EmployeeId", request.EmployeeId);
                    cmd.Parameters.AddWithValue("ProductId", request.ProductId);
                    cmd.Parameters.AddWithValue("RequestedAmount", request.RequestedAmount);
                    cmd.Parameters.AddWithValue("RequestStatus", request.Status.ToString());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw new Exception("There has been an error in RequestRepository");
            }
        }

        public List<RequestedItemsStatistics> GetRequestedItemsStatistics()
        {
            List<RequestedItemsStatistics> requestedItemsStatisticsList = new List<RequestedItemsStatistics>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "SELECT ProductName, COUNT(request.ProductId) AS 'Times requested' FROM request INNER JOIN products ON request.ProductId = products.ProductId GROUP BY ProductName";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                RequestedItemsStatistics requestedItemsStatistic = null;
                while (dr.Read())
                {
                    requestedItemsStatistic = new RequestedItemsStatistics();
                    requestedItemsStatistic.ProductName = dr.GetString("ProductName");
                    requestedItemsStatistic.Count = dr.GetInt32("Times requested");
                    requestedItemsStatisticsList.Add(requestedItemsStatistic);
                }
            }
            return requestedItemsStatisticsList;
        }

        public List<RequestedCategoriesStatistics> GetRequestedCategoriesStatistics()
        {
            List<RequestedCategoriesStatistics> requestedCategoriesStatisticsList = new List<RequestedCategoriesStatistics>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "SELECT category.categoryname AS 'categoryName', COUNT(products.ProductCategoryId) AS 'Times requested' FROM request INNER JOIN products ON request.ProductId=products.ProductId INNER JOIN category ON products.ProductCategoryId=category.categoryid GROUP BY category.categoryname";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                RequestedCategoriesStatistics requestedCategoriesStatistics = null;
                while (dr.Read())
                {
                    requestedCategoriesStatistics = new RequestedCategoriesStatistics();
                    requestedCategoriesStatistics.CategoryName = dr.GetString("categoryName");
                    requestedCategoriesStatistics.Count = dr.GetInt32("Times requested");
                    requestedCategoriesStatisticsList.Add(requestedCategoriesStatistics);
                }
            }
            return requestedCategoriesStatisticsList;
        }
    }
}
