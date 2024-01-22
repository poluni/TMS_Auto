using LINQ.models;

namespace LINQ;

public class SalaryStatement
{
    public string EmployeeSurname { get; set; }

    public decimal Salary { get; set; }

    public SalaryStatement(string surname, decimal salary)
    {
        EmployeeSurname = surname;
        Salary = salary;
    }
}