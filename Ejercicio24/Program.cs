using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] factorsOf300 = { 2, 2, 3, 5, 5 };
			var uniqueFactors = factorsOf300.Distinct();

			Console.Write("Result:");

			foreach (var j in uniqueFactors)
			{
				Console.WriteLine(j.ToString());
			}
		}
    }
}
