using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer;

namespace DataAccessLayer.Interfaces
{
    public interface IRestockRequestDAL
    {
        void AddRestockRequest(RestockRequestDTO request);
        void UpdateRestockRequestStatus(int requestId, string status);
        void DeleteRestockRequest(int requestId);
        List<RestockRequestDTO> GetAllRestockRequests();
        Task<RestockRequestDTO> GetRestockRequestByUserAndProductAsync(string senderName, int productId);
    }
}
