using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var arrayWords = words.Max(x => x.Length);
            Console.WriteLine(arrayWords);
        }
    }
}
