using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class ATM
    {
        public List<Bills> cassets = new List<Bills>();

        public void loadCassets(string path, List<Bills> cassets)
        {
            using (var reader = new System.IO.StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    cassets.Add(new Bills() { Value = int.Parse(line.Split(' ')[0]), Count = int.Parse(line.Split(' ')[1]) });
                }
            }
        }

        public string getSumm(int cash)
        {
           

            return result.ToString();
        }
    }
}