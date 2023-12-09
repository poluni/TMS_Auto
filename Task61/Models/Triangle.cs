using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task61.Models
{
    internal class Triangle : Shape
    {
        public Triangle()
        {
        }

        public Triangle(double a) : this()
        {
            if (a > 0) {
                A = a;
            }
        }

        public Triangle(double a, double b) : this(a)
        {
            if (b > 0)
            {
                B = b;
            }
        }

        public Triangle(double a, double b, double c) : this (a, b)
        {            
            if (c > 0 && a + b > c && a + c > b && b + c > a)
            {
                C = c;
            }
        }

        public double A;
        public double B;
        public double C;

        public override double GetArea() 
        {
            double p = (A + B + C) / 2;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area; 
        }

        public override double GetPerimetr() => (A + B + C) / 2;
    }
}
