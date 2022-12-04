// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int DataEntry(string str) // метод ввода числа пользователем
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] FillArray(int[] array) //метод заполнения массива рандомными числами
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 100); //из условия задачи предположили, что числа в массиве должны быть двузначными
    }
    return array;
    Console.WriteLine(array);
}

// void FillArray(int[] collection) //метод заполнения массива рандомными числами
// {
//     for (int i = 0; i < collection.Length; i++)
//     {
//         collection[i] = new Random().Next(0, 100); //из условия задачи предположили, что числа в массиве должны быть двузначными
//     }
// }

void PrintArray(int[] col) //метод вывода на печать массива
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i] + " ");
    }
}


int number = DataEntry("Введите количество элементов массива");
int[] array = new int[number];

FillArray(array);
PrintArray(array);
Console.WriteLine();
