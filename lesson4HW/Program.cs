/*
Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
/*
int error = 0;
void Exponentiation(int[] arr)
{
    int baseNumber = arr[0];
    int degree = arr[1];
    int rez = 1;

    for (int i = 0; i < degree; i++)
    {
        rez *= baseNumber;
    }

    Console.WriteLine(rez);
}

Console.Write("Введите два числа x, y: ");
int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

if (array.Length != 2)
{
    Console.WriteLine("Введено не верное количество символов!");
    error = 1;
}

if (error == 0) Exponentiation(array);
*/
//===================================================================================================
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/
/*
int SummOfNumber(int num)
{
    int rez = 0;

    while (num != 0)
    {
        rez += num % 10;
        num /= 10;
    }

    return rez;
}

Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(SummOfNumber(number));
*/
//==================================================================================================
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/*
Вариант1  когда программа сама создает массив из 8 элементов и выводит их на экран.
int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }

    return array;
}
string str = string.Join(", ", GetArray());
Console.WriteLine("[" + str + "]");
*/
/*
Вариант 2 когда пользователь через запятую вводит числа а программа собирает
эти числа в массив и выводит его на экран. Как в примерах:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int[] GetArray()
{
    Console.Write("Введите числа через запятую: ");
    int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

    return array;
}
string str = string.Join(", ", GetArray());
Console.WriteLine("[" + str + "]");

