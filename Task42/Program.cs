// Тема 4 "Классы и методы". Задача 2.

namespace Task42
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard1 = new CreditCard("4545454", 56894.66m);
            CreditCard creditCard2 = new CreditCard("383783", 424373.83m);
            CreditCard creditCard3 = new CreditCard("8383838", 35.2m);

            creditCard1.ShowBalance();
            creditCard1.PutOnAccountNumber(56.56m);
            creditCard1.ShowBalance();

            creditCard2.ShowBalance();
            creditCard2.PutOnAccountNumber(18.00m);
            creditCard2.ShowBalance();

            creditCard3.ShowBalance();
            creditCard3.WithdrawalFromAccountNumber(25.99m);
            creditCard3.ShowBalance();
        }
    }
}
