using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class PetAllergen
    {
        public long Id { get; set; }
        public long PetId { get; set; }
        public string AllergenName { get; set; }
        public string ReactionDescription { get; set; }
        public DateTime? DateOfDiagnosis { get; set; }
        public int SeverityId { get; set; }
        public string TreatmentPlan { get; set; }
        public string TriggersOrExposures { get; set; }
        public string DiagnosticTests { get; set; }
        public string ReactionSymptoms { get; set; }
        public string EmergencyProtocol { get; set; }
        public string Notes { get; set; }
        public bool? IsActive { get; set; }

        public virtual Pet Pet { get; set; }
        public virtual SysRefSeverity Severity { get; set; }
    }
}
