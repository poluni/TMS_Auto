using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51.Models
{
    class Rectangle : Figure
    {
        double rectangleA;
        double rectangleB;

        public double RectangleA { get; set; }

        public double RectangleB { get; set; }

        public virtual double RectangleArea => rectangleA * rectangleB;
    }
}
