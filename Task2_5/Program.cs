// Тема 2 "Массивы и циклы". Задача 5.

namespace TMS_Auto
{
    static class Task25
    {
        static void Main(string[] args)
        {
            int arrayLength;

            do
            {
                Console.Write("Введите размер массива: ");
                arrayLength = Convert.ToInt32(Console.ReadLine());
                if (arrayLength <= 5 || arrayLength > 10)
                {
                    Console.WriteLine($"Введенный размер массива {arrayLength} не входит в границы (5; 10]");
                }
            } while (arrayLength <= 5 || arrayLength > 10);

            int[] array = new int[arrayLength];
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                array[i] = new Random().Next(100);
            }
            Console.WriteLine("Изначальный массив чисел: ");
            OutputArray(array);

            int countInArray = 0;
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                if (array[i] % 2 == 0)
                {
                    countInArray++;
                }
            }

            if (countInArray > 0)
            {
                int[] evenArray = new int[countInArray];
                int j = 0;
                for (int i = 0; i <= array.GetUpperBound(0); i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        evenArray[j] = array[i];
                        j++;
                    }
                }
                Console.WriteLine("Массив из четных чисел: ");
                OutputArray(evenArray);
            }


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