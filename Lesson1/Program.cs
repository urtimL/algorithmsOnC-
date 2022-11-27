/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int rez = number * number;
Console.WriteLine(rez);
*/
/*
Console.Write("Введите первое число- ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число- ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber == secondNumber * secondNumber)
{
    Console.Write("Второе число является корнем первого");
}
else Console.Write("Второе число Не является корнем первого");
*/
/*
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	3 -> Среда 
5 -> Пятница
*/
// 5. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
int positivNumber = Convert.ToInt32(Console.ReadLine());
if (positivNumber < 0) positivNumber *= -1;
int negativNumber = positivNumber * -1;
while (negativNumber <= positivNumber)
{
    Console.Write(negativNumber + " ");
    negativNumber++;
}