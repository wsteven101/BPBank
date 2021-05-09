using BPBank.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPBank.Data
{
    public class BPBankContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Currency> Currencys { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public BPBankContext(DbContextOptions<BPBankContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().
                    HasOne(a => a.BaseCcy);

            modelBuilder.Entity<Currency>().HasData(
                new { CurrencyId = 1, ISOCode = "GBP", ExternalId = "GBP", Description = "British Pounds" },
                new { CurrencyId = 2, ISOCode = "USD", ExternalId = "USD", Description = "United States Dollars" },
                new { CurrencyId = 3, ISOCode = "EUR", ExternalId = "EUR", Description = "EU Euros" });

            modelBuilder.Entity<Account>().HasData(
                new Account { AccountId = 1, UserId=1, AccNumber="123456", BaseCcyCurrencyId = 1 },
                new Account { AccountId = 2, UserId=1, AccNumber="764321", BaseCcyCurrencyId = 2 },
                new Account { AccountId = 3, UserId=2, AccNumber="827419", BaseCcyCurrencyId = 3 });

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    FirstName = "Fred",
                    Surname = "Flintstone",
                    LoginName = "fred"
                },
                new User
                {
                    UserId = 2,
                    FirstName = "Barney",
                    Surname = "Rubble",
                    LoginName = "barney"
                });


        }
    }
}
