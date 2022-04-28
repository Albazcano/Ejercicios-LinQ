using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var digitsOrdered = digits.OrderBy(x => x.Length).ThenBy(l => l);
            foreach (var i in digitsOrdered)
                Console.WriteLine(i);
        }
    }
}
