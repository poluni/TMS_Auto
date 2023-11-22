// Тема 2 "Массивы и циклы". Задача 7.

namespace TMS_Auto
{
    static class Task27
    {
        static void Main(string[] args)
        {
            string[] namesArray = { "Domenic", "Alex", "Paolo", "Cristian" };
            Array.Sort(namesArray);
            Console.WriteLine("Отсортированный массив: ");
            foreach (string name in namesArray)
            {
                Console.Write($" {name} ");
            }
            Console.WriteLine();
        }
    }
}