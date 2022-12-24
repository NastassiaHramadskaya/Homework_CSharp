// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

//метод сортировки строк массива по убыванию
void RowsSort(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int step = 0; step < matr.GetLength(1) - 1; step++)
        {
            for (int j = 0; j < matr.GetLength(1) - 1; j++)
            {
                if (matr[i, j] < matr[i, j + 1])
                {
                    int buf = matr[i, j];
                    matr[i, j] = matr[i, j + 1];
                    matr[i, j + 1] = buf;
                }
            }
        }
    }
}

int m = DataEntry("Введите число строк: ");
int n = DataEntry("Введите число столбцов: ");
int[,] array = FillMatrix(m, n, 1, 10);
PrintMatrix(array);
Console.WriteLine();
RowsSort(array);
PrintMatrix(array);