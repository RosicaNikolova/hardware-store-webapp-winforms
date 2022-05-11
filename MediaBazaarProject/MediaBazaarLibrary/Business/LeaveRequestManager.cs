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
            DateTime today = DateTime.Today;
            if (requestedDate.Day >= today.Day + 2)
            {
                if (requestedDate.Month >= DateTime.Today.Month)
                {
                    if (leaveRequestRepository.checkForNrOfRequestsAMonth(employeeID, requestedDate) < 2)
                    {
                        LeaveRequest leaveRequest = new LeaveRequest();
                        leaveRequest.EmployeeID = employeeID;
                        leaveRequest.RequestedDate = requestedDate;
                        leaveRequest.RequestStatus = "PENDING";
                        leaveRequestRepository.saveRequest(leaveRequest);
                    }
                    else
                    {
                        throw new Exception("You have already requested max limit(2)");
                    }
                }
                else
                {
                    throw new Exception("Requested date must be atleast two days in advance");
                }
            }
            else
            {
                throw new Exception("Requested date must be atleast two days in advance");
            }
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
        //this one is for admin, sees all employee requests
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
        //This one is for Worker form, here employee sees only his leaverequests
        public DataTable GetLeaveRequestsTableEmployee(int employeeID)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RequestID".ToString());
            dt.Columns.Add("RequestedDate".ToString());
            dt.Columns.Add("RequestStatus".ToString());
            foreach (var leaveRequest in leaveRequestRepository.getLeaveRequestsEmployee(employeeID))
            {
                DataRow dr = dt.NewRow();
                dr["RequestID"] = leaveRequest.RequestID;
                dr["RequestedDate"] = leaveRequest.RequestedDate;
                dr["RequestStatus"] = leaveRequest.RequestStatus;
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
