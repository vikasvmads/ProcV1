using System;
using System.Collections.Generic;

namespace Procuerment.Models
{
    public partial class MaterialGroupDesccription
    {
        public MaterialGroupDesccription()
        {
            Procurement = new HashSet<Procurement>();
        }

        public string MaterialType { get; set; }
        public string MaterialTypeDescription { get; set; }

        public virtual ICollection<Procurement> Procurement { get; set; }
    }
}
