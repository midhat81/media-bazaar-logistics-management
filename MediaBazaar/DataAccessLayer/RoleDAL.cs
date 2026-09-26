using DTOLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RoleDAL:Database
    {
        public void CreateRole(RoleDTO role)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand(
                    "INSERT INTO Role (Name) VALUES (@Name)", connection);
              
                command.Parameters.AddWithValue("@Name", role.Role);
                command.ExecuteNonQuery();
            }
        }

        public RoleDTO GetRoleById(int id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM Role WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new RoleDTO
                        (
                            (int)reader["Id"],
                            reader["Name"].ToString()
                        );
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public void UpdateRole(RoleDTO role)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand(
                    "UPDATE Role SET Name = @Name WHERE Id = @Id", connection);

                command.Parameters.AddWithValue("@Id", role.Id);
                command.Parameters.AddWithValue("@Name", role.Role);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteRole(int id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("DELETE FROM Role WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        public List<RoleDTO> GetAllRoles()
        {
            var roles = new List<RoleDTO>();
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM Role", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        roles.Add(new RoleDTO
                        (
                            (int)reader["Id"],
                            reader["Name"].ToString()
                        ));
                    }
                }
            }
            return roles;
        }

       

    }
}
