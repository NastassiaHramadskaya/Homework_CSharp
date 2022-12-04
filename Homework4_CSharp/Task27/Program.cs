// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int DataEntry(string str) // метод ввода числа пользователем
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumOfDigits(int number) //метод нахождения суммы цифр числа
{
    int numberWork = Math.Abs(number); //берем число по модулю, если пользователь ввел отрицательное число
    int sum = 0;
    int ost = 0;
    for (int i = 0; numberWork != 0; i++)
    {
        ost = numberWork % 10;
        numberWork = numberWork / 10;
        sum = sum + ost;
    }
    return sum;
}


int number = DataEntry("Введите число:");
int result = SumOfDigits(number);
Console.WriteLine($"{number} -> {result}");


