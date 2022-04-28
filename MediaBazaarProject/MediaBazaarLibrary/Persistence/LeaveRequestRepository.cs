using MediaBazaarLibrary.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Persistence
{
    public class LeaveRequestRepository
    {
        public void saveRequest(LeaveRequest leaveRequest)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "insert into leave_requests (RequestID, RequestedDate, EmployeeID, RequestStatus) values (@RequestID, @RequestedDate, @EmployeeID, @RequestStatus)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("RequestID", leaveRequest.RequestID);
                cmd.Parameters.AddWithValue("RequestedDate", leaveRequest.RequestedDate);
                cmd.Parameters.AddWithValue("EmployeeID", leaveRequest.EmployeeID);
                cmd.Parameters.AddWithValue("RequestStatus", leaveRequest.RequestStatus);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                cmd.ExecuteNonQuery();
            }
        }

        public void updateRequest(LeaveRequest leaveRequest)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "update leave_requests set (RequestID, RequestedDate, EmployeeID, )";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("RequestID", leaveRequest.RequestID);
                cmd.Parameters.AddWithValue("RequestedDate", leaveRequest.RequestedDate);
                cmd.Parameters.AddWithValue("EmployeeID", leaveRequest.EmployeeID);
                cmd.Parameters.AddWithValue("RequestStatus", leaveRequest.RequestStatus);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                cmd.ExecuteNonQuery();
            }
        }


        //public LeaveRequest getLeaveRequest(int leaveRequestID)
        //{
            
        //}
    }
}
