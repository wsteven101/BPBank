using BPBank.Domain.Contracts.Data;
using BPBank.Domain.Contracts.DomainServices;
using BPBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPBank.Domain.Services
{
    public class AccountBalanceService :IAccountBalanceService
    {
        private readonly IUserRepo _userRepo;

        public AccountBalanceService(IUserRepo userRepo) => _userRepo = userRepo;
        
        public async Task<IEnumerable<Account>> GetUserBalances(string userId)
        {

            if ((userId ?? "") == "")
            {
                throw new ArgumentException("No User Id provided");
            }

            var userInfo = await _userRepo.GetByLoginName(userId);
            return userInfo.Accounts;

        }
    }
}
