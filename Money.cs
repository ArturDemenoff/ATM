using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class Money
    {
        public Dictionary<Bill, int> money { get; set; }

        public int TotalSumm()
        {
            int total = 0;

            foreach(var a in money)
            {
                total += (a.Key.Nominal * a.Value);
            }

            return total;
        }
    }
}
