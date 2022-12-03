//9.Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8 
//12-> 2 
//85 -> 8
/*
int number = new Random().Next(10, 100); // Next (start, finish + 1)

int firstDigit = number / 10;//Первая цифра числа: 78 -> 7

int secondDigit = number % 10; //Вторая цифра числа: 78 -> 8

int max = firstDigit; // Пусть максимум - первая цифра числа

if (secondDigit > max) // max = 5, secondDigit  = 10
{
    max = secondDigit;
}
Console.WriteLine("Исходное число:" + number);
Console.WriteLine("Максимальное число:" + max);
*/
/*
11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98

12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число 
кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
/*
System.Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
    System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine("не кратно, остаток " + firstNumber % secondNumber);
}

*/
/*

14.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine("кратно");
}
else System.Console.WriteLine("не кратно");
