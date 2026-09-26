using MediaBazaar.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace MediaBazaarWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private EmployeeManager _employeeManager;
        public IndexModel(EmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public void OnGet()
        {
            var idClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            if (idClaim != null)
            {
                int id = int.Parse(idClaim.Value);
                var employee = _employeeManager.GetEmployeeById(id);
                if (employee != null)
                {
                    FirstName = employee.FirstName;
                    LastName = employee.LastName;
                }
            }
        }
    }

}
