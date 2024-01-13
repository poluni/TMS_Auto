using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task101
{
    internal class GetRandomNumber
    {
        private delegate int GetNumber();

        internal int GenerateInt()
        {
            GetNumber intNumber = new(GenerateIntNumber);
            return intNumber();
        }

        private int GenerateIntNumber()
        {
            return new Random().Next(0, 11);
        }
    }
}
