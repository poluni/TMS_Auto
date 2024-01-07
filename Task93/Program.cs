using Task93.Models;

namespace Task93
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diesel diesel = new();
            Car<Diesel> car1 = new(diesel);
            car1.Backwards();
            car1.Leftwards();

            Electric electric = new();
            Car<Electric> car2 = new(electric);
            car2.Forwards();
            car2.Rightwards();
        }
    }
}
