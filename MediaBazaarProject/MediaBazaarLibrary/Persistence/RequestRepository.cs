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
    }
}
