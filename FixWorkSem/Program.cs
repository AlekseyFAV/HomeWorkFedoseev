/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/
/*
Console.Write("Введите числа через пробел: ");
int[] numbers = GetArrayFromString(Console.ReadLine()!);

int count = 0;
foreach (int el in numbers)
{
    count += el > 0 ? 1 : 0;
}

Console.WriteLine(count);

int[] GetArrayFromString (string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}
*/

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine()!);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;


Console.WriteLine($"Точка пересечения двух прямых {y}, {x}");
*/
