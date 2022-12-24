// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// метод ввода числа пользователем
int DataEntry(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//метод создания двумерного массива и заполнения случайными числами
int[,] FillMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] table = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            table[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return table;
}

//метод вывода двумерного массива
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//метод нахождения произведения двух матриц
void MultiplyMatrices(int[,] firstmatrix, int[,] secondmatrix)
{
    int columnsFirstMatrix = firstmatrix.GetLength(1);
    int rowsSecondMatrix = secondmatrix.GetLength(0);
    if (columnsFirstMatrix == rowsSecondMatrix)
    //Две матрицы можно перемножить между собой тогда и только тогда, когда количество столбцов первой матрицы равно количеству строк второй матрицы.
    {
        int[,] resultMatrix = new int[firstmatrix.GetLength(0), secondmatrix.GetLength(1)];
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int element = 0;
                for (int l = 0; l < firstmatrix.GetLength(1); l++)
                {
                    element = element + firstmatrix[i, l] * secondmatrix[l, j];
                }
                resultMatrix[i, j] = element;
            }
        }
        PrintMatrix(resultMatrix);
    }
    else
    {
        Console.WriteLine("Перемножение матриц невозможно");
    }
}

Console.Clear();
int m = DataEntry("Введите число строк первой матрицы: ");
int n = DataEntry("Введите число столбцов первой матрицы: ");
int o = DataEntry("Введите число строк второй матрицы: ");
int p = DataEntry("Введите число столбцов второй матрицы: ");
Console.WriteLine();
int[,] firstmatrix = FillMatrix(m, n, 1, 10);
PrintMatrix(firstmatrix);
Console.WriteLine();
int[,] secondmatrix = FillMatrix(o, p, 1, 10);
PrintMatrix(secondmatrix);
Console.WriteLine();
MultiplyMatrices(firstmatrix, secondmatrix);