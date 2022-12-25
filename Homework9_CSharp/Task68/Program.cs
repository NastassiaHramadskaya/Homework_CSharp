// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//функция Аккермана
int AckermannFunction(int firstnumber, int secondnumber)
{
    if (firstnumber == 0) return secondnumber + 1;
    else if ((firstnumber != 0) && (secondnumber == 0)) return AckermannFunction(firstnumber - 1, 1);
    else return AckermannFunction(firstnumber - 1, AckermannFunction(firstnumber, secondnumber - 1));
}

int numberM = 3;
int numberN = 2;
Console.WriteLine();
int result = AckermannFunction(numberM, numberN);
Console.WriteLine(result);
