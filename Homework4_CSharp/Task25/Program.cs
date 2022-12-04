// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int DataEntry(string str) // метод ввода числа пользователем
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int numberA = DataEntry("Введите число А:");
int numberB = DataEntry("Введите число B:");
int numberDegree = 1;
for (int i = 1; i <= numberB; i++) //нахождение степени числа А через цикл (по условию задачи); цикл можно заменить на Math.Pow
{
    numberDegree = numberDegree * numberA;
}
Console.WriteLine($"{numberA} , {numberB} -> {numberDegree}");


// Console.Clear();

// int DataEntry(string str) // метод ввода числа пользователем
// {
//     Console.WriteLine(str);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int numberA = DataEntry("Введите число А:");
// int numberB = DataEntry("Введите число B:");
// double numberDegree = Math.Pow(numberA, numberB);
// Console.WriteLine($"{numberA} , {numberB} -> {numberDegree}");