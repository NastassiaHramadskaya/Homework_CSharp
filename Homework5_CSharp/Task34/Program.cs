// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

//задание констант
const int SIZE = 10;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 999;

int[] array = new int[SIZE];

//метод заполнения массива случайными числами
int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

//метод подсчета количества четных чисел в массиве
void AmountOfEvenNumbers(int[] arr, out int amount)
{
    amount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            amount += 1;
        }
    }
}

array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(",", array) + ']');
AmountOfEvenNumbers(array, out int amount);
Console.WriteLine($"количество чётных чисел в массиве = {amount}");