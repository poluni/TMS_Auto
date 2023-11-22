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

            Console.WriteLine("Максимальное значение в массиве: {0}", Max(array));
            Console.WriteLine("Минимальное значение в массиве: {0}", Min(array));
            Console.WriteLine("Среднее значение в массиве: {0}", Averege(array));


            int Max(int[] array)
            {
                int maxNumber = 0;
                for (int i = 0; i <= array.GetUpperBound(0); i++)
                {
                    if (array[i] > maxNumber)
                    {
                        maxNumber = array[i];
                    }
                }
                return maxNumber;
            }

            int Min(int[] array)
            {
                int minNumber = array.First();
                for (int i = 0; i <= array.GetUpperBound(0); i++)
                {
                    if (array[i] < minNumber)
                    {
                        minNumber = array[i];
                    }
                }
                return minNumber;
            }

            double Averege(int[] array)
            {
                int sum = 0;
                foreach (int num in array)
                {
                    sum += num;
                }
                return (double)sum / (array.GetLength(0));
            }
       }
    }
}