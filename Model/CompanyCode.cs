using System;
using System.Collections.Generic;

namespace Procuerment.Models
{
    public partial class CompanyCode
    {
        public CompanyCode()
        {
            Procurement = new HashSet<Procurement>();
        }

        public int PocompanyCode { get; set; }
        public string PocompanyName { get; set; }

        public virtual ICollection<Procurement> Procurement { get; set; }

        public static implicit operator CompanyCode(List<CompanyCode> v)
        {
            throw new NotImplementedException();
        }
    }
}
