using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRyt.PWABaseLibrary.DTOs
{
    public class RegisterWithMobileRequest
    {
        //[Required]
        public string UserName { get; set; }

        //[Required]
        [Phone]
        public string MobileNumber { get; set; }

        [EmailAddress]
        public string? Email { get; set; } // Optional
        [MinLength(6)]
        //[PasswordPropertyText]
        public string? Password { get; set; }
        [Compare("Password")]
        public string? ConfirmPassword { get; set; }
        //[Required]
        public bool AgreementRead { get; set; }

        // New fields for user type selection
        //[Required]
        public string UserType { get; set; } = string.Empty; // "individual" or "organisation"

        // Individual user fields
        public List<string> IndividualUserTypes { get; set; } = new List<string>();

        // Organisation fields
        public long? SelectedOrganisationId { get; set; }
        public string? SelectedOrganisationName { get; set; }
        public string? SelectedOrganisationType { get; set; }
        public int? SelectedOrganisationRoleId { get; set; }
        public string? OrganisationRole { get; set; }

        // Additional metadata
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
        public string? RegistrationSource { get; set; } = "Web"; // Web, Mobile, etc.

    }
}
