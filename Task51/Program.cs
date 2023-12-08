// Задача "Введение в ООП". Задача 1.

using Task51.Models;

namespace Task51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Square(5.5),
                new Square(3),
                new Rectangle(2, 3),
                new Triangle(3, 3, 3).CreateTriangle(),
                new Triangle(5, 5, 8).CreateTriangle(),
                new Triangle(3, 4, 5).CreateTriangle(),
                new Triangle(8, 7, 3).CreateTriangle()
            };

            foreach (Shape shape in shapes)
            {
                shape.GetArea();
            }
        }
    }
}
