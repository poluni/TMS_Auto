using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task72.CustomExeptions;

namespace Task72.Models
{
    internal class Order
    {
        private Item[] itemList = { };

        private Shipping shipping;

        public int IdOrder { get; set; }

        public Order(int id, Item[]? items, Shipping? shipping)
        {
            ValidateID(id);
            ValidateItem(items);
            ValidateDelivery(shipping);
        }

        private void ValidateID(int id)
        {
            try
            {
                if (id >= 0)
                {
                    IdOrder = id;
                }
                else throw new InvalidOrderNumberException();
            }
            catch (InvalidOrderNumberException ex)
            {
                Console.WriteLine("Номер заказа - отрицательное число");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void ValidateItem(Item[]? items)
        {
            try
            {
                if (items is null || items.GetLength(0) == 0) throw new EmptyOrderException();
                else
                {
                    itemList = items;
                }
            }
            catch (EmptyOrderException ex)
            {
                Console.WriteLine("Список товаров пуст");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void ValidateDelivery(Shipping? shipping)
        {
            try
            {
                if (shipping == null)
                    throw new DeliveryInformationMissingException();
                else this.shipping = shipping;
            }
            catch (DeliveryInformationMissingException ex)
            {
                Console.WriteLine("Не заполнена доставка");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
