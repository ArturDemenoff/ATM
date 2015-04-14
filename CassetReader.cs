using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class CassetReader
    {
        public Money cassets { get; set; }

        public void Read(string filePath)
        {
            this.cassets = new Money();

            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                this.cassets.money.Add( new Bill() { Nominal = int.Parse(lines[i].Split(' ')[0]) },int.Parse(lines[i].Split(' ')[1]));
            }
        }
    }
}
