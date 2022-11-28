/*
Задача 2: Напишите программу, которая на вход принимает два числа 
и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7->max = 7
a = 2 b = 10->max = 10
a = -9 b = -3->max = -3


Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Большее число: " + a);
    Console.WriteLine("Меньшее число: " + b);
}
else if (a == b)
{
    Console.Write("Числа равны" + b);
}
else
{
    Console.WriteLine("Большее число: " + b);
    Console.WriteLine("Меньшее число: " + a);
}



Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
 
Console.WriteLine("Введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a >= b & a >= c) Console.WriteLine("Большее число: " + a);
else if (b >= a & b >= c) Console.WriteLine("Большее число: " + b);
else Console.WriteLine("Большее число: " + c);



Задача 6: Напишите программу, которая на вход принимает число 
и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4->да
- 3->нет
7->нет


Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0) Console.Write("да");
else Console.Write("нет");



Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int counter = 2;

while (counter <= a)
{
    Console.Write(counter + ", ");
    counter += 2;
}
