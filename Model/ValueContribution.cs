using System;
using System.Collections.Generic;

namespace Procuerment.Models
{
    public partial class ValueContribution
    {
        public ValueContribution()
        {
            Procurement = new HashSet<Procurement>();
        }

        public int ValueContributionId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Procurement> Procurement { get; set; }
    }
}
