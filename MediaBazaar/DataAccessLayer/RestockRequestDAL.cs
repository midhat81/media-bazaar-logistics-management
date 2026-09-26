using DataAccessLayer.Interfaces;
using DTOLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
  public class RestockRequestDAL : Database, IRestockRequestDAL
    {
        public RestockRequestDAL() 
        {
        }

        public void AddRestockRequest(RestockRequestDTO request)
        {
            using (SqlConnection connection = OpenConnection())
            {
                SqlTransaction transaction = null;
                try
                {
                    transaction = connection.BeginTransaction();

                    string query = @"INSERT INTO dbo.RestockRequest (ProductId, RequestedQuantity, Status, RequestDate, ResponseDate, SenderName)
                             VALUES (@ProductId, @RequestedQuantity, @Status, @RequestDate, @ResponseDate, @SenderName)";

                    SqlCommand command = new SqlCommand(query, connection, transaction);
                    command.Parameters.AddWithValue("@ProductId", request.ProductId);
                    command.Parameters.AddWithValue("@RequestedQuantity", request.RequestedQuantity);
                    command.Parameters.AddWithValue("@Status", request.Status ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@RequestDate", request.RequestDate);
                    command.Parameters.AddWithValue("@ResponseDate", request.ResponseDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@SenderName", request.SenderName ?? (object)DBNull.Value);
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch
                {
                    transaction?.Rollback();
                    throw; 
                }
            }
        }
        public void DeleteRestockRequest(int requestId)
        {
            using (SqlConnection connection = OpenConnection())
            {
                SqlTransaction transaction = null;
                try
                {
                    transaction = connection.BeginTransaction();
                    string query = @"DELETE FROM dbo.RestockRequest WHERE RequestId = @RequestId";
                    SqlCommand command = new SqlCommand(query, connection, transaction);
                    command.Parameters.AddWithValue("@RequestId", requestId);
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch
                {
                    transaction?.Rollback();
                    throw;
                }
            }
        }

        public async Task<RestockRequestDTO> GetRestockRequestByUserAndProductAsync(string senderName, int productId)
        {
            RestockRequestDTO request = null;
            using (SqlConnection connection = OpenConnection())
            {
                string query = @"SELECT TOP 1 * FROM dbo.RestockRequest 
                         WHERE SenderName = @SenderName AND ProductId = @ProductId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SenderName", senderName);
                command.Parameters.AddWithValue("@ProductId", productId);

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        request = new RestockRequestDTO
                        {
                            RequestId = Convert.ToInt32(reader["RequestId"]),
                            ProductId = Convert.ToInt32(reader["ProductId"]),
                            RequestedQuantity = Convert.ToInt32(reader["RequestedQuantity"]),
                            Status = reader["Status"].ToString(),
                            RequestDate = Convert.ToDateTime(reader["RequestDate"]),
                            ResponseDate = reader.IsDBNull(reader.GetOrdinal("ResponseDate")) ? (DateTime?)null : Convert.ToDateTime(reader["ResponseDate"]),
                            SenderName = reader["SenderName"].ToString()
                        };
                    }
                }
            }
            return request;
        }

        public void UpdateRestockRequestStatus(int requestId, string status)
        {
            using (SqlConnection connection = OpenConnection())
            {
                SqlTransaction transaction = null;
                try
                {
                    transaction = connection.BeginTransaction();

                    string query = @"UPDATE dbo.RestockRequest
                             SET Status = @Status, ResponseDate = @ResponseDate
                             WHERE RequestId = @RequestId";

                    SqlCommand command = new SqlCommand(query, connection, transaction);
                    command.Parameters.AddWithValue("@RequestId", requestId);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@ResponseDate", DateTime.Now); 

                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch
                {
                    transaction?.Rollback();
                    throw;
                }
            }
        }


        public List<RestockRequestDTO> GetAllRestockRequests()
        {
            List<RestockRequestDTO> requests = new List<RestockRequestDTO>();

            using (SqlConnection connection = OpenConnection())
            {
                string query = @"SELECT rr.RequestId, rr.ProductId, p.Model as ProductName, rr.RequestedQuantity, rr.Status, rr.RequestDate, rr.ResponseDate, rr.SenderName
                         FROM dbo.RestockRequest rr
                         JOIN dbo.Product p ON rr.ProductId = p.Id"; 
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RestockRequestDTO request = new RestockRequestDTO
                        {
                            RequestId = Convert.ToInt32(reader["RequestId"]),
                            ProductId = Convert.ToInt32(reader["ProductId"]),
                            ProductName = reader["ProductName"].ToString(),
                            RequestedQuantity = Convert.ToInt32(reader["RequestedQuantity"]),
                            Status = reader["Status"].ToString(),
                            RequestDate = Convert.ToDateTime(reader["RequestDate"]),
                            ResponseDate = reader.IsDBNull(reader.GetOrdinal("ResponseDate")) ? (DateTime?)null : Convert.ToDateTime(reader["ResponseDate"]),
                            SenderName = reader.IsDBNull(reader.GetOrdinal("SenderName")) ? null : reader["SenderName"].ToString()
                        };
                        requests.Add(request);
                    }
                }
            }
            return requests;
        }
    }
}
