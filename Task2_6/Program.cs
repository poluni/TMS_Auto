// Тема 2 "Массивы и циклы". Задача 6.

namespace TMS_Auto
{
    static class Task26
    {
        static void Main(string[] args)
        {

            int[] array = new int [10];
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                array[i] = new Random().Next(100);
            }
            Console.WriteLine("Изначальный массив чисел: ");
            OutputArray(array);

            int[] newArray = new int[array.GetLength(0)];
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                if (i % 2 != 0)
                {
                    newArray[i] = array[i];
                }
            }
            Console.WriteLine("Массив, где каждый элемент с нечётным индексом заменен на нуль: ");
            OutputArray(newArray);

            int[] OutputArray(int[] array)

            {
                for (int i = 0; i <= array.GetUpperBound(0); i++)
                {
                    Console.Write($" {array[i]} ");
                }
                Console.WriteLine();
                return array;

            }
        }
    }
}