using System;
using System.Collections.Generic;

namespace Procuerment.Models
{
    public partial class MilestoneStatus
    {
        public MilestoneStatus()
        {
            Procurement = new HashSet<Procurement>();
        }

        public int MilestoneStatusId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Procurement> Procurement { get; set; }
    }
}
