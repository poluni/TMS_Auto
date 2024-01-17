using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

//Сортировка Шелла

namespace Task103.Models
{
    internal static class ShellSort
    {
        private static int[] s_sortedArray = { };
        private static int s_gap;

        public static int[] DoShellSort(int[] inputArray)
        {
            s_gap = inputArray.Length / 2;
            s_sortedArray = new int[inputArray.Length];
            Array.Copy(inputArray, s_sortedArray, inputArray.Length);
            while (s_gap >= 1)
            {
                for (int i = 0; i < s_sortedArray.Length; i++)
                {
                    for (int j = i - s_gap; j >= 0; j -= s_gap)
                    {
                        if (s_sortedArray[j] > s_sortedArray[j + s_gap])
                        {
                            int tmp = s_sortedArray[j];
                            s_sortedArray[j] = s_sortedArray[j + s_gap];
                            s_sortedArray[j + s_gap] = tmp;
                        }
                    }
                }
                s_gap /= 2;
            }
            return s_sortedArray;
        }
    }
}
