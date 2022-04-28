using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			int[] numbersFiltered = numbers.Where(x => x < 5).ToArray();

			Console.WriteLine("numbers");
			Console.Write("\t");
			foreach (int i in numbers)
				Console.Write(i + " ");

			Console.WriteLine("\nArray Filtrado");
			Console.Write("\t");
			foreach (int i in numbersFiltered)
				Console.Write(i + " ");
		}
    }
}
