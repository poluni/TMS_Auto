using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task84
{
    internal class Reader
    {
        public Reader(string name, int libraryCardNumber)
        {
            Name = name;
            LibraryCardNumber = libraryCardNumber;
        }

        public string Name { get; set; }

        public int LibraryCardNumber { get; set; }
    }
}
