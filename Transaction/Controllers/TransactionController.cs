using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Transaction.models;

namespace Transaction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        // Transaction
        [HttpPost]
        public ActionResult<string> TransferMoney([FromBody] UserTransaction value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if(value.Amount < 0)
            {
                return "Ammount can not be negative";
            }
            return "Transfered " + value.Amount + " successfully.";
        }

        // Transaction Summay
        [HttpGet("{userId}")]
        public ActionResult<string> TransactionSummary(int userId)
        {

            return "Transaction Summary";
        }
    }
}
