/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными(тип double) числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns);
PrintArray(array);


double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble();
        }
    }
    return result;
}


void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(inArray[i, j], 2)} ");
        }
        Console.WriteLine();
    }
}
*/




/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 1, j = 2 -> 2
i = 4, j = 2 -> такого элемента не существует

*/
/*
int rows = 5;
int columns = 5;

Console.Write("Введите значение строки i: ");
int i = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение столбца j: ");
int j = int.Parse(Console.ReadLine()!);


int[,] array = GetArray(rows, columns, 10, 100);
PrintArray(array);

Console.WriteLine();
NumberSearch(i, j, columns, rows);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


void NumberSearch (int i, int j, int columns, int rows)
{
    if (i < rows || j < columns)
    {
        Console.WriteLine($"{array[i, j]}");
    }
    else 
    {
        Console.WriteLine("Числа на данной позиции нету");
    }
}
*/


/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое* элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
* Сумма всех цифр / их количество(это количество ваших строк)
*/
/*
Console.Write("Введите количество строк в массиве ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов в массиве ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);

Console.WriteLine();
double[] arraySum = Average(array);
Console.WriteLine($"{String.Join("; " , arraySum)}");

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] Average(double[,] inArray)
{
    double[] result = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += inArray[i, j] / rows;
            result[j] = Math.Round(sum, 2);
        }
    }
    return result;
}
*/

