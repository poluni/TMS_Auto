// -=============================================  Одномерный массив =============================================-

//Инициализация массива 2
int[] array1;
int n = 4;
array1 = new int[n];

//Инициализация массива 3
int[] array2 = new int[5] { 1, 9, 3, 6, 5 };

//Инициализация массива 1
int[] array = { 1, 9, 3, 6, 5 };

Console.WriteLine(array[4]);
array[0] = 10;

Console.WriteLine($"Last item in array: {array[array.Length - 2]}");
Console.WriteLine($"Last item in array: {array[^2]}");
Console.WriteLine($"Last item in array: {array[array.GetUpperBound(0)]}");

Console.WriteLine(array[0]);
Console.WriteLine("Length: " + array.Length);                       // количество всех элементов
Console.WriteLine("Rank: " + array.Rank);                           // ранк массива
Console.WriteLine("GetLength(0): " + array.GetLength(0));           // количество строк
Console.WriteLine("GetUpperBound(0): " + array.GetUpperBound(0));   // Верхний индекс строк
Console.WriteLine("GetUpperBound(0): " + array.GetLowerBound(0));   // Нижний индекс строк

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write($"{array[i]} ");
}
*/

/*
int[] array = { 1, 9, 3, 6, 5 };

Console.WriteLine();
for (int i = 0; i <= array.GetUpperBound(0); i++)
{
    array[i] = new Random().Next(100);
}

Console.WriteLine();
foreach (int item in array)
{
    Console.Write($"{item} ");
}
*/

/*
int n = 10;
for (int i = n; i <= 10; i += 2)
{
    if (i != 6)
    {
        Console.Write($"{i} ");
    }
}

Console.WriteLine();
string text = "Hello!!!";
foreach (char ch in text)
{
    Console.Write($"{ch} ");
}

int[] arr1 = new int[6];

int u = 6;
bool flag = true;

do
{
    if (u < 0) flag = false;

    Console.WriteLine($"{u}");
    u--;
} while (flag);

u = 6;
do
{
    Console.WriteLine($"{u}");
    u--;
} while (u >= 0);
*/


// -============================================= Двумерный массив =============================================-

using System;

int[,] array = new int[4, 5];
Console.WriteLine("Length: " + array.Length);                       // количество всех элементов
Console.WriteLine("Rank: " + array.Rank);                           // ранк массива
Console.WriteLine("GetLength(0): " + array.GetLength(0));           // количество строк
Console.WriteLine("GetUpperBound(0): " + array.GetUpperBound(0));   // Верхний индекс строк
Console.WriteLine("GetLength(1): " + array.GetLength(1));           // количество столбцов
Console.WriteLine("GetUpperBound(1): " + array.GetUpperBound(1));   // Верхний индекс столбцов
Console.WriteLine("GetLowerBound(0): " + array.GetLowerBound(0));   // Нижний индекс строк
Console.WriteLine("GetLowerBound(1): " + array.GetLowerBound(1));   // Нижний индекс столбцов

Console.WriteLine("=========");

int t = 1;
// Задание значений
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
    }
}

int rows = array.GetLength(0);
int columns = array.Length / rows;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}


foreach (int item in array)
{
    Console.Write($"{item} ");
}