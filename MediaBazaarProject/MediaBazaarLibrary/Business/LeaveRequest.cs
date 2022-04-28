using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class LeaveRequest
    {
        public int RequestID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime RequestedDate { get; set; }
        public string RequestStatus { get; set; }
    }
}
