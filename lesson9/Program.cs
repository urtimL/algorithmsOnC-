// // Рекурсия - ф-я, вызывающая саму себя
// // Факториал - с помощью рекурсии

// int Factorial(int num) // num - число, от которого ищется факториал
// {
//     // Базовый случай - выходите из рекурсии, рекурсия = бесконечный цикл без базового случая
//     if (num == 1)
//     {
//         return 1;
//     }
//     // Рекурсивный случай
//     // num = 5, 5 * 4 * 3 * 2 * 1
//     return num * Factorial(num - 1);
// }

// Console.WriteLine(Factorial(4)); // 4! = 1 * 2 * 3 * 4 = 24

// Задача 63: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int n = Convert.ToInt32(Console.ReadLine()); // N (правая граница)
// 1; N: start = 1, end = N
string PrintNumbers(int start, int end)
{
    // Базовый случай - выход из рекурсии
    if (start == end) return start.ToString(); // n = 2: res = 1, 2(start == end)
    // Рекурсивный случай

    return (start + ", " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(-4, n));

// Задача 67: Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



// int digit = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int number)
// {
//     // Базовый случай
//     if (number == 0) return 0;
//     // Рекурсивный случай
//     return (number % 10 + SumNumbers(number / 10));
// }

// Console.WriteLine($"Сумма цифр в числе {digit} = {SumNumbers(digit)}");

// Задача 69: Напишите программу,
// которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите cтепень: ");
// int degree = Convert.ToInt32(Console.ReadLine());
// if (degree < 0)
// {
//     return;
// }
// int Pow(int digit, int power)
// {
//     if (power == 0) return 1; 
//     if (power == 1) return digit;
//     // Рекурсивный случай
//     return (digit * Pow(digit, power - 1)); 
//     // power - грубо говоря, счетчик 
// }
// Console.WriteLine($"Число {number} в степени {degree} = {Pow(number, degree)} ");
