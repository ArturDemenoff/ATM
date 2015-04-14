using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    public enum AlgorithmStates
    {
        OK = 1,
        ImposibleToCollectMoney = 2,
        NotEnoughMoney = 3
    };
}
