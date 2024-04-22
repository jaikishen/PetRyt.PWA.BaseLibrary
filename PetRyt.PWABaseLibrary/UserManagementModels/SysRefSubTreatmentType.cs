using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class SysRefSubTreatmentType
    {
        public SysRefSubTreatmentType()
        {
            PetTreatments = new HashSet<PetTreatment>();
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public int TreatmentTypeId { get; set; }
        public bool? IsActive { get; set; }
        public string Description { get; set; }

        public virtual SysRefTreatmentType TreatmentType { get; set; }
        public virtual ICollection<PetTreatment> PetTreatments { get; set; }
    }
}
