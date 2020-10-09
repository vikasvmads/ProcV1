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

    public class QueryParameter
    {
        const int _maxSize = 10;
        private int _size = 10;

        public int? UserId { get; set; }

        public int Page { get; set; }

        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = Math.Min(_maxSize, value);
            }
        }
    }
}