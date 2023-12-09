// Тема "Абстрактные классы и интерфейсы". Задача 1.

using Task61.Models;

namespace Task61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
             new Triangle(5, 5 , 6.4),
             new Triangle(5, 5 , 5),
             new Rectangle(5.3, 6.2),
             new Circle(5.1),
             new Circle(3)
            };

            foreach (Shape shape in shapes)
            {
                Console.Write(string.Format("Периметр - {0:f2}", shape.GetPerimetr()));
                Console.WriteLine(string.Format(" Площадь {0:f2}", shape.GetArea()));
            }
        }
    }
}
