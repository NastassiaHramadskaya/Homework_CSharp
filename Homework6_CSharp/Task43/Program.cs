// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

int[] firstLine = new int[2];
firstLine = FillArrayWithRandomNumbers("Введите b1, k1: ");
int[] secondLine = new int[2];
secondLine = FillArrayWithRandomNumbers("Введите b2, k2: ");
double[] result = FindIntersectionPoint(firstLine, secondLine);
Console.WriteLine($"[{string.Join(", ", firstLine)}]");
Console.WriteLine($"[{string.Join(", ", secondLine)}]");
Console.WriteLine($"[{string.Join(", ", result)}]");

//метод заполнения массива через ввод пользователем числа
int[] FillArrayWithRandomNumbers(string str)
{
    Console.WriteLine(str);
    int[] arr = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

//метод нахождения точки пересечения двух прямых
double[] FindIntersectionPoint(int[] arr1, int[] arr2) //x = (b2 - b1) / (k1 - k2)
{
    double[] point = new double[2];
    double x = 0;
    double y = 0;
    x = (arr2[0] - arr1[0]) / (arr1[1] - arr2[1]);
    y = arr1[1] * x + arr1[0];
    point[0] = Math.Round(x, 2);
    point[1] = Math.Round(y, 2);
    return point;
}

// метод ввода числа пользователем
int DataEntry(string str) 
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}



