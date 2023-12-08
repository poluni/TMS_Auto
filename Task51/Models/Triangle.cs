using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51.Models
{
    class Triangle : Shape
    {
        public Triangle(double a, double b, double c) : base(a, b, c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
        }

        public Triangle CreateTriangle()
        {
            {
                if (A == B && B == C)
                {
                    EquilateralTriangle triangle = new EquilateralTriangle(A, B, C);
                    return triangle;
                }
                else if (A == B || B == C || A == C)
                {
                    return new IsoscelesTriangle(A, B, C);
                }
                else if (A == B && B == C)
                {
                    return new EquilateralTriangle(A, B, C);
                }
                else if (A * A + B * B == C * C)
                {
                    return new RectangularTriangle(A, B, C);
                }
                return new ScaleneTriangle(A, B, C);
            }
        }
    }
}
