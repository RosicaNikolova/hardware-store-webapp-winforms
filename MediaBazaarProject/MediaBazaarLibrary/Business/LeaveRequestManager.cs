using MediaBazaarLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class LeaveRequestManager
    {
        LeaveRequestRepository leaveRequestRepository = new LeaveRequestRepository();
        public void sendRequest(int employeeID, DateTime requestedDate) {
            LeaveRequest leaveRequest = new LeaveRequest();
            leaveRequest.EmployeeID = employeeID;
            leaveRequest.RequestedDate = requestedDate;
            leaveRequest.RequestStatus = "PENDING";
            leaveRequestRepository.saveRequest(leaveRequest);
        }
        public void approveRequest(int leaveRequestID) {
            LeaveRequest leaveRequest = leaveRequestRepository.getLeaveRequest(leaveRequestID);
            leaveRequest.RequestStatus = "APPROVED";
            leaveRequestRepository.updateRequest(leaveRequest);
        }
        public void disapproveRequest(int leaveRequestID) {
            LeaveRequest leaveRequest = leaveRequestRepository.getLeaveRequest(leaveRequestID);
            leaveRequest.RequestStatus = "DISAPPROVED";
            leaveRequestRepository.updateRequest(leaveRequest);
        }
        public DataTable GetLeaveRequestsTable() {
            DataTable dt = new DataTable();
            dt.Columns.Add("EmployeeID".ToString());
            dt.Columns.Add("RequestID".ToString());
            dt.Columns.Add("RequestedDate".ToString());
            dt.Columns.Add("RequestStatus".ToString());
            foreach (var leaveRequest in leaveRequestRepository.getLeaveRequests())
            {
                DataRow dr = dt.NewRow();
                dr["EmployeeID"] = leaveRequest.EmployeeID;
                dr["RequestID"] = leaveRequest.RequestID;
                dr["RequestedDate"] = leaveRequest.RequestedDate;
                dr["RequestStatus"] = leaveRequest.RequestStatus;
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
