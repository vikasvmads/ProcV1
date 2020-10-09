using System;
using System.Collections.Generic;

namespace Procuerment.Models
{
    public partial class ValueLever
    {
        public ValueLever()
        {
            Procurement = new HashSet<Procurement>();
        }

        public int ValueLeverId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Procurement> Procurement { get; set; }
    }
}
