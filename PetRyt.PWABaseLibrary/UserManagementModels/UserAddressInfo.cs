using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class UserAddressInfo
    {
        public long Id { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
        public long UserId { get; set; }
        public bool? IsActive { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
