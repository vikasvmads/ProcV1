using System;
using System.ComponentModel.DataAnnotations;
namespace Procuerment.Models
{
    public class ProcuermentData
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Creationdate { get; set; }

        [Required]
        [MaxLength(25)]
        public string CreatedBy { get; set; }

        [Required]
        [MaxLength(50)]
        public string InitiativeTitle { get; set; }

        [Required]
        [MaxLength(250)]
        public string InitiativeDescription { get; set; }

        [Required]
        [MaxLength(25)]
        public string BaselineId { get; set; }

        [Required]
        [MaxLength(50)]
        public string BaselineType { get; set; }


        [Required]
        [MaxLength(50)]
        public string ValueLever { get; set; }


        [Required]
        [MaxLength(50)]
        public string Methods { get; set; }


        [Required]
        [MaxLength(50)]
        public string MethodId { get; set; }



        [Required]
        [MaxLength(50)]
        public string LeverDescription { get; set; }



        [Required]
        [MaxLength(10)]
        public string PriceIncrease { get; set; }


        [Required]
        [MaxLength(10)]
        public string Discountgiven { get; set; }



        [Required]
        [MaxLength(10)]
        public string MaterialSubstitution { get; set; }


        [Required]
        [MaxLength(10)]
        public string VolumeIncrease { get; set; }


        [Required]
        [MaxLength(10)]
        public string CurrencyImpact { get; set; }

        [Required]
        [MaxLength(10)]
        public string IndexsavingConsideration { get; set; }

        [Required]
        [MaxLength(10)]
        public string InitiativeStatus { get; set; }


        [Required]
        [MaxLength(25)]
        public string ValueContribution { get; set; }




        [Required]
        public string name { get; set; }

        [Required]

        public string value { get; set; }

        [Required]
        public int price { get; set; }

        public string vendor { get; set; }

    }
}