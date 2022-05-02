using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsPlusOne = numbers.Select(n => n + 1);

            Console.WriteLine("New array:");
            foreach (var j in numsPlusOne)
            {
                Console.WriteLine(j.ToString());
            }
        }
    }
}
