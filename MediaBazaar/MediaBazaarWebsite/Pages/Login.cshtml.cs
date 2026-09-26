using DTOLayer;
using MediaBazaar.Classes;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Dynamic;
using System.Net.WebSockets;
using System.Security.Claims;

namespace MediaBazaarWebsite.Pages
{
    public class LoginModel : PageModel
    {
        private EmployeeManager? employeeManager;
        private IHttpContextAccessor? httpContextAccessor;
        public LoginModel(EmployeeManager _employeeManager, IHttpContextAccessor _httpContextAccessor)
        {
            employeeManager = _employeeManager;
            httpContextAccessor = _httpContextAccessor;
        }

        [BindProperty]
        public string? Email { get; set; }
        [BindProperty]
        public string? Password { get; set; }

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

                Employee isPasswordValid = employeeManager.AuthenticateEmployee(employee.Email, Password);
                if (isPasswordValid != null)
                {
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, employee.EmployeeID.ToString()),
                    new Claim(ClaimTypes.Email, employee.Email),
                    new Claim(ClaimTypes.GivenName, employee.FirstName),
                    new Claim(ClaimTypes.Surname, employee.LastName),
                    new Claim(ClaimTypes.Role, employee.Role.role),
                    new Claim("ContractID", employee.Contract.Id.ToString()),
                    new Claim("IsManager", employee.IsManager.ToString())
                };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties();

                    httpContextAccessor?.HttpContext?.SignInAsync(
                      CookieAuthenticationDefaults.AuthenticationScheme,
                      new ClaimsPrincipal(claimsIdentity),
                      authProperties);
                    if (employee.FirstPassword)
                    {
                        return RedirectToPage("/Password_Reset");
                    }
                    return RedirectToPage("/Schedule");
                }
                ModelState.AddModelError(string.Empty, "Invalid password or email.");
                return Page();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }
    }
}
