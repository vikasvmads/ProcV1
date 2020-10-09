using System;
using System.Collections.Generic;

namespace Procuerment.Models
{
    public partial class BaselineType
    {
        public BaselineType()
        {
            Procurement = new HashSet<Procurement>();
        }

        public int BaselineId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Procurement> Procurement { get; set; }

        public static implicit operator BaselineType(List<BaselineType> v)
        {
            throw new NotImplementedException();
        }
    }
}
