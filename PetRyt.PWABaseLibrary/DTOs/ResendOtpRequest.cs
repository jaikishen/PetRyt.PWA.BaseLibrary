using System.ComponentModel.DataAnnotations;

namespace PetRyt.PWABaseLibrary.DTOs
{
    public class ResendOtpRequest
    {
        [Required]
        public string MobileNumber { get; set; }
        public long? UserId { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
    }
}
