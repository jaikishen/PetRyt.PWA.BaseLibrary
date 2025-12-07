using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRyt.PWABaseLibrary.DTOs.Registration
{
    public class ResendRegistrationOtpRequest
    {
        public string MobileNumber { get; set; } = string.Empty;
        public long? UserId { get; set; }
        public string? Reason { get; set; } = "User Request";
    }
}
