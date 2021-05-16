using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPBank.Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string AccNumber { get; set; }
        public decimal Balance { get; set; }
        public int? BaseCcyId { get; set; }
        public Currency? BaseCcy { get; set; } 
        public List<Transaction> Transactions { get; set; }
    }
}
