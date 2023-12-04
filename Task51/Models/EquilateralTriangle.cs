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
        public double EquilateralTriangleArea(double a) => (a * a * Math.Sqrt(3)) / 4;
    }
}
