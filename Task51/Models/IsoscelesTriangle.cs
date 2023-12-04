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
        public double IsoscelesTriangleArea(double a, double alpha, double beta)
        {
            double area = (a * a * Math.Sin(alpha) * Math.Sin(beta)) / (2 * Math.Sin(alpha + beta));
            return area;
        }
    }
}
