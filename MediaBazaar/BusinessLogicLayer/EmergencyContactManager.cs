using DTOLayer;
using MediaBazaar.Classes;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
	public class EmergencyContactManager
	{
		private EmergencyContactDAL emergencyContactDAL= new EmergencyContactDAL();
		public EmergencyContactManager()
		{
			emergencyContactDAL = new EmergencyContactDAL();
		}
		public void AddEmergencyContact(EmergencyContact newEmergencyContact)
		{
			emergencyContactDAL.CreateEmergencyContact(TransformEmergencyContactToDTO(newEmergencyContact));
		}

		public EmergencyContact TransformDTOToEmergencyContact(EmergencyContactDTO dto)
		{
			return new EmergencyContact(dto.Id, dto.FirstName, dto.LastName, dto.PhoneNumber, dto.Email);
		}

		public EmergencyContactDTO TransformEmergencyContactToDTO(EmergencyContact emergencyContact)
		{
			return new EmergencyContactDTO(emergencyContact.Id, emergencyContact.FirstName, emergencyContact.LastName, emergencyContact.PhoneNumber, emergencyContact.Email);
		}

		public EmergencyContact ReadEmergencyContact(int employeeId)
		{
			try
			{
				EmergencyContactDTO emergencyContactDTO = emergencyContactDAL.ReadEmergencyContact(employeeId);
				return TransformDTOToEmergencyContact(emergencyContactDTO);
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public void UpdateEmergencyContactInDB(EmergencyContact emergencyContact)
		{
			emergencyContactDAL.UpdateEmergencyContact(TransformEmergencyContactToDTO(emergencyContact));
		}

		public void RemoveEmergencyContactFromDB(EmergencyContact emergencyContact)
		{
			emergencyContactDAL.DeleteEmergencyContact(emergencyContact.Id);
		}

		public void RemoveEmergencyContactFromDB(int employeeId)
		{
            emergencyContactDAL.DeleteEmergencyContact(employeeId);
        }
	}
}
