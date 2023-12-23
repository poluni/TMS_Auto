using System;

namespace Task82
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Инициализация
            Dictionary<string, Item>? inventoryDictionary = new Dictionary<string, Item>() { };
            Item item1 = new Item("Ручка шариковая синяя", 120.12M, 46);
            Item item2 = new Item("Тетрадь в клеточку", 50.12M, 23);
            Item item3 = new Item("Карандаш", 15.1M, 68);
            Helper.AddItem(ref inventoryDictionary, item1);
            Helper.AddItem(ref inventoryDictionary, item2);
            Helper.AddItem(ref inventoryDictionary, item3);

            Console.WriteLine("Начальный список:");
            Helper.PrintItems(inventoryDictionary);

            //Поиск по id
            Console.Write("Введите id для поиска: ");
            string? searchId = Console.ReadLine().ToString();
            Console.WriteLine("Найдено:");
            Helper.SearchByID(inventoryDictionary, searchId);

            //Обновление данных
            Console.Write("Введите id обновления: ");
            string? updateId = Console.ReadLine().ToString();
            Helper.UpdateItem(ref inventoryDictionary, updateId);
            Helper.PrintItems(inventoryDictionary);

            //Удаление
            Console.Write("Введите id для удаления: ");
            string? deletedId = Console.ReadLine().ToString();
            Helper.DeleteItem(ref inventoryDictionary, deletedId);
            Helper.PrintItems(inventoryDictionary);
        }
    }
}
