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

        public Rectangle(double a, double b) : base(a, b) => Width = b;

        public double Length { get; set; }

        public double Width { get; set; }

        public override void GetArea() =>
            Console.WriteLine(string.Format("Площадь прямоугольника {0:f2}", Length * Width));
    }
}
