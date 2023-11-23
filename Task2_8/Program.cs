// Тема 2 "Массивы и циклы". Задача 8.

namespace TMS_Auto
{
    static class Task28
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                array[i] = new Random().Next(100);
            }

            Console.WriteLine("Изначальный массив чисел: ");
            OutputArray(array);

            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(0) - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }

            Console.WriteLine("Отсортированный по возрастанию массив чисел: ");
            OutputArray(array);

            int[] OutputArray(int[] array)
            {
                foreach(int number in array)
                {
                    Console.Write($" {number} ");
                }
                Console.WriteLine();
                return array;
            }
        }
    }
}