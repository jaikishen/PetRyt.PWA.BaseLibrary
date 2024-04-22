using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class Pet
    {
        public Pet()
        {
            PetAllergens = new HashSet<PetAllergen>();
            PetMedicalConditions = new HashSet<PetMedicalCondition>();
            PetMedications = new HashSet<PetMedication>();
            PetTreatments = new HashSet<PetTreatment>();
            PetVaccinationRecords = new HashSet<PetVaccinationRecord>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public byte GenderId { get; set; }
        public string Breed { get; set; }
        public string Weight { get; set; }
        public string CoatColor { get; set; }
        public string LeyeColor { get; set; }
        public string ReyeColor { get; set; }
        public string BloodGroup { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public long UserId { get; set; }
        public int SpeciesId { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? IsDeceased { get; set; }
        public bool? IsActive { get; set; }
        public int? SizeId { get; set; }
        public bool? IsDonor { get; set; }
        public bool? IsNeuteredSpayed { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual SysRefSpeciesSize Size { get; set; }
        public virtual SysRefSpecy Species { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual ICollection<PetAllergen> PetAllergens { get; set; }
        public virtual ICollection<PetMedicalCondition> PetMedicalConditions { get; set; }
        public virtual ICollection<PetMedication> PetMedications { get; set; }
        public virtual ICollection<PetTreatment> PetTreatments { get; set; }
        public virtual ICollection<PetVaccinationRecord> PetVaccinationRecords { get; set; }
    }
}
