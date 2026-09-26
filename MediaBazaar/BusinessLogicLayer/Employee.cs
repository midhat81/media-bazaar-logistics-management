using BusinessLogicLayer;
using MediaBazaar.Classes;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DTOLayer
{
	public class Employee
	{
		public int EmployeeID { get; private set; }
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public string Email { get; private set; }
		public string Password { get; private set; }
		public string PhoneNumber { get; private set; }
		public string BSN { get; private set; }
		public DateTime Birthday { get; private set; }
		public Role Role { get; private set; }
		public bool IsManager { get; private set; }
		public EmergencyContact EmergencyContact { get; private set; }
		public string Address { get; private set; }
		public Contract Contract { get; private set; }
		public bool FirstPassword { get; private set; }
		public string Salt { get; private set; }

		public Employee()
		{

		}
		public Employee(int id, string firstName, string lastName, string email, string password, string bSN, DateTime birthday, Role role)
		{
			EmployeeID = id;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Password = password;
			BSN = bSN;
			Birthday = birthday;
			Role = role;
		}
		public Employee(int id, string firstName, string lastName, string email, string password, string phoneNumber, string bsn, DateTime birthday, Role role, bool isManager, EmergencyContact emergencyContact, string address
				, Contract contract, bool firstPassword, string salt)
		{
			EmployeeID = id;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Password = password;
			PhoneNumber = phoneNumber;
			BSN = bsn;
			Birthday = birthday;
			Role = role;
			IsManager = isManager;
			EmergencyContact = emergencyContact ?? throw new ArgumentNullException(nameof(emergencyContact), "EmergencyContact cannot be null.");
			Address = address;
			Contract = contract ?? throw new ArgumentNullException(nameof(contract), "Contract cannot be null.");
			FirstPassword = firstPassword;
			Salt = salt;
		}
		public void UpdateInformation(int id, string firstName, string lastName, string email, string password, string bSN, DateTime birthday, Role role)
		{
			EmployeeID = id;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Password = password;
			BSN = bSN;
			Birthday = birthday;
			Role = role;
		}

		public void UpdateInformationWebsite(string firstName, string lastName, string email, string phoneNumber, string address)
		{
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			PhoneNumber = phoneNumber;
			Address = address;
		}

		public string GetFullName()
		{
			return ($"{FirstName} {LastName}");
		}

		public void FirstPasswordChange()
		{
			FirstPassword = false;
		}
	}
}
