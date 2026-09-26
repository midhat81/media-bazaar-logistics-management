using DTOLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DepartmentDAL: Database
    {
        public void CreateDepartment(DepartmentDTO department)
        {
            using (var connection = OpenConnection())
            {
                var transaction = connection.BeginTransaction();

                try
                {
                    var command = new SqlCommand(
                        "INSERT INTO Departments (Name, Description, PointOfContact) VALUES (@Name, @Description, @PointOfContact); SELECT SCOPE_IDENTITY();", connection, transaction);
                    command.Parameters.AddWithValue("@Name", department.Name);
                    command.Parameters.AddWithValue("@Description", department.Description);
                    command.Parameters.AddWithValue("@PointOfContact", department.PointOfContact);

                    department.Id = Convert.ToInt32(command.ExecuteScalar());

                    foreach (var rp in department.RequiredPersonnel)
                    {
                        var rpCommand = new SqlCommand(
                            "INSERT INTO RequiredPersonnel (DepartmentId, RoleId, NumberOfEmployees) VALUES (@DepartmentId, @RoleId, @NumberOfEmployees)", connection, transaction);
                        rpCommand.Parameters.AddWithValue("@DepartmentId", department.Id);
                        rpCommand.Parameters.AddWithValue("@RoleId", rp.Key);
                        rpCommand.Parameters.AddWithValue("@NumberOfEmployees", rp.Value);
                        rpCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public DepartmentDTO ReadDepartment(int id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM Departments WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var department = new DepartmentDTO(
                            (int)reader["Id"],
                            reader["Name"].ToString(),
                            reader["Description"].ToString(),
                            reader["PointOfContact"].ToString()
                        );

                        reader.Close();

                        var rpCommand = new SqlCommand("SELECT RoleId, NumberOfEmployees FROM RequiredPersonnel WHERE DepartmentId = @DepartmentId", connection);
                        rpCommand.Parameters.AddWithValue("@DepartmentId", id);

                        using (var rpReader = rpCommand.ExecuteReader())
                        {
                            while (rpReader.Read())
                            {
                                department.RequiredPersonnel.Add((int)rpReader["RoleId"], (int)rpReader["NumberOfEmployees"]);
                            }
                        }

                        return department;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public void UpdateDepartment(DepartmentDTO department)
        {
            using (var connection = OpenConnection())
            {
                var transaction = connection.BeginTransaction();

                try
                {
                    var command = new SqlCommand(
                        "UPDATE Departments SET Name = @Name, Description = @Description, PointOfContact = @PointOfContact WHERE Id = @Id", connection, transaction);
                    command.Parameters.AddWithValue("@Id", department.Id);
                    command.Parameters.AddWithValue("@Name", department.Name);
                    command.Parameters.AddWithValue("@Description", department.Description);
                    command.Parameters.AddWithValue("@PointOfContact", department.PointOfContact);
                    command.ExecuteNonQuery();

                    var deleteCommand = new SqlCommand("DELETE FROM RequiredPersonnel WHERE DepartmentId = @DepartmentId", connection, transaction);
                    deleteCommand.Parameters.AddWithValue("@DepartmentId", department.Id);
                    deleteCommand.ExecuteNonQuery();

                    foreach (var rp in department.RequiredPersonnel)
                    {
                        var rpCommand = new SqlCommand(
                            "INSERT INTO RequiredPersonnel (DepartmentId, RoleId, NumberOfEmployees) VALUES (@DepartmentId, @RoleId, @NumberOfEmployees)", connection, transaction);
                        rpCommand.Parameters.AddWithValue("@DepartmentId", department.Id);
                        rpCommand.Parameters.AddWithValue("@RoleId", rp.Key);
                        rpCommand.Parameters.AddWithValue("@NumberOfEmployees", rp.Value);
                        rpCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void DeleteDepartment(int id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("DELETE FROM Departments WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        public List<DepartmentDTO> GetAllDepartments()
        {
            var departments = new List<DepartmentDTO>();
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM Departments", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var department = new DepartmentDTO(
                            (int)reader["Id"],
                            reader["Name"].ToString(),
                            reader["Description"].ToString(),
                            reader["PointOfContact"].ToString()
                        );

                        departments.Add(department);
                    }
                }

                foreach (var department in departments)
                {
                    var rpCommand = new SqlCommand("SELECT RoleId, NumberOfEmployees FROM RequiredPersonnel WHERE DepartmentId = @DepartmentId", connection);
                    rpCommand.Parameters.AddWithValue("@DepartmentId", department.Id);

                    using (var rpReader = rpCommand.ExecuteReader())
                    {
                        while (rpReader.Read())
                        {
                            department.RequiredPersonnel.Add((int)rpReader["RoleId"], (int)rpReader["NumberOfEmployees"]);
                        }
                    }
                }
            }
            return departments;
        }

        public int GetNextId()
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT MAX(Id) FROM Departments", connection);
                object result = command.ExecuteScalar();
                return (result is DBNull) ? 1 : (int)result + 1;
            }
        }
    }
}
