using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            var doublesOrdered = doubles.OrderByDescending(x => x);
            foreach (var i in doublesOrdered)
                Console.WriteLine(i);
        }
    }
}
