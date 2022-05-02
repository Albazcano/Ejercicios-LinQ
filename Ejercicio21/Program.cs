using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var arrayWords = words.Sum(x => x.Length);
            Console.WriteLine(arrayWords);
        }
    }
}
