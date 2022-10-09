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

// Генерируем индекс проверяемой позиции
int i = new Random().Next(0, 10);
int j = new Random().Next(0, 10);

// Генерируем размер массива 
int rows = new Random().Next(5, 10);
int columns = new Random().Next(5, 10);

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
SearchValue(i, j, rows, columns);


void SearchValue(int i, int j, int rows, int columns)
{
    if (i < rows && j < columns) 
    {
        Console.WriteLine($"i = {i}, j = {j} -> {array [i,j]}");
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

