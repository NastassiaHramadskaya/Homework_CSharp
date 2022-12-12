// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();
const int SIZE = 5; //сколько пользователь введет чисел

int[] array = new int[SIZE];
array = FillArrayWithRandomNumbers(SIZE);
Console.WriteLine($"[{string.Join(", ", array)}]");
int result = AmountOfPositiveNumbers(array);
Console.WriteLine($"Пользователь ввел {result} положительных чисел");

//метод заполнения массива через ввод пользователем числа
int[] FillArrayWithRandomNumbers(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

//метод подсчета положительных чисел в массиве
int AmountOfPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}