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
        public AlgorithmStates State { get; set; }
        public Money DispouseSumm(Money cassets, int requestedSum)
        {
            int[] combination = new int[requestedSum];

            int count = 0;

            if(requestedSum > cassets.TotalSumm())
            {
                State = AlgorithmStates.NotEnoughMoney;

                return null;
            }


            for (int i = 1; i <= cassets.money.Sum(x => x.Value); i++)
            {
                if (RightCombination)
                {
                    combination = combination.Where(x => x != null).ToArray();
                    Dictionary<Bill , int > resultSumm = new Dictionary<Bill,int>();
                    foreach(var a in cassets.money)
                    {
                        count = combination.Where(x => x == a.Key.Nominal).Count();
                        resultSumm.Add(a.Key, count);
                    }

                    State = AlgorithmStates.OK;

                    return new Money() { money = resultSumm };
                }
                else if(State == AlgorithmStates.ImposibleToCollectMoney)
                {
                    break;
                }

                combination = new int[i];
                FindCombination(cassets.money.Count, i, cassets, combination, requestedSum);
            }

                return null;
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

                    State = AlgorithmStates.ImposibleToCollectMoney;

                }
            }
            else
            {
                for (int i = cassetsIndex; i < n; i++)
                {
                    if (RightCombination || State == AlgorithmStates.ImposibleToCollectMoney)
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
