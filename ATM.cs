using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CashMachine
{
    class ATM
    {
        public Cassets[] cassets;
        bool RightCombination = false;

        public void loadCassets(string path)
        {
            string[] stringCassets = File.ReadAllLines(path);

            cassets = new Cassets[stringCassets.Length];

            for(int i = 0; i < stringCassets.Length; i++)
            {
                cassets[i] = new Cassets() { Bill = new Bills() { Nominal = int.Parse(stringCassets[i].Split(' ')[0]) }, Count = int.Parse(stringCassets[i].Split(' ')[1]) };
            }
        }
        public void withdrawMoney()
        {
            int[] combination;
            int requestedSum = 160;

            for (int i = 1; i <= cassets.Sum(x => x.Count); i++)
            {
                if (RightCombination) break;
                combination = new int[i];
                FindCombination(cassets.Length, i, cassets, combination, requestedSum);
            }
        }
        
        public void FindCombination(int n,int k,Cassets[] cassets, int[] combination,int requestedSum, int combinationIndex = 0, int cassetsIndex = 0)
        {
            
            if(combinationIndex == k)
            {
                if(combination.Sum() == requestedSum)
                {
                    RightCombination = true;
                }
            }
            else 
            {
                for(int i = cassetsIndex; i < n; i++)
                {
                    if (RightCombination) break;
                    combination[combinationIndex] = cassets[i].Bill.Nominal;
                    FindCombination(n, k, cassets, combination, requestedSum, combinationIndex + 1, i);
                }
            }
        }
    }
}