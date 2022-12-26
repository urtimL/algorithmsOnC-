/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
string PrintNumbers(int start)
{
    if (start == 1) return start.ToString();

    return (start + ", " + PrintNumbers(start - 1));
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(n));
*/
//==============================================================================
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int PrintNumbers(int start, int end)
{
    if (start == end) return start;

    return (start + PrintNumbers(start + 1, end));
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int start = M > N ? N : M;
int end = M < N ? N : M;

Console.WriteLine(PrintNumbers(start, end));
*/
//===============================================================================
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int AkrmanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkrmanFunction(m - 1, 1);
    else return AkrmanFunction(m - 1, AkrmanFunction(m, n - 1));
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m},{n}) = {AkrmanFunction(m, n)}");