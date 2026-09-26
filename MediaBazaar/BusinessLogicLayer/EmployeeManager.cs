using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using DTOLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace MediaBazaar.Classes
{
    public class EmployeeManager
    {
        public EmergencyContactManager _emergencyContactManager { get; private set; }
        public ContractManager _contractManager { get; private set; }
        public EmployeeDAL employeeDAL { get; private set; }
        public List<Employee> employees { get; private set; }
        public  PasswordHasher _passwordHasher { get; private set; }
        private RoleManager _roleManager;
        public EmployeeManager()
        {
            _emergencyContactManager = new EmergencyContactManager();
            _contractManager = new ContractManager();
            employees = new List<Employee>();
            employeeDAL = new EmployeeDAL();
            _passwordHasher = new PasswordHasher();
            _roleManager = new RoleManager();
            GetEmployeesFromDB();
        }
        public void AddEmployee(Employee newEmployee)
        {
            if (employees.Any(e => e.EmployeeID == newEmployee.EmployeeID))
            {
                throw new Exception("Employee already exists.");
            }
            employees.Add(newEmployee);
            employeeDAL.CreateEmployee(TransformEmployeeToDTO(newEmployee));
        }
        public Employee SearchEmployee(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.EmployeeID == id)
                {
                    return emp;
                }
            }
            return null;
        }

        public void UpdateEmployee(Employee updatedEmployee)
        {
            var employee = employees.FirstOrDefault(e => e.EmployeeID == updatedEmployee.EmployeeID);
            if (employee == null)
            {
                throw new Exception("Employee not found.");
            }
            employeeDAL.UpdateEmployee(TransformEmployeeToDTO(updatedEmployee));
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = employees.FirstOrDefault(e => e.EmployeeID == employeeId);
            if (employee == null)
            {
                throw new Exception("Employee not found.");
            }
            var contract = _contractManager.GetContractFromDB(employee.Contract.Id);
            if (contract != null)
            {
                contract.UpdateEndDate(DateTime.Now);
                contract.UpdateIsActive(false);
                contract.UpdateTerminationReason("Employee has been removed from the system.");
                _contractManager.UpdateContractInDB(contract);
            }
            employeeDAL.DeleteEmployee(employeeId);
            employees.Remove(employee);
            _emergencyContactManager.RemoveEmergencyContactFromDB((int)employee.EmergencyContact.Id);
        }

        public Employee GetEmployeeById(int employeeID)
        {
            return employees.FirstOrDefault(e => e.EmployeeID == employeeID);
        }

		public List<Employee> GetAllRegularEmployees()
        {
            return employees.Where(e => !e.IsManager).ToList();
        }

        public List<Employee> GetAllManagerEmployees()
        {
            return employees.Where(e => e.IsManager).ToList();
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public List<Employee> SearchEmployees(string searchTerm)
        {
            return employees.Where(e => e.FirstName.Contains(searchTerm)).ToList();
        }

        public List<Employee> FilterEmployees(Func<Employee, bool> filter)
        {
            return employees.Where(filter).ToList();
        }

        public Employee AuthenticateEmployee(string email, string password)
        {
            Employee foundemployee = employees.FirstOrDefault(e => e.Email == email);
            if(foundemployee != null)
            
                if (foundemployee.Salt == "0")
                {
                    if (foundemployee.Password == password)
                        return foundemployee;
                }
                else
                {
                    if (_passwordHasher.VerifyPassword(password+foundemployee.Salt, foundemployee.Password))
                        return foundemployee;
                }
            return null;
            //return employees.FirstOrDefault(e => e.Email == email && e.Password == password && e.IsManager);
        }

        public Employee TransformDTOToEmployee(EmployeeDTO employeeDTO)
        {
            EmergencyContact emergencyContact = _emergencyContactManager.ReadEmergencyContact(employeeDTO.EmergencyContactId);
            Contract contract = _contractManager.GetContractFromDB(employeeDTO.ActiveContractId);
            if (emergencyContact != null && contract != null)
            {
                Employee employee = new Employee(employeeDTO.Id,
                                      employeeDTO.FirstName,
                                      employeeDTO.LastName,
                                      employeeDTO.Email,
                                      employeeDTO.Password,
                                      employeeDTO.PhoneNumber,
                                      employeeDTO.BSN,
                                      employeeDTO.Birthday,
                                      _roleManager.ConvertToEntity(_roleManager.GetRoleById(employeeDTO.Role)),
                                      employeeDTO.IsManager,
                                      emergencyContact,
                                      employeeDTO.Address,
                                      contract,
                                      employeeDTO.FirstPassword,
                                      employeeDTO.Salt);
                return employee;
            }
            throw new InvalidOperationException("Emergency contact or contract is null.");
        }

        public EmployeeDTO TransformEmployeeToDTO(Employee employee)
        {
            EmployeeDTO employeeDTO = new EmployeeDTO(
                employee.EmployeeID,
                employee.FirstName,
                employee.LastName,
                employee.Email,
                employee.Password,
                employee.PhoneNumber,
                employee.Address,
                employee.BSN,
                employee.Birthday,
                employee.Role.id,
                employee.IsManager,
                employee.Contract.Id,
                employee.EmergencyContact.Id,
                employee.FirstPassword,
                employee.Salt
                );
            return employeeDTO;
        }

        public void GetEmployeesFromDB()
        {
            employees.Clear();
            List<EmployeeDTO> listOfEmployeeDTO = employeeDAL.GetAllEmployees();
            foreach (EmployeeDTO dto in listOfEmployeeDTO)
            {
                employees.Add(TransformDTOToEmployee(dto));
            }
        }

        public int GetNextEmployeeId()
        {
            return employeeDAL.GetNextEmpId();
        }

        public bool CheckManager(EmployeeRoleEnum role)
        {
            if ((int)role < 3)
            {
                return true;
            }
            return false;
        }
        public Employee GetEmployeeByName(string name)
        {
            return employees.FirstOrDefault(e => e.FirstName + " " + e.LastName == name);
        }

        public Employee GetEmployeeByEmail(string email)
        {
            return employees.FirstOrDefault(e => e.Email == email);
        }

        public void ChangePassword(string password,string salt, int employeeID)
        {
            employeeDAL.ChangePassword(employeeID, password, salt);
        }

        public void ResetPassword(int id) 
        { 
            employeeDAL.ResetPassword(id);
        }

        public int HiredInTimeFrame(int months)
        {
            DateTime currentDate = DateTime.Now;
            DateTime comparisonDate = currentDate.AddMonths(-months);
            return employees.Count(e => e.Contract.startDate > comparisonDate && e.Contract.startDate <= DateTime.Now);
        }

        public int FiredInTimeFrame(int months)
        {
            DateTime currentDate = DateTime.Now;
            DateTime comparisonDate = currentDate.AddMonths(-months);
            return employees.Count(e => e.Contract.endDate > comparisonDate && e.Contract.endDate <= DateTime.Now);
        }

        public int DeactivatedEmployees()
        {
            return employees.Count(e => !e.Contract.isActive);
        }

    }
}
