using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task54.Models
{
    internal class PassengerCar : Auto
    {
        public PassengerCar(string number, string make, double speed, double loadCapacity) : base(number, make, speed, loadCapacity)
        {
        }

        public override void PrintAutoInfo()
        {
            base.PrintAutoInfo();
            Console.WriteLine();
        }

        public override void GetLoadCapacity() => Console.WriteLine($"Найдена легковая машина {Make} c номером {Number} - {LoadCapacity}");
    }
}
