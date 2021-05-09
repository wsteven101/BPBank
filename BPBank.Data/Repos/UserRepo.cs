using BPBank.Domain.Contracts.Data;
using BPBank.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPBank.Data.Repos
{
    public class UserRepo :IUserRepo
    {
        private readonly BPBankContext _BPBankContext;

        public UserRepo(BPBankContext bPBankContext)
        {
            _BPBankContext = bPBankContext;
        }

        public async Task<User> GetByLoginName(string loginName)
        {
            var searchLoginName= loginName.Trim().ToLower();
            return await _BPBankContext.Users.
                Include(u=>u.Accounts).
                ThenInclude(a=>a.BaseCcy).
                Include(u=>u.Accounts).
                ThenInclude(a=>a.Transactions).
                Where(u => u.LoginName == searchLoginName).
                FirstOrDefaultAsync();
        }
    }
}
