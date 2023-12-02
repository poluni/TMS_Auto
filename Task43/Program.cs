// Тема 4 "Классы и методы". Задача 3.

namespace Task43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm1 = new ATM(100, 90, 80);
            atm1.WithdrawalFromCard(100, 90, 80);
            atm1.PutOnCard(amount20: 2, amount100: 16);

            Console.WriteLine(atm1.WithdrawalFromCard(amount20: 2, amount100: 16) ?
                "Операция выполнена" : "Операция не выполнена");
            Console.WriteLine();

            Console.WriteLine(atm1.WithdrawalFromCard(amount20: 2, amount50: 16) ?
                "Операция выполнена" : "Операция не выполнена");
            Console.WriteLine();

            Console.WriteLine(atm1.WithdrawalFromCard(amount100: 16) ?
                "Операция выполнена" : "Операция не выполнена");
            Console.WriteLine();

            Console.WriteLine(atm1.WithdrawalFromCard(amount20: 2, amount50: 16, amount100: 16) ?
                "Операция выполнена" : "Операция не выполнена");
            Console.WriteLine();

            Console.WriteLine(atm1.WithdrawalFromCard() ?
                 "Операция выполнена" : "Операция не выполнена");
        }
    }
}
