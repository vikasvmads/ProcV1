using System;
using System.Collections.Generic;

namespace Procuerment.Models
{
    public partial class FinancialStatementArea
    {
        public FinancialStatementArea()
        {
            Procurement = new HashSet<Procurement>();
        }

        public int FinancialStatementAreaId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Procurement> Procurement { get; set; }
    }
}
