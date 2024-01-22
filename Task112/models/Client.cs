using static System.Net.Mime.MediaTypeNames;

namespace LINQ.models;

public struct Client
{
    public Client(int year, sbyte month, int houres)
    {
        Code = new Random().Next();
        if (year > 2017) Year = year;
        if (month >= 1 && month <= 12) Month = month;
        Houres = houres;
    }

    public int Code { get; private set; }

    public int Year { get; set; }

    public sbyte Month { get; set; }

    public int Houres { get; set; }

    public override string ToString()
    {
        return $"Code: {Code}, Year: {Year}, Month: {Month}, Houres: {Houres}";
    }
}