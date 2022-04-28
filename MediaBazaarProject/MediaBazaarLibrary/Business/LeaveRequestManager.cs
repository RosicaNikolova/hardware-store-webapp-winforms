using MediaBazaarLibrary.Persistence;
using System;
using System.Collections.Generic;
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
            leaveRequestRepository.saveRequest(leaveRequest);
        }
        public void disapproveRequest(int leaveRequestID) {
            LeaveRequest leaveRequest = leaveRequestRepository.getLeaveRequest(leaveRequestID);
            leaveRequest.RequestStatus = "DISAPPROVED";
            leaveRequestRepository.saveRequest(leaveRequest);
        }
    }
}
