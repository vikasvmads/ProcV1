using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Procuerment.Data;
using Procuerment.Models;
using AutoMapper;







namespace Procuerment.Data
{

    public class ProcuermentQueryData : QueryParameter
    {
        public string? Title { get; set; }
        public string? CreatedBy { get; set; }
        public string UniqueId { get; set; }

    }
}