// Тема 2 "Массивы и циклы". Задача 2.

namespace TMS_Auto
{
    static class Task22
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

            Console.Write("Введите число, которое нужно удалить: ");
            int numberToDelete = Convert.ToInt32(Console.ReadLine());

            int countInArray = 0;
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                if (numberToDelete == array[i])
                {
                    countInArray++;
                }
            }

            if (countInArray > 0)
            {
                int[] newArray = new int[array.GetLength(0) - countInArray];
                int j = 0;
                for (int i = 0; i <= array.GetUpperBound(0); i++)
                {
                    if (array[i] != numberToDelete)
                    {
                          newArray[j] = array[i];
                          j++;
                    }
                }
                OutputArray(newArray);
            }
            else
            {
                Console.WriteLine($"Число {numberToDelete} не входит в массив");
            }


            void OutputArray(int[] array)
            {
                for (int i = 0; i <= array.GetUpperBound(0); i++)
                {
                    Console.Write($" {array[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}