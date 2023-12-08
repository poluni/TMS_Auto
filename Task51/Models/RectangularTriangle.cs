//Прямоугольный треугольник.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51.Models
{
    class RectangularTriangle : Triangle
    {
        public RectangularTriangle(double a, double b, double c) : base(a, b, c)
        {
        }

        public override void GetArea() =>
             Console.WriteLine(string.Format("Площадь прямоугольного треугольника {0:f2}", 0.5 * A * B));

    }
}
