// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()); //перевод введенной строки в число
if (number < 0)
{
    number = number * (-1); //корректировка отрицательного числа на положительного для упрощения работы
}
string numberA = number.ToString();
int N = numberA.Length;
int[] array = {};
int index = 0;
while (index < N)
{
    array[index] = number %10;
    index = index - 1;
}
Console.WriteLine(array[N - 4]);

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }