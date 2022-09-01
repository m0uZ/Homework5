// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] returnArray(int N)
{
    int[] array = new int[N];
    Console.Write("[ ");
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");

    }
    Console.WriteLine("]");
    return array;
}
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] rndArray = returnArray(N);
int max = rndArray[0];
for (int i = 0; i < rndArray.Length; i++)
{
    if (max < rndArray[i]) max = rndArray[i];
}
int min = rndArray[0];
for (int i = 0; i < rndArray.Length; i++)
{
    if (min > rndArray[i]) min = rndArray[i];
}
int diff = max - min;

Console.WriteLine($"Максимальное значение = {max}. Минимальное значение = {min}. Разница между ними = {diff}.");


