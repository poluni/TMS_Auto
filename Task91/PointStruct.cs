using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task91
{
    internal struct PointStruct<T>
    {
        private T _x;
        private T _y;

        public T X { get; set; } = default;
        public T Y { get; set; } = default;

        public PointStruct(T x, T y)
        {
            _x = x;
            _y = y;
        }

        public void Show() => Console.WriteLine($"({_x}, {_y})");
    }
}
