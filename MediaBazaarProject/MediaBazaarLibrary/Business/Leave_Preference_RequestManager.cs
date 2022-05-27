using MediaBazaarLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class Leave_Preference_RequestManager
    {
        Leave_Preference_RequestRepository leave_preference_RequestRepository = new Leave_Preference_RequestRepository();
        public void sendRequest(int employeeID, DateTime requestedDate)
        {
            DateTime today = DateTime.Today;
            if (requestedDate.Day >= today.Day + 2 && requestedDate.Month >= DateTime.Today.Month)
            {
                if (leave_preference_RequestRepository.checkForNrOfRequestsAMonth(employeeID, requestedDate) < 2)
                {
                    LeaveRequest leaveRequest = new LeaveRequest();
                    leaveRequest.EmployeeID = employeeID;
                    leaveRequest.RequestedDate = requestedDate;
                    leaveRequest.RequestStatus = "PENDING";
                    leave_preference_RequestRepository.saveRequest(leaveRequest);
                }
                else
                {
                    throw new Exception("You have already requested max limit(2)");
                }
            }
            else if (requestedDate.Month > DateTime.Today.Month)
            {
                if (leave_preference_RequestRepository.checkForNrOfRequestsAMonth(employeeID, requestedDate) < 2)
                {
                    LeaveRequest leaveRequest = new LeaveRequest();
                    leaveRequest.EmployeeID = employeeID;
                    leaveRequest.RequestedDate = requestedDate;
                    leaveRequest.RequestStatus = "PENDING";
                    leave_preference_RequestRepository.saveRequest(leaveRequest);
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
        public void approveRequest(int leaveRequestID)
        {
            LeaveRequest leaveRequest = leave_preference_RequestRepository.getLeaveRequest(leaveRequestID);
            leaveRequest.RequestStatus = "APPROVED";
            leave_preference_RequestRepository.updateRequest(leaveRequest);
        }
        public void disapproveRequest(int leaveRequestID)
        {
            LeaveRequest leaveRequest = leave_preference_RequestRepository.getLeaveRequest(leaveRequestID);
            leaveRequest.RequestStatus = "DISAPPROVED";
            leave_preference_RequestRepository.updateRequest(leaveRequest);
        }
        //this one is for admin, sees all employee requests
        public DataTable GetLeaveRequestsTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("EmployeeID".ToString());
            dt.Columns.Add("RequestID".ToString());
            dt.Columns.Add("RequestedDate".ToString());
            dt.Columns.Add("RequestStatus".ToString());
            foreach (var leaveRequest in leave_preference_RequestRepository.getLeaveRequests())
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
            foreach (var leaveRequest in leave_preference_RequestRepository.getLeaveRequestsEmployee(employeeID))
            {
                DataRow dr = dt.NewRow();
                dr["RequestID"] = leaveRequest.RequestID;
                dr["RequestedDate"] = leaveRequest.RequestedDate;
                dr["RequestStatus"] = leaveRequest.RequestStatus;
                dt.Rows.Add(dr);
            }
            return dt;
        }
        //Add preference request
        public void AddPreferenceRequest(int employeeID, string requestedDateDay)
        {
            string today = DateTime.Today.ToString("dddd");
            //You can ask for the prefered shift any day but Friday
            if(today != "Thursday")
            {
                leave_preference_RequestRepository.AddPreference(employeeID, requestedDateDay);
            }
            //if (requestedDate.Day > today.Day + 7 && requestedDate.Month >= DateTime.Today.Month)
            //{
            //    leave_preference_RequestRepository.AddPreference(employeeID, requestedDate);
            //}
            //else if (requestedDate.Month > DateTime.Today.Month)
            //{
            //    leave_preference_RequestRepository.AddPreference(employeeID, requestedDate);
            //}
            else {
                //throw new Exception("You have to ask for prefered shift in advance(at least 7 days in advance)!");
                throw new Exception("You cannot request for prefered shift today, the schedule is being made, try tomorrow!");
            }

        }
    }
}
