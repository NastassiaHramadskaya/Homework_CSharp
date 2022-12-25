// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// индексы спиральной матрицы
// 00 01 02 03 = 3 
// 10 11 12 13 = 4
// 20 21 22 23 = 5
// 30 31 32 33 = 6
// 3  4  5  6

//метод создания двумерного массива и заполнения спиралью
//с решением таким образом помогли, через булевые переменные пока не получилось сделать
int[,] FillSpiralMatrix(int rows, int columns)
{
    int[,] table = new int[rows, columns];
    int number = 1;
    int row = 0;
    int column = 0;

    while (number <= 16)
    {
        table[row, column] = number;
        number++;
        if (row <= column + 1 && row + column < 3)
            column++;
        else if (row < column && row + column >= 3)
            row++;
        else if (row >= column && row + column > 3) 
            column--;
        else
            row--;
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

int[,] spiral = FillSpiralMatrix(4, 4);
PrintMatrix(spiral);