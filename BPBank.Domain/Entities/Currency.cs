using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPBank.Domain.Entities
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        public string ISOCode { get; set; }
        public string ExternalCode { get; set; }
        public string Description { get; set; }
    }
}
