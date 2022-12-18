// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//на вход принимаем число, проверяем есть ли число в массиве, если есть, выводим его позицию

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

//метод поиска числа в массиве и возврата его позиции
string FindPositionOfElement(int[,] matr, int number)
{
    string result = String.Empty;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == number)
            {
                result = $"число {number} находится в {i + 1} строке, {j + 1} столбце";
                break;
            }
            else
            {
                result = ($"числа нет в массиве");
            }
        }
    }
    return result;
}

int m = DataEntry("Введите число M: ");
int n = DataEntry("Введите число N: ");
int[,] array = FillMatrix(m, n, 0, 10);
int number = DataEntry("Введите число, которое необходимо найти в массиве: ");
PrintMatrix(array);
string position = FindPositionOfElement(array, number);
Console.WriteLine(position);

