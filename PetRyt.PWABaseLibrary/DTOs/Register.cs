using System.ComponentModel.DataAnnotations;

namespace PetRyt.PWABaseLibrary.DTOs
{
	public class Register 
	{
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; }

        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Mobile Number is required")]
        public string MobileNumber { get; set; }
		
		[EmailAddress]
		//[Required(ErrorMessage = "Email is required")]
		public string? Email { get; set; }
        [DataType(DataType.Password)]
        //[Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

		[Display(Name = "Confirm Password")]
		[DataType(DataType.Password)]
		[Compare(nameof(Password))]
		//[Required]
		public string? ConfirmPassword { get; set; }

		[Required(ErrorMessage = "Please read the 'Terms of Use' and 'Privacy Policy'")]
		public bool AgreementRead { get; set; }
	}
}
