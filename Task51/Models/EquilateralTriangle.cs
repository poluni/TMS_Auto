// Равносторонний треугольник

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51.Models
{
    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double a, double b, double c) : base(a, b, c)
        {
        }

        public override void GetArea() =>
    Console.WriteLine(string.Format("Площадь равностороннего треугольника {0:f2}", (A * A * Math.Sqrt(3)) / 4));
    }
}
