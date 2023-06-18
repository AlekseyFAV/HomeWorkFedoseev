/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
Console.WriteLine("Enter a five-digit number: ");
string number = Console.ReadLine();

if (number.Length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("The number is a polindpome");
    }
    else{
    Console.WriteLine("The number is not a polindrome");
    }
}
else
{
Console.WriteLine("The number is not five-digit");
}
*/


/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/





/*
Console.WriteLine("Введите координату x для точки А: ");
int ax = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y для точки А: ");
int ay = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введитие координату z для точки A: ");
int az = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату x для точки B: ");
int bx = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y для точки B: ");
int by = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z для точки B: ");
int bz = int.Parse(Console.ReadLine()!);

double AB = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
Console.WriteLine($"Расстояние AB = {AB:f2}");
*/





/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
Console.WriteLine("Enter number N: ");
int N = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= N; i++)
{
    int cbrt = Convert.ToInt32(Math.Pow(i, 3));
    Console.WriteLine(cbrt);
}
*/

