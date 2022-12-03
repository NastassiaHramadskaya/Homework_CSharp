// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//метод вывода кубов чисел от 1 до введенного
Console.Clear();

void TableOfCubed(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    int i = 1;
    if (number < 1)
    {
        Console.WriteLine("Введенное число не соответствует условиям задачи. Введите число от 1 и более.");
    }
    else
    {
        Console.WriteLine("Таблица кубов для чисел от 1 до " + number + ": ");
        while (i <= number)
        {
            Console.Write(Math.Pow(i, 3) + ", ");
            i++;
        }
    }
    Console.WriteLine();
}

TableOfCubed("Введите число: ");