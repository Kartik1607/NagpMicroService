using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transaction.models
{
    public class UserTransaction
    {
        public string From { get; set; }
        public string To { get; set; }
        public double Amount { get; set; }
    }
}
