using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task54.Models
{
    internal class Motocycle : Auto
    {
        public Motocycle(string number, string make, double speed, double loadCapacity = 0, bool isSideCar = false) : base(number, make, speed)
        {
            IsSideCar = isSideCar;
            if (IsSideCar)
            {
                LoadCapacity = loadCapacity;
            }
            else LoadCapacity = 0;
        }

        public bool IsSideCar { get; set; }

        public override void PrintAutoInfo()
        {
            base.PrintAutoInfo();
            Console.Write(IsSideCar ? "Есть коляска" : "Нет коляски");
            Console.WriteLine();
        }

        public override void GetLoadCapacity() => Console.WriteLine($"Найден мотоцикл {Make} c номером {Number} - {LoadCapacity}");
    }
}
