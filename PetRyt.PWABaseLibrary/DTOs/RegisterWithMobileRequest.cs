using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRyt.PWABaseLibrary.DTOs
{
    public class RegisterWithMobileRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [Phone]
        public string MobileNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; } // Optional
        [MinLength(6)]
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public bool AgreementRead { get; set; }
    }
}
