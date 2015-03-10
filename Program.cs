using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const int maxAmount = 5000000;

            ATM atm = new ATM();

            atm.loadCassets(@"C:\Users\Artur\Documents\Visual Studio 2013\Projects\OOP_lab1\OOP_lab1\money.txt", atm.cassets);
            int summ;

            do
            {
                Console.Write("Input your summ : ");
                summ = int.Parse(Console.ReadLine());

                if (summ != maxAmount)
                {
                    Console.Write(atm.getSumm(summ));
                }
                else
                {
                    break;
                }

            }while(summ != 0);           
        }
    }

}