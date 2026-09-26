using DTOLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAL : Database
    {

        public void CreateProduct(ProductDTO product)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("INSERT INTO Product (Model, Brand, Price, Description, Weight, Height, Width, Depth, Category) " +
                    "VALUES (@Model, @Brand, @Price, @Description, @Weight, @Height, @Width, @Depth, @Category); " +
                    "INSERT INTO Stock (ProductId, Quantity) VALUES (SCOPE_IDENTITY(), @Stock)", connection);
                command.Parameters.AddWithValue("@Model", product.Model);
                command.Parameters.AddWithValue("@Brand", product.Brand);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Description", product.Description);
                command.Parameters.AddWithValue("@Weight", product.Weight);
                command.Parameters.AddWithValue("@Height", product.Height);
                command.Parameters.AddWithValue("@Width", product.Width);
                command.Parameters.AddWithValue("@Depth", product.Depth);
                command.Parameters.AddWithValue("@Category", product.Category);
                command.Parameters.AddWithValue("@Stock", product.Stock);
                command.ExecuteNonQuery();
            }
        }


        public ProductDTO GetProduct(int id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT P.*, S.Quantity FROM Product P LEFT JOIN Stock S ON P.Id = S.ProductId WHERE P.Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ProductDTO
                        {
                            Id = reader.GetInt32(0),
                            Model = reader.GetString(1),
                            Brand = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            Description = reader.GetString(4),
                            Weight = reader.GetDecimal(5),
                            Height = reader.GetDecimal(6),
                            Width = reader.GetDecimal(7),
                            Depth = reader.GetDecimal(8),
                            Category = (int)(ProductCategoryEum)reader.GetInt32(9),
                            Stock = reader.GetInt32(10)
                        };
                    }
                }
            }
            return null;
        }



        public void UpdateProduct(ProductDTO product)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("UPDATE Product SET Model = @Model, Brand = @Brand, Price = @Price, Description = @Description, Weight = @Weight, Height = @Height, Width = @Width, Depth = @Depth, Category = @Category WHERE Id = @Id; " +
                    "UPDATE Stock SET Quantity = @Stock WHERE ProductId = @Id", connection);
                command.Parameters.AddWithValue("@Id", product.Id);
                command.Parameters.AddWithValue("@Model", product.Model);
                command.Parameters.AddWithValue("@Brand", product.Brand);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Description", product.Description);
                command.Parameters.AddWithValue("@Weight", product.Weight);
                command.Parameters.AddWithValue("@Height", product.Height);
                command.Parameters.AddWithValue("@Width", product.Width);
                command.Parameters.AddWithValue("@Depth", product.Depth);
                command.Parameters.AddWithValue("@Category", product.Category);
                command.Parameters.AddWithValue("@Stock", product.Stock);
                command.ExecuteNonQuery();
            }
        }



        public void DeleteProduct(int id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("DELETE FROM Product WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }


        public List<ProductDTO> GetAllProducts()
        {
            var products = new List<ProductDTO>();

            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT P.*, S.Quantity FROM Product P LEFT JOIN Stock S ON P.Id = S.ProductId", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new ProductDTO
                        {
                            Id = reader.GetInt32(0),
                            Model = reader.GetString(1),
                            Brand = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            Description = reader.GetString(4),
                            Weight = reader.GetDecimal(5),
                            Height = reader.GetDecimal(6),
                            Width = reader.GetDecimal(7),
                            Depth = reader.GetDecimal(8),
                            Category = (int)(ProductCategoryEum)reader.GetInt32(9),
                            Stock = reader.IsDBNull(10) ? 0 : reader.GetInt32(10)
                        });
                    }
                }
            }

            return products;
        }
    }
}
