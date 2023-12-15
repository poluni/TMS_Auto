using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51.Models
{
    class Square : Rectangle
    {
        public Square(double a) : base(a) => Length = a;

        public override double GetArea()
        {
            double area = Length * Length;
            Console.WriteLine(string.Format("Площадь квадрата {0:f2}", area));
            return area;
        }
    }
}
