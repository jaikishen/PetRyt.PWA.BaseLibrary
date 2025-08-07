using System.ComponentModel.DataAnnotations;

namespace PetRyt.PWABaseLibrary.DTOs
{
    public class VerifyOtpRequest
    {
        [Required]
        [Phone]
        public string MobileNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(6, MinimumLength = 4)]
        public string Otp { get; set; } = string.Empty;

        public long? UserId { get; set; }
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
    }
}
