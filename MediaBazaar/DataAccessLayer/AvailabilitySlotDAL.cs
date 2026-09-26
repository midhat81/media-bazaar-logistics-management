using DTOLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AvailabilitySlotDAL : Database
    {
        public void CreateSlot(AvailabilitySlotDTO availabilitySlot)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand(
                    "INSERT INTO Availability (ContractId, WorkingTimeId, Date) VALUES (@ContractId, @TimeslotID, @Date)", connection);
                command.Parameters.AddWithValue("@ContractID", availabilitySlot.ContractID);
                command.Parameters.AddWithValue("@TimeSlotID", availabilitySlot.TimeSlotID);
                command.Parameters.AddWithValue("@Date", availabilitySlot.Date.Date); // Use Date property for just date

                command.ExecuteNonQuery();
            }
        }

        public List<AvailabilitySlotDTO> GetAvailabilitySlotsPerContract(int contractID) 
        {
            var slots = new List<AvailabilitySlotDTO>();
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT ContractId, WorkingTimeId, Date FROM Availability WHERE ContractId= @ContractId", connection);
                command.Parameters.AddWithValue("@ContractId", contractID);

                using ( var reader = command.ExecuteReader()) 
                {
                    while(reader.Read())
                    {
                        slots.Add(new AvailabilitySlotDTO(
                            
                            (int)reader["ContractId"],
                            (int)reader["WorkingTimeId"],
                            (DateTime)reader["Date"],
                            true
                            ));
                    }
                }
            }
            return slots;
        }

        public List<AvailabilitySlotDTO> GetAvailabilitySlots()
        {
            var slots = new List<AvailabilitySlotDTO>();
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM Availability" , connection);
                

                using ( var reader = command.ExecuteReader()) 
                {
                    while(reader.Read())
                    {
                        slots.Add(new AvailabilitySlotDTO(
                            
                            (int)reader["ContractId"],
                            (int)reader["WorkingTimeId"],
                            (DateTime)reader["Date"],
                            true
                            ));
                    }
                }
            }
            return slots;
        }

        public void DeleteAvailabilitySlots(int Id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("DELETE FROM Availability WHERE ContractId = @Id", connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.ExecuteNonQuery();

            }

        }

        public void DeleteAvailabilitySlots(int Id, DateTime currentMonth, DateTime? specificMonth)
        {
            using (var connection = OpenConnection())
            {
                string query;

                if (specificMonth.HasValue)
                {
                    query = "DELETE FROM Availability WHERE ContractId = @Id AND " +
                            "DATEPART(year, Date) = @SpecificYear AND " +
                            "DATEPART(month, Date) = @SpecificMonth";
                }
                else
                {
                    query = "DELETE FROM Availability WHERE ContractId = @Id AND Date < @CurrentMonthStart";
                }

                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);

                if (specificMonth.HasValue)
                {
                    command.Parameters.AddWithValue("@SpecificYear", specificMonth.Value.Year);
                    command.Parameters.AddWithValue("@SpecificMonth", specificMonth.Value.Month);
                }
                else
                {
                    command.Parameters.AddWithValue("@CurrentMonthStart", new DateTime(currentMonth.Year, currentMonth.Month, 1));
                }

                command.ExecuteNonQuery();
            }
        }

    }
}
