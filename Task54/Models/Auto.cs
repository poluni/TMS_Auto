using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task54.Models
{
    internal class Auto
    {
        public Auto(string number, string make, double speed)
        {
            Number = number;
            Make = make;
            Speed = speed;
        }

        public Auto(string number, string make, double speed, double loadCapacity) : this(number, make, speed)
        {
            Number = number;
            Make = make;
            Speed = speed;
            LoadCapacity = loadCapacity;
        }

        public string Number { get; set; }

        public string Make { get; set; }

        public double Speed { get; set; }

        public double LoadCapacity { get; set; }

        public virtual void PrintAutoInfo()
        {
            Console.WriteLine();
            Console.Write($"Номер - {Number}, Марка - {Make}, Скорость - {Speed}, Грузоподъемность {LoadCapacity} ");
        }

        public virtual void GetLoadCapacity() { }
    }
}
