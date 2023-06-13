
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Проверка на трехзначность при вводе пользователем)
// 456 -> 5
// 782 -> 8
// 918 -> 1

//Вариант с Рандомом
/*int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int num1 = number / 10;
int num2 = num1 % 10;
Console.WriteLine($"Вторая цифра числа: {num2}");
*/



//Вариант с проверкой на трехзначность
/*Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
int num1 = number / 10;
int num2 = num1 % 10;
if (number > 99 && number < 1000)
{
    Console.WriteLine($"Вторая цифра числа: {num2}");
}
else Console.WriteLine($"Введено некорректное число");
*/






// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int number = new Random().Next(10, 100000);   // с рандомом
// Console.WriteLine(number);

// Console.WriteLine("Введите трехзначное число: ");      //ввод числа вручную
// int number = Convert.ToInt32(Console.ReadLine()!);

/*if (number < 100)
{
    Console.WriteLine($"Число состоит менее чем из тех символов");
}

if (number > 99 && number < 1000)
{
    int num2 = number % 10;
    Console.WriteLine($"Третья цифра числа: {num2}");
}

if (number > 1000 && number < 10000)
{
    int num1 = number / 10;
    int num2 = num1 % 10;
    Console.WriteLine($"Третья цифра числа: {num2}");
}

if (number > 10000 && number < 100000)
{
    int num1 = number / 100;
    int num2 = num1 % 10;
    Console.WriteLine($"Третья цифра числа: {num2}");
}
if (number > 99999)
{
    Console.WriteLine($"Число слишком большое");
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(использовать И и ИЛИ)
// 6 -> да
// 7 -> да
// 1 -> нет


/*
Console.WriteLine("Введите число, обозначающее день недели: ");
int number = Convert.ToInt32(Console.ReadLine()!);

if (number == 6 || number == 7)
{
    Console.WriteLine("Да, Выходной день");
}
if (number < 6 && number > 0)
{
    Console.  WriteLine("Нет, Будний день");
}
if (number < 1 || number > 7)
{
    Console.WriteLine("Такого дня недели нету");
}
*/