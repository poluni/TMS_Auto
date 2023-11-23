// Тема 2 "Массивы и циклы". Задача 4.

namespace TMS_Auto
{
    static class Task24
    {
        static void Main(string[] args)
        {
            int[] arrayOne = InizializeArray(5, 80);            
            Console.WriteLine("Изначальный массив чисел первого массива: ");
            OutputArray(arrayOne);

            int[] arrayTwo = InizializeArray(5, 85);
            Console.WriteLine("Изначальный массив чисел второго массива: ");
            OutputArray(arrayTwo);

            double AveregeOfArrayOne = Averege(arrayOne);
            double AveregeOfArrayTwo = Averege(arrayTwo);

            if (AveregeOfArrayOne > AveregeOfArrayTwo)
            {
                Console.WriteLine("Среднее значение ({0}) в первом массиве больше, чем во втором ({1})",
                    AveregeOfArrayOne, AveregeOfArrayTwo);
            }
            else if (AveregeOfArrayOne < AveregeOfArrayTwo)
            {
                Console.WriteLine("Среднее значение ({1}) во втором массиве больше, чем в первом ({0})",
                AveregeOfArrayOne, AveregeOfArrayTwo);
            }
            else Console.WriteLine("Среднее значение ({0}) в первом массиве равно " +
                "среднему значению во втором массиве ({1})",
                    AveregeOfArrayOne, AveregeOfArrayTwo);

            double Averege(int[] array)
            {
                int sum = 0;
                foreach (int num in array)
                {
                    sum += num;
                }
                return (double)sum / (array.GetLength(0));
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

            int[] InizializeArray(int length, int randomNum)
            {
                int[] array = new int[length];
                for (int i = 0; i <= array.GetUpperBound(0); i++)
                {
                    array[i] = new Random().Next(randomNum);
                }
                return array;
            }
        }
    }
}