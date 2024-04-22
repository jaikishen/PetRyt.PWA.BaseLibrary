using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class SysRefSeverity
    {
        public SysRefSeverity()
        {
            PetAllergens = new HashSet<PetAllergen>();
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string Symptoms { get; set; }

        public virtual ICollection<PetAllergen> PetAllergens { get; set; }
    }
}
