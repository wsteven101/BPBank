using BPBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPBank.DTO
{
    public class AccountBalanceDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string AccNumber { get; set; }
        public decimal Balance { get; set; }
        public int? BaseCcyId { get; set; }
        public string BaseCcy { get; set; }

        public AccountBalanceDTO(Account account)
        {
            Id = account.Id;
            UserId = account.UserId;
            AccNumber = account.AccNumber;
            Balance = account.Balance;
            BaseCcyId = account.BaseCcyId;
            BaseCcy = account.BaseCcy.ISOCode;
        }
    }
}
