// Задача "Обработка исключений". Задача 2.

using Task72.Models;

namespace Task72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shipping shipping2 = new Shipping(null, "Москва, ул Академика Королева, д 12 , кв 15");
            //Shipping shipping3 = new Shipping("Курьер", null);
            Shipping shipping = new Shipping("Курьер", "Москва, ул Академика Королева, д 12 , кв 15");
            Item item1 = new Item("Настольная лампа");
            Item item2 = new Item("Лампочка 10 Вт");
            Order order = new Order(1, new Item[] { item1, item2 }, shipping);

            //Order order2 = new Order(-1, new Item[] { item1, item2 }, shipping);
            //Order order3 = new Order(1, null, shipping);
            //Order order4 = new Order(1, new Item[]{ }, shipping);
            //Order order5 = new Order(1, new Item[] { item1, item2 }, null);
        }
    }
}
