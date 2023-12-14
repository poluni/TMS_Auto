using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task72.CustomExeptions
{
    internal class InvalidOrderNumberException : Exception
    {
        public InvalidOrderNumberException() : base()
        {
            Console.WriteLine($"Тип исключения: {base.GetType()}");
        }

        public InvalidOrderNumberException(string message) : this()
        {
            Console.WriteLine(message);
        }
    }
}
