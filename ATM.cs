using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class ATM
    {
        public List<Cassets> cassets = new List<Cassets>();

        public void loadCassets(string path)
        {
            using (var reader = new System.IO.StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    cassets.Add(new Cassets() {Bill = new Bills() { Nominal = int.Parse(line.Split(' ')[0])}, Count = int.Parse(line.Split(' ')[1])});
                }
            }
        }

        public Money getSumm(int cash)
        {
            Money money = new Money();

            return money;
        }
    }
}