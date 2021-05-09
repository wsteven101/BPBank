using BPBank;
using BPBank.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Test.BPBank
{
    public class AccountControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task test_get_user_accounts()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            var configuration = builder.Build();
            var webHostBuilder =
                  new WebHostBuilder()
                        .UseConfiguration(configuration)
                        .UseEnvironment("Development")
                        .UseStartup<Startup>();

            using (var server = new TestServer(webHostBuilder))
            using (var client = server.CreateClient())
            {
                string resultString = await client.GetStringAsync("api/account/user/fred");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var accounts = JsonSerializer.Deserialize<IEnumerable<Account>>(resultString,options);

                Assert.Greater(accounts.Count(), 0);
            }
        }
    }
}