using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task113.data;
using Task113.helper;

namespace Task113
{
    public class Sorting
    {
        private TestStringSet _testStringSet = new TestStringSet();

        public void Run()
        {
            var result = _testStringSet.List
                .Select(s => s)
                .OrderBy(s => s.Length)
                .ThenByDescending(s => s);
            Console.WriteLine("Итоговый массив: ");
            PrintHelper.Print(result, i => Console.Write($"{i} "));
        }
    }
}
