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
            Item.AddItem(ref inventoryDictionary, item1);
            Item.AddItem(ref inventoryDictionary, item2);
            Item.AddItem(ref inventoryDictionary, item3);

            Console.WriteLine("Начальный список:");
            Item.PrintItems(inventoryDictionary);

            //Поиск по id
            Console.Write("Введите id для поиска: ");
            string? searchId = Console.ReadLine().ToString();
            Console.WriteLine("Найдено:");
            Item.SearchByID(inventoryDictionary, searchId);

            //Обновление данных
            Console.Write("Введите id обновления: ");
            string? updateId = Console.ReadLine().ToString();
            Item.UpdateItem(ref inventoryDictionary, updateId);
            Item.PrintItems(inventoryDictionary);

            //Удаление
            Console.Write("Введите id для удаления: ");
            string? deletedId = Console.ReadLine().ToString();
            Item.DeleteItem(ref inventoryDictionary, deletedId);
            Item.PrintItems(inventoryDictionary);
        }
    }
}
