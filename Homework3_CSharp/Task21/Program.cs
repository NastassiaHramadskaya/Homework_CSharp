// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();

// int DataEntryXY(string str) //метод ввода данных
// {
//     Console.WriteLine(str);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }
// //метод нахождения расстояния между точками по координатам в 3д пространстве
// double FindDistance(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
// {
//     double dist = Math.Sqrt(Math.Pow((arg4 - arg1), 2) + Math.Pow((arg5 - arg2), 2) + Math.Pow((arg6 - arg3), 2));
//     return dist;
// }

// int x1 = DataEntryXY("Введите координаты x1=");
// int y1 = DataEntryXY("Введите координаты y1=");
// int z1 = DataEntryXY("Введите координаты z1=");
// int x2 = DataEntryXY("Введите координаты x2=");
// int y2 = DataEntryXY("Введите координаты y2=");
// int z2 = DataEntryXY("Введите координаты z2=");
// double result = Math.Round(FindDistance(x1, y1, z1, x2, y2, z2), 2);
// Console.WriteLine(result);

// //Не рекомендуется в функции использовать более 5 аргументов. 
//В данном случае лучше было бы записывать координаты точек в массивах. Тогда бы в функции было бы всего 2 аргумента.
// В примере задания результат указан, округленным до двух цифр после запятой. 
//Следовало все-таки округлить. В C# есть метод Math.Round(value, count), где count – количество значащих цифр после запятой. Пользуйтесь на здоровье)
// Разделяйте пробелами имена переменных и действия. Можно воспользоваться комбинацией клавиш Shift + Alt + F на Windows, 
//или Shift + Option + F на Mac.

void EntryCoordinates3D(int[] coordinates) //метод ввода данных
{
    int index = 0;
    int length = 3;
    while (index < length)
    {
        int number = int.Parse(Console.ReadLine());
        coordinates[index] = number;
        index++;
    }
}

// //метод нахождения расстояния между точками по координатам в 3д пространстве
double FindDistance(int[] arg1, int[] arg2)
{
    int index = 0;
    int length = arg1.Length;
    double sum = 0;
    double dist = 0;
    while (index < length)
    {
        sum = sum + Math.Pow((arg1[index] - arg2[index]), 2);
        index++;
    }
    dist = Math.Sqrt(sum);
    return dist;
}

int[] XYZ1 = new int[3];
int[] XYZ2 = new int[3];
Console.WriteLine("Введите координаты точки A:");
EntryCoordinates3D(XYZ1);
Console.WriteLine("Введите координаты точки B:");
EntryCoordinates3D(XYZ2);
double result = Math.Round(FindDistance(XYZ1, XYZ2), 2);
Console.WriteLine("Расстояние между точками: " + result);
