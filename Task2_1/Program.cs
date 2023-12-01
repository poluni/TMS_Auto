// Тема 2 "Массивы и циклы". Задача 1

namespace TMS_Auto
{
    static class Task21
    {
        static void Main(string[] args)
        {
            Console.Write("Массив чисел: ");
            int[] array = new int[20];

            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                array[i] = new Random().Next(100);
                Console.Write($" {array[i]} ");
            }
            Console.WriteLine();


            Console.Write("Введите свое число: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            bool isInArray = false;
            foreach (int number in array)
            {
                if (userNumber == number)
                {
                    isInArray = true;
                    break;
                }
            }

            if (isInArray)
            {
                Console.WriteLine($"Число {userNumber} в массиве");
            }
            else
            {
                Console.WriteLine($"Число {userNumber} не в массиве");
            }
        }
    }
}