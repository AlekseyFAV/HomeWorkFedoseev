﻿
/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3



Console.Write("Введите первое число:  ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:  ");
int number1 = int.Parse(Console.ReadLine()!);
int max = number;
int min = number1;

if (number < number1)
{
    max = number1;
    min = number;
    Console.Write("Наибольшее число: ");
    Console.WriteLine(max);
    Console.Write("Наименьшее число: ");
    Console.WriteLine(min);
}
else
{
    max = number;
    min = number1;
    Console.Write("Наибольшее число: ");
    Console.WriteLine(max);
    Console.Write("Наименьшее число: ");
    Console.WriteLine(min);
}
*/




/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


Console.Write("Введите первое число:  ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:  ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int number2 = int.Parse(Console.ReadLine()!);
int max = number;

if (number > max)
{
    max = number;
}
if (number1 > max)
{
    max = number1;
}
if (number2 > max)
{
    max = number2;
}

Console.Write("Наибольшее число: ");
Console.WriteLine(max);
*/




/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет

Console.Write("Введите число:  ");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Не четное");
}
*/





/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8


Console.Write("Введите число N:  ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;

while (N >= count)
{
    if (count % 2 == 0)
    {

        Console.Write($"{count} ");
    }
    count++;
}

*/