using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task72.CustomExeptions;

namespace Task72.Models
{
    internal class Shipping
    {
        public Shipping(string shippingMethods, string deliveryAddress)
        {
            try
            {
                if (string.IsNullOrEmpty(shippingMethods)) 
                    throw new DeliveryInformationMissingException();                                 
                else ShippingMethod = shippingMethods;
            }
            catch (DeliveryInformationMissingException ex)
            {
                Console.WriteLine("Не указан метод доставки");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                if (string.IsNullOrEmpty(deliveryAddress)) 
                    throw new DeliveryInformationMissingException();                
                else DeliveryAddress = deliveryAddress;
            }
            catch (DeliveryInformationMissingException ex)
            {
                Console.WriteLine("Не указан адрес доставки");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
        }

        public Shipping(int id, string shippingMethods, string deliveryAddress) : this(shippingMethods, deliveryAddress)
        {
            ID = id;
        }

        public int ID { get; private set; } = new Random().Next(1, 500);

        public string ShippingMethod { get; set; }

        public string DeliveryAddress { get; set; }
    }
}
