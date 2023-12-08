using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51.Models
{
    class ScaleneTriangle : Triangle
    {
        public ScaleneTriangle(double a, double b, double c) : base(a, b, c)
        {
        }

        public override void GetArea()
        {
            double p = (A + B + C) / 2;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            Console.WriteLine(string.Format("Площадь обычного треугольника {0:f2}", area));
        }
    }
}
