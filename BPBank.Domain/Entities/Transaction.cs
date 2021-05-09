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
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public TransferType Operation { get; set; }
        public int ExternalAccountAccountId { get; set; }
        public Account ExternalAccount { get; set; }
        public decimal Amount{ get; set; }
        public int? FromCcyCurrencyId { get; set; }
        public Currency? FromCcy { get; set; }
        public int? ToCcyCurrencyId { get; set; }
        public Currency? ToCcy { get; set; }
    }
}
