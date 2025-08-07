using System.ComponentModel.DataAnnotations;

namespace PetRyt.PWABaseLibrary.DTOs
{
    public class ResendOtpRequest
    {
        [Required]
        public string MobileNumber { get; set; }
    }
}
