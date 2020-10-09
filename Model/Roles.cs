using System;
using System.Collections.Generic;

namespace Procuerment.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Procurement = new HashSet<Procurement>();
        }

        public int RoleId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Procurement> Procurement { get; set; }
    }
}
