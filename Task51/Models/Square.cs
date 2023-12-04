using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51.Models
{
    class Square : Rectangle
    {
        double squareA;

        public double SquareA { get; set; }

        public override double RectangleArea => squareA * squareA;

    }
}
