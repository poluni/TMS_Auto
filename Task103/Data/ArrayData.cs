using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task103.Data
{
    internal static class ArrayData
    {
        private static int[] s_numbers;

        public static int[] GenerateData(int length)
        {
            s_numbers = new int[length];
            for (int i = 0; i < length; i++)
                s_numbers[i] = new Random().Next(0, 501);
            return s_numbers;
        }
    }
}
