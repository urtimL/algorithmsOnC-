/*
Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
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


