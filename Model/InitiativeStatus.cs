using System;
using System.Collections.Generic;

namespace Procuerment.Models
{
    public partial class InitiativeStatus
    {
        public InitiativeStatus()
        {
            Procurement = new HashSet<Procurement>();
        }

        public int InitiativeStatusId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Procurement> Procurement { get; set; }
    }
}
