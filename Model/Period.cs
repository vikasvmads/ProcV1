using System;
using System.Collections.Generic;

namespace Procuerment.Models
{
    public partial class Period
    {
        public Period()
        {
            Procurement = new HashSet<Procurement>();
        }

        public int PeriodId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Procurement> Procurement { get; set; }
    }
}
