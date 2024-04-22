using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class PetMedication
    {
        public long Id { get; set; }
        public long PetId { get; set; }
        public string MedicationName { get; set; }
        public string Description { get; set; }
        public string Dose { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? PrescriptionId { get; set; }
        public string PrescriptionLocationId { get; set; }
        public int? PrescribedById { get; set; }
        public string PrescribedBy { get; set; }
        public string AdditionalRelevantDetails { get; set; }
        public bool? IsActive { get; set; }

        public virtual Pet Pet { get; set; }
    }
}
