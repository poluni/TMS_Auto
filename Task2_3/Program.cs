// Тема 2 "Массивы и циклы". Задача 3.

namespace TMS_Auto
{
    static class Task23
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива чисел: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayLength];
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                array[i] = new Random().Next(100);
            }

            Console.WriteLine("Изначальный массив чисел: ");
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                Console.Write($" {array[i]} ");
            }
            Console.WriteLine();

            int maxNumber = 0;

            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
            }

            Console.WriteLine($"Максимальное значение в массиве: {maxNumber}");

            int minNumber = array.First();

            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                if (array[i] < minNumber)
                {
                    minNumber = array[i];
                }
            }

            Console.WriteLine($"Минимальное значение в массиве: {minNumber}");

            int midIndex = array.GetLength(0) / 2;
            bool isEven = midIndex == (midIndex >> 1) << 1;

            if (isEven)
                Console.WriteLine("Среднее значение массива: {0}, {1}",
                    array[midIndex - 1], array[midIndex]);
            else
                Console.WriteLine("Среднее значение массива: {0}",
                   array[midIndex]);
        }
    }
}