using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPBank.Domain.Types;

namespace BPBank.Domain.Entities
{
    public enum TransferType { Invalid, Debit, Credit }

    public class Transaction
    {
        public int Id { get; set; }
        public int FromAccountId { get; set; }
        public TransferType Operation { get; set; }
        public int ToAccountId { get; set; }
        public decimal FromAmount{ get; set; }
        public int? FromCcyId { get; set; }
        public decimal ToAmount { get; set; }
        public int? ToCcyId { get; set; }
    }
}
