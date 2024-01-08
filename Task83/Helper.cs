using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Task83
{
    internal static class Helper
    {
        public static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
