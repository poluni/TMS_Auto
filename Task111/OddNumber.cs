using LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task111;
using Task111.helper;

namespace Task111
{
    public class OddNumber
    {
        private TestIntDataSet _testIntSet = new TestIntDataSet();

        public void Run()
        {
            var result = _testIntSet.Where(num => num % 2 == 1).Distinct();
            Console.WriteLine("Итоговый массив: ");
            PrintHelper.Print(result, i => Console.Write($"{i} "));           
        }
    }
}
