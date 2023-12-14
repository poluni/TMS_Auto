using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task72.CustomExeptions
{
    internal class EmptyOrderException : Exception
    {
        public EmptyOrderException() : base()
        {
            Console.WriteLine($"Тип исключения: {base.GetType()}");
        }

        public EmptyOrderException(string message) : this()
        { 
            Console.WriteLine(message);
        }
    }
}
