// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//метод ввода числа пользователем
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
//метод подсчета ср. арифм. элементов по столбцу
void FindAverageOfElementsInColumn(int[,] matr)
{
    int rows = matr.GetLength(0);
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        double sum = 0;
        double average = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            sum += matr[j, i];
        }
        average = Math.Round(sum / rows, 2);
        Console.WriteLine($"Сумма чисел столбца {i+1} = {sum}, среднее чисел = {average}");
    }
}

int m = DataEntry("Введите число M: ");
int n = DataEntry("Введите число N: ");
int[,] array = FillMatrix(m, n, 0, 10);
PrintMatrix(array);
Console.WriteLine();
FindAverageOfElementsInColumn(array);