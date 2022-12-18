// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
// int[,] -> int [rows,columns]
// Матрица - прямоугольная таблица с размером m * n 
// Квадратная матрица - таблица, у которой кол-во строк = кол-во столбцов
// Прямоугольная матрица - таблица, у которой кол-во строк != кол-во столбцов
// m - кол-во стр, n - кол-во столбцов
int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n]; // m - кол-во строков, n - кол-во столбцов
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = m, по строчкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // j, m, k 
        // matrix.GetLength(1) = n, по столбцам
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // Строчку с индексом
        }

        Console.WriteLine(); // После строчки можно сделать перенос
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = GetMatrix(rows, columns, 0, 10); // Создали матрицу
PrintMatrix(result);

// int[,] ChangeMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i+=2)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j+=2)
//         {
//             matrix[i, j] *= matrix[i, j]; // matrix[i,j] = matrix[i,j] * matrix[i,j]
//         }
//     }
//     return matrix;
// }
// System.Console.WriteLine();
// PrintMatrix(ChangeMatrix(result));

int GetSumDiagonal(int[,] matrix)
{
    int sum = 0; // Изначальное значение суммы
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i, j]; // sum = sum + matrix[i, j]
            }
        }
    }
    return sum;
}
Console.WriteLine($"Сумма чисел в главной диагонали: {GetSumDiagonal(result)}");
