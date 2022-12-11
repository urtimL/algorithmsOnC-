/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
/*
int[] array = { 345, 897, 568, 234, 333, 850, 100, 888 };

int NumberOfEven(int[] arr)
{
    int rez = 0;

    foreach (var item in arr)
    {
        if (item % 2 == 0)
        {
            rez++;
        }
    }
    return rez;
}

Console.WriteLine($"Количество четных чисел в массиве: [{String.Join("; ", array)}], равняется - {NumberOfEven(array)} шт.");
*/
//==============================================================================================================================
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
Console.Write("Для создания массива введите числа через запятую: ");
int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

int SumElementsOddPositions(int[] arr)
{
    int length = arr.Length;
    int rez = 0;

    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0)
        {
            rez += arr[i];
        }
    }

    return rez;
}

string text = "Сумма элементов, стоящих на нечетных позициях заданного массива";
Console.WriteLine($"{text}, равна: {SumElementsOddPositions(array)}");
*/
//===============================================================================================
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
Console.Write("Для создания массива введите числа через пробел: ");
int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

string text = "Разница между максимальным и минимальным элементом массива, составляет: ";

int DifferenceBetweenMaxAndMinElements(int[] arr)
{
    int minElement = arr[0];
    int maxElement = 0;

    foreach (var item in arr)
    {
        if (maxElement < item) maxElement = item;
        if (minElement > item) minElement = item;
    }

    return maxElement - minElement;
}

Console.WriteLine($"{text}{DifferenceBetweenMaxAndMinElements(array)}");