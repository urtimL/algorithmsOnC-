/*
Задача 19
Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write("Введите число N: ");
string strNumber = Console.ReadLine();
int nomCharacters = strNumber.Length;
int half = nomCharacters / 2;
int k = 1, n = 0;

for (int i = 0; i < half; i++)
{
    string firstSimvol = strNumber.Substring(i, 1);
    string lastSimvol = strNumber.Substring(nomCharacters - 1 * k, 1);
    k++;

    if (firstSimvol != lastSimvol)
    {
        n = 1;
        break;
    }
}

if (n == 0) Console.WriteLine("да");
else Console.WriteLine("нет");