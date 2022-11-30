// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int DataEntryXY(string str) //метод ввода данных
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//метод нахождения расстояния между точками по координатам в 3д пространстве
double FindDistance(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) 
{
    double dist = Math.Sqrt(Math.Pow((arg4-arg1),2) + Math.Pow((arg5-arg2),2)+ Math.Pow((arg6-arg3),2));
    return dist;
} 

int x1 = DataEntryXY("Введите координаты x1=");
int y1 = DataEntryXY("Введите координаты y1=");
int z1 = DataEntryXY("Введите координаты z1=");
int x2 = DataEntryXY("Введите координаты x2=");
int y2 = DataEntryXY("Введите координаты y2=");
int z2 = DataEntryXY("Введите координаты z2=");
double result = Math.Round(FindDistance(x1, y1, z1, x2, y2, z2), 2);
Console.WriteLine(result);
