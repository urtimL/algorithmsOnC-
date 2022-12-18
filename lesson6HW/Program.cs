/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
Console.Write("Введите числа через запятую: ");
int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

int AmountPositiveNumbers(int[] arr)
{
    int rez = 0;
    foreach (var item in arr)
    {
        if (item > 0) rez++;
    }

    return rez;
}

Console.WriteLine($"Количество положительных чисел: {AmountPositiveNumbers(array)} шт.");
*/
//==================================================================================================
/*
Задача 42: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 

значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
Console.Write("Введите значения - b1, k1, b2, k2 через запятую: ");
int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

double[] LineIntersectionCoordinates(int[] arr)
{
    double x = 0;
    double y = 0;
    double b1 = arr[0];
    double k1 = arr[1];
    double b2 = arr[2];
    double k2 = arr[3];

    x = b2 / (k1 - k2) - b1 / (k1 - k2);
    y = k2 * x + b2;

    double[] rez = { x, y };

    return rez;
}
double[] arrRezult = LineIntersectionCoordinates(array);
Console.WriteLine($"Координаты пересечения прямых: ({arrRezult[0]}; {arrRezult[1]})");
*/
//==================================================================================================
/*
Задача 43 (ДОП, по желанию, на 5 нужно сделать 2 задачки): 
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
Console.Write("Введите число: ");
int nomber = Convert.ToInt32(Console.ReadLine());

void DecimalToBinary(int num)
{
    string rez = "";

    while (num != 0)
    {
        //  if (num % 2 == 0) rez = "0" + rez;
        //  else rez = "1" + rez;
        rez = (num % 2 == 0 ? '0' : '1') + rez;
        num /= 2;
    }

    Console.WriteLine(Convert.ToInt32(rez));
    Console.WriteLine(rez);
}

DecimalToBinary(nomber);