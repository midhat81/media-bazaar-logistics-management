using System.ComponentModel.DataAnnotations;

namespace MediaBazaarWebsite.ViewModels
{
	public class EmployeeViewModel
	{
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
		public string FirstName { get; set; }

		[Required]
		[StringLength(50)]
		[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
		public string LastName { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		public string BSN { get; set; }

		public DateTime Birthday { get; set; }

		[Required]
		[Phone]
		public string PhoneNumber { get; set; }

		[Required]
		[StringLength(100)]
		public string Address { get; set; }
	}
}