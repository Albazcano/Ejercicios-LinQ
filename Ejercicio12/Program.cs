using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

			var numbersGrouped = numbers.GroupBy(x => x % 5);
			foreach (var i in numbersGrouped)
			{
				Console.WriteLine("\tNumbers grouped by remain'{0}':", i.Key);

				foreach (var j in i)
				{
					Console.Write("Valores" + j);
					Console.WriteLine();
				}
			}
		}
    }
}
