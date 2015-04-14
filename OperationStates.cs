using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    public enum OperationStates : int
    {
        OK = 1,
        NotEnoughMoney = 2,
        ImposibleToCollectSum = 3
    };
}
