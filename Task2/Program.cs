using System;

namespace Task2;
class Program
{
    static void Main(string[] args)
    {
        float userNumber = 0.0f;
        do 
        {
            Console.Write("Введите число от -50 до 50: ");
            userNumber = Convert.ToSingle(Console.ReadLine());
            if (userNumber < -50 && userNumber > 50) 
            {                 
                Console.WriteLine("Введенное число не попало в промежуток [-50, 50]");
            }
        } while (userNumber < -50 || userNumber > 50);

        if (userNumber >= -40 && userNumber <= -10)
        {
            Console.WriteLine("Введенное число попало в промежуток [-40, -10]");
        }
        else if (userNumber >= -9 && userNumber <= 0)
        {
            Console.WriteLine("Введенное число попало в промежуток [-9, 0]");
        }
        else if (userNumber >= 1 && userNumber <= 10)
        {
            Console.WriteLine("Введенное число попало в промежуток [1, 10]");
        }
        else if (userNumber >= 11 && userNumber <= 40)
        {
            Console.WriteLine("Введенное число попало в промежуток [11, 40]");
        }
        else
        {
            Console.WriteLine("Введенное число не попало ни в один промежуток");
        }
    }
}
