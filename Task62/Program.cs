// Тема "Абстрактные классы и интерфейсы". Задача 2.

using Task62.Models;

namespace Task62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] items =
                {
             new Item("Ноутбук", 150_000M, new DateTime(2020, 05, 18), new DateTime(2024, 05, 18)),
             new Item("Батарейка", 15.15M, new DateTime(2017, 05, 18), new DateTime(2023, 05, 18))
                };

            //Вывод всей информации по товару на экран

            foreach (Item item in items)
            {
                item.PrintProductInfo();
                Console.Write(item.IsValid(item.ExpirationDate) ? "Годен" : "Просрочен");
                Console.WriteLine();
            }

            //Поиск товаров с истекшим сроком годности

            Console.WriteLine();
            foreach (Item item in items)
            {
                if (!item.IsValid(item.ExpirationDate)) item.PrintProductInfo();
            }
        }
    }
}
