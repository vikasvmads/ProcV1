using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Procuerment.Models
{
    public partial class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime MODIFY_DATE { get; set; }
        public int ROWSTATE { get; set; }


        public Role()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.MODIFY_DATE = DateTime.UtcNow;
        }
    }
}