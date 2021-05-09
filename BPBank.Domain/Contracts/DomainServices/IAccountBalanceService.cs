using BPBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPBank.Domain.Contracts.DomainServices
{
    public interface IAccountBalanceService
    {
        public Task<IEnumerable<Account>> GetUserBalances(string userId);
    }
}
