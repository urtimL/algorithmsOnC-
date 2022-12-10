// Напишите программу, которая принимает на вход число A 
// и выдаёт сумму чисел от 1 до A 
/*
int GetSum(int A)
{
    int prod = 1;

    for (int i = 1; i <= A; i++)
    {
        prod *= i;
    }

    return prod;
}


Console.Write("Введите число А: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSum(N));
/*
int Count(int A)
{
    int rez = 0;

    while (A != 0)
    {
        A = A / 10;
        rez++;
    }



    return rez;
}
Console.Write("Введите число А: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Count(N));
*/

/*
Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0] 
*/
int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }

    return array;
}
string str = string.Join(", ", GetArray());
Console.WriteLine("[" + str + "]");

void PrintArray(int[] col)
// Метод для выввода массива на экран 
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(col[position]);
        Console.Write(" "); position++;
    }
}