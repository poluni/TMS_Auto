using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51.Models
{
    public class Shape
    {
        public Shape()
        {
        }

        public Shape(double a, double b) : this()
        {
            if (a > 0 && b > 0)
            {
                A = a;
                B = b;
            }
        }

        public Shape(double a, double b, double c) : this(a, b)
        {
        }

        public double A { get; set; }

        public double B { get; set; }

        public double C { get; set; }

        public virtual void GetArea() { }
    }
}
