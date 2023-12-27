using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task91
{
    internal struct PointStruct<T>
    {
        private T x;
        private T y;

        public T X { get; set; }
        public T Y { get; set; }

        public PointStruct(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public void Show() => Console.WriteLine($"({x}, {y})");
    }
}
