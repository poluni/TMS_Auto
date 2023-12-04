using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51.Models
{
    class ScaleneTriangle : Triangle
    {
        public double ScaleneTriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    }
}
