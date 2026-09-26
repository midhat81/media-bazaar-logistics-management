using BusinessLogicLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Interfaces;
using DTOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class RestockRequestManager : IRestockRequestManager
    {
        private IRestockRequestDAL restockRequestDAL;
        public RestockRequestManager(IRestockRequestDAL restockRequestDal)
        {
            this.restockRequestDAL = restockRequestDal ?? throw new ArgumentNullException(nameof(restockRequestDAL));
        }

        public void AddRestockRequest(RestockRequestDTO request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (request.ProductId <= 0) throw new ArgumentException("Invalid Product ID.");
            if (request.RequestedQuantity <= 0) throw new ArgumentException("Requested quantity must be greater than zero.");

            try
            {
                restockRequestDAL.AddRestockRequest(request);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while adding the restock request.", ex);
            }
        }

        public void DeleteRestockRequest(int requestId)
        {
            if (requestId <= 0) throw new ArgumentException("Invalid Request ID.");
            try
            {
                restockRequestDAL.DeleteRestockRequest(requestId);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while deleting the restock request.", ex);
            }
        }

        public void ApproveRestockRequest(int requestId)
        {
            if (requestId <= 0) throw new ArgumentException("Invalid Request ID.");
            restockRequestDAL.UpdateRestockRequestStatus(requestId, "Approved");
        }
        public async Task<RestockRequestDTO> GetRestockRequestByUserAndProductAsync(string senderName, int productId)
        {
            return await restockRequestDAL.GetRestockRequestByUserAndProductAsync(senderName, productId);
        }

        public void DenyRestockRequest(int requestId)
        {
            if (requestId <= 0) throw new ArgumentException("Invalid Request ID.");
            restockRequestDAL.UpdateRestockRequestStatus(requestId, "Denied");
        }

        public List<RestockRequestDTO> GetAllRestockRequests()
        {
            return restockRequestDAL.GetAllRestockRequests();
        }
    }
}
