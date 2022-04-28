
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Tres formas de hacerlo
		string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
		//var first = words.First(word => word.First() == 'o');
		//var first = words.First(word => word[0]== 'o');
		var first = words.First(word => word.StartsWith("o"));

		Console.WriteLine(first);
        }
    }
}
