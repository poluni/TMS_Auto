// Тема 2 "Массивы и циклы". Задача 10.

namespace TMS_Auto
{
    static class Task210
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2,3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(100);
                    Console.Write($" {array[i, j]} ");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }

            Console.WriteLine($"Сумма элементов в массиве: {sum}");
        }
    }
}