using Task54.Models;

namespace Task54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto[] autos =
            {
            new Motocycle("fg456hj", "Yamaha", 99.8, 2, true),
            new Motocycle("gh456hj", "Yamaha", 100.8),
            new Motocycle("fd456hj", "Yamaha", 120, 1.4, false),
            new Motocycle("rt456hj", "Yamaha", 143.15, 0, true),
            new Truck("yu123dd", "КАМАЗ", 55.2, 8.5, true),
            new Motocycle("yu123as", "КАМАЗ", 15),
            new Motocycle("rf123fg", "КАМАЗ", 120, 20.4, false),
            new Motocycle("yu123hj", "КАМАЗ", 143.15, 0, true),
            new PassengerCar("rt4g6hj", "Audi", 120, 15)
            };

            foreach (Auto auto in autos) auto.PrintAutoInfo();

            Console.Write("Введите грузоподъемность для поиска: ");
            double loadCapacityUser = Convert.ToDouble(Console.ReadLine().Trim());
            foreach (Auto auto in autos)
            {
                if (loadCapacityUser.Equals(auto.LoadCapacity)) auto.GetLoadCapacity();
            }
        }
    }
}
