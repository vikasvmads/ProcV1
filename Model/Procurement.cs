using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Procuerment.Models
{
    public partial class Procurement
    {
        [Required]
        public int ProcurementId { get; set; }
        [Required]
        public string InitiativeTitle { get; set; }
        [Required]
        public string InitiativeDescription { get; set; }
        [Required]
        public int BaselineId { get; set; }
        [Required]
        public int ValueLeverId { get; set; }
        [Required]
        public string Methods { get; set; }
        [Required]
        public string LeverDescription { get; set; }
        [Required]
        public string PriceIncrease { get; set; }
        [Required]
        public string Discountgiven { get; set; }
        [Required]
        public string MaterialSubstitution { get; set; }
        [Required]
        public string VolumeIncrease { get; set; }
        [Required]
        public string CurrencyImpact { get; set; }
        [Required]
        public string IndexsavingConsideration { get; set; }
        [Required]
        public int InitiativeStatusId { get; set; }
        [Required]
        public int ValueContributionId { get; set; }
        [Required]
        public int FinancialStatementAreaId { get; set; }
        [Required]
        public int RoleId { get; set; }
        [Required]
        public int PeriodId { get; set; }
        [Required]
        public string Material { get; set; }
        [Required]
        public string PurchaseOrganization { get; set; }
        [Required]
        public string Division { get; set; }
        [Required]
        public int MilestoneStatusId { get; set; }
        [Required]
        public string MilestoneDescription { get; set; }
        [Required]
        public DateTime MilestoneStartdatemilestone { get; set; }
        [Required]
        public DateTime? MilestonePlannedDuedate { get; set; }
        [Required]
        public DateTime? MilestoneActualDuedate { get; set; }
        [Required]
        public int Milestonestatuspercentage { get; set; }
        [Required]
        public string Remarks { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        public string CurrencyType { get; set; }

        [Required]
        public int Periodofsaving { get; set; }
        [Required]
        public int FiscalYear { get; set; }

        [Required]
        public decimal ExternalCost { get; set; }
        [Required]
        public decimal InternalCost { get; set; }
        [Required]
        public decimal EstimatedSavings { get; set; }
        [Required]
        public decimal NetSavings { get; set; }
        [Required]
        public decimal BaselinedetailsPrice { get; set; }
        [Required]
        public decimal BaselinedetailsQty { get; set; }
        [Required]
        public string BaselinedetailsUom { get; set; }
        [Required]
        public decimal BaselinedetailsPriceunit { get; set; }
        [Required]
        public decimal InitiativedetailsNewSpendvalue { get; set; }
        [Required]
        public decimal InitiativedetailsNewprice { get; set; }
        [Required]
        public decimal InitiativedetailsPriceIncrease { get; set; }

        [Required]
        public string Initiativedetails { get; set; }
        [Required]
        public decimal InitiativedetailsDiscountgiven { get; set; }

        [Required]
        public string NewMaterial { get; set; }
        [Required]
        public string Uom { get; set; }

        [Required]
        public decimal Qty { get; set; }
        [Required]
        public decimal CostReduction { get; set; }
        [Required]
        public DateTime Creationdate { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public string MaterialGroup { get; set; }
        [Required]
        public string MaterialDescription { get; set; }

        [Required]
        public int? CompanyCode { get; set; }

        [Required]
        public int? SupplierId { get; set; }
        [Required]
        public int? PlantId { get; set; }

        public virtual BaselineType Baseline { get; set; }
        public virtual CompanyCode CompanyCodeNavigation { get; set; }
        public virtual FinancialStatementArea FinancialStatementArea { get; set; }
        public virtual InitiativeStatus InitiativeStatus { get; set; }
        public virtual MaterialGroupDesccription MaterialDescriptionNavigation { get; set; }
        public virtual MaterialGroup MaterialGroupNavigation { get; set; }
        public virtual MilestoneStatus MilestoneStatus { get; set; }
        public virtual Period Period { get; set; }
        public virtual PlantName Plant { get; set; }
        public virtual Roles Role { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ValueContribution ValueContribution { get; set; }
        public virtual ValueLever ValueLever { get; set; }
    }
}
