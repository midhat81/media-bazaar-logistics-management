using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DTOLayer;

namespace MediaBazaar.Classes
{
	public class EmergencyContact
	{
		public int Id { get; private set; }
		public string? FirstName { get; private set; }
		public string? LastName { get; private set; }
		public string? PhoneNumber { get; private set; }
		public string? Email { get; private set; }

		public EmergencyContact() { }
		public EmergencyContact(int id, string firstName, string lastName, string phoneNumber, string email)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			PhoneNumber = phoneNumber;
			Email = email;

		}

		public void UpdateInformationWebsite(string firstName, string lastName, string phoneNumber, string email)
		{
			FirstName = firstName;
			LastName = lastName;
			PhoneNumber = phoneNumber;
			Email = email;
		}
	}
}
