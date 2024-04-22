using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class PetMedicalCondition
    {
        public long Id { get; set; }
        public long PetId { get; set; }
        public string ConditionName { get; set; }
        public string Description { get; set; }
        public DateTime? DateOfDiagnosis { get; set; }
        public string AdditionalRelevantDetails { get; set; }
        public bool? IsActive { get; set; }

        public virtual Pet Pet { get; set; }
    }
}
