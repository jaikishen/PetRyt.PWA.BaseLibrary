using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class SysRefSpecy
    {
        public SysRefSpecy()
        {
            Pets = new HashSet<Pet>();
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
