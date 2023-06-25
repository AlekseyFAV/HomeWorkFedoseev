/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
int[] array = GetArray(10, 100, 1000);
Console.WriteLine($"[{String.Join(", ", array)}]");

int count = 0;

// foreach (int el in array)
// {
//     count += el % 2 == 0 ? 1 : 0;
// }

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count = count + 1;
    }
    else
    {
        count = count + 0;
    }
}

Console.WriteLine($"Количество четных чисел = {count}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
*/






/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
int[] array = GetArray(10, 1, 15);
Console.WriteLine($"[{String.Join(", ", array)}]");

int oddNumSum = 0;

for (int i = 1; i < array.Length; i+= 2)
{
  if (i % 2 != 0)
  {
    oddNumSum = oddNumSum + array[i];
  }
}

Console.WriteLine($"Сумма элементов на нечетных индексах равно {oddNumSum}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}
*/






/*Задача 38: Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[22, 42, 15, 77, 65] => 77 - 15 = 62**
*/
/*
int[] array = GetArray(7, 10, 99);
Console. WriteLine($"[{String.Join(", ", array)}]");

int minNumber = array.Min();
int maxNumber = array.Max();
int diff = maxNumber - minNumber;
Console.WriteLine($"Разница между {minNumber} и {maxNumber} равна {diff}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}
*/

