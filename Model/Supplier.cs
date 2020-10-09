using System;
using System.Collections.Generic;

namespace Procuerment.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Procurement = new HashSet<Procurement>();
        }

        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorType { get; set; }
        public string VendorCountry { get; set; }

        public virtual ICollection<Procurement> Procurement { get; set; }
    }
}
