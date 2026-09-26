using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
	public class EmergencyContactDTO
	{
		public string FirstName {  get; set; }
		public string LastName {  get; set; }
		public string PhoneNumber {  get; set; }
		public string Email {  get; set; }
		public int Id {  get; set; }

        public EmergencyContactDTO(int id, string firstName, string lastName, string phoneNumber, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
