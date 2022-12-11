// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76;

//Вещественное число - это число, в котором есть целая и дробная части. Целая и дробная часть отделяются друг от друга запятой.

Console.Clear();

//задание констант
const int SIZE = 4;

double[] array = new double[SIZE];
double result = 0;

//метод заполнения массива случайными вещественными числами
double[] FillArrayWithRandomNumbers(int size)
{
    Random rand = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.NextDouble(), 2); //используется Random.NextDouble Метод, т.к. по условию задачи массив состоит из вещественных чисел + округлили для удобства
    }
    return arr;
}

//метод нахождения максимального элемента массива
double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

//метод нахождения минимального элемента массива
double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

array = FillArrayWithRandomNumbers(SIZE);
Console.WriteLine('[' + string.Join(";", array) + ']');
double maximum = FindMax(array);
Console.WriteLine($"Максимальный элемент массива = {maximum}");
double minimum = FindMin(array);
Console.WriteLine($"Минимальный элемент массива = {minimum}");
result = Math.Round(maximum - minimum, 2);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {result}");


