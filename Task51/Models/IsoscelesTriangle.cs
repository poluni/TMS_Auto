// Равнобедренный треугольник

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51.Models
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double a, double b, double c) : base(a, b, c)
        {
        }

        public override double GetArea()
        {
            double area = Math.Sqrt(Math.Abs(A * A) - (B / 2) * (B / 2)) * B * 0.5;
            Console.WriteLine(string.Format("Площадь равнобедренного треугольника {0:f2}", area));
            return area;
        }
    }
}
