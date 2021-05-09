using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPBank.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string LoginName { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public List<Account> Accounts { get; set; } = new List<Account>();
    }
}
