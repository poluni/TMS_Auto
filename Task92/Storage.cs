using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task92
{
    internal class Storage<T>
    {
        private static T[]? S_storage = { };

        internal static T[] Add(T obj)
        {
            Array.Resize(ref S_storage, S_storage.Length + 1);
            S_storage[S_storage.Length - 1] = obj;
            return S_storage;
        }

        public static T[] Remove(T obj)
        {
            T[] tmpArray = S_storage.Except(new T[] { obj }).ToArray();
            Array.Resize(ref S_storage, S_storage.Length - 1);
            Array.Copy(tmpArray, S_storage, S_storage.Length);
            return S_storage;
        }

        public static T? GetElementByIndex(int index)
        {
            return S_storage[index];
        }

        public static int GetLength()
        {
            return S_storage.GetLength(0);
        }

        public static void Show()
        {
            if (S_storage.GetLength(0) != 0)
            {
                for (int i = 0; i <= S_storage.GetUpperBound(0); i++)
                {
                    Console.Write($"{S_storage[i]} ");
                }
            }
            else Console.Write($"Массив пуст ");
            Console.WriteLine();
        }
    }
}
