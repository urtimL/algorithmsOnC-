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
/*
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
*/
//====================================================================================================
/*
Задача 37 со звездочкой, дополнительная: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.Write("Для создания массива введите числа через пробел: ");
int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

string text = "Произведение пар чисел в массиве: ";

void ProductPairsNumbers(int[] arr, string message)
{
    int size = arr.Length;
    int length = size / 2;
    int lastNumber = 0;
    int k = 1;

    for (int i = 0; i < length; i++)
    {
        message += Convert.ToString(arr[i] * arr[size - k]) + " ";
        lastNumber = arr[i + 1];
        k++;
    }

    message += size % 2 != 0 ? Convert.ToString(lastNumber) : "";

    Console.WriteLine($"{message}");
}

ProductPairsNumbers(array, text);