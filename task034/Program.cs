// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] returnArray(int N)
{
    int[] array = new int[N];
    Console.Write("[");
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
int sum = 0;
for (int i = 0; i < rndArray.Length; i++)
{
    if (rndArray[i] % 2 == 0) sum++;
}
Console.WriteLine($"Число четных элементов в массиве => {sum} <= ");