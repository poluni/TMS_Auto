using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task103.Data
{
    internal static class ArrayData
    {
        private static int[] numbers;

        public static int[] GenerateData(int length)
        {
            numbers = new int[length];
                for (int i = 0; i < length; i++) 
                    numbers[i] = new Random().Next(0, 501);
            return numbers;
        }

        public static int GetMaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
                if (max < array[i]) max = array[i];
            return max;
        }
    }
}
