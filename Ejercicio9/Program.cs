using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var wordsOrdered = words.OrderBy(x => x.Length);
            foreach (var i in wordsOrdered)
                Console.WriteLine(i);
        }
    }
}
