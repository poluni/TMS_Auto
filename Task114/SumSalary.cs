using LINQ;
using Task114.models;
using LINQ.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task114.helper;

namespace Task114
{
    public class SumSalary
    {
        private TestEmployeeSet _testEmployeeSet = new TestEmployeeSet();

        private TestSalarySet _testSalaryStatementSet = new TestSalarySet();

        public void Run()
        {
            var queryResult = _testEmployeeSet
                        .Join
                        (_testSalaryStatementSet,
                        emp => emp.Surname,
                        sal => sal.EmployeeSurname,
                        (emp, sal) => new { emp.Specialization, sal.Salary })
                        .GroupBy(x => x.Specialization)
                        .Select(y => new
                        {
                            Specialization = y.Key,
                            SumSalary = y.Sum(sal
                        => sal.Salary)
                        });

            PrintHelper.Print(queryResult, s => Console.WriteLine(s));
        }
    }
}
