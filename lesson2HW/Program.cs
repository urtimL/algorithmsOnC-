/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number / 10 % 10);
*/
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100) Console.WriteLine("третьей цифры нет");
else
{
    int power = number.ToString().Length - 3;
    int coef = Convert.ToInt32(Math.Pow(10, power));
    Console.WriteLine(number / coef % 10);
}
*/
/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1) Console.WriteLine("Введено неверное число!");
else if (number == 6 || number == 7) Console.WriteLine("да");
else Console.WriteLine("нет");