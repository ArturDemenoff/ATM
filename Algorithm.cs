using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class Algorithm
    {
        bool RightCombination = false;

        public Money withdrawMoney(Money cassets, int requestedSum)
        {
            int[] combination = new int[requestedSum];
            int count = 0;

            for (int i = 1; i <= cassets.money.Sum(x => x.Value); i++)
            {
                if (RightCombination)
                {
                    combination = combination.Where(x => x != null).ToArray();
                    foreach(var a in cassets.money)
                    {
                        count = combination.Where(x => x == a.Key.Nominal).Count();
                        cassets.money[a.Key] -= count;
                    }

                    break;
                }
                combination = new int[i];
                FindCombination(cassets.money.Count, i, cassets, combination, requestedSum);
            }

                return cassets;
        }


        public void FindCombination(int n, int k, Money cassets, int[] combination, int requestedSum, int combinationIndex = 0, int cassetsIndex = 0)
        {

            if (combinationIndex == k)
            {
                if (combination.Sum() == requestedSum)
                {
                    RightCombination = true;
                }
                else if (combination.Sum() > requestedSum)
                {

                    //

                }
            }
            else
            {
                for (int i = cassetsIndex; i < n; i++)
                {
                    if (RightCombination)
                    {
                        break;
                    }
                    combination[combinationIndex] = cassets.money.ElementAt(i).Key.Nominal;
                    FindCombination(n, k, cassets, combination, requestedSum, combinationIndex + 1, i);
                }
            }
        }
    }
}
