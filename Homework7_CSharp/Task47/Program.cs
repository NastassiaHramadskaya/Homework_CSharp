// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//метод ввода числа пользователем
int DataEntry(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//метод создания двумерного массива и заполнения случайными вещественными числами
double[,] FillMatrix(int rows, int columns, int leftRange, int rightRange)
{
    double[,] table = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            table[i, j] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 2);
        }
    }
    return table;
}
//метод вывода двумерного массива, заполненного вещественными числами
void PrintMatrix(double[,] matr)
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

int m = DataEntry("Введите число M: ");
int n = DataEntry("Введите число N: ");
double[,] array = FillMatrix(m, n, 0, 10);
PrintMatrix(array);