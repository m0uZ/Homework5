// Задача 21 HARD - необязательная
// Напишите программу, которая принимает на вход координаты точек и находит расстояние 
// между ними в N-мерном пространстве. N - задается пользователем.

Console.Write("Введите N мерное пространство: ");
int N = Convert.ToInt32(Console.ReadLine());
double S = 0;
if (N == 4)
{
    Console.Write("введите координату х1 ");
    int x1 = int.Parse(Console.ReadLine());
    Console.Write("введите координату y1 ");
    int y1 = int.Parse(Console.ReadLine());
    Console.Write("введите координату z1 ");
    int z1 = int.Parse(Console.ReadLine());
    Console.Write("введите координату t1 ");
    int t1 = int.Parse(Console.ReadLine());
    Console.Write("введите координату x2 ");
    int x2 = int.Parse(Console.ReadLine());
    Console.Write("введите координату y2 ");
    int y2 = int.Parse(Console.ReadLine());
    Console.Write("введите координату z2 ");
    int z2 = int.Parse(Console.ReadLine());
    Console.Write("введите координату t2 ");
    int t2 = int.Parse(Console.ReadLine());

    S = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) + Math.Pow(t2 - t1, 2)), 2);
    Console.WriteLine($"Расстояние между точкави в 4D = {S}");
}
else if (N == 3)
{
    Console.Write("введите координату х1 ");
    int x1 = int.Parse(Console.ReadLine());
    Console.Write("введите координату y1 ");
    int y1 = int.Parse(Console.ReadLine());
    Console.Write("введите координату z1 ");
    int z1 = int.Parse(Console.ReadLine());
    Console.Write("введите координату x2 ");
    int x2 = int.Parse(Console.ReadLine());
    Console.Write("введите координату y2 ");
    int y2 = int.Parse(Console.ReadLine());
    Console.Write("введите координату z2 ");
    int z2 = int.Parse(Console.ReadLine());

    S = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
    Console.WriteLine($"Расстояние между точкави в 3D = {S}");
}
else if (N == 2)
{
    Console.Write("введите координату х1 ");
    int x1 = int.Parse(Console.ReadLine());
    Console.Write("введите координату y1 ");
    int y1 = int.Parse(Console.ReadLine());
    Console.Write("введите координату x2 ");
    int x2 = int.Parse(Console.ReadLine());
    Console.Write("введите координату y2 ");
    int y2 = int.Parse(Console.ReadLine());

    S = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
    Console.WriteLine($"Расстояние между точкави в 2D = {S}");
}
else if (N == 1)
{
    Console.Write("введите координату х1 ");
    int x1 = int.Parse(Console.ReadLine());
    Console.Write("введите координату x2 ");
    int x2 = int.Parse(Console.ReadLine());

    S = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2)), 2);
    Console.WriteLine($"Расстояние между точкави в 1D = {S}");
}
else
{
    Console.WriteLine("Программа считает от 1D до 4D пространств");
}
