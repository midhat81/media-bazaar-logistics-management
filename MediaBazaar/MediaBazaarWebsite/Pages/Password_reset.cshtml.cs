using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BusinessLogicLayer;
using MediaBazaar.Classes;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;

namespace MediaBazaarWebsite.Pages
{
	public class Password_ResetModel : PageModel
	{
		private EmployeeManager _employeeManager;

		[BindProperty]
		[Required(ErrorMessage = "Password is required")]
		[DataType(DataType.Password)]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one number, and one special character.")]
		public string? password { get; set; }

		[BindProperty]
		[Required(ErrorMessage = "Confirm Password is required")]
		[DataType(DataType.Password)]
		[Compare(nameof(password), ErrorMessage = "Passwords do not match")]
		public string? password2 { get; set; }

		public Password_ResetModel(EmployeeManager employeeManager)
		{
			_employeeManager = employeeManager;
		}

		public void OnGet()
		{
		}

		public ActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page(); 
			}
			PasswordHasher hasher = new PasswordHasher();
			var idClaim = User.FindFirst(ClaimTypes.NameIdentifier);
			if (idClaim != null)
			{
				string salt = hasher.GenerateSalt();
				string hashedpassword = hasher.HashPassword(password, salt);
				_employeeManager.ChangePassword(hashedpassword, salt, int.Parse(idClaim.Value));
			}
			return RedirectToPage("/Index");
		}
	}
}
