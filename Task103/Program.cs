using Task103.Data;
using Task103.Helper;
using Task103.Models;

namespace Task103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Первоначальный массив: ");
            int[] array = ArrayData.GenerateData(10);
            PrintHelper.PrintData(array);

            Console.Write($"Отсортированный массив (Сортировка подсчетом): ");
            int max = ArrayData.GetMaxValue(array);
            int[] sortedArray1 = CountingSort.DoCountingSort(array, max);
            PrintHelper.PrintData(sortedArray1);
            
            Console.Write($"Отсортированный массив (Сортировка Шелла): ");
            int[] sortedArray2 = ShellSort.DoShellSort(array);
            PrintHelper.PrintData(sortedArray2);
        }
    }
}
