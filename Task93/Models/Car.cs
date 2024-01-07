using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task93.Models
{
    internal class Car<T> : IMovable
        where T : Engine
    {
        private T _engine;

        public Car(T engine)
        {
            _engine = engine;
        }

        public void Backwards()
        {
            Console.WriteLine("Назад");
        }

        public void Forwards()
        {
            Console.WriteLine("Вперед");
        }

        public void Leftwards()
        {
            Console.WriteLine("Налево");
        }

        public void Rightwards()
        {
            Console.WriteLine("Направо");
        }
    }
}
