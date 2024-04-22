using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class PetVaccinationRecord
    {
        public long Id { get; set; }
        public long PetId { get; set; }
        public string VaccinationName { get; set; }
        public string Description { get; set; }
        public DateTime? AdministeredDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string AdditionalRelevantDetails { get; set; }
        public bool? IsActive { get; set; }

        public virtual Pet Pet { get; set; }
    }
}
