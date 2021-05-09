using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPBank.Domain.Contracts.MarketData
{
    public interface IFXRateService
    {
        public Task<decimal> GetLatestRate(string fromCcy, string toCcy);
    }
}
