using System;
using System.Collections.Generic;

namespace Procuerment.Models
{
    public partial class MaterialGroup
    {
        public MaterialGroup()
        {
            Procurement = new HashSet<Procurement>();
        }

        public string UnspscMaterial { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Procurement> Procurement { get; set; }
    }
}
