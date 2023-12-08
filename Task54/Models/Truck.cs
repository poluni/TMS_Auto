using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task54.Models
{
    internal class Truck : Auto
    {
        public Truck(string number, string make, double speed, double loadCapacity, bool isTrailer = false) : base(number, make, speed)
        {
            IsTrailer = isTrailer;
            if (IsTrailer)
            {
                LoadCapacity = loadCapacity * 2;
            }
            LoadCapacity = loadCapacity;
        }

        public bool IsTrailer { get; set; }

        public override void PrintAutoInfo()
        {
            base.PrintAutoInfo();
            Console.Write(IsTrailer ? "Есть прицеп" : "Нет прицепа");
            Console.WriteLine();
        }

        public override void GetLoadCapacity() => Console.WriteLine($"Найден грузовик {Make} c номером {Number} - {LoadCapacity}");
    }
}
