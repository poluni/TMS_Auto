using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51.Models
{
    class Rectangle : Shape
    {
        public Rectangle(double a) => Length = a;

        public Rectangle(double a, double b) : this(a) => Width = b;

        public double Length { get; set; }

        public double Width { get; set; }

        public override double GetArea()
        {
            double area = Length * Width;
            Console.WriteLine(string.Format("Площадь прямоугольника {0:f2}", area));
            return area;
        }
    }
}
