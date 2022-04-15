using MediaBazaarLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class RequestManager
    {
        RequestRepository requestRepository = new RequestRepository();
        EnumManager enumManager = new EnumManager();
        public List<Request> GetAllRequestsList()
        {
            return requestRepository.GetRequests();
        }

        public void Create(int empId, int productId, int requestAmount, EnumRequestStatus status)
        {
            try
            {
                Request request = new Request();
                request.EmployeeId = empId;
                request.ProductId = productId;
                request.RequestedAmount = requestAmount;
                request.Status = status;
                requestRepository.CreateRequest(request);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public void Edit(Request updateRequest, int empId, int productId, int requestAmount, EnumRequestStatus status)
        {
            try
            {
                Request request = updateRequest;
                request.EmployeeId = empId;
                request.ProductId = productId;
                request.RequestedAmount = requestAmount;
                request.Status = status;
                requestRepository.UpdateRequest(request);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
    }
}
