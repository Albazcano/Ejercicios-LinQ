using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
			int[] numbersB = { 1, 3, 5, 7, 8 };


			var uniqueNumbers = numbersA.Intersect(numbersB);

			foreach (var j in uniqueNumbers)
			{
				Console.WriteLine(j.ToString());
			}
		}
    }
}
