// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Метод проверки пятизначного числа на является ли оно палиндромом
void IfPolindrom(string str)
{
    Console.Clear();
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    int first = number / 1000; //находим первые 2 цифры
    int a = (number % 10) * 10;
    int b = ((number % 100) - (number % 10)) / 10;
    int last = a + b; //находим последние 2 цифры через 2 шага выше
    if (first == last)
    {
        Console.Write(number + "-> является палиндромом");
    }
    else
    {
        Console.Write(number + "-> не является палиндромом");
    }
    Console.WriteLine();
}

IfPolindrom("Введите пятизначное число: ");

//Решение задачи обычным способом, пошагово
// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int number = int.Parse(Console.ReadLine());
// int first = number / 1000;
// int a = (number % 10) * 10;
// int b = ((number % 100) - (number % 10)) / 10;
// int last = a + b; 
// if (first == last)
//     {
//         Console.WriteLine(a + ", " + b);
//         Console.WriteLine(first + ", " + last);
//         Console.Write(number + "-> является палиндромом");
//     }
// else
//     {
//         Console.WriteLine(a + ", " + b);
//         Console.WriteLine(first + ", " + last);
//         Console.Write(number + "-> не является палиндромом");
//     }
//  Console.WriteLine();