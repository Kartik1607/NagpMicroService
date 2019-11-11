using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnBoard.models;

namespace OnBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnBoardController : ControllerBase
    {
        // Onboard User
        [HttpPost]
        public ActionResult<UserAccount> CreteNewUser([FromBody]UserAccount account)
        {
            Random random = new Random();
            var Account = new UserAccount()
            {
                AccountNumber = random.Next(10, 10000) + "",
                Balance = account.Balance,
                Name = account.Name
            };
            return Account;
        }

        // DeBoard User
        [HttpDelete("{id}")]
        public ActionResult<string> RemoveUser(int id)
        {
            return "User removed with id" + id;
        }
    }
}
