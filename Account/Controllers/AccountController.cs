using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Account.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Account.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private Config config;
        public AccountController(IOptions<Config> config)
        {
            this.config = config.Value;
        }

        [HttpGet]
        public ActionResult<UserAccount> GetAccount()
        {
            var Account = new UserAccount()
            {
                AccountNumber = "1234",
                Balance = 1000,
                Name = config.Message,
            };
            return Account;
        }

        // Viewing the Accounts Linked with an UserId
        [HttpGet("{id}")]
        public ActionResult<UserAccount> GetAccountById(int id)
        {
            var Account = new UserAccount()
            {
                AccountNumber = ""+id,
                Balance = 1000,
                Name = "Kartik Sharma"
            };
            return Account;
        }

        // Updating the Accounts Linked with an UserId
        [HttpPut("{id}")]
        public ActionResult<UserAccount> UpdateAccountById(int id,[FromBody]UserAccount account)
        {
            var acc = this.GetAccountById(id);
            acc.Value.Name = account.Name;
            return acc.Value;
        }
    }
}
