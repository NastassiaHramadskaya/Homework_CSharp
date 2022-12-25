// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// метод ввода числа пользователем
int DataEntry(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//метод вывода натуральных чисел от N до 1
void ShowNumbers(int number)
{
    Console.Write($"{number} ");
    if (number > 1)
    {
        ShowNumbers(number - 1);
    }
}

int number = DataEntry("Введите число N: ");
Console.WriteLine();
ShowNumbers(number);