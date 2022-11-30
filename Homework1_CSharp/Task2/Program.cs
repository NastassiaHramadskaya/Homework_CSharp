//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA == numberB)
{
    Console.WriteLine($"а = {numberA} ; b = {numberB} -> числа равны");
}
else
{
    if (numberA > numberB)
    {
        Console.WriteLine($"а = {numberA} ; b = {numberB} -> max = {numberA}, min = {numberB}");
    }
    else
    {
        Console.WriteLine($"а = {numberA} ; b = {numberB} -> max = {numberB}, min = {numberA}");
    }
}