using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task93
{
    internal interface IMovable
    {
        public void Forwards();

        public void Backwards();

        public void Rightwards();

        public void Leftwards();
    }
}
