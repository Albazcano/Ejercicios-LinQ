using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
	public class Program
	{
		public static void Main()
		{
			string[] words = { "believe", "relief", "receipt", "field" };
			var selectedWord = words.Any(word => word.Contains("ei"));

			Console.WriteLine(selectedWord);

		}
	}
}
