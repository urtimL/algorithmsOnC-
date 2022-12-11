// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//  Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 
// 29, сумма отрицательных равна -20.

// int[] GetArray(int size,int minValue, int maxValue)
//  // size - размер массива, minValue - минимальное число (-9), maxValue - (9)
// {
//     int[] array = new int[size]; //Массив на size элементов, заполненных нулями
//     for (int i = 0; i < size; i++) // size = array.Length
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// // Вызов функции
// int[] resultArray = GetArray(4, -9, 9);
// Console.WriteLine(String.Join("; ", resultArray));

// int resultPositive = 0; 
// int resultNegative = 0; 


// for (int i = 0; i < resultArray.Length; i++)
// {
//     resultPositive += resultArray[i] > 0 ? resultArray[i] : 0;
//     // resultArray[i] > 0 (ИСТИНА): resultPositive+=resultArray[i] 
//     // resultArray[i] > 0 (ложь): resultPositive+=0
//     resultNegative += resultArray[i] < 0 ? resultArray[i] : 0;
// }

// for (int i = 0; i < resultArray.Length; i++)
// {
//     if (resultArray[i] > 0) // положительное число
//     {
//         resultPositive += resultArray[i]; // resultPositive = resultPositive + resultArray[i]
//     }

//     else resultNegative += resultArray[i];
// }

// Console.WriteLine($"Сумма отр.чисел: {resultNegative}, сумма пол.чисел: {resultPositive}");

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] GetArray(int size,int minValue, int maxValue)
//  // size - размер массива, minValue - минимальное число (-9), maxValue - (9)
// {
//     int[] array = new int[size]; //Массив на size элементов, заполненных нулями
//     for (int i = 0; i < size; i++) // size = array.Length
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// // Вызов функции
// int[] resultArray = GetArray(12, -9, 9);


// int[] InverseArray(int[] array)
// {
//     int size = array.Length; // size = array.Length (длина массива)
//     for (int i = 0; i < size; i++)
//     {
//         array[i] *= (-1); // array[i] = array[i] * (-1)
//     }
//     return array;

// }
// Console.WriteLine($"Array: [{String.Join("; ", resultArray)}]");
// Console.WriteLine($"Reverse array: [{String.Join("; ", InverseArray(resultArray))}]");

// int[] array = { 1, 2, 3, 4, 5, 6, 7 };
// int searchNumber = new Random().Next(1, 11); // [1;10]
// Console.WriteLine($"Ищем число {searchNumber} в массиве..");
// int size = array.Length;
// string result = "отсутствует"; // false = число в массиве НЕ найдено
// // true = число в массиве найдено
// for (int i = 0; i < size; i++)
// {
//     if (searchNumber == array[i])
//     {
//         result = "присутствует"; // element found
//         break;
//     }
// }

// Console.WriteLine($"Элемент {searchNumber} в массиве: {result}");


int[] GetArray(int size, int minValue, int maxValue)
// size - размер массива, minValue - минимальное число (-9), maxValue - (9)
{
    int[] array = new int[size]; //Массив на size элементов, заполненных нулями
    for (int i = 0; i < size; i++) // size = array.Length
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
// PascalCase - для методов, camelCase - для переменных
int GetCountElements(int[] inputArray, int leftRange, int rightRange)
{
    int count = 0; // Числа еще не искали :)
    // foreach (тип_данных_и_переменную in массиве)
    foreach (var item in inputArray)
    {
        // & - "И"
        if (item >= leftRange && item <= rightRange) count++;
        // inputArray[i] = item
    }
    return count; // Количество чисел в диапазоне от 10 до 99 включительно
}// Вызов функции
int[] resultArray = GetArray(7, 0, 1000); // 123 элемента от 0 до 999 включительноэ

Console.WriteLine($"Array: [{String.Join("; ", resultArray)}]");
Console.WriteLine($"Количество элементов в д-е [10;99]: {GetCountElements(resultArray, 10, 99)}");