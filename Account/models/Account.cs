using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.models
{
    public class UserAccount
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public long Balance { get; set; }
    }
}
