using System.ComponentModel.DataAnnotations;

namespace PetRyt.PWABaseLibrary.DTOs
{
	public class Register : AccountBase
	{

		[EmailAddress]
		[Required(ErrorMessage = "Email is required")]
		public string? Email { get; set; }

		[Display(Name = "Confirm Password")]
		[DataType(DataType.Password)]
		[Compare(nameof(Password))]
		[Required]
		public string? ConfirmPassword { get; set; }


		[Display(Name = "Mobile Number")]
		[Required(ErrorMessage = "Mobile Number is required")]
		public string? MobileNumber { get; set; }

		[Required(ErrorMessage = "Please read the 'Terms of Use' and 'Privacy Policy'")]
		public bool AgreementRead { get; set; }
	}
}
