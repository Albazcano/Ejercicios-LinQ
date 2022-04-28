using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			int[] numbersFiltered = numbers.Where(x => x > 5).ToArray();

			Console.WriteLine("numbers");
			Console.Write("\t");
			foreach (int i in numbers)
				Console.Write(i + " ");

			Console.WriteLine("\nArray Filtrado");
			Console.Write("\t");
			foreach (int i in numbersFiltered)
				Console.Write(i + " ");
			Console.Write("\n");

			int secondBigger = (from number in numbers
								orderby number descending
								select number).Skip(1).First();

			Console.Write("Second number > 5");
			Console.Write("\n");
			Console.Write(secondBigger);
		}
    }
}
