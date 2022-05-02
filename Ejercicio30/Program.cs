using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    internal class Program
    {
        static void Main(string[] args)
        {
			string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

			var wordsUppercase = words.Select(x => x.ToUpper());

			Console.WriteLine("New array with Uppercase:");

			foreach (var j in wordsUppercase)
			{
				Console.WriteLine(j.ToString());
			}

			var wordsLowercase = words.Select(x => x.ToLower());

			Console.WriteLine("New array with Lowercase:");

			foreach (var j in wordsLowercase)
			{
				Console.WriteLine(j.ToString());
			}
		}
    }
}
