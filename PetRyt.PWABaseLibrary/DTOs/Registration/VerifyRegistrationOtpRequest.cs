using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRyt.PWABaseLibrary.DTOs.Registration
{
    public class VerifyRegistrationOtpRequest
    {
        public string Otp { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public long? UserId { get; set; }
        public string? DeviceId { get; set; }
        public string? UserAgent { get; set; }
    }
}
