namespace LINQ.models;
using Task114.models;

public class Employee
{
    public Employee(string surname)
    {
        Surname = surname;
    }

    public Employee(string surname, Specialization specialization) : this(surname)
    {
        Specialization = specialization;
    }

    public string Surname { get; set; }

    public Specialization Specialization { get; set; }
}