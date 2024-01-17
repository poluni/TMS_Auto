using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task103.Helper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task103.Models
{
    internal class Sorting
    {
        private delegate int[] Sort(int[] array);

        public void Run(int[] array, SortTypeEnum typeSorting)
        {
            SortTypeEnum[] sortTypes = (SortTypeEnum[])Enum.GetValues(typeof(SortTypeEnum));

            Sort sorting1;
            foreach (SortTypeEnum type in sortTypes)
            {
                if (type.Equals(typeSorting))
                {
                    sorting1 = SelectSorting(type);
                    sorting1?.Invoke(array);
                }
            }
        }

        public int[] SortShell(int[] array)
        {
            int[] sortedArray = ShellSort.DoShellSort(array);
            PrintHelper.PrintData(sortedArray);
            return sortedArray;
        }

        public int[] SortBubble(int[] array)
        {
            int[] sortedArray = BubbleSort.DoBubbleSort(array);
            PrintHelper.PrintData(sortedArray);
            return sortedArray;
        }

        private Sort SelectSorting(SortTypeEnum sortType)
        {
            switch (sortType)
            {
                case SortTypeEnum.ShellSorting: return SortShell;
                case SortTypeEnum.BubbleSorting: return SortBubble;
                default: throw new Exception("Cортировка не реализована.");
            }
        }
    }
}
