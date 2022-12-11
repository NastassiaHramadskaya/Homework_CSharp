// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

//задание констант
const int SIZE = 4;
const int LEFT_RANGE = -100;
const int RIGHT_RANGE = 100;

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

//метод подсчета суммы элементов, стоящих на нечётных позициях
void SumOfNumberOnOddPositions(int[] arr, out int sum)
{
    sum = 0;
    for (int i = 1; i < arr.Length;)
    {
        sum += arr[i];
        i = i + 2;
    }
}

array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(",", array) + ']');
SumOfNumberOnOddPositions(array, out int sum);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {sum}");