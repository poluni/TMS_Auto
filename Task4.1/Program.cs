namespace Task4_1;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        long userNumber = Convert.ToInt64(Console.ReadLine());
        bool isEven = userNumber % 2 == 0;
        outputMessage(isEven);

        void outputMessage(bool isEven)
        {
            if (isEven)
            {
                Console.Write($"Число \"{userNumber}\" - четное");
            }
            else
            {
                Console.Write($"Число \"{userNumber}\" - нечетное");
            }
        }
    }

}