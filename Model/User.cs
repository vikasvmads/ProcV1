using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Procuerment.Models
{
    public partial class UserInfo
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime MODIFY_DATE { get; set; }
        public string MODIFY_BY { get; set; }
        public int ROWSTATE { get; set; }

        public UserInfo()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.MODIFY_DATE = DateTime.UtcNow;
        }


    }
}