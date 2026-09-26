using DTOLayer;
using MediaBazaar.Classes;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace MediaBazaarWebsite.Pages
{
    public class Change_PasswordModel : PageModel
    {

        private EmployeeManager? employeeManager;
        [BindProperty]
        public string? Email { get; set; }

        public Change_PasswordModel(EmployeeManager? employeeManager)
        {
            this.employeeManager = employeeManager;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                var employee = employeeManager?.GetEmployeeByEmail(Email);
                if (employee == null)
                {
                    ModelState.AddModelError(string.Empty, "Employee does not exist.");
                    return Page();
                }

                return RedirectToPage("/Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }
    }
}
