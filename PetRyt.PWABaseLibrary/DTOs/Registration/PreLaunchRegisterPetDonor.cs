using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRyt.PWABaseLibrary.DTOs.Registration
{
    public class PreLaunchRegisterPetDonorModel
    {   
        public UserModel User { get; set; } = new UserModel();
        public List<PetModel> Pets { get; set; } = new List<PetModel>();
    }
    // Models
    public class UserModel
    {
        public string Name { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Mobile { get; set; } = "";
        public string Email { get; set; } = "";
        public bool Agreement { get; set; } = false;
        public string UserType { get; set; } = "";
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
    }

    public class PetModel
    {
        public long UserId { get; set; }
        public string Name { get; set; } = "";
        public string Species { get; set; } = "";
        public int SpeciesId { get; set; }
        public int? SizeId { get; set; }
        public string Breed { get; set; } = "";
        public string Gender { get; set; } = "";
        public int GenderId { get; set; }
        public string Weight { get; set; } = string.Empty;

        public string Age { get; set; } = "";
        public string BloodGroup { get; set; } = "";
        public string MicroChipId { get; set; } = string.Empty;

        public bool IsDonor { get; set; } = true;
        public bool? IsActive { get; set; } = true;
        public DateTime? LastDonationDate { get; set; }

        public DateTime? DateCreated { get; set; }
        public DateTime? LastUpdatedOn { get; set; }

    }
}
