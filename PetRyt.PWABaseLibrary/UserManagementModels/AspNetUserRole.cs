using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class AspNetUserRole
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }
        public bool? IsActive { get; set; }

        public virtual AspNetRole Role { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
