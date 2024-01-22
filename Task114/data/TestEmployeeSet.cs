using System.Collections;
using System.Collections.Generic;
using LINQ.models;
using Task114.models;

namespace LINQ;

public class TestEmployeeSet : IEnumerable<Employee>
{
    public IEnumerator<Employee> GetEnumerator()
    {
        var EmployeeList = new List<Employee>()
        {
            new Employee("Smith", Specialization.Engineer),
            new Employee("Wilson", Specialization.Engineer),
            new Employee("Burr", Specialization.StaffEngineer),
            new Employee("Mayers", Specialization.StaffEngineer),
            new Employee("Ferguson", Specialization.StaffEngineer),
            new Employee("Somberg", Specialization.PrincipalEngineer),
        };

        foreach (Employee s in EmployeeList)
        {
            yield return s;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}