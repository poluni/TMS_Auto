// Тема 4 "Классы и методы". Задача 1.

namespace Task41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 экземпляр класса Phone
            Phone phone1 = new Phone();
            Console.WriteLine("Серия - {0}, Модель - {1}, Вес - {2} 1 экземпляра класса Phone",
                phone1.number, phone1.model, phone1.weight);
            phone1.ReceiveCall("Alex");
            Console.WriteLine(phone1.GetNumber());

            // 2 экземпляр класса Phone
            Phone phone2 = new Phone("+7(856)568123468", "AD895H");
            Console.WriteLine("Серия - {0}, Модель - {1}, Вес - {2} 2 экземпляра класса Phone",
                phone2.number, phone2.model, phone2.weight);
            phone2.ReceiveCall("Stiven");
            Console.WriteLine(phone2.GetNumber());

            // 3 экземпляр класса Phone
            Phone phone3 = new Phone("+7(856)568123469", "AD895H", 15);
            Console.WriteLine("Серия - {0}, Модель - {1}, Вес - {2} 3 экземпляра класса Phone",
                phone3.number, phone3.model, phone3.weight);
            phone3.ReceiveCall("Bob");
            Console.WriteLine(phone3.GetNumber());

            phone1.SendMessage("+7(856)568123461", "+7(856)568123462");
            phone1.SendMessage("+7(856)568123463", "+7(856)568123464",
                "+7(123)568123465", "+7(756)52424466", "+7(456)528738367");
        }
    }
}
