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
        public static int[] DoShellSort(int[] inputArray)
        {
            int gap = inputArray.Length / 2;
            int[] sortedArray = new int[inputArray.Length];
            Array.Copy(inputArray, sortedArray, inputArray.Length);
            while (gap >= 1)
            {
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    for (int j = i - gap; j >= 0; j -= gap)
                    {
                        if (sortedArray[j] > sortedArray[j + gap])
                                { 
                            int tmp = sortedArray[j];
                            sortedArray[j] = sortedArray[j + gap];
                            sortedArray[j + gap] = tmp;
                        }
                    }                    
                }
                gap /= 2;
            }
            return sortedArray;
        }        
    }
}
