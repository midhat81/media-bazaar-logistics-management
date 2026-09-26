using DTOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface IRestockRequestManager
    {
        void AddRestockRequest(RestockRequestDTO request);
        void ApproveRestockRequest(int requestId);
        void DenyRestockRequest(int requestId);
        List<RestockRequestDTO> GetAllRestockRequests();
        Task<RestockRequestDTO> GetRestockRequestByUserAndProductAsync(string senderName, int productId);
    }
}
