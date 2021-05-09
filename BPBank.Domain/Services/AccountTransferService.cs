using BPBank.Domain.Contracts.MarketData;
using BPBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPBank.Domain.Services
{
    public class AccountTransferService
    {
        private readonly IFXRateService _fXRateService;
        public AccountTransferService(IFXRateService fXRateService)
        {
            _fXRateService = fXRateService;
        }

        public async Task Transfer(
            int fromAccount, 
            int toAccount, 
            decimal amount)
        {

        }
    }
}
