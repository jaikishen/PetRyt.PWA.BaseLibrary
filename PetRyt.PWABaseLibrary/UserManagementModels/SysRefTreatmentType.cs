using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class SysRefTreatmentType
    {
        public SysRefTreatmentType()
        {
            SysRefSubTreatmentTypes = new HashSet<SysRefSubTreatmentType>();
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public bool? IsActive { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SysRefSubTreatmentType> SysRefSubTreatmentTypes { get; set; }
    }
}
