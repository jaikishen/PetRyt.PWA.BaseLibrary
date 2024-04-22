using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class UserPhoneInfo
    {
        public long Id { get; set; }
        public string PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public string PhoneConfirmationCode { get; set; }
        public DateTime? PhoneCodeExpiry { get; set; }
        public DateTime? PhoneCodeResendTime { get; set; }
        public long UserId { get; set; }
        public bool? IsActive { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
