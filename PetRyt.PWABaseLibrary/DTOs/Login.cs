using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRyt.PWABaseLibrary.DTOs
{
	public class Login
	{
        [Display(Name = "User Name")]
        //[Required(ErrorMessage = "User Name is required")]
        public string? UserName { get; set; }


        [DataType(DataType.Password)]
        //[Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? MobileNumber { get; set; }
    }
}
