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

            Console.Write($"Отсортированный массив (Сортировка Шелла): ");
            new Sorting().Run(array, SortTypeEnum.ShellSorting);

            Console.Write($"Отсортированный массив (Пузырьковая сортировка): ");
            new Sorting().Run(array, SortTypeEnum.BubbleSorting);
        }
    }
}
