using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task61.Models
{
    internal class Circle : Rectangle
    {
        public Circle(double radius) : base(radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double GetArea() => Radius * Radius * Math.PI;

        public override double GetPerimetr() => Radius * 2 * Math.PI;
    }
}
