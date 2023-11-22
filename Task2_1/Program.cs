// Тема 2 "Массивы и циклы". Задача 1

namespace TMS_Auto
{
    static class Task21
    {
        static void Main(string[] args)
        {
            Console.Write("Numbers array: ");
            int[] array = new int[20];
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                array[i] = new Random().Next(100);
                Console.Write($" {array[i]} ");
            }
            Console.WriteLine();


            Console.Write("Enter your number: ");
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
                Console.WriteLine($"Number {userNumber} is in an array");
            }
            else
            {
                Console.WriteLine($"Number {userNumber} isn't in an array");
            }
        }
    }
}