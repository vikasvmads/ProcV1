using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Procuerment.Models
{
    public partial class UserRoleMapping
    {
        [Key]
        public int Id { get; set; }
        public int RoleId { get; set; }//ForeignKey
        public int UserId { get; set; }//ForeignKey
        public string MODIFY_BY { get; set; }


        public DateTime? CreatedDate { get; set; }
        public DateTime? MODIFY_DATE { get; set; }
        public int? ROWSTATE { get; set; }



    }
}