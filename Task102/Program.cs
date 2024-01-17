namespace Task102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");

            if (double.TryParse(Console.ReadLine().Trim(), out double radius))
            {
                new Geometry().CalculateGeometry(radius);
            }
            else Console.WriteLine("Неуспешный ввод радиуса.");
        }
    }
}
