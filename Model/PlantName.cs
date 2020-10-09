using System;
using System.Collections.Generic;

namespace Procuerment.Models
{
    public partial class PlantName
    {
        public PlantName()
        {
            Procurement = new HashSet<Procurement>();
        }

        public int PlantId { get; set; }
        public string PlantName1 { get; set; }

        public virtual ICollection<Procurement> Procurement { get; set; }
    }
}
