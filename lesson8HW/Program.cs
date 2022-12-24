
/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки 
двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
//создадим двумерный массив
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }

    return matrix;
}
*/
//печатаем двумерный массив
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

/*
//упорядочим по убыванию значения элементов строки
void SortRowData(int rowIndex, int[,] matrix)
{
    int length = matrix.GetLength(1) - 1;
    int length1, k;
    for (int i = 0; i < length; i++)
    {
        length1 = length - i;
        for (int j = 0; j < length1; j++)
        {
            if (matrix[rowIndex, j] < matrix[rowIndex, j + 1])
            {
                k = matrix[rowIndex, j + 1];
                matrix[rowIndex, j + 1] = matrix[rowIndex, j];
                matrix[rowIndex, j] = k;
            }
        }
    }
}

//получим массив после сортировки строк
void SortMatrix(int[,] matrix)
{
    int length = matrix.GetLength(0);
    for (int i = 0; i < length; i++)
    {
        SortRowData(i, matrix);
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = GetMatrix(rows, columns);
PrintMatrixInt(matrix);

Console.WriteLine("Матрица после сортировки строк по убыванию:");
SortMatrix(matrix);
PrintMatrixInt(matrix);
*/
//======================================================================================
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/
/*
int SmallestAmount(int[,] matrix)
{
    int lengthRow = matrix.GetLength(0);
    int lengthColumn = matrix.GetLength(1);
    int rowAmount;
    int minRowAmount = int.MaxValue;
    int indexMinRow = 0;

    for (int i = 0; i < lengthRow; i++)
    {
        rowAmount = 0;
        for (int j = 0; j < lengthColumn; j++)
        {
            rowAmount += matrix[i, j];
        }

        if (minRowAmount > rowAmount)
        {
            minRowAmount = rowAmount;
            indexMinRow = i;
        }
    }
    return indexMinRow;
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = GetMatrix(rows, columns);
PrintMatrixInt(matrix);

System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {SmallestAmount(matrix)}");
*/
//=======================================================================================
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int[,] MatrixMultiplication(int[,] mat1, int[,] mat2)
{
    int lengthRow = mat1.GetLength(0);
    int lengthColumn = mat1.GetLength(1);
    int[,] mat3 = new int[lengthRow, lengthColumn];

    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthColumn; j++)
        {
            mat3[i, j] = mat1[i, j] * mat2[i, j];
        }
    }

    return mat3;
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Матрица1");
int[,] matrix1 = GetMatrix(rows, columns);
PrintMatrixInt(matrix1);

Console.WriteLine("Матрица2");
int[,] matrix2 = GetMatrix(rows, columns);
PrintMatrixInt(matrix2);

Console.WriteLine("Результирующая матрица");
int[,] matrix3 = MatrixMultiplication(matrix1, matrix2);
PrintMatrixInt(matrix3);
*/
//========================================================================================
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы 
каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*
void LineByLineOutputArrayElements(int x, int y, int z)
{
    int k = 10;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int n = 0; n < z; n++)
            {
                Console.Write($"{k++}({i},{j},{n})\t");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите количество значений первого измерения: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество значений второго измерения: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество значений третего измерения: ");
int z = Convert.ToInt32(Console.ReadLine());

LineByLineOutputArrayElements(x, y, z);
*/
//========================================================================================
/*
Задача 62 (дополнительная). Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
void FillingArrayInSpiral(int row, int col)
{
    int[,] arr = new int[row, col];
    int number = 1;
    int amountOfElements = arr.Length;
    int lengthI = arr.GetLength(0) - 1;
    int lengthJ = arr.GetLength(1) - 1;
    int I = 0, I1 = 0;
    int J = 0, J1 = 0;
    int k = 0;

    while (number < amountOfElements)
    {
        //с лева на право
        for (int j = J; j < lengthJ; j++)
        {
            arr[I, j] = number++;
            J = j;
        }

        //с верху вниз
        J++;
        for (int i = I; i < lengthI; i++)
        {
            arr[i, J] = number++;
            I = i;
        }

        //с права на лево
        I++;
        J1 = J;
        for (int j = 0; j < lengthJ - k; j++)
        {
            arr[I, J1 - j] = number++;
            J = J1 - j;
        }

        //с низу в верх
        J--;
        I1 = I;
        for (int i = 0; i < lengthI - k; i++)
        {
            arr[I1 - i, J] = number++;
            I = I1 - i;
        }

        lengthI--;
        lengthJ--;
        J++;
        k++;
        if (number == amountOfElements) arr[I, J] = number;
    }

    PrintMatrixInt(arr);
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

FillingArrayInSpiral(rows, columns);