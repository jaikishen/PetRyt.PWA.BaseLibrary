using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRyt.PWABaseLibrary.DTOs.Registration
{
    public class VerifyOtpResponse
    {
        public bool IsVerified { get; set; }
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? TokenExpiry { get; set; }
        public UserProfileSummary? UserProfile { get; set; }
    }
}
