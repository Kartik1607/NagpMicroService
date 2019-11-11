using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChequeController: ControllerBase
    {
        // Cheque book ordering
        [HttpPost("{userId}")]
        public ActionResult<string> OrderCheckBook(int userId)
        {
            return "Check Book Ordered for User" + userId;
        }

        // Cheque book cancelling
        [HttpDelete("{userId}")]
        public ActionResult<string> CancelCheckBookOrder(int userId)
        {
            return "Check Book Order for User" + userId + " Cancelled";
        }
    }
}
