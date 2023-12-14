using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task72.CustomExeptions
{
    internal class DeliveryInformationMissingException : Exception
    {
        public DeliveryInformationMissingException() : base()
        {
            Console.WriteLine($"Тип исключения: {base.GetType()}");
        }

        public DeliveryInformationMissingException(string message) : this() 
        {
            Console.WriteLine(base.GetType().ToString());
            Console.WriteLine(message);
        }
    }
}
