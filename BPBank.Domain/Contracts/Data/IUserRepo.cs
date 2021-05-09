using BPBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPBank.Domain.Contracts.Data
{
    public interface IUserRepo
    {
        public Task<User> GetByLoginName(string userId);
    }
}
