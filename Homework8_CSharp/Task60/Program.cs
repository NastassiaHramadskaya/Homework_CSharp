// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// метод ввода числа пользователем
int DataEntry(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//метод создания двумерного массива и заполнения случайными числами
int[,,] Fill3DMatrix(int rows, int columns, int third, int leftRange, int rightRange)
{
    int[,,] table = new int[rows, columns, third];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < third; k++)
            {
                table[i, j, k] = rand.Next(leftRange, rightRange + 1);
            }
        }
    }
    return table;
}

//метод вывода двумерного массива
void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
               Console.Write($"{matr[i, j, k]} ( {i}, {j}, {k}) "); 
            }
            Console.WriteLine();
        }  
    }
}

Console.Clear();
int m = DataEntry("Введите число m: ");
int n = DataEntry("Введите число n: ");
int o = DataEntry("Введите число o: ");
Console.WriteLine();
int[,,] array = Fill3DMatrix(m, n, o, 10, 99);
PrintMatrix(array);