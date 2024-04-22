using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class PetTreatment
    {
        public long Id { get; set; }
        public long PetId { get; set; }
        public DateTime Date { get; set; }
        public int SubTreatmentId { get; set; }
        public string Veterinarian { get; set; }
        public decimal? Cost { get; set; }
        public string Notes { get; set; }

        public virtual Pet Pet { get; set; }
        public virtual SysRefSubTreatmentType SubTreatment { get; set; }
    }
}
