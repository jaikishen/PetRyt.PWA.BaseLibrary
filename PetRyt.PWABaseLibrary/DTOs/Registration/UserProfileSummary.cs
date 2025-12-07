using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRyt.PWABaseLibrary.DTOs.Registration
{
    public class UserProfileSummary
    {
        public long UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserType { get; set; } = string.Empty;
        public List<string> IndividualTypes { get; set; } = new List<string>();
        public string? OrganisationName { get; set; }
        public string? OrganisationRole { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool IsMobileVerified { get; set; }
        public bool IsProfileComplete { get; set; }
    }
}
