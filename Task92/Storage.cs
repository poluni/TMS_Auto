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
        private static T[]? s_storage = { };

        internal static T[] Add(T obj)
        {
            Array.Resize(ref s_storage, s_storage.GetLength(0) + 1);
            s_storage[s_storage.GetLength(0) - 1] = obj;
            return s_storage;
        }

        public static T[] Remove(T obj)
        {
            if (s_storage.Contains(obj))
            {
                T[] tmpArray = s_storage.Except(new T[] { obj }).ToArray();
                Array.Resize(ref s_storage, s_storage.GetLength(0) - 1);
                Array.Copy(tmpArray, s_storage, s_storage.GetLength(0));
                return s_storage;
            }
            else
            {
                Console.WriteLine($"{obj} не содержится в массиве");
                throw new Exception();
            }
        }

        public static T? GetElementByIndex(int index)
        {
            try
            {
                return s_storage[index];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                throw new IndexOutOfRangeException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception();
            }
        }

        public static int GetLength()
        {
            return s_storage.GetLength(0);
        }

        public static void Show()
        {
            if (s_storage.GetLength(0) != 0)
            {
                for (int i = 0; i <= s_storage.GetUpperBound(0); i++)
                {
                    Console.Write($"{s_storage[i]} ");
                }
            }
            else Console.Write($"Массив пуст ");
            Console.WriteLine();
        }
    }
}
