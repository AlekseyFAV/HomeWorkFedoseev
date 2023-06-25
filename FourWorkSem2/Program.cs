/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В: ");
int deg = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {deg} равно {DegreeOfNumber(A, deg)}");


int DegreeOfNumber(int A, int B)
{
    int mult = Convert.ToInt32(Math.Pow(A, B));
    return mult;
}*/






/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
Console.WriteLine("Введите число: ");
string Number = Console.ReadLine()!;
Console.WriteLine($"Сумма чисел {Number} равна {SumA(Number)}");

int SumA(string A)
{
    int count = A.Length;
    // int index = 0;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
       sum =  Convert.ToInt32(Char.GetNumericValue(A[i])) + sum;
    }
    // while (index < count)
    // {
    //     sum = A[index] + sum;
    //     index++;
    // }
    return sum;
}*/






/* Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
[0, 1, 1, 0, 0, 0, 1, 0]
*/
/*
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

int[] array = GetArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");
*/