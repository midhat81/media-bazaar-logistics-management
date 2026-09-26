using BusinessLogicLayer;
using MediaBazaar.Classes;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using MediaBazaarWebsite.ViewModels;
using System.Reflection;

namespace MediaBazaarWebsite.Pages
{
    public class DetailsModel : PageModel
    {
        private EmployeeManager _employeeManager;
        private EmergencyContactManager _emergencyContactManager;

        public DetailsModel(EmployeeManager employeeManager, EmergencyContactManager emergencyContactManager)
        {
            _employeeManager = employeeManager;
            _emergencyContactManager = emergencyContactManager;
        }

        [BindProperty]
        public EmployeeViewModel Employee { get; set; }
        [BindProperty]
        public EmergencyContactViewModel EmergencyContact { get; set; }

        public void OnGet()
        {
            if (Request.Method != "POST" && User.Identity.IsAuthenticated)
            {
                var idClaim = User.FindFirst(ClaimTypes.NameIdentifier);
                if (idClaim != null)
                {
                    int id = int.Parse(idClaim.Value);
                    PopulateEmployeeData(id);
                    PopulateEmergencyContactData(id);
                }
            }
        }

        public IActionResult OnPostUpdateEmployee()
        {
            ModelState.Clear();
            if (!TryValidateModel(model: Employee, "Employee"))
            {
                var idClaim = User.FindFirst(ClaimTypes.NameIdentifier);
                if (idClaim != null)
                {
                    int id = int.Parse(idClaim.Value);
                    PopulateEmergencyContactData(id);
                }
                return Page();
            }
            UpdateEmployeeData();
            return RedirectToPage("/Details", new { id = Employee.Id });
        }

        public IActionResult OnPostUpdateEmergencyContact()
        {
            ModelState.Clear();
            if (!TryValidateModel(model: EmergencyContact, "EmergencyContact"))
            {
                var idClaim = User.FindFirst(ClaimTypes.NameIdentifier);
                if (idClaim != null)
                {
                    int id = int.Parse(idClaim.Value);
                    PopulateEmergencyContactData(id);
                }
                return Page();
            }
            UpdateEmergencyContactData();
            return RedirectToPage("/Details", new { id = Employee.Id });
        }

        private void PopulateEmployeeData(int id)
        {
            var employee = _employeeManager.GetEmployeeById(id);
            Employee = new EmployeeViewModel
            {
                Id = employee.EmployeeID,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                BSN = employee.BSN,
                Birthday = employee.Birthday,
                PhoneNumber = employee.PhoneNumber,
                Address = employee.Address
            };
        }

        private void PopulateEmergencyContactData(int id)
        {
            var employee = _employeeManager.GetEmployeeById(id);
            var emergencyContact = employee.EmergencyContact;
            EmergencyContact = new EmergencyContactViewModel
            {
                firstName = emergencyContact.FirstName,
                lastName = emergencyContact.LastName,
                phoneNumber = emergencyContact.PhoneNumber,
                email = emergencyContact.Email,
            };
        }

        private void UpdateEmployeeData()
        {
            var employeeToUpdate = _employeeManager.GetEmployeeById(Employee.Id);
            employeeToUpdate.UpdateInformationWebsite(Employee.FirstName, Employee.LastName, Employee.Email, Employee.PhoneNumber, Employee.Address);
            _employeeManager.UpdateEmployee(employeeToUpdate);
        }

        private void UpdateEmergencyContactData()
        {
            var employeeToUpdate = _employeeManager.GetEmployeeById(Employee.Id);
            var emergencyContactToUpdate = _emergencyContactManager.ReadEmergencyContact(employeeToUpdate.EmployeeID);
            emergencyContactToUpdate.UpdateInformationWebsite(EmergencyContact.firstName, EmergencyContact.lastName, EmergencyContact.phoneNumber, EmergencyContact.email);
            _emergencyContactManager.UpdateEmergencyContactInDB(emergencyContactToUpdate);
        }
    }
}
