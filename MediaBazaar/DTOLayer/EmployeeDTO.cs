using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace DTOLayer
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string BSN { get; set; }
        public DateTime Birthday { get; set; }
        public int Role { get;  set; }
        public bool IsManager { get; set; } 
        public int ActiveContractId {  get; set; }
        public int EmergencyContactId {  get; set; }
        public bool FirstPassword {  get; set; }
        public string Salt { get; set; }

        public EmployeeDTO(int id, string firstName, string lastName, string email, string password, string phoneNumber, string address, string bSN, DateTime birthday,
                             int role, bool isManager, int activeContractId, int emergencyContactId, bool firstPassword, string salt)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            BSN = bSN;
            Birthday = birthday;
            Role = role;
            IsManager = isManager;
            EmergencyContactId = emergencyContactId;
            Address = address;
            ActiveContractId = activeContractId;
            FirstPassword = firstPassword;
            Salt = salt;
        }

        public EmployeeDTO(int id,string firstName, string lastName, string email, string phoneNumber, string address,int role,bool isManager)
        {
            Id=id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address=address;
            Role = role;
            IsManager = isManager;
        }
    }
}
