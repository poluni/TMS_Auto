using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Пузырьковая сортировка

namespace Task103.Models
{
    internal static class BubbleSort
    {
        private static int[] s_numArray = { };

        public static int[] DoBubbleSort(int[] inputArray)
        {
            s_numArray = new int[inputArray.Length];
            Array.Copy(inputArray, s_numArray, inputArray.Length);
            for (int i = 0; i < s_numArray.Length; i++)
                for (int j = 0; j < s_numArray.Length - i - 1; j++)
                {
                    if (s_numArray[j] > s_numArray[j + 1])
                    {
                        var tmp = s_numArray[j];
                        s_numArray[j] = s_numArray[j + 1];
                        s_numArray[j + 1] = tmp;
                    }
                }
            return s_numArray;
        }
    }
}
