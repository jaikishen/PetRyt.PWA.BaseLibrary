using PetRyt.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRyt.PWABaseLibrary.DTOs.Registration
{
    public class RegisterUserResponse : ApiResponse
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string UserType{ get; set; }
        public string MobileNumber { get; set; } 
        public string Email { get; set; }
        public bool RequiresEmailVerification { get; set; }
        public bool RequiresMobileVerification { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
