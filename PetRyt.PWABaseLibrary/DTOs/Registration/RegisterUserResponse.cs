using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRyt.PWABaseLibrary.DTOs.Registration
{
    public class RegisterUserResponse
    {
        public long UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public string? Email { get; set; }
        public bool RequiresEmailVerification { get; set; }
        public bool RequiresMobileVerification { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
