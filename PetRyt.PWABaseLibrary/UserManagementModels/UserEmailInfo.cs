using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class UserEmailInfo
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string EmailConfirmationCode { get; set; }
        public DateTime? EmailCodeExpiry { get; set; }
        public long UserId { get; set; }
        public bool? IsActive { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
