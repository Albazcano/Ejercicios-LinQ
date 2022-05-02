using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            var uniqueFactors = factorsOf300.Distinct().Count();

            Console.WriteLine("There are {0} unique factors of 300.", uniqueFactors);
        }
    }
}
