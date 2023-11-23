// Тема 2 "Массивы и циклы". Задача 9.

namespace TMS_Auto
{
    static class Task29
    {
        static void Main(string[] args)
        {
            int[,] matrixOne = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 } };
            int[,] matrixTwo = { { 1, 2, 3 }, { 1, 1, 1 }, { 0, 0, 0 }, { 2, 1, 0 } };
            int[,] matrixResult = new int[3,3];
            for (int i = 0; i < matrixOne.GetLength(0); i++)
            {
                for (int j = 0; j < matrixTwo.GetLength(1); j++)
                {
                    for (int l = 0; l < matrixTwo.GetLength(0); l++)
                    {
                        matrixResult[i, j] += matrixOne[i, l] * matrixTwo[l, j];                        
                    }
                    Console.Write($" {matrixResult[i, j]} ");
                }
            }
        }
    }
}