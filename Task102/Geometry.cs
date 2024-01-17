using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task102
{
    internal class Geometry
    {
        private delegate double Calculate(double r);

        public void CalculateGeometry(double r)
        {
            Calculate length = GetLengthCircle;
            Calculate squre = GetSquareCircle;
            Calculate volume = GetVolumeSphere;

            Console.WriteLine(string.Format("Длина окружности: {0:f2}", length(r)));
            Console.WriteLine(string.Format("Площадь круга: {0:f2}", squre(r)));
            Console.WriteLine(string.Format("Объем сферы: {0:f2}", volume(r)));
        }

        private double GetLengthCircle(double radius) => 2 * Math.PI * radius;

        private double GetSquareCircle(double radius) => Math.PI * radius * radius;

        private double GetVolumeSphere(double radius) => Math.PI * Math.Pow(radius, 3) * 4 / 3;
    }
}
