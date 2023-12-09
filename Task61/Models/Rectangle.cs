using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task61.Models
{
    internal class Rectangle : Triangle
    {
        public Rectangle(double a, double b) : base(a, b)
        {
            Width = a;
            Length = b;
        }

        public Rectangle(double a) : base(a)
        {
        }

        public double Width { get; set; }

        public double Length { get; set; }

        public override double GetArea() => Width * Length;

        public override double GetPerimetr() => 2 * (Width + Length);
    }
}
