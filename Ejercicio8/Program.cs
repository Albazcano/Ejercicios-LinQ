using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
			string[] words = { "cherry", "apple", "blueberry" };

			var wordsOrdered = words.OrderBy(x => x);
			foreach (var i in wordsOrdered)
				Console.WriteLine(i);

			//Otra manera de hacerlo

			/*var wordsList = words.ToList();
			wordsList.Sort();

			foreach(var i in wordsList)
				Console.WriteLine(i);*/
		}
	}
}
