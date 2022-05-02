using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

			var numsToText = numbers.Select(x => strings[x]);

			Console.WriteLine("New array:");

			foreach (var j in numsToText)
			{
				Console.WriteLine(j.ToString());
			}
		}
    }
}
