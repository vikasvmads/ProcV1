
using System;
using System.Collections.Generic;

namespace Procuerment.Models
{

    public class LookUps
    {
        public List<Models.BaselineType> BaselineType { get; set; }
        public List<Models.CompanyCode> CompanyCode { get; set; }

        public List<Models.FinancialStatementArea> FinancialStatementArea { get; set; }
        public List<Models.InitiativeStatus> InitiativeStatus { get; set; }

        public List<Models.MaterialGroup> MaterialGroup { get; set; }
        public List<Models.MaterialGroupDesccription> MaterialGroupDesccription { get; set; }

        public List<Models.MaterialMater> MaterialMater { get; set; }
        public List<Models.MilestoneStatus> MilestoneStatus { get; set; }

        public List<Models.Period> Period { get; set; }

        public List<Models.PlantName> PlantName { get; set; }

        public List<Models.PurchaseOrganization> PurchaseOrganization { get; set; }

        public List<Models.Supplier> Supplier { get; set; }

        public List<Models.ValueContribution> ValueContribution { get; set; }
        public List<Models.ValueLever> ValueLever { get; set; }

    }
}