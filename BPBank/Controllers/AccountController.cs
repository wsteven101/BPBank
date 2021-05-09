using BPBank.Domain.Entities;
using BPBank.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPBank.Domain.Contracts.DomainServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BPBank.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountBalanceService _accountBalanceService;

        public AccountController(IAccountBalanceService accountBalanceService) 
        {
            _accountBalanceService = accountBalanceService;
        }

        // GET: api/<AccountController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AccountController>/5
        [HttpGet("user/{id}")]
        public async Task<ActionResult<IEnumerable<Account>>> GetAccounts(string id)
        {
            try
            {
                var balances = await _accountBalanceService.GetUserBalances(id);
                return balances.ToList();
            }
            catch (Exception ex)
            {
                return NotFound("Error:" + ex.Message);
            }
        }

        // POST api/<AccountController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
