//9.Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8 
//12-> 2 
//85 -> 8

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
