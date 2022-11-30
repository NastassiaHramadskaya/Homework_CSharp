// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()); //перевод введенной строки в число
int numberShort = number; //добавление переменной для отсечения разрядов
int thirdDigit = 0;
if (number < 0)
{
    numberShort = number * (-1); //корректировка отрицательного числа на положительного для упрощения работы
}
if (numberShort < 100)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else
{while (numberShort > 1000) //цикл для сокращения числа до трехзначного
    {
        numberShort = numberShort / 10;
    }
    thirdDigit = numberShort % 10;
    Console.WriteLine($"{number} -> {thirdDigit}");
}
