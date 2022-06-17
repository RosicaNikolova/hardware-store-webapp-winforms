using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class Request
    {
        public int RequestId { get; set; }

        public int EmployeeId { get; set; }

        public int ProductId { get; set; }

        public int RequestedAmount { get; set; }

        public EnumRequestStatus Status { get; set; }

        public string Reason {get; set;}

        public override string ToString()
        {
            return $"RequestId: {this.RequestId}, Requested by: {this.EmployeeId}, RequestedItem: {this.ProductId}, AmountRequested: {this.RequestedAmount}, Status: {this.Status}, {this.Reason}";
        }
    }
}
