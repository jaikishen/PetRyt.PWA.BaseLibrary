using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRyt.PWABaseLibrary.DTOs
{
    public class SendOtpForLoginRequest
    {
        [Required(ErrorMessage = "Mobile number is required")]
        [Phone(ErrorMessage = "Please enter a valid mobile number")]
        public string MobileNumber { get; set; } = string.Empty;
    }
}
