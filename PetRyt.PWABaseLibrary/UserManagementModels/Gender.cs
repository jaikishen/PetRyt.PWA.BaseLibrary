using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class Gender
    {
        public Gender()
        {
            Pets = new HashSet<Pet>();
        }

        public byte Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
