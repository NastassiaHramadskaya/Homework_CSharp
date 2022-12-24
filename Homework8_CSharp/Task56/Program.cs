// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

//метод нахождения строки в наименьшей суммой элементов
void FindMinSumOfElementsInRow(int[,] matr)
{
    int[] rowssum = new int [matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        Console.WriteLine($"Сумма чисел строки {i + 1} = {sum}");
        rowssum[i] = sum;
    }
    // Console.WriteLine('[' + string.Join(",", rowssum) + ']');
    Console.WriteLine();
    int min = rowssum[0];
    int minrownumber = 1;
    for (int k = 0; k < rowssum.Length; k++)
    {
        if (rowssum[k] < min)
        {
            min = rowssum[k];
            minrownumber = k +1;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minrownumber}");
}

Console.Clear();
int m = DataEntry("Введите число строк: ");
int n = DataEntry("Введите число столбцов: ");
Console.WriteLine();
int[,] array = FillMatrix(m, n, 1, 10);
PrintMatrix(array);
Console.WriteLine();
FindMinSumOfElementsInRow(array);