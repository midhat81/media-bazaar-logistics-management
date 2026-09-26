using System.ComponentModel.DataAnnotations;

namespace MediaBazaarWebsite.ViewModels
{
	public class EmergencyContactViewModel
	{
		[Required]
		[StringLength(50)]
		[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
		public string firstName { get; set; }

		[Required]
		[StringLength(50)]
		[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
		public string lastName { get; set; }

		[Required]
		[Phone]
		public string phoneNumber { get; set; }

		[Required]
		[EmailAddress]
		public string email { get; set; }
	}
}
