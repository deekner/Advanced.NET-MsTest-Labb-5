using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    public class Transactions
    {
        public double Amount { get; set; }
        public string accFrom { get; set; }
        public string accTo { get; set; }

        public Transactions(double Amount, string accFrom, string accTo)
        {
            this.Amount = Amount;
            this.accFrom = accFrom;
            this.accTo = accTo;
        }
       
    }
}
