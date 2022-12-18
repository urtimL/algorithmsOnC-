/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
void PrintMatrix(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

double[,] GetMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 1000, 2);
        }
    }

    return matrix;
}

Console.Write("Введите значения - m, n через запятую: ");
int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

PrintMatrix(GetMatrix(array[0], array[1]));
*/
//===============================================================================================
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
/*
void PrintMatrixInt(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

//создадим двумерный массив
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    int k = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = k++;
        }
    }

    return matrix;
}

int GetMatrixValue(int[,] valueMatrix, int[] coordinates)
{
    int x = coordinates[0];
    int y = coordinates[1];

    int numberOfRows = valueMatrix.GetLength(0);
    int numberOfColumns = valueMatrix.GetLength(1);

    if (x > numberOfRows || y > numberOfColumns) return 0;

    return valueMatrix[x, y];
}

int[,] matrix = GetMatrix(3, 4);
PrintMatrixInt(matrix);

Console.WriteLine();

Console.Write("Введите значения позиции элемента в двумерном массиве (x,y) через запятую: ");
int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

int rez = GetMatrixValue(matrix, array);

if (rez == 0) Console.WriteLine("элемента с такими координатами в массиве нет");
else Console.WriteLine(rez);
*/
//================================================================================================
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

//создадим двумерный массив
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }

    return matrix;
}

void PrintMatrixInt(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

void ArithmeticMeanOfEachColumn(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    double k = 0;

    for (int j = 0; j < columns; j++)
    {
        k = 0;
        for (int i = 0; i < rows; i++)
        {
            k += arr[i, j];
        }
        Console.Write($"{Math.Round(Convert.ToDouble(k / rows), 1)} \t");
    }
}

int[,] matrix = GetMatrix(3, 4);
PrintMatrixInt(matrix);
Console.WriteLine();
ArithmeticMeanOfEachColumn(matrix);
Console.WriteLine();