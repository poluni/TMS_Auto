using LINQ;
using LINQ.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task112
{
    internal class Stat
    {
        private TestObjectDataSet _testObjSet = new TestObjectDataSet();

        public void Run()
        {
            var min = _testObjSet.Min(client => client.Houres);
            var result = _testObjSet.Where(c => c.Houres == min).Select(c =>
                new
                {
                    c.Houres,
                    c.Year,
                    c.Month
                }).LastOrDefault();

            Console.WriteLine($"Клиент с минимальной продолжительностью: ");
            Console.WriteLine($"Продолжительность занятий: {result.Houres}, год: {result.Year}, месяц: {result.Month}");
        }
    }
}
