/*
17. Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/
/*
Console.Write("Введите координату по оси оХ: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси оУ: ");
int y = Convert.ToInt32(Console.ReadLine());

// 1: ++
if (x > 0 && y > 0)
{
    Console.WriteLine("I четверть");
}
// 2: -+
else if (x < 0 && y > 0)
{
    Console.WriteLine("II четверть");
}
// 3: --
else if (x < 0 && y < 0)
{
    Console.WriteLine("III четверть");
}
// 4: +-
else if (x > 0 && y < 0)
{
    Console.WriteLine("IV четверть");
}
*/
/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
/*
Console.Write("Введите координату х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
// Math.Sqrt(число) => Math.Sqrt(25) => 5
// Math.Pow (2, 3) => 8 = 2 * 2 * 2
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // Math.Pow(число, степень)
// Math.Round(число, количество знаков) 
Console.WriteLine("Расстояние между 2 точками: " + Math.Round(d));
// A (3,6); B (2,1) -> 5,09
*/

/*
Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
/*
Console.Write("Введите число N:");
int finish = Convert.ToInt32(Console.ReadLine()); // Идем от 1 до N: [1;N]

int start = 1; // start -> finish

while (start <= finish)
{
    Console.Write(Math.Pow(start, 2) + " ");
    start++; // start++ => start = start + 1
    // start += 1
}
*/
Console.Write("Введите число N: ");
int finish = Convert.ToInt32(Console.ReadLine()); // Идем от 1 до N: [1;N]
// точка начала; условие выхода из цикла; увеличение счетчика: start++
for (int start = 1; start <= finish; start++)
{
    Console.Write(Math.Pow(start, 2) + " ");
}
