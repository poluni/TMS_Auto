using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51.Models
{
    class Figure
    {
        public void CreateFigure(double a, double b, double c)
        {
            if (a + b > c || a + c > b || b + c > a)
            {
                Triangle triangle = new Triangle();
            }
            else if (a == b )
            { 
            }
        }
    }
}
