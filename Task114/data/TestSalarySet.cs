using System.Collections;
using System.Collections.Generic;
using LINQ.models;
using Task114.models;

namespace LINQ;

public class TestSalarySet : IEnumerable<SalaryStatement>
{
    public IEnumerator<SalaryStatement> GetEnumerator()
    {
        var SalaryStatementList = new List<SalaryStatement>()
    {
        new SalaryStatement("Smith", 12_000M),
        new SalaryStatement("Wilson", 16_500M),
        new SalaryStatement("Burr", 148_800M),
        new SalaryStatement("Mayers", 160_000M),
        new SalaryStatement("Ferguson", 171_250M),
        new SalaryStatement("Somberg", 180_100M)
    };

        foreach (SalaryStatement s in SalaryStatementList)
        {
            yield return s;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}