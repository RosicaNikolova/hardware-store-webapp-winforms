using MediaBazaarLibrary.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Persistence
{
    public class Leave_Preference_RequestRepository
    {
        public int checkForNrOfRequestsAMonth(int employeeID, DateTime requestedDateMonth) {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "select COUNT(RequestID) as nrRequests from leave_requests where EmployeeID = @EmployeeID and EXTRACT(MONTH from RequestedDate) = EXTRACT(MONTH FROM @RequestedDateMonth)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("RequestedDateMonth", requestedDateMonth);
                cmd.Parameters.AddWithValue("EmployeeID", employeeID);

                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                int nrOFRequestsAMonth = 0;
                while (dr.Read())
                {
                    nrOFRequestsAMonth = dr.GetInt32("nrRequests");
                }
                return nrOFRequestsAMonth;
            }
        }
        public void saveRequest(LeaveRequest leaveRequest)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "insert into leave_requests (RequestedDate, EmployeeID, RequestStatus) values (@RequestedDate, @EmployeeID, @RequestStatus)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("RequestedDate", leaveRequest.RequestedDate);
                cmd.Parameters.AddWithValue("EmployeeID", leaveRequest.EmployeeID);
                cmd.Parameters.AddWithValue("RequestStatus", leaveRequest.RequestStatus);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public void updateRequest(LeaveRequest leaveRequest)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "update leave_requests set RequestID=@RequestID, RequestedDate=@RequestedDate, EmployeeID=@EmployeeID, RequestStatus=@RequestStatus where RequestID=@RequestID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("RequestID", leaveRequest.RequestID);
                cmd.Parameters.AddWithValue("RequestedDate", Convert.ToDateTime(leaveRequest.RequestedDate));
                cmd.Parameters.AddWithValue("EmployeeID", leaveRequest.EmployeeID);
                cmd.Parameters.AddWithValue("RequestStatus", leaveRequest.RequestStatus);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public List<LeaveRequest> getLeaveRequests()
        {
            List<LeaveRequest> allLeaveRequests = new List<LeaveRequest>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {

                string sql = "SELECT e.EmployeeID, RequestID, RequestStatus, RequestedDate from employees as e right join leave_requests as l_s on e.EmployeeID = l_s.EmployeeID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                
                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();


                LeaveRequest leaveRequest = null;
                while (dr.Read())
                {
                    leaveRequest = new LeaveRequest();
                    leaveRequest.EmployeeID = dr.GetInt32("EmployeeID");
                    leaveRequest.RequestID = dr.GetInt32("RequestID");
                    leaveRequest.RequestedDate = dr.GetDateTime("RequestedDate");
                    leaveRequest.RequestStatus = dr.GetString("RequestStatus");
                    allLeaveRequests.Add(leaveRequest);
                }
            }
            return allLeaveRequests;
        }
        public LeaveRequest getLeaveRequest(int requestID)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {

                string sql = "SELECT e.EmployeeID, RequestID, RequestStatus, RequestedDate " +
                    "from employees as e left join" +
                    " leave_requests as l_s on e.EmployeeID = l_s.EmployeeID " +
                    "where RequestID=@requestID ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("RequestID", requestID);
                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                

                LeaveRequest leaveRequest = null;
                while (dr.Read())
                {
                    leaveRequest = new LeaveRequest();
                    leaveRequest.EmployeeID = dr.GetInt32("EmployeeID");
                    leaveRequest.RequestID = dr.GetInt32("RequestID");
                    leaveRequest.RequestedDate = dr.GetDateTime("RequestedDate");
                    leaveRequest.RequestStatus = dr.GetString("RequestStatus");
                }
                return leaveRequest;
            }
            
        }
        //Adds a row to preferenceShifts table
        public void AddPreference(int employeeID, string requestedDateDay)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection()) {
                string sql = "Insert into prefered_shifts (EmployeeID, RequestedDateDay) values (@EmployeeID, @RequestedDateDay)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("RequestedDateDay", requestedDateDay);
                
                conn.Open();
                
                cmd.ExecuteNonQuery();
            }
        }

        public List<LeaveRequest> getLeaveRequestsEmployee(int employeeID)
        {
            List<LeaveRequest> allLeaveRequests = new List<LeaveRequest>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {

                string sql = "SELECT e.EmployeeID, RequestID, RequestStatus, RequestedDate from employees as e right join leave_requests as l_s on e.EmployeeID = l_s.EmployeeID where e.EmployeeID=@employeeID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("EmployeeID", employeeID);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();


                LeaveRequest leaveRequest = null;
                while (dr.Read())
                {
                    leaveRequest = new LeaveRequest();
                    leaveRequest.RequestID = dr.GetInt32("RequestID");
                    leaveRequest.RequestedDate = dr.GetDateTime("RequestedDate");
                    leaveRequest.RequestStatus = dr.GetString("RequestStatus");
                    allLeaveRequests.Add(leaveRequest);
                }
            }
            return allLeaveRequests;
        }
    }
}
