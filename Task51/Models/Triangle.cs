using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51.Models
{
    class Triangle : Figure
    {
        double alpha;
        double beta;

        double a;
        double b;
        double c;

        enum Triangles
        {
            Equilateral
        }

        public double Alpha { get; set; }
        public double Beta { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public void CreateTriangle(double a, double b, double c, double alpha, double beta)
        {
                if (a == b && b == c)
                {
                     new EquilateralTriangle();
                }
                else if (a == b || b == c || a == c)
                {
                     new IsoscelesTriangle();
                }
                else if (a * b + b * b == c * c)
                {
                     new RectangularTriangle();
                }
                else new ScaleneTriangle();      
        }
    }
}
