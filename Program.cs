// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 7 -2 -85
// 1 -3 8 -9
// 8 7 -7 9

// Console.WriteLine("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, -10, 10);
// PrintArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

// int i = new Random().Next(0, 10);
// int j = new Random().Next(0, 10);

// int rows = new Random().Next(5, 10);
// int columns = new Random().Next(5, 10);

// int[,] array = GetArray(rows, columns, 0, 9);
// PrintArray(array);
// SearchValue(i, j, rows, columns);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = new Random().Next(3, 5);
int columns = new Random().Next(3, 5);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine($"Среднее арифметическое каждого столбца: {AverageColumns(array)}");

string AverageColumns(int[,] array)
{
    string result = string.Empty;
    double res = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            res += array[i, j];
        }
        res = Math.Round(res / array.GetLength(0), 1);
        if (j < array.GetLength(1) - 1)
        {
        result += Convert.ToString(res) + "; ";
        }
        else 
        {
            result += Convert.ToString(res) + ".";
        }
        res = 0;
    }
    return result;
}




void SearchValue(int i, int j, int rows, int columns)
{
    if (i < rows && j < columns)
    {
        Console.WriteLine($"i = {i}, j = {j} -> {array[i, j]}");
    }
    else
    {
        Console.WriteLine($"i = {i}, j = {j} -> такого элемента в массиве нет");
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

