// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// метод ввода числа пользователем
int DataEntry(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//метод расчета суммы натуральных элементов в промежутке от M до N
int SumOfNumbersInRange(int firstnumber, int secondnumber)
{
    if (firstnumber == secondnumber) return secondnumber;
    return SumOfNumbersInRange(firstnumber + 1, secondnumber) + firstnumber;
}

int numberM = DataEntry("Введите число M: ");
int numberN = DataEntry("Введите число N: ");
Console.WriteLine();
int result = SumOfNumbersInRange(numberM, numberN);
Console.WriteLine(result);