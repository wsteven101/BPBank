using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BPBank.Domain.Contracts.MarketData;

namespace BPBank.MarketData
{
    public class FXRateService : IFXRateService
    {
        private readonly IHttpClientFactory _clientFactory;

        public FXRateService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<decimal> GetLatestRate(string fromCcy, string toCcy)
        {
            var client = _clientFactory.CreateClient();

            var baseUrl = @" https://api.ratesapi.io/api/latest";
            var fullUrl = QueryHelpers.AddQueryString(baseUrl, "symbols", fromCcy + "," + toCcy);

            var request = new HttpRequestMessage(HttpMethod.Get, fullUrl);
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                throw new Exception($"Http get request {fullUrl} failed");
            }

            var responseString = response.ToString();
            var fxRate = Decimal.Parse(responseString);

            return fxRate;
        }

        
    }
}
