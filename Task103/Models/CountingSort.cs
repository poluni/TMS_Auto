using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Сортировка подсчетом

namespace Task103.Models
{
    internal static class CountingSort
    {
        public static int[] DoCountingSort(int[] inputArray, int maxValue)
        {
            int[] nums = new int[maxValue + 1];
            foreach (int index in inputArray) nums[index]++;
            int[] sortedArray = new int[inputArray.Length];
            int currentIndex = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                int count = nums[j];
                for (int k = 0; k < count; k++)
                {
                    sortedArray[currentIndex] = j;
                    currentIndex++;
                }
            }
            return sortedArray;
        }
    }
}
