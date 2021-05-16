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
                new { Id = 1, ISOCode = "GBP", ExternalId = "GBP", Description = "British Pounds" },
                new { Id = 2, ISOCode = "USD", ExternalId = "USD", Description = "United States Dollars" },
                new { Id = 3, ISOCode = "EUR", ExternalId = "EUR", Description = "EU Euros" });

            modelBuilder.Entity<Account>().HasData(
                new Account { Id = 1, UserId=1, AccNumber="123456", Balance=25000m, BaseCcyId = 1 },
                new Account { Id = 2, UserId=1, AccNumber="764321", Balance = 47000m, BaseCcyId = 2 },
                new Account { Id = 3, UserId=2, AccNumber="827419", Balance = 8000m, BaseCcyId = 3 },
                new Account { Id = 4, UserId = 1, AccNumber = "243970", Balance = 4000m, BaseCcyId = 1 },
                new Account { Id = 5, UserId = 1, AccNumber = "100321", Balance = 500m, BaseCcyId = 1 });

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Fred",
                    Surname = "Flintstone",
                    LoginName = "fred"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Barney",
                    Surname = "Rubble",
                    LoginName = "barney"
                });


        }
    }
}
