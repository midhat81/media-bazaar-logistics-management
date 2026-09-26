using DTOLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class WorksheetDAL : Database
    {
        private int _nextId = 1;
        public void CreateWorksheet(WorksheetDTO worksheet)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand(
                    "INSERT INTO EmployeeWorksheet (Id,TimeSlot, WeekDay, EmployeeId, WeekNr) " +
                    "VALUES (@Id, @TimeSlot, @WeekDay, @EmployeeId, @WeekNr)", connection);

                command.Parameters.AddWithValue("@Id", worksheet.Id);
                command.Parameters.AddWithValue("@TimeSlot", worksheet.TimeSlot);
                command.Parameters.AddWithValue("@WeekDay", worksheet.WeekDay);
                command.Parameters.AddWithValue("@EmployeeId", worksheet.EmployeeId);
                command.Parameters.AddWithValue("@WeekNr", worksheet.WeekNr);
                command.ExecuteNonQuery();
            }
        }
        public WorksheetDTO ReadWorksheet(int id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM EmployeeWorksheet WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new WorksheetDTO
                        (
                            (int)reader["Id"],
                            (int)reader["TimeSlot"],
                            (int)reader["WeekDay"],
                             reader["EmployeeId"] == DBNull.Value ? (int?)null : (int)reader["EmployeeId"],
                            (int)reader["WeekNr"]
                        );
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public void UpdateWorksheet(WorksheetDTO worksheet)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand(
                    "UPDATE EmployeeWorksheet SET TimeSlot = @TimeSlot, WeekDay = @WeekDay, " +
                    "EmployeeId = @EmployeeId, WeekNr = @WeekNr WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", worksheet.Id);
                command.Parameters.AddWithValue("@TimeSlot", worksheet.TimeSlot);
                command.Parameters.AddWithValue("@WeekDay", worksheet.WeekDay);
                command.Parameters.AddWithValue("@EmployeeId", worksheet.EmployeeId ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@WeekNr", worksheet.WeekNr);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteWorksheet(int id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("DELETE FROM EmployeeWorksheet WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public List<WorksheetDTO> GetAllWorksheets()
        {
            var worksheets = new List<WorksheetDTO>();
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM EmployeeWorksheet", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        worksheets.Add(new WorksheetDTO
                        (
                            (int)reader["Id"],
                            (int)reader["TimeSlot"],
                            (int)reader["WeekDay"],
                            reader["EmployeeId"] == DBNull.Value ? (int?)null : (int)reader["EmployeeId"],
                            (int) reader["WeekNr"]
                        ));
                    }
                }
            }
            return worksheets;
        }

        public int GetNextWorksheetId()
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT MAX(Id) FROM EmployeeWorksheet", connection);
                var result = command.ExecuteScalar();
                if (result is DBNull)
                {
                    return _nextId;
                }
                return (int)result + 1;
            }
        }
    }
}
