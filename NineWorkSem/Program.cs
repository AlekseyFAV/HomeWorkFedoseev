// // Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// // A = 3; B = 5 -> 243 (3⁵)

// // A = 2; B = 3 -> 8

// Console.Write("Введите число: ");
// int A = int.Parse(Console.ReadLine()!);

// Console.Write("Введите степень: ");
// int B = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"{Pow(A,B) }");

// int Pow(int number, int rank){
//     if(rank == 0) return 1;
//     if(rank == 1) return number;
//     return (number * Pow(number, rank-1));
// }

// // Задача 63: Задайте значение N. Напишите программу, которая 
// // выведет все натуральные числа в промежутке от 1 до N.

// // N = 5 -> "1, 2, 3, 4, 5"

// // N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"{PrintNumbers(1, N)}");

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
    
//     return (start +", "+ PrintNumbers(start + 1, end));
// }

// // Задача 65: Задайте значения M и N. Напишите программу, 
// // которая выведет все натуральные числа в промежутке от M до N.

// // M = 1; N = 5. -> "1, 2, 3, 4, 5"
// // M = 4; N = 8. -> "4, 5, 6, 7, 8"

// Console.Write("Введите число: ");
// int M = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"{PrintNumbers(M, N)}");

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
    
//     return (start +", "+ PrintNumbers(start + 1, end));
// }

// // Задача 67: Напишите программу, которая будет принимать 
// // на вход число и возвращать сумму его цифр.
// // 453 -> 12
// // 45 -> 9

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"{n} -> {SumNumbers(n)}");

// int SumNumbers(int n)
// {
//     if (n == 0) return 0;
//     return (n % 10 + SumNumbers(n / 10));
// }




/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{PrintNumbers( N, 1)}");

string PrintNumbers(int start, int end)
{
    if (start == 1) return start.ToString();
    
    else return (start +", "+ PrintNumbers(start - 1, end));
}
*/

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"M = {M}; N = {N} -> {SumNumbers( M, N)}");

int SumNumbers(int start, int end)
{
    if (start == end) return start;
    
    else return (start + SumNumbers(start +1, end));
}
*/

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

